// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя).


Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

int result = number * number;

Console.WriteLine($"Число: {number}, Квадрат: {result}");
