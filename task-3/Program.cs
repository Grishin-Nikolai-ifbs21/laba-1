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

int tabs = N - 1;
int countFigure = 1;

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < tabs; j++)
    {
        Console.Write(' ');
    }
        
    for (int j = 0; j < countFigure; j++)
    {
        Console.Write('*');
    }
        
    Console.Write('\n');
    tabs--;
    countFigure += 2;
}


Console.ReadLine();