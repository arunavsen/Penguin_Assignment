using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            double[] balance = new double[input];
            for (int i = 0; i < input; i++)
            {
                balance[i] = Convert.ToDouble(Console.ReadLine());
            }

            var result = efficientJanitor(balance);
            Console.WriteLine(result);
        }

        static int efficientJanitor(double[] balance)
        {
            Array.Sort(balance);
            var n = balance.Length;
            int left_index = 0;
            int trips = 0;

            for (int i = n-1; i > 0; i--)
            {
                if (balance[i] > 1.99)
                {
                    trips++;
                }else if (balance[i] <= 1.99)
                {
                    if (balance[i]+balance[left_index] <= 3)
                    {
                        left_index++;
                        trips++;
                    }
                }

                if (left_index>=i)
                {
                    break;
                }
            }
            return trips;
        }
    }
}
