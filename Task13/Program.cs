// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5 //78 -> третьей цифры нет //32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberLength = number.ToString().Length;

if(numberLength < 3)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    if (number > 99 && number < 1000)
        {
            number = number % 10;
        }

    else
        {   
            while(number > 1000)
            {
                number = number / 10;
            }
            number = number % 10;
        } 
    int thirdDigit = number;
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}