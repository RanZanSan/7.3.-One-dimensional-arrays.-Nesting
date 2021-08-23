using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoIdenticalElements
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

            string answer = "";
            for (int countVar = -10000; countVar <= 10000; countVar++)
            {
                int count = 0;
                for(int index = 0; index < arrayNumbers.Length; index++)
                {
                    if (arrayNumbers[index] == countVar)
                    {
                        count++;
                    }
                }

                if (count >= 2)
                {
                    answer = "YES";
                    break;
                }
                else
                    answer = "NO";
            }

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}