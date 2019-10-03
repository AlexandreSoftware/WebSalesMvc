using System;
using System.Drawing;
namespace SalesWebMvcTests
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] input = Console.ReadLine().Split(' '); // getting input as string
            int[] nums = new int[input.Length]; // declaring int array with same length as input
            for (int i = 0; i < input.Length; i++)
            { // starting a for loop to convert input string to int in nums[]
                nums[i] = Convert.ToInt32(input[i]);
            }
            int a, b, c;
            a = nums[0];
            b = nums[1];
            c = nums[2];
            if (a > b && a > c)
            {
                Console.WriteLine(a);
                break;
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
                break;
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c);
                break;
            }

        }
    }
}
