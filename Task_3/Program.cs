 /* Напишите программу, которая принимает на вход цифру, 
 обозначающую день недели, и проверяет, является ли этот день 
 выходным.

6 -> да
7 -> да
1 -> нет */

int number1 = ReadOn("Введите число дня недели: ");

if (number1 == 1 || number1 == 2 || number1 == 3 || number1 == 4 
|| number1 == 5)
{
    Console.Write("День не является выходным");
}

else if (number1 == 6 || number1 == 7)
{
    Console.Write("День является выходным");
}

else
{
    Console.Write("Некорректное число, введите от 1 до 7");
}

int ReadOn (string messege)
    {
        Console.Write(messege);
        return Convert.ToInt32(Console.ReadLine());
    }
    