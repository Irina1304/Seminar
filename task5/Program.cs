// Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа


Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000)
Console.WriteLine(number % 10);
else
Console.WriteLine("Ошибка, число должно быть трехзначным");

