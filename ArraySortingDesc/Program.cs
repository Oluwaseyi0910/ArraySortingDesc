using System;

namespace ArraySortingDesc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraySeyi = { 15, 34, 25, 17, 42, 57, 77, 52, 27, 68 };

            int x = arraySeyi.Length;


            for (int i = 0; i < x-1; i++)
            {
                if (arraySeyi[i] < arraySeyi[i+1])
                {
                    int placeHolder = arraySeyi [i];
                    arraySeyi [i] = arraySeyi [i + 1];
                    arraySeyi [i + 1] = placeHolder;
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(",", arraySeyi));
        }
    }
}
