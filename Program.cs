    //By NicholasDev
    
    //Declaração de variáveis com valor padrão
    double adult1 = 0, adult2 = 0, kid = 0, drink1 = 0, drink2 = 0, drinkwater = 0, drinkwater1 = 0, drinkwater2 = 0;
    double drinkwater3 = 0, accompany = 0, accompany1 = 0, accompany2 = 0, accompany3 = 0, meat = 0;

    //Consultando a quantidade de adultos e crianças
    Console.WriteLine("Adultos (que consomem bebidas alcoólicas): ");
    adult1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Adultos (que não consomem bebidas alcoólicas): ");
    adult2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Crianças: ");
    kid = int.Parse(Console.ReadLine()!);

    //Condicional para calcular a quantidade de bebidas
    if (adult1 != 0)
    {
        drinkwater1 = adult1 * 400;
        accompany1 = adult1 * 200;
    }

    if (adult2 != 0)
    {
        drink2 = adult2 * 2;
        drinkwater2 = adult2 * 400;
        accompany2 = adult2 * 200;
    }

    if (kid != 0)
    {
        drinkwater3 = kid * 400;
        accompany3 = kid * 200;
    }

    //Calculando a quantidade de carne
    meat = (adult1 + adult2) * 400; 
    meat = meat + kid * 200;
    meat = meat / 1000;
    
    //Somando a quantidade de bebidas e dividindo por 1000 para converter em litros
    drink1 = (adult1 + adult2 + kid) * 500;
    drink1 = drink1 / 1000;

    //Somando o acompanhamento e dividindo por 1000 para converter em kg
    accompany = accompany1 + accompany2 + accompany3;
    accompany = accompany / 1000;

    drinkwater = drinkwater1 + drinkwater2 + drinkwater3;
    drinkwater = drinkwater / 1000;

    //Exibe a quantidade de adultos e crianças
    Console.WriteLine("--- Churrascaria Cupim Rei ---");

    Console.WriteLine($"Adultos (que consomem bebidas alcoólicas):.....{adult1}");
    Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas): {adult2}");
    Console.WriteLine($"Crianças:......................................{kid}");

    Console.WriteLine();

    //Exibe o total que será gasto
    Console.WriteLine($"Carne:............ {meat}kg");
    Console.WriteLine($"Acompanhamentos:.. {accompany}kg");
    Console.WriteLine($"Cerveja:.......... {drink2}l");
    Console.WriteLine($"Refrigerante:..... {drink1}l");
    Console.WriteLine($"Água:..............{drinkwater}l");