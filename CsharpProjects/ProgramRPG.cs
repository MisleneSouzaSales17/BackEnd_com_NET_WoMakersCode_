using System;

class Programrpg
{
    static void Main()
    {
        Random random = new Random();

        int heroHealth = 10;
        int monsterHealth = 10;

        do
        {
            Console.WriteLine("\nPressione qualquer tecla para iniciar a próxima rodada...");
            Console.ReadKey(true); // espera o jogador apertar uma tecla

            // Herói ataca primeiro
            int heroAttack = random.Next(1, 11);
            monsterHealth -= heroAttack;
            Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

            // Se o monstro ainda estiver vivo, ele contra-ataca
            if (monsterHealth > 0)
            {
                int monsterAttack = random.Next(1, 11);
                heroHealth -= monsterAttack;
                Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
            }

        } while (heroHealth > 0 && monsterHealth > 0);

        // Determina o vencedor
        Console.WriteLine();
        if (heroHealth > 0)
        {
            Console.WriteLine("Hero wins!");
        }
        else if (monsterHealth > 0)
        {
            Console.WriteLine("Monster wins!");
        }
        else
        {
            Console.WriteLine("Both have fallen!");
        }
    }
}
