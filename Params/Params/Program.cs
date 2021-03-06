using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, "hello",  2, 3, 4, 5));
            float[] array = new float[] { 3.6f, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(Sum(123, "why?", array));
            Console.WriteLine(Sum(4, "vasya"));
            SumArray(array);
            Console.WriteLine(SumStr(4, "hello", "world", "!", " how ", "are ", "you?"));
        }

        static string Sum(int x, string y, params float[] integers)
        {
            string str;
            float results = 0;
            for(int i = 0; i < integers.Length; i++)
            {
                results += integers[i];
            }
            str = ($"{x} {y} {results}");
            return str;
        }

        static string SumStr(int x, string y, params string[] str)
        {
            string arraystr = "";
            for (int i = 0; i < str.Length; i++)
                arraystr += str[i];
            return ($"{x} {y} {arraystr}");
        }

        static void SumArray(float[] mas)
        {
            float res = 0;
            for(int i = 0; i < mas.Length; i++)
            {
                res += mas[i];
            }
            Console.WriteLine(res);
        }
    }
}
