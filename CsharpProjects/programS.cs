using System;

class Programs
{
    static void Main()
    {
        string role = "";
        bool validInput = false;

        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

        // Loop de validação
        do
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string input = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

            // Remove espaços extras e ignora maiúsculas/minúsculas
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            role = input.Trim().ToLower();
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.

            // Verifica se corresponde a uma das opções válidas
            if (role == "administrator" || role == "manager" || role == "user")
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            }

        } while (!validInput);

        // Mensagem final
        Console.WriteLine($"Your input value ({role}) has been accepted.");
    }
}
