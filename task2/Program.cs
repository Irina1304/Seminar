// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if(numberA/numberB == numberB)
Console.WriteLine("Да");
else
Console.WriteLine("Нет");