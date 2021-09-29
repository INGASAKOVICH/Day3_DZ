using System;

namespace Number_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter aray size");
            var size = int.Parse(Console.ReadLine());
            int[] nums = new int[size];
            Console.WriteLine("Enter max value");
            var maxValue = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < nums.Length; i++)
            {
                Random R = new Random();
                nums[i] = R.Next(0, maxValue);
                {
                    if (i == size-1)
                        Console.Write(" " + nums[i] + ".");
                    else
                        Console.Write(" " + nums[i] + ",");
                }
            }
            Console.WriteLine();
            int temp;
            for (int a = 0; a < nums.Length - 1; a++)
            {
                for (int j = a + 1; j < nums.Length; j++)
                {
                    if (nums[a] > nums[j])
                    {
                        temp = nums[a];
                        nums[a] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            for (i = 0; i < nums.Length; i++)
            {
                if (i == size - 1)
                    Console.Write(" " + nums[i] + ".");
                else
                    Console.Write(" " + nums[i] + ",");
            }
        }
    }
}
