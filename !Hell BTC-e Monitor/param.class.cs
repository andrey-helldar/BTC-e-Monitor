using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Hell_BTC_e_Monitor
{
    // Show my profile
    public class profileParam
    {
        public string Name;
        public bool Show;
        public profileParam(string pName, bool pShow) { Name = pName; Show = pShow; }
        public profileParam() { Name = ""; Show = false; }
    }

    class profile
    {
        public string pName;
        public bool pShow;

        public List<profileParam> Range;
        public List<List<profileParam>> subRange;

        public void Add(string name, bool show)
        {
            try
            {
                if (Range.Count <= 0) { }
            }
            catch (Exception)
            {
                Range = new List<profileParam>();
                subRange = new List<List<profileParam>>();
            }

            Range.Add(new profileParam(name, show));
            subRange.Add(Range);

            pName = subRange[0][0].Name;
            pShow = subRange[0][0].Show;
        }
    }


    // Show prices
    public class courceShow
    {
        public string Name;
        public bool Show;
        public decimal Price;
        public courceShow(string cName, bool cShow, decimal cPrice) { Name = cName; Show = cShow; Price = cPrice; }
        public courceShow() { Name = ""; Show = false; Price = 0; }
    }

    class cource
    {
        public string cName;
        public bool cShow;
        public decimal cPrice;

        public List<courceShow> Range;
        public List<List<courceShow>> subRange;

        public void Add(string Name, bool Show, decimal Price)
        {
            try
            {
                if (Range.Count <= 0) { }
            }
            catch (Exception)
            {
                Range = new List<courceShow>();
                subRange = new List<List<courceShow>>();
            }

            Range.Add(new courceShow(Name, Show, Price));
            subRange.Add(Range);

            cName = subRange[0][0].Name;
            cShow = subRange[0][0].Show;
            cPrice = subRange[0][0].Price;
        }
    }
}