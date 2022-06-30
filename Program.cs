using System;

namespace A2Q11
{
    internal class Program
    {
        //swapping function is called in this main funciton
        static void Main(string[] args)
        {
            //input the parameter into the new array
            int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("After swapping first and last elements:\n ");
            
            //swapped array is printed
            for (int i=0; i <6; i++)
            {
                Console.Write(item[i] + " ");
            }
        }
        
        //function which swaps the first to last, it is called in the main function above
        static int[] test(int[] numbers)
        {
            //first index is stored, then assigned to the last index position.
            int first = numbers[0];
            numbers[0] = numbers[numbers.Length - 1];
            //last index position is assigned the variable 'first', which had the first value.
            numbers[numbers.Length - 1] = first;

            return numbers;
        }
    }
}

