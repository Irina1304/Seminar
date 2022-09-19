// Напишите программу, которая на вход принимает одно число n, а на выход показывает все целые числа в промежутке от -n до n.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

for (int i = -number; i<=number; i++)
Console.WriteLine($"{i} ");
