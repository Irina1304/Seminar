// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int GetRandomNumber(int leftRange, int rightRange)
{
    Random rnd = new Random();
    int result = rnd.Next(leftRange, rightRange);
    return result;
}

int DeleteSecondDigit(int number)
{
    int firstDigits = number / 100;
    int tridDigits = number % 10;
    return firstDigits*10+tridDigits;
}

int number = GetRandomNumber(100, 1000);
Console.WriteLine($"Рандомное число: {number}");

int twoDigits = DeleteSecondDigit(number);
Console.WriteLine($"Двухзначная цифра: {twoDigits}");