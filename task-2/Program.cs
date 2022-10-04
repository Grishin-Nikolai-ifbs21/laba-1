Console.Write("Введите N: ");

int N;
if (!int.TryParse(Console.ReadLine(), out N))
{
    Console.Write("\nОшибка! Было введено не число!");
    Console.ReadLine();
    return;
}

if (N < 0)
{
    Console.Write("\nОшибка! N не может быть меньше нуля!");
    Console.ReadLine();
    return;
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write('*');
    }
            
    Console.Write('\n');
}


Console.ReadLine();