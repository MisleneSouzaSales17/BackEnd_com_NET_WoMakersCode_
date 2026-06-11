using System;

class Programa
{
    static void Main()
    {
        // Array de strings fornecido
        string[] myStrings = new string[2] 
        { 
            "I like pizza. I like roast chicken. I like salad", 
            "I like all three of the menu choices" 
        };

        // Laço externo para percorrer cada string
        foreach (string myString in myStrings)
        {
            string currentString = myString;
            int periodLocation;

            // Laço interno para processar cada frase
            do
            {
                // Localiza o primeiro ponto na string
                periodLocation = currentString.IndexOf(".");

                if (periodLocation != -1)
                {
                    // Extrai a frase até o ponto
                    string sentence = currentString.Substring(0, periodLocation);

                    // Remove espaços extras no início
                    Console.WriteLine(sentence.TrimStart());

                    // Remove a parte já processada (frase + ponto)
                    currentString = currentString.Remove(0, periodLocation + 1);
                }
                else
                {
                    // Se não houver ponto, imprime o restante da string
                    Console.WriteLine(currentString.TrimStart());
                }

            } while (periodLocation != -1);
        }
    }
}
