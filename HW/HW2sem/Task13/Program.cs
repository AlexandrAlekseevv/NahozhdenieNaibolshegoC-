/*Задача 13: 
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 6
78 -> третьей цифры нет
32679 -> 6
*/
using System;
using static System.Console;
Clear();

Write("Введите число ");
int number = Convert.ToInt32(ReadLine());

int yournumber = number;//для красивого ответа
number = Math.Abs(number);//модуль. для работы с отрицательными числами

if(number/100<1)
{
    WriteLine("В числе "+ yournumber+ " -> третьей цифры нет"); 
}

else
{
    while(number/100 >= 10)
    {
        number = number/10;
    }

    WriteLine("Третья цифра в числе "+ yournumber+ " -> "+ number%10);
}

