// Creamos una instancia de la clase Random para generar números aleatorios
Random dice = new Random();

// Generamos tres números aleatorios entre 1 y 6, simulando lanzamientos de un dado
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Calculamos la suma de los tres lanzamientos de dados
int total = roll1 + roll2 + roll3;

// Imprimimos en pantalla los resultados de los lanzamientos
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Comprobamos si se obtuvo algún par o triple en los lanzamientos
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    // Comprobamos si se obtuvo un triple
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6; // Añadimos un bono de +6 al total
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2; // Añadimos un bono de +2 al total
    }
}

// Comprobamos el valor del total para determinar el premio obtenido
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a cat!");
}
