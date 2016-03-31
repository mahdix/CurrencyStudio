using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyStudio.Core.RuntimeSystem
{
    public class SignalGroup
    {
        public SignalGroup(string id)
        {
            GroupId = id;
        }

        public SignalGroup()
        {
        }

        public SignalGroup FindChild(string id)
        {
            if (id == this.GroupId) return this;

            foreach (SignalGroup sg in Children)
            {
                if (sg.GroupId == id) return sg;

                SignalGroup result = sg.FindChild(id);

                if (result != null) return result;
            }

            return null;
        }

        public SignalGroup FindChildParent(string id)
        {
            foreach (SignalGroup sg in Children)
            {
                if (sg.GroupId == id) return this;

                SignalGroup result = sg.FindChild(id);

                if (result != null) return sg;
            }

            return null;
        }

        public string GroupId = "";
        public List<SignalGroup> Children = new List<SignalGroup>();
    }
}
