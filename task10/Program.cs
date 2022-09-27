/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

int GetNumber ()
{
    Console.WriteLine("Введите два числа");
    string firstNumberStr = Console.ReadLine();
    int firstNumber = int.Parse(firstNumberStr);
    return firstNumber;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();
firstNumber = Math.Abs(firstNumber);
secondNumber = Math.Abs(secondNumber);

if (firstNumber / secondNumber == secondNumber || secondNumber / firstNumber == firstNumber)
    Console.WriteLine ("Да");
else 
    Console.WriteLine ("Нет");
