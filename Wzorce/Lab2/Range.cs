using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Range
    {
        public Range(double from, double to)
        {
            rangeFrom = from;
            rangeTo = to;
        }

        public double rangeFrom;
        public double rangeTo;


        //List<Range> RangeList = new List<Range>();

        public static List<Range> CreateRangeList()
        {
            List<Range> RangeList = new List<Range>();

            RangeList.Add(new Range(-5, 0));
            RangeList.Add(new Range(-5, 0));
            RangeList.Add(new Range(-5, 0));
            return RangeList;
        }        
    }
}
