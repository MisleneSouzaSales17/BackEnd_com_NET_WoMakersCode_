Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Regra 5: assinatura já expirada
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
// Regra 4: expira em 1 dia
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
// Regra 3: expira em 5 dias ou menos
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
// Regra 2: expira em 10 dias ou menos
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
// Regra 6: mais de 10 dias → não exibe nada
else
{
    // Nenhuma mensagem
}

// Exibir desconto, se aplicável
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
