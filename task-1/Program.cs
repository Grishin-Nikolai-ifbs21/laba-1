byte? checkNubmer()
{
    Console.Write("Введите число: ");

    byte tmp;
    if (!byte.TryParse(Console.ReadLine(), out tmp))
    {
        return null;
    }

    return tmp;
}

byte? firstNumber = checkNubmer();
byte? secondNumber = checkNubmer();

Console.Write('\n');

if (firstNumber == null || secondNumber == null)
{
    Console.Write("\nОшибка! Введите число в диапазоне от 0 до 255!");
}
else
{
    Console.Write($"AND: {firstNumber & secondNumber}\n");
    Console.Write($"OR: {firstNumber | secondNumber}\n");
    Console.Write($"XOR: {firstNumber ^ secondNumber}\n");
}


Console.ReadLine();
