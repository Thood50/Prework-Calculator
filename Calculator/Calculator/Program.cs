using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_1;
            int num_2;
            string op;

            Console.WriteLine("Enter 1st number ");
            num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number ");
            num_2 = Convert.ToInt32(Console.ReadLine());

            while(num_2<=0)
            {
                Console.WriteLine("Enter a 2nd number that is greater then 0");
                num_2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter operator ");
            op = Console.ReadLine();

            if(op.Equals("+"))
            {
                Console.WriteLine(num_1 + num_2);
            }

            if (op.Equals("-"))
            {
                Console.WriteLine(num_1 - num_2);
            }

            if (op.Equals("*"))
            {
                Console.WriteLine(num_1 * num_2);
            }

            if (op.Equals("/"))
            {
                Console.WriteLine(num_1 / num_2);
            }

            Console.ReadLine();
        }
    }
}
