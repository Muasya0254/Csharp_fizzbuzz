// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello World!");


using System;

class FizzBuzz

{
     static void Main()
    {
        //for loop to list numbers from 1 to 100
        for (int i = 1; i <= 100; i++)
        {
            string output = DetermineFizzBuzz(i);
            Console.WriteLine(output);
        }
    }

    static string DetermineFizzBuzz(int num)
    {
        //If the number is evenly divisible by both, it prints "fizzbuzz"
        if (num % 3 == 0 && num % 5 == 0)
        {
            return "FizzBuzz";
        }
        //If the number is evenly divisible by 3, the program also prints "fizz"
        else if (num % 3 == 0)
        {
            return "Fizz";
        }
        //If the number is evenly divisible by 5, the program also prints "buzz"
        else if (num % 5 == 0)
        {
            return "Buzz";
        }
        //print the number itself if the number is not divisible by either 3 or 5
        else
        {
            return num.ToString();
        }
    }
}