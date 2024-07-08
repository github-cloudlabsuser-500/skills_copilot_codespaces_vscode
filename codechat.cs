using System;

class Program
{
   const int MAX = 100;

   static int Sum(int[] arr)
   {
       int result = 0;
       foreach (int num in arr)
       {
           result += num;
       }
       return result;
   }

   static void Main()
   {
       int n;
       Console.Write("Enter the number of elements (1-100): ");
       if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > MAX)
       {
           Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
           Environment.Exit(1);
       }

       int[] arr = new int[n];

       Console.WriteLine("Enter " + n + " integers:");
       for (int i = 0; i < n; i++)
       {
           if (!int.TryParse(Console.ReadLine(), out arr[i]))
           {
               Console.WriteLine("Invalid input. Please enter valid integers.");
               Environment.Exit(1);
           }
       }

       int total = Sum(arr);

       Console.WriteLine("Sum of the numbers: " + total);
   }
 }