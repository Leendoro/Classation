using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int numba = randomGenerator.Next(1,101);

        int guess = -1;


        while (guess != numba)
        {
            Console.Write("Guess the magic number");
            guess = int.Parse(Console.ReadLine());

            if (numba > guess)
            {
                Console.WriteLine ("magic number is bigger than your guess");
            }

            else if (numba < guess)
            {
                Console.WriteLine ("its lower");
            }

            else
            {
                Console.WriteLine ("CORRECT");
            }
            









        }











//         string response = "yes";

// while (response == "yes")
// {
//     Console.Write("Do you want to continue? ");
//     response = Console.ReadLine();
// }


    }
    
}