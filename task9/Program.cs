/* 
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

int GetNumber ()
{
    Console.WriteLine("Введите число");
    string NumberStr = Console.ReadLine();
    int Number = int.Parse(NumberStr);
    return Number;
}

int Number = GetNumber();
int firstResult = Number % 7;
int secondResult = Number % 23;

if (firstResult == 0 && secondResult == 0)
    Console.WriteLine ("Да");
else 
    Console.WriteLine ("Нет");
