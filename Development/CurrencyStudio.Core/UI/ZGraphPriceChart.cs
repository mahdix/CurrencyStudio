using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Text;
using ZedGraph;
using CurrencyStudio.Core.Helper;

namespace CurrencyStudio.Core.UI
{
    public class ZGraphPriceChart
    {
        private OHLCBarItem chart = null;
        public ToolStripStatusLabel InfoLabel = null;
        private ZedGraphControl Parent = null;

        public void Initialize(string title,ZedGraphControl parent)
        {
            Parent = parent;

            GraphPane myPane = Parent.GraphPane;
            
            myPane.Title.Text = title;

            Color[] colors = { Color.Red, Color.Green };
            Fill myFill = new Fill(colors);
            myFill.Type = FillType.GradientByColorValue;
            myFill.SecondaryValueGradientColor = Color.Empty;
            myFill.RangeMin = 1;
            myFill.RangeMax = 2;

            chart = myPane.AddOHLCBar("Price", new StockPointList(), Color.Empty);
            chart.Bar.GradientFill = myFill;
            chart.Bar.IsAutoSize = false;
            chart.Bar.Width = 2.0F;
            chart.Bar.Size = 12.0F;

            Parent.IsShowHScrollBar = true;
            Parent.IsShowVScrollBar = true;

            // automatically set the scrollable range to cover the data range from the curves
            Parent.IsAutoScrollRange = true;
            Parent.ScrollGrace = 12;

            // Horizontal pan and zoom allowed
            Parent.IsEnableHPan = true;
            Parent.IsEnableHZoom = true;

            // Vertical pan and zoom not allowed
            Parent.IsEnableVPan = true;
            Parent.IsEnableVZoom = true;


            myPane.XAxis.Scale.Min = 0.0;
            myPane.XAxis.Scale.Max = 50.0;

            myPane.XAxis.Title.IsVisible = false;
            myPane.YAxis.Title.IsVisible = false;

            myPane.XAxis.Type = AxisType.DateAsOrdinal;
            myPane.Chart.Fill = new Fill(Color.White);
            myPane.Fill = new Fill(Color.White);
            myPane.Title.FontSpec.Size = 20.0f;
            myPane.XAxis.Title.FontSpec.Size = 18.0f;
            myPane.XAxis.Scale.FontSpec.Size = 10.0f;
            myPane.YAxis.Title.FontSpec.Size = 18.0f;
            myPane.YAxis.Scale.FontSpec.Size = 10.0f;

            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MajorGrid.Color = Color.Gray;

            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.Color = Color.Gray;

            myPane.Legend.IsVisible = false;
            Parent.AxisChange();

            Parent.MouseMove += new MouseEventHandler(OnMouseMoveHandler);
        }

        DateTime currentQuoteTime = DateTime.MinValue;
        double currentLow = 0;
        double currentHigh = 0;
        double currentOpen = 0;
        double currentClose = 0;

        double firstX = -1;
        double lastX = -1;

        public void AddTick(DateTime time, double value)
        {
            StockPt addingPoint = null;
            double dblDate = new XDate(time).XLDate;
            bool addPoint = false;

            if (firstX == -1) firstX = dblDate;
            lastX = dblDate;

            if (time != currentQuoteTime)
            {
                currentQuoteTime = time;

                currentClose = currentLow = currentHigh = currentOpen = value;

                addingPoint = new StockPt();
                addingPoint.Date = dblDate;
                addPoint = true;
            }
            else
            {
                currentClose = value;
                currentHigh = Math.Max(currentHigh, currentClose);
                currentLow = Math.Min(currentLow, currentClose);

                for(int i=0;i<chart.Points.Count;i++)
                {
                    StockPt pt = chart.Points[i] as StockPt;
                    if (pt.Date == dblDate)
                    {
                        addingPoint = pt;
                        break;
                    }
                }

                if (addingPoint == null)
                {
                    throw new Exception("Invalida date");
                }
            }

            addingPoint.Open = currentOpen;
            addingPoint.Close = currentClose;
            addingPoint.High = currentHigh;
            addingPoint.Low = currentLow;

            //if price is increasing color=black, else color=red
            addingPoint.ColorValue = addingPoint.Close > addingPoint.Open ? 2 : 1;

            if (addPoint)
            {
                chart.AddPoint(addingPoint);
            }

            //Parent.GraphPane.XAxis.Scale.Min = minX;
            //Parent.GraphPane.XAxis.Scale.Max = maxX;

            //Parent.ScrollMinX = firstX;
            //Parent.ScrollMaxX = lastX;

            Parent.Invoke(new MethodInvoker(delegate()
                {
                    Parent.AxisChange();
                    Parent.Invalidate();
                }));
        }

        void OnMouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (InfoLabel == null) return;
            if (!(sender is ZedGraphControl)) return;

            PointF mousePt = new PointF(e.X, e.Y);

            // Find the Chart rect that contains the current mouse location
            GraphPane pane = (sender as ZedGraphControl).MasterPane.FindChartRect(mousePt);

            // If pane is non-null, we have a valid location.  Otherwise, the mouse is not
            // within any chart rect.
            if (pane != null)
            {
                CurveItem dragCurve;
                int dragIndex;

                pane.FindNearestPoint(mousePt, out dragCurve, out dragIndex);

                if (dragCurve != null)
                {
                    StockPt nearestPt = dragCurve.Points[dragIndex] as StockPt;

                    string str = "Time: {0}, O={1}, H={2}, L={3}, C={4}";
                    str = string.Format(str, new XDate(nearestPt.Date).DateTime.ToString("yyyy.MM.dd HH:mm"), nearestPt.Open, nearestPt.High, nearestPt.Low, nearestPt.Close);
                    InfoLabel.Text = str;
                }
                else
                {
                    InfoLabel.Text = "";
                }
            }
        }

        public void AddPositionSymbol(int barIndex, double price, PositionType type, bool isClosed)
        {
            TextObj text = new TextObj("X", barIndex+0.75, price, CoordType.AxisXYScale);

            if (type == PositionType.Long && isClosed == false)
            {
                text.Text = Def.LongOpenPositionSymbol;
            }
            else if (type == PositionType.Long && isClosed )
            {
                text.Text = Def.LongClosePositionSymbol;
            }
            else if (type == PositionType.Short && isClosed == false)
            {
                text.Text = Def.ShortOpenPositionSymbol;
            }
            else if (type == PositionType.Short && isClosed)
            {
                text.Text = Def.ShortClosePositionSymbol;
            }

            // Align the text such that the Bottom-Center is at (175, 80) in user scale coordinates
            text.Location.AlignH = AlignH.Center;
            text.Location.AlignV = AlignV.Center;
            text.FontSpec.FontColor = Color.Black;
            text.FontSpec.Fill.Type = FillType.None;
            text.FontSpec.Border.IsVisible = false;
            text.FontSpec.IsBold = true;
            
            //text.FontSpec.StringAlignment = StringAlignment.Center;
            //text.IsVisible = true;
                
            Parent.GraphPane.GraphObjList.Add(text);
            Parent.AxisChange();
            Parent.Invalidate();
        }
    }
}
