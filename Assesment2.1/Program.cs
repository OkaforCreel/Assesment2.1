using System;

namespace Assesment2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "alic3", "bob", "3", "4", "00000" };
            int maxVal = 0;

            foreach (string s in strs)
            {
                int val;
                if (int.TryParse(s, out val))
                {
                    maxVal = Math.Max(maxVal, val);
                }
                else
                {
                    maxVal = Math.Max(maxVal, s.Length);
                }
            }
            Console.WriteLine("Maximum value: " + maxVal);
        }
    }
}
