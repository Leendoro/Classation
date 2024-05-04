using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("were gonna make a list, write down some numbers, enter 0 when your finished ");

        List<int> numbers = new List<int>();


        int inpuNO = -1;
        while (inpuNO != 0)
        {
            Console.Write ("Write your number: ");

            string userResponse = Console.ReadLine();
            inpuNO = int.Parse(userResponse);



            if (inpuNO != 0)
            {
                numbers.Add(inpuNO);
            }




        }
        int sum = 0;
            foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");



        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");




        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        }

    }
