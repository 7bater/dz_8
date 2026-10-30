using dz_8;
using System;

namespace dz_8
{
    public class ArrayContainer : ICalc
    {
        private int[] _data;

        public ArrayContainer(int[] data)
        {
            _data = data;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var item in _data)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var item in _data)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}