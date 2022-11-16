/* Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает вторую цифру 
этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
 int number1 = number % 100;
    int finishNumber = number1 / 10;
    Console.Write(finishNumber);
}
else if (number < -100 && number > -1000)
{
    int number1 = (-1)*(number % 100);
    int finishNumber = number1 / 10;
    Console.Write(finishNumber);
}
else
{
    Console.Write("Введенное число не является трехзначным");
}
