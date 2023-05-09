using System;

namespace NameSpace
{
    class OurProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your dath of birth: ");
            string userInput = Console.ReadLine();
            // Console.Write(userInput);

            if (string.IsNullOrEmpty(userInput))
            {
                Console.Write("Input filed is empty!");
            }else
            {
                int userDateOfBirth = Convert.ToInt32(userInput ?? userInput);
                const int currentDate = 2023;
            int age = currentDate - userDateOfBirth;
            Console.Write($"Your age is {age}");
            
            }
        }
    }
}