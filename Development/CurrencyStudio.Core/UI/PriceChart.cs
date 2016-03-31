using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CurrencyStudio.Core.UI
{
    public delegate void PointInfoUpdateHandler(DataPoint point);

    public class PriceChart
    {
        private Chart innerChart = null;
        private ChartArea innerChartArea = null;
        private Series innerSeries = null;
        private bool chartIsEmpty = true;
        private Form parentForm = null;
        private DataPoint selectedPoint = null;     //point that is selected by mousemove on interactive mode
        public event PointInfoUpdateHandler SelectedPointChanged;
        private DateTimeIntervalType dateAxisType = DateTimeIntervalType.Auto;
        private int chartShiftLeftCount = 3;
        private TimeSpan mouseWheelScrollStep = new TimeSpan(0, 1, 0);
        private int zoomFactor = 1;      //number of bard added/removed from visible threshold for zooming
        private Color priceUpColor = Color.Green;
        private Color priceDownColor = Color.Red;
        private Color priceConstColor = Color.Gray;        
        private Color selectedPointColor = Color.Orange;
        private bool scrollByMouseWheelEnabled = false;
        private bool autoZoomPricesEnabled = true;
        private bool displayTickPriceInTitle = true;

        //empty extra space when zooming to show only required interval in price axis
        private double zoomMargin = 0.0001;

        public void Setup(Form form,Chart c, string areaName, string seriesName)
        {
            innerChart = c;
            innerChartArea = c.ChartAreas[areaName];
            parentForm = form;

            if (seriesName == null)
            {
                innerSeries = new Series();
                innerChart.Series.Add(innerSeries);
                innerSeries.ChartArea = areaName;
            }
            else
            {
                innerSeries = c.Series[seriesName];
            }
        }

        private void ThreadSafeCall(MethodInvoker mi)
        {
            if (innerChart.InvokeRequired)
            {
                innerChart.Invoke(mi);
            }
            else
            {
                mi();
            }
        }

        public static class ChartConfig
        {
        }

        public int MaxVisibleBarCount
        {
            get
            {
                return (int)innerChartArea.AxisX.ScaleView.Size;
            }
            set
            {
                if (value <= 0) return;

                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        //double temp = innerChartArea.AxisX.ScaleView.Position;
                        innerChartArea.AxisX.ScaleView.Size = value;

                        //it seems that we need to refresh sizeType when size is changed
                        innerChartArea.AxisX.ScaleView.SizeType = dateAxisType;

                        //innerChartArea.AxisX.ScaleView.Position = temp;
                    }));

                AutoZoomPrices();
            }
        }

        public DateTime StartDate
        {
            get
            {
                if (innerChartArea.AxisX.ScaleView.Position.Equals(double.NaN) )
                {
                    return DateTime.MinValue;
                }

                return DateTime.FromOADate(innerChartArea.AxisX.ScaleView.Position);
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    if (value == DateTime.MinValue)
                    {
                        innerChartArea.AxisX.ScaleView.Position = double.NaN;
                    }
                    else
                    {
                        innerChartArea.AxisX.ScaleView.Position = value.ToOADate();
                    }
                }));
            }
        }

        public void InitializeWithDefaults()
        {
            DateAxisType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            BorderWidth = 3;
            MaxVisibleBarCount = 30;
            ScrollEnabled = false;
            PriceAxisDigitCount = 5;
            ShowDatesInXAxis = false;
            GridLineStyle = ChartDashStyle.Dash;
            LegendVisible = false;

            AxisColor = Color.FromArgb(111, 111, 111);
            ChartAreaBackColor = Color.FromArgb(30, 30, 30);
            DrawColor = Color.Gray;
            ChartBackColor = Color.Black;
            
            AxisTextColor = Color.FromArgb(200, 200, 200);
            priceDownColor = Color.FromArgb(255, 47, 47);
            MinorGridEnabled = true;
            RightSidePriceAxisEnabled = true;
            PriceAxisLabelFontSize = 8;
            priceUpColor = Color.FromArgb(127, 255, 0);
            priceConstColor = Color.FromArgb(47, 79, 79);
            ChartAreaHeightPercent = 90;
            ChartAreaWidthPercent = 100;
            ChartAreaPosition = new Point(0, 30);
            InteractivePointInfoEnabled = true;
            ZoomByMouseWheelEnabled = true;
            ScrollByMouseWheelEnabled = true;
        }

        public bool ScrollEnabled
        {
            get
            {
                return innerChartArea.AxisX.ScrollBar.Enabled && innerChartArea.AxisY.ScrollBar.Enabled;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.AxisX.ScrollBar.Enabled = value;
                    innerChartArea.AxisY.ScrollBar.Enabled = value;
                    innerChartArea.AxisY2.ScrollBar.Enabled = value;
                }));
            }
        }

        private void SetPointColorBasedOnPrices(DataPoint dp)
        {
            double open = dp.YValues[2];
            double close = dp.YValues[3];

            if (open == close)
            {
                dp.Color = priceConstColor;
            }
            else if (close < open)
            {
                dp.Color = priceDownColor;
            }
            else
            {
                dp.Color = priceUpColor;
            }
        }

        public DateTimeIntervalType DateAxisType
        {
            get
            {
                return innerChartArea.AxisX.ScaleView.SizeType;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerSeries.XValueType = ChartValueType.DateTime;
                        innerChartArea.AxisX.ScaleView.SizeType = value;
                    }));

                dateAxisType = value;
            }
        }

        public bool IsZoomable
        {
            get
            {
                return innerChartArea.CursorX.IsUserEnabled;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.CursorX.IsUserEnabled = value;
                        innerChartArea.CursorX.IsUserSelectionEnabled = value;
                        innerChartArea.CursorX.SelectionColor = System.Drawing.SystemColors.Highlight;
                        innerChartArea.CursorY.IsUserEnabled = value;
                        innerChartArea.CursorY.IsUserSelectionEnabled = value;
                        innerChartArea.CursorY.SelectionColor = System.Drawing.SystemColors.Highlight;

                        innerChartArea.AxisX.ScaleView.Zoomable = value;
                        innerChartArea.AxisY.ScaleView.Zoomable = value;
                    }));
            }
        }

        public Color[] ScrollColors
        {
            get
            {
                return new Color[]{innerChartArea.AxisX.ScrollBar.ButtonColor,
                    innerChartArea.AxisX.ScrollBar.BackColor,
                    innerChartArea.AxisX.ScrollBar.LineColor};
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.AxisX.ScrollBar.ButtonColor = value[0];
                    innerChartArea.AxisX.ScrollBar.BackColor = value[1];
                    innerChartArea.AxisX.ScrollBar.LineColor = value[2];


                    innerChartArea.AxisY.ScrollBar.ButtonColor = value[0];
                    innerChartArea.AxisY.ScrollBar.BackColor = value[1];
                    innerChartArea.AxisY.ScrollBar.LineColor = value[2];
                }));
            }
        }

        public Color ChartBackColor
        {
            get
            {
                return innerChart.BackColor;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChart.BackColor = value;
                    }));
            }
        }

        public Color DrawColor
        {
            get
            {
                return innerSeries.Color;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerSeries.Color = value;
                }));
            }
        }

        public Color ChartAreaBackColor
        {
            get
            {
                return innerChartArea.BackColor;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.BackColor = value;
                }));
            }
        }

        public Color AxisColor
        {
            get
            {
                return innerChartArea.AxisX.LineColor;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.AxisX.LineColor = value;
                    innerChartArea.AxisY.LineColor = value;
                    innerChartArea.AxisY2.LineColor = value;
                    innerChartArea.AxisX.MajorGrid.LineColor = value;
                    innerChartArea.AxisY.MajorGrid.LineColor = value;
                    innerChartArea.AxisY2.MajorGrid.LineColor = value;
                }));
            }
        }

        public Color BarBorderColor
        {
            get
            {
                return innerSeries.BorderColor;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerSeries.BorderColor = value;
                    }));
            }
        }
        //(Color tail, Color border, Color priceUp, Color priceDown)
        public Color CandlestickUpColor
        {
            get
            {
                return ChartStringToColor(innerSeries["PriceUpColor"]);

            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerSeries["PriceUpColor"] = ColorToChartString(value);
                    }));
            }
        }

        public Color CandlestickDownColor
        {
            get
            {
                return ChartStringToColor(innerSeries["PriceDownColor"]);
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerSeries["PriceDownColor"] = ColorToChartString(value);
                }));
            }
        }

        public int BorderWidth
        {
            get
            {
                return innerSeries.BorderWidth;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerSeries.BorderWidth = value;
                    }));
            }
        }
        /// <summary>
        /// converts a color to a string for chart color settings
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private string ColorToChartString(Color c)
        {
            if (c.Equals(Color.Empty)) return null;
            return string.Format("{0},{1},{2}", c.R.ToString(), c.G.ToString(), c.B.ToString());
        }

        private Color ChartStringToColor(string s)
        {
            if (s == null) return Color.Empty;
            string[] rgb = s.Split(',');
            return Color.FromArgb(int.Parse(rgb[0]),int.Parse(rgb[1]),int.Parse(rgb[2]));
        }

        public void ResetZoom()
        {
            ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.AxisX.ScaleView.ZoomReset();
                    innerChartArea.AxisY.ScaleView.ZoomReset();
                    innerChartArea.AxisY2.ScaleView.ZoomReset();
                }));
        }

        public bool LegendVisible
        {
            get
            {
                return innerChart.Legends[0].Enabled;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        foreach (Legend l in innerChart.Legends)
                        {
                            l.Enabled = value;
                        }
                    }));
            }
        }

        public int ChartShiftLeftBarCount
        {
            get
            {
                return chartShiftLeftCount;
            }
            set
            {
                chartShiftLeftCount = value;
            }
        }

        private DateTime lastTime = DateTime.MinValue;
        private double currentLow = 0;
        private double currentHigh = 0;
        private double currentOpen = 0;
        private double currentClose = 0;
        private int lastDataPointIndex = -1;

        public void Tick(DateTime dt, double tickPrice)
        {
            if (chartIsEmpty)
            {
                StartDate = dt;
                chartIsEmpty = false;
            }

            if (dt != lastTime)
            {
                currentClose = currentHigh = currentLow = currentOpen = tickPrice;
                lastTime = dt;

                double[] prices = new double[4] { currentHigh, currentLow, currentOpen, currentClose };
                DataPoint dp = new DataPoint(lastTime.ToOADate(), prices);
                SetPointColorBasedOnPrices(dp);

                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerSeries.Points.Add(dp);

                        lastDataPointIndex = innerSeries.Points.Count - 1;                        
                    }));
            }
            else
            {
                currentClose = tickPrice;
                currentHigh = Math.Max(currentHigh, currentClose);
                currentLow = Math.Min(currentLow, tickPrice);

                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        DataPoint dp = innerSeries.Points[lastDataPointIndex];
                        dp.SetValueY(currentHigh, currentLow, currentOpen, currentClose);
                        SetPointColorBasedOnPrices(dp);
                    }));
            }

            ScrollToEnd();
            ThreadSafeCall(new MethodInvoker(delegate() { innerChart.Invalidate(); })); 
            AutoZoomPrices();

            if (DisplayTickPriceInTitle)
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        if (innerChart.Titles.Count < 1) innerChart.Titles.Add("Test");
                        innerChart.Titles[0].Text = tickPrice.ToString(innerChartArea.AxisY.LabelStyle.Format);
                    }));
            }
        }

        private void ScrollToEnd()
        {
            Series ptSeries = innerSeries;

            int size = (int)innerChartArea.AxisX.ScaleView.Size;

            if (size > 0)
            {
                int targetIndex = ptSeries.Points.Count - size + chartShiftLeftCount;

                if (targetIndex < 0) targetIndex = 0;

                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.AxisX.ScaleView.Position = ptSeries.Points[targetIndex].XValue;
                    }));
            }
        }

        public void SetPointLabel(DateTime dt, string str)
        {
            DataPoint dp = innerSeries.Points.FindByValue(dt.ToOADate(), "X");

            ThreadSafeCall(new MethodInvoker(delegate()
                {
                    dp.Label = str;
                }));
        }

        public void AutoSetAxisDateFormat()
        {
            ThreadSafeCall(new MethodInvoker(delegate()
                {
                    switch (dateAxisType)
                    {
                        case DateTimeIntervalType.Days: AxisDateFormatString = GetAxisDateFormatString(false, true, true, false, false); break;
                        case DateTimeIntervalType.Hours: AxisDateFormatString = GetAxisDateFormatString(false, false, true, true, false); break;
                        case DateTimeIntervalType.Minutes: AxisDateFormatString = GetAxisDateFormatString(false, false, false, true, true); break;
                    }
                }));
        }

        public string AxisDateFormatString
        {
            get
            {
                return innerChartArea.AxisX.LabelStyle.Format;
            }
            set
            {
                if (value != innerChartArea.AxisX.LabelStyle.Format)
                {
                    ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.AxisX.LabelStyle.Format = value;
                    }));
                }
            }
        }

        public string GetAxisDateFormatString(bool year, bool month, bool day, bool hour, bool min)
        {
            string format = year ? "yyyy." : "";

            if (month)
            {
                if (format.Length == 0) format = "MM"; else format += ".MM";
            }

            if (day)
            {
                if (format.Length == 0) format = "dd"; else format += ".dd";
            }

            if (hour)
            {
                if (format.Length == 0) format = "HH"; else format += " HH";
            }

            if (min)
            {
                if (format.Length == 0) format = "mm"; else format += ":mm";
            }

            return format;            
        }

        public void SetPointMarker(DateTime dt, string imagePath)
        {
            DataPoint dp = innerSeries.Points.FindByValue(dt.ToOADate(), "X");

            ThreadSafeCall(new MethodInvoker(delegate()
                {
                    dp.MarkerImage = imagePath;
                }));
        }

        public void AddPoint(DateTime dt, double value)
        {
            if (chartIsEmpty)
            {
                StartDate = dt;
                chartIsEmpty = false;
            }


            ThreadSafeCall(new MethodInvoker(delegate()
            {
                if (innerSeries.Points.Count > 0)
                {
                    DataPoint dp = innerSeries.Points.FindByValue(dt.ToOADate(), "X");

                    //if this point exists in the series, just update its price
                    if (dp != null)
                    {
                        dp.SetValueY(value);
                        return;
                    }
                }

                innerSeries.Points.AddXY(dt.ToOADate(), value);
            }));
        }

        public void AddPoint(DateTime dt, double high,double low,double open,double close)
        {
            if (chartIsEmpty)
            {
                StartDate = dt;
                chartIsEmpty = false;
            } 
            
            ThreadSafeCall(new MethodInvoker(delegate()
            {
                double[] prices = new double[4] { high, low, open, close };
                DataPoint dp = new DataPoint(dt.ToOADate(), prices);
                SetPointColorBasedOnPrices(dp);
                innerSeries.Points.Add(dp);
            }));

            ScrollToEnd();
            AutoZoomPrices();
        }

        public void AutoZoomPrices()
        {
            if (false == autoZoomPricesEnabled) return;

            int barCount = (int)innerChartArea.AxisX.ScaleView.Size;
            int seriesPointCount = innerSeries.Points.Count;

            if (barCount == 0 || seriesPointCount == 0) return;

            if ( seriesPointCount < barCount )
            {
                barCount = seriesPointCount;
            }

            double beginViewValue = innerChartArea.AxisX.ScaleView.Position;
            DataPoint beginViewDataPoint = innerSeries.Points.FindByValue(beginViewValue, "X");

            if (beginViewDataPoint == null) return;
            int beginViewPointIndex = innerSeries.Points.IndexOf(beginViewDataPoint);

            double min = -1;
            double max = -1;

            int endViewIndex = Math.Min(beginViewPointIndex + MaxVisibleBarCount,innerSeries.Points.Count);


            for (int i = beginViewPointIndex; i < endViewIndex; i++)
            {
                double currentHigh = innerSeries.Points[i].YValues[0];
                double currentLow = 0;

                if (innerSeries.Points[i].YValues.Length > 1)
                {
                    currentLow = innerSeries.Points[i].YValues[1];
                }
                else
                {
                    currentLow = currentHigh;
                }
                
                if (min == -1) min = currentLow;
                if (max == -1) max = currentHigh;

                if (currentLow < min ) min = currentLow;
                if (currentHigh > max ) max = currentHigh;
            }


            ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.AxisY.ScaleView.Zoom(min - ZoomMargin, max + ZoomMargin);
                    innerChartArea.AxisY2.ScaleView.Zoom(min - ZoomMargin, max + ZoomMargin);
                }));
        }

        public bool ScrollByMouseWheelEnabled
        {
            get
            {
                return scrollByMouseWheelEnabled;
            }
            set
            {
                if (value == scrollByMouseWheelEnabled) return;

                scrollByMouseWheelEnabled = value;
                if (scrollByMouseWheelEnabled)
                {
                    parentForm.MouseWheel += new MouseEventHandler(ctl_MouseWheel);
                }
                else
                {
                    parentForm.MouseWheel -= new MouseEventHandler(ctl_MouseWheel);
                }
            }
        }

        void ctl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control) return;

            DateTime dt = DateTime.FromOADate(innerChartArea.AxisX.ScaleView.Position);

            if (e.Delta > 0)
            {
                dt = dt.Subtract(mouseWheelScrollStep);
            }
            else
            {
                dt = dt.Add(mouseWheelScrollStep);
            }

            innerChartArea.AxisX.ScaleView.Position = dt.ToOADate();
            AutoZoomPrices();
        }

        public bool ShowDatesInXAxis
        {
            get
            {
                return innerChartArea.AxisX.LabelStyle.Enabled;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.AxisX.LabelStyle.Enabled = value;
                    }));
            }
        }

        public int PriceAxisDigitCount
        {
            get
            {
                string temp = innerChartArea.AxisY.LabelStyle.Format;
                int idx = temp.IndexOf(".");
                return temp.Length - idx - 1;
            }
            set
            {
                string temp = "0.";
                for (int i = 0; i < value; i++) temp += "0";
                innerChartArea.AxisY.LabelStyle.Format = temp;
                innerChartArea.AxisY2.LabelStyle.Format = temp;
            }
        }

        private bool interactivePointInfoEnabled = false;
        public bool InteractivePointInfoEnabled
        {
            get
            {
                return interactivePointInfoEnabled;
            }
            set
            {
                if (value == interactivePointInfoEnabled) return;

                interactivePointInfoEnabled = value;

                if (interactivePointInfoEnabled)
                {
                    innerChart.MouseMove += new MouseEventHandler(innerChart_MouseMove);
                }
                else
                {
                    innerChart.MouseMove -= new MouseEventHandler(innerChart_MouseMove);
                }
            }
        }

        void innerChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectedPointChanged == null) return;

            HitTestResult result = innerChart.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                parentForm.Cursor = Cursors.Hand;
                DataPoint point = innerSeries.Points[result.PointIndex];

                if (!point.Equals(selectedPoint) && selectedPoint != null)
                {
                    SetPointColorBasedOnPrices(selectedPoint);
                }

                SelectedPointChanged(point);

                point.Color = selectedPointColor;
                selectedPoint = point;
            }
            else
            {
                parentForm.Cursor = Cursors.Default;

                if (selectedPoint != null)
                {
                    SetPointColorBasedOnPrices(selectedPoint);
                }
            }
        }

        public ChartDashStyle GridLineStyle
        {
            get
            {
                return innerChartArea.AxisX.MajorGrid.LineDashStyle;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.AxisX.MajorGrid.LineDashStyle = value;
                        innerChartArea.AxisX.MinorGrid.LineDashStyle = value;
                        innerChartArea.AxisY.MajorGrid.LineDashStyle = value;
                        innerChartArea.AxisY.MinorGrid.LineDashStyle = value;
                        innerChartArea.AxisY2.MinorGrid.LineDashStyle = value;
                        innerChartArea.AxisY2.MajorGrid.LineDashStyle = value;
                    }));
            }
        }

        public Color AxisTextColor
        {
            get
            {
                return innerChartArea.AxisX.LabelStyle.ForeColor;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.AxisX.LabelStyle.ForeColor = value;
                        innerChartArea.AxisY.LabelStyle.ForeColor = value;
                        innerChartArea.AxisY2.LabelStyle.ForeColor = value;
                    }));
            }
        }

        public bool RightSidePriceAxisEnabled
        {
            get
            {
                return innerChartArea.AxisY2.Enabled == AxisEnabled.True;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.AxisY2.Enabled = value ? AxisEnabled.True : AxisEnabled.False;
                    }));
            }
        }

        public bool MinorGridEnabled
        {
            get
            {
                return innerChartArea.AxisX.MinorGrid.Enabled;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.AxisX.MinorGrid.Enabled = value;
                        innerChartArea.AxisY.MinorGrid.Enabled = value;
                        innerChartArea.AxisY2.MinorGrid.Enabled = value;
                    }));
            }
        }

        public float PriceAxisLabelFontSize
        {
            get
            {
                return innerChartArea.AxisY.LabelStyle.Font.Size;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        Font f = new Font(innerChartArea.AxisY.LabelStyle.Font.FontFamily,value);

                        innerChartArea.AxisY.LabelStyle.Font = f;
                        innerChartArea.AxisY2.LabelStyle.Font = f;
                    }));
            }
        }

        public float ChartAreaWidthPercent
        {
            get
            {
                return innerChartArea.Position.Width;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                    {
                        innerChartArea.Position.Width = value;
                    }));
            }
        }

        public float ChartAreaHeightPercent
        {
            get
            {
                return innerChartArea.Position.Height;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.Position.Height = value;
                }));
            }
        }

        public Point ChartAreaPosition
        {
            get
            {
                return new Point((int)innerChartArea.Position.X,(int)innerChartArea.Position.Y);
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerChartArea.Position.X = value.X;
                    innerChartArea.Position.Y = value.Y;
                }));
                
            }
        }

        public SeriesChartType SeriesChartType
        {
            get
            {
                return innerSeries.ChartType;
            }
            set
            {
                ThreadSafeCall(new MethodInvoker(delegate()
                {
                    innerSeries.ChartType = value;
                }));
            }
        }

        public void ZoomIn()
        {
            MaxVisibleBarCount -= zoomFactor;
        }

        public void ZoomOut()
        {
            MaxVisibleBarCount += zoomFactor;
        }


        private bool zoomByMouseWheelEnabled = false;
        public bool ZoomByMouseWheelEnabled
        {
            get
            {
                return zoomByMouseWheelEnabled;
            }
            set
            {
                if (value == zoomByMouseWheelEnabled) return;

                zoomByMouseWheelEnabled = value;
                if (zoomByMouseWheelEnabled)
                {
                    parentForm.MouseWheel += new MouseEventHandler(parentForm_MouseWheelZoomHandler);
                }
                else
                {
                    parentForm.MouseWheel -= new MouseEventHandler(parentForm_MouseWheelZoomHandler);
                }
            }
        }

        void parentForm_MouseWheelZoomHandler(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    ZoomIn();
                }
                else
                {
                    ZoomOut();
                }
            }
        }

        public TimeSpan MouseWheelScrollStep
        {
            get
            {
                return mouseWheelScrollStep;
            }
            set
            {
                mouseWheelScrollStep = value;
            }
        }

        public int ZoomFactor
        {
            get
            {
                return zoomFactor;
            }
            set
            {
                zoomFactor = value;
            }
        }


        public Color PriceUpColor
        {
            get
            {
                return priceUpColor;
            }
            set
            {
                priceUpColor = value;
            }
        }

        public Color PriceDownColor
        {
            get
            {
                return priceDownColor;
            }
            set
            {
                priceDownColor = value;
            }
        }

        public Color PriceConstColor
        {
            get
            {
                return priceConstColor;
            }
            set
            {
                priceConstColor = value;
            }
        }

        public Color SelectedPointColor
        {
            get
            {
                return selectedPointColor;
            }
            set
            {
                selectedPointColor = value;
            }
        }

        public bool AutoZoomPricesEnabled
        {
            get
            {
                return autoZoomPricesEnabled;
            }
            set
            {
                autoZoomPricesEnabled = value;
            }
        }

        public double ZoomMargin
        {
            get
            {
                return zoomMargin;
            }
            set
            {
                zoomMargin = value;
            }
        }

        public bool DisplayTickPriceInTitle
        {
            get
            {
                return displayTickPriceInTitle;
            }
            set
            {
                displayTickPriceInTitle = value;
            }
        }

        //public string SerializeConfig()
        //{
        //    ArrayList arrValues = new ArrayList();
        //    ArrayList arrNames = new ArrayList();

        //    foreach (PropertyInfo pi in this.GetType().GetProperties())
        //    {
        //        object value = pi.GetValue(this, null);
        //        arrValues.Add(value);
        //        arrNames.Add(pi.Name);
        //    }

        //    BinaryFormatter bf = new BinaryFormatter();
        //    MemoryStream ms = new MemoryStream();
        //    bf.Serialize(ms, new ArrayList[]{arrNames,arrValues});

        //    return Convert.ToBase64String(ms.GetBuffer());
        //}

        //public void DeserializeConfig(string config)
        //{
        //    BinaryFormatter bf = new BinaryFormatter();
        //    MemoryStream ms = new MemoryStream(Convert.FromBase64String(config));
        //    object result = bf.Deserialize(ms);

        //    ArrayList[] arr = (ArrayList[])result;
        //    ArrayList arrNames = arr[0];
        //    ArrayList arrValues = arr[1];

        //    for(int i=0;i<arrValues.Count;i++)
        //    {
        //        PropertyInfo pi = this.GetType().GetProperty(arrNames[i].ToString());
        //        pi.SetValue(this, arrValues[i], null);
        //    }           
        //}
    } 
}
