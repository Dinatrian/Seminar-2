// Задача: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string num = Console.ReadLine();
    int number;
    number = int.Parse(num);
    return number;
}

int number = ReadInt("Введите трёхзначное число: ");

if (number > 999 || number < 100)
{
    Console.WriteLine(number + " - не трёхзначное число.");
}
else
{
    int secondDigit = number / 10;
    secondDigit = secondDigit % 10;
    Console.WriteLine("Вторая цифра числа " + number + " - " + secondDigit);
}