/* Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает вторую цифру 
этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 || number < 100)
{
    Console.Write("Введенное число не трехзначное");
}
else
{
    int number1 = number % 100;
    int finishNumber = number1 / 10;
    Console.Write(finishNumber);
}
