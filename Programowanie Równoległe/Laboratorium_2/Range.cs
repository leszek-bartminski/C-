using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Range
    {
        public double rangeFrom;
        public double rangeTo;

        static Range range1 = new Range
        {
            rangeFrom = -10,
            rangeTo = 10
        };

        static Range range2 = new Range
        {
            rangeFrom = -5,
            rangeTo = 20
        };

        static Range range3 = new Range
        {
            rangeFrom = -5,
            rangeTo = 0
        };

        List<Range> RangeList = new List<Range>();

        public List<Range> CreateRangeList()
        {
            List<Range> RangeList = new List<Range>();

            RangeList.Add(range1);
            RangeList.Add(range2);
            RangeList.Add(range3);

            return RangeList;
        }        
    }
}
