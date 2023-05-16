using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter n = ");
            int n = int.Parse(Console.ReadLine());
            int[] A1 = new int[n];
            int sum = 0;
            int max = A1[0];
            int min = A1[0];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("number of block " + (i+1)+ " = ");
                A1[i] = int.Parse(Console.ReadLine());
                sum += A1[i];
            }
            Console.WriteLine("sum = " +sum);
            Console.WriteLine("Mean = " +sum/n);
            Array.Sort(A1);
            int range = A1[n - 1] - A1[0];
            Console.WriteLine("range = " +range);
            int median;
            int mid = n / 2;
            if(n%2!=0)
            {
                median = A1[mid];
                Console.WriteLine("Median = " +median );

            }
            if(n%2==0)
            {
                int mac = mid - 1;
                median = (A1[mid] + A1[mac]) / 2;
                Console.WriteLine("median = " +median);

            }
            Array.Sort(A1);
            int Q1;
            if (n % 2 == 0)
            {
                Q1 = A1[(n - 1) / 4];
                Console.WriteLine(" Q1  =" + Q1);
            }
           else
            {
                Q1 = A1[(n - 2) / 4];
                Console.WriteLine(" Q1  =" + Q1);
            }
            int Q3;
            if (n % 2 == 0)
            {
                Q3 = A1[(n + 1) * 3 / 4];
                Console.WriteLine(" Q3  =" + Q3);
            }
            else
            {
                Q3 = A1[n * 3 / 4];
                Console.WriteLine(" Q3  =" + Q3);
            }
            var groups = A1.GroupBy(x => x);
            var maxaccount = groups.Max(g => g.Count());
            var mode = groups.First(g => g.Count() == maxaccount).Key;
            Console.WriteLine("mode = " +mode);

            int count = n;
            int index = (int)Math.Round(count * 0.9) - 1;
            int p90 = A1[index];
            Console.WriteLine("p90 value = " +p90);
            int IQR = Q3 - Q1;
            Console.WriteLine("Iqr = " + IQR);
            double upperoutiler = Q3 + (1.5 * IQR);
            double loweroutiler = Q1 - (1.5 * IQR);
            Console.WriteLine("UPPEROUTILER IS = " + upperoutiler);
            Console.WriteLine("LOWEROUTILER IS = " +loweroutiler);
            Console.WriteLine("enter variable outiler = ");
            int d = int.Parse(Console.ReadLine());
              if(d < upperoutiler && d > loweroutiler)
            {
                Console.WriteLine("value is existed and = " +d);

            }
            else
            {
                Console.WriteLine("value is not existed");
            }
            



        }
        
      
    }
}
