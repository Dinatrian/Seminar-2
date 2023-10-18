// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int ReadInt(string msg) // Объявление функции, с именем ReadInt и строковым параметром msg
{
    Console.WriteLine(msg); // Пишем в консоль параметр msg
    string num = Console.ReadLine(); // Функция считывания введённых данных
    int number; // Объявление переменной 
    number = int.Parse(num); // Присвоение переменной number числового формата
    return number; // Возвращение значения из функции
}

int day = ReadInt("Введите номер дня недели: ");
if (day == 6 || day == 7)
{
    Console.WriteLine("да");
}
else if (day < 6 & day > 0)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("В неделе 7 дней, введите цифру в диапазоне 1-7.");
}