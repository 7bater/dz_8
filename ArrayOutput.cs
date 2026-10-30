using dz_8;
using static System.Console;

namespace Lessons8
{
    public class ArrayOutput : IOutput2
    {
        private int[] _data;

        public ArrayOutput(int[] data)
        {
            _data = data;
        }

        public void ShowEven()
        {
            Write("Парні значення: ");
            foreach (var item in _data)
            {
                if (item % 2 == 0)
                {
                    Write($"{item} ");
                }
            }
            WriteLine();
        }

        public void ShowOdd()
        {
            Write("Непарні значення: ");
            foreach (var item in _data)
            {
                if (item % 2 != 0)
                {
                    Write($"{item} ");
                }
            }
            WriteLine();
        }
    }
}