﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {                                                                   //сравнение если number[номерация цифр]  0 1 2 3 4 (первый с последним  второй с предпоследним)
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{                                        //проверка длинны
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
