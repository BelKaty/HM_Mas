// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
   // 6 -> да
   // 7 -> да
   //1 -> нет  

Console.Write("Введите номер дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());

if(numberOfDay > 7 || numberOfDay < 1)
    {
    Console.WriteLine("Ошибка! Номер дня недели может быть от 1 до 7");
    }
else
    {
    if (numberOfDay > 0 && numberOfDay < 6) 
    {
    Console.WriteLine("Нет!");
    }
    else
    {
    Console.WriteLine("Да!");
    }
    }
