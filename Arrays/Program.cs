using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length

            Console.WriteLine("Length:" +  numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);

            Console.WriteLine("Index of 9:" + index);

            //Clear()
            // clear sets the element to the default value of the element type.  0 for int, false for bool
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers) {
                Console.WriteLine(n);
            }

            //Copy()
            //copies the elements from the first array into the second starting at the first index 

            var another = new int[3];

            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another) {
                Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
