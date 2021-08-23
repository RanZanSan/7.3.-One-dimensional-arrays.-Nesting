using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theOnlyElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            string[] arrayStrings = Console.ReadLine().Split(' ');
            int[] arrayNumbers = new int[length];

            for (int index = 0; index < arrayNumbers.Length; index++)
            {
                arrayNumbers[index] = Convert.ToInt32(arrayStrings[index]);
            }

            int soughtVar = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    if (arrayNumbers[j] == arrayNumbers[i])
                    {
                        count++;
                        if (count == 1)
                            soughtVar = arrayNumbers[j];
                    }
                }
                if (count == 1)
                    Console.Write(soughtVar + " ");
            }
        }
    }
}