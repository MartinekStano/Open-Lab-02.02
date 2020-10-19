using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write(string.Format("{0:0.00}", numbers[i]));
            }
            
        }
    }
}
