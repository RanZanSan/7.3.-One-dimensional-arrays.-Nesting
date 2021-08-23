using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int cnt = 0;
            int n = ss.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ss[i] == ss[j])
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}