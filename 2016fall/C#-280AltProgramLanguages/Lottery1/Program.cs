using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery1
{
    class Person
    {
        public static void greeting()
        {
            Console.WriteLine("Hello");

        }

        public void salutation()
        {
            Console.WriteLine("Sincerely");
        }
    }

    class Program
    {
        public static void printIntArrayForEach(int[] a)
        {
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }

        public static void printIntArrayFor(int[] a)
        {
            for (int i=0; i<a.Length;++i)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Main(string[] args)
        {
            Person student = new Person();  // create an object of type Person
            Person.greeting();  // static method called from class

            student.salutation();  // non-static method called from object

            //int[] nums = new int[10];
            int[] nums = {15, 18, 12, 55, 10, 24, 20, 36, 48, 32 };

            Console.WriteLine("Original");
            printIntArrayForEach(nums);
            Console.WriteLine(nums.Length );
            Array.Sort(nums);
            Console.WriteLine("Sorted");
            printIntArrayFor(nums);
            Array.Reverse(nums);
            Console.WriteLine("Reversed");
            printIntArrayFor(nums);

            // Math m = new Math();  // do not need to instantiate
            // the Math class to an object in order to run methods therein

            double x=Math.Abs(-30);

            int[] lotteryNums = new int[6];

            Random r = new Random();

            for (int i=0; i<lotteryNums.Length;++i)
            {
                lotteryNums[i] = r.Next(1, 65);
            }

            Array.Sort(lotteryNums);
            Console.WriteLine("Lottery Numbers");
            printIntArrayFor(lotteryNums);
        }
    }
}
