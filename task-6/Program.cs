Console.WriteLine("Введите стороны треугольника\n");

double? checkSide()
{
    Console.Write("Введите сторону треугольника: ");

    int tmp;
    if (!int.TryParse(Console.ReadLine(), out tmp))
    {
        return null;
    }

    if (tmp < 0)
    {
        return null;
    }

    return tmp;
}

double? a = checkSide();
double? b = checkSide();
double? c = checkSide();

if (a == null || b == null || c == null)
{
    Console.Write("Ошибка! Было введено не число, либо оно меньше нуля!");
}
else
{
    if (a + b > c && b + c > a && a + c > b)
    {
        double p = (double)(a + b + c) / 2;
        Console.Write($"\nПлощаль треугольника: {Math.Sqrt((double)(p * (p - a) * (p - b) * (p - c)))}");
    }
    else
    {
        Console.Write("\nОшика! Сумма двух сторон треунольника должна быть больше длины третьей!");
    }
}
    

Console.ReadLine();
