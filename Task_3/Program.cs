 /* Напишите программу, которая принимает на вход цифру, 
 обозначающую день недели, и проверяет, является ли этот день 
 выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число дня недели: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 1 || number1 == 2 || number1 == 3 || number1 == 4 
|| number1 == 5)
{
    WriteOn("День не является выходным");
}

else if (number1 == 6 || number1 == 7)
{
    WriteOn("День является выходным");
}

else
{
    WriteOn ("Некорректное число, введите от 1 до 7");
}

void WriteOn (string messege)
    {
        Console.Write(messege);
    }
    