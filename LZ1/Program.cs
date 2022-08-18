﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

Console.WriteLine("ВВедите точки координат");
Console.Write("Ax:  ");
int ax = Convert.ToInt32(Console.ReadLine());

Console.Write("Ay:  ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Az:  ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Bx:  ");
int bx = Convert.ToInt32(Console.ReadLine());

Console.Write("By:  ");
int by = Convert.ToInt32(Console.ReadLine());

Console.Write("Bz:  ");
int bz = Convert.ToInt32(Console.ReadLine());

double pif = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));  //Sqrt - корень  Pow - квадрат

Console.WriteLine(Math.Round(pif, 2)); //на сколько отступать



