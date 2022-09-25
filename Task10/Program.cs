// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int numberLength = threeDigitNumber.ToString().Length;

if (numberLength < 3 || numberLength > 3)
{
    Console.WriteLine("Ошибка! Трехзначное число состоит из трех цифр. Нужно вводить трехзначное число.");
}
else
{
    int secondDigit = 0;

    secondDigit = ((threeDigitNumber / 10) % 10);

    Console.WriteLine($"Результат: {secondDigit}");
}