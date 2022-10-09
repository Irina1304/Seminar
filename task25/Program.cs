﻿// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int GetLength()
{
    Console.WriteLine("Введите сторону");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void CheckTriangle(int a, int b, int c)
{
    if ((a < b + c) && (c < a + b) && (b < c + a))
        Console.WriteLine("Такой реугольник существует");
    else
        Console.WriteLine("Такого треугольника не существует");
}

int a = GetLength();
int b = GetLength();
int c = GetLength();

CheckTriangle(a, b, c);
