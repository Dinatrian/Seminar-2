// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string num = Console.ReadLine();
    int number;
    number = int.Parse(num);
    return number;
}

int number = ReadInt("Введите число: ");
int thirdDigit = number;
if (number > 99)
{
    while (thirdDigit > 1000)
    {
        thirdDigit = thirdDigit / 10;
    }
    thirdDigit = thirdDigit % 10;
    System.Console.WriteLine("Третья цифра в числе " + number + " - " + thirdDigit);
}
else
{
    System.Console.WriteLine("Третьей цифры в числе " + number + " нет.");
}