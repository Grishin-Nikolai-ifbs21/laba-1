byte checkNubmer()
{
    Console.Write("Введите число: ");

    byte tmp;
    if (!byte.TryParse(Console.ReadLine(), out tmp))
    {
        Console.Write("\nОшибка! Введите число в диапазоне от 0 до 255!");
        Console.ReadLine();
        Environment.Exit(0);
    }

    return tmp;
}

int firstNumber = checkNubmer();
int secondNumber = checkNubmer();

Console.Write('\n');

Console.Write($"AND: {firstNumber & secondNumber}\n");
Console.Write($"OR: {firstNumber | secondNumber}\n");
Console.Write($"XOR: {firstNumber ^ secondNumber}\n");


Console.ReadLine();