Console.WriteLine("Введите стороны треугольника\n");

int checkSide()
{
    Console.Write("Введите сторону треугольника: ");

    int tmp;
    if (!int.TryParse(Console.ReadLine(), out tmp))
    {
        Console.Write("\nОшибка! Было введено не число!");
        Console.ReadLine();
        Environment.Exit(0);
    }

    if (tmp < 0)
    {
        Console.Write("\nОшибка! Сторона не может быть меньше нуля!");
        Console.ReadLine();
        Environment.Exit(0);
    }

    return tmp;
}

int a = checkSide();
int b = checkSide();
int c = checkSide();

if (a + b > c && b + c > a && a + c > b)
{
    double p = (double)(a + b + c) / 2;
  
    Console.Write($"\nПлощаль треугольника: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
}
else
{
    Console.Write("\nОшика! Сумма двух сторон треунольника должна быть больше длины третьей!");
}
    

Console.ReadLine();