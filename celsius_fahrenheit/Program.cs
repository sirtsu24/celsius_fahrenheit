using System;

namespace celsius_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {

           /* Write a program in C# Sharp that converts Fahrenheit into Celcius and vice versa.
- The program enables the user to select if the user wants to convert into Celcius or into Farenheit.
- After the user has made their choice, the program asks for an input, performs calculations and displays the result
- fahrenheit = (celsius * 9) / 5 + 32;
            -celsius = (fahrenheit - 32) * 5 / 9; */


            float input;
            string userAnswer;

            Console.WriteLine("Dou you want to convert into Celsius or into Fahrenheit?");
            userAnswer = Console.ReadLine();
            bool Answer = false;
        Start:
            while (!Answer)
            {
                if (userAnswer.ToLower() == "celsius" || userAnswer.ToLower() == "fahrenheit")
                {
                    Answer = true;
                    Console.WriteLine("Insert value what you want to convert");
                    input = float.Parse(Console.ReadLine());
                    Convert(input, userAnswer);
                }
                else
                {
                    Console.WriteLine("Please insert Celsius or Fahrenheit");
                    userAnswer = Console.ReadLine();
                    goto Start;
                }
            }


            
                           
            Console.ReadLine();
        }
        public static void Convert(float x, string y)
        {
            
            if (y == "celsius")
            {
                float i = (x - 32) * 5 / 9;
                Console.WriteLine(i);
            }
            else
            {
                float i = (x * 9) / 5 + 32;
                Console.WriteLine(i);
            }
            

        }
        
    }
}