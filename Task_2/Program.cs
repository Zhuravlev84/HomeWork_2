/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int number = ReadInt ("Введите число: ");

int numberLimit = 3;
int temp = number;
int a = 0;
while (temp > 0)
{
    temp = temp/10;
    a++;
}
while (a > numberLimit)
{
    number = number/10;
    a = a - 1;
}
Console.Write(number%10);

int ReadInt (string messege)
{   
    Console.Write (messege);
    return Convert.ToInt32 (Console.ReadLine());
}