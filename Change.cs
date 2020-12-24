using System;
using System.Linq;

namespace oneHundredTasks
{
    public static class Change
    {
        private static readonly int[] CoinValues = {1, 5, 7, 10, 15};
        private static int[] _count = new int[5];

        public static void Calc(int change)
        {
            _count = new int[5];
            var i = CoinValues.Length;
            while (change > 0)
            {
                i--;
                while (change >= CoinValues[i])
                {
                    change -= CoinValues[i];
                    _count[i]++;
                }
            }

            Print();
        }

        private static void Print()
        {
            for (var i = 0; i < _count.Length; i++)
                Console.WriteLine(_count[i] + " монет по " + CoinValues[i] + " рублей.");
            Console.WriteLine("Всего " + _count.ToArray().Sum() + " монет.");
        }
    }
}