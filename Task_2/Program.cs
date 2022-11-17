/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number > 99 && number < 1000)
{
    int number1 = number % 10;
    Console.Write(number1);
}
else if (number > 999 && number < 10000)
{
    int number1 = number % 100;
    int finishNumber = number1 / 10;
    Console.Write(finishNumber);
}
else if (number > 9999 && number < 100000)
{
    int number1 = number % 1000;
    int finishNumber = number1 / 100;
    Console.Write(finishNumber);
}
else
{
    Console.Write ("Третьей цифры нет");
}
// пытаюсь сделать в массиве для всех чисел, если получится 
// это сообщение не увидете