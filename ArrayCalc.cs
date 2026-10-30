using System;
using System.Collections.Generic;

namespace dz_8
{
    public class ArrayCalc : ICalc2
    {
        private int[] _data;

        public ArrayCalc(int[] data)
        {
            _data = data;
        }

        public int CountDistinct()
        {
            HashSet<int> distinctElements = new HashSet<int>(_data);
            return distinctElements.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (var item in _data)
            {
                if (item == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}