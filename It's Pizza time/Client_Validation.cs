using System;


namespace It_s_Pizza_time
{
    internal class Client_Validation
    {
        public Client_Validation()
        {


            // Will validate user input, Loop on conditions if needed // 

            string clientInput;

            do
            {
                Console.Write("Good day, It's Pizza Time. May I take your name: ");

                clientInput = Console.ReadLine();


            } while (string.IsNullOrEmpty(clientInput) || !clientInput.All(char.IsLetter));

            Console.WriteLine($"Hi {clientInput} May I take your order please");
        }
    }
}