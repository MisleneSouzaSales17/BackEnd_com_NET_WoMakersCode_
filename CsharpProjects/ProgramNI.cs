using System;

class Programni
{
    static void Main()
    {
        int number;
        bool validInput = false;

        Console.WriteLine("Enter an integer value between 5 and 10");

        // Loop de validação
        do
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string input = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

            // Tenta converter a entrada para inteiro
            if (int.TryParse(input, out number))
            {
                // Verifica se está no intervalo correto
                if (number >= 5 && number <= 10)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }

        } while (!validInput);

        // Mensagem final
        Console.WriteLine($"Your input value ({number}) has been accepted.");
    }
}
