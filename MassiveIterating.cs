using System;

namespace oneHundredTasks
{
    public static class MassiveIterating
    {
        private static readonly int[] Array = {1, 2, 3, 4, 5, -1, -2, -3, 55, 0, 16, -12, 43};

        public static void Block1()
        {
            foreach (var el in Array) Console.Write(el + " ");
            Console.WriteLine();
        }

        public static void Block2()
        {
            for (var i = Array.Length - 1; i >= 0; i--) Console.Write(Array[i] + " ");
            Console.WriteLine();
        }

        public static void Block3()
        {
            foreach (var el in Array)
                if (el % 2 == 0)
                    Console.Write(el + " ");
            Console.WriteLine();
        }

        public static void Block4()
        {
            for (var i = 0; i < Array.Length; i += 2) Console.Write(Array[i] + " ");
            Console.WriteLine();
        }

        public static void Block5()
        {
            foreach (var el in Array)
            {
                if (el == -1)
                    break;
                Console.Write(el + " ");
            }

            Console.WriteLine();
        }
    }
}