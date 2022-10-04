Console.WriteLine("Введите размер прямоугольника");

double checkSide()
{
    Console.Write("Введите сторону прямоугольника: ");

    double tmp;
    if (!double.TryParse(Console.ReadLine(), out tmp))
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

double a = checkSide();
double b = checkSide();

Console.Write($"\nПлощаль прямоугольника: {a * b}");


Console.ReadLine();