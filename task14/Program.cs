﻿/* Напишите программу, которая на вход принимает число N и выдает таблицу квадратов чисел от 1 до N.
5-> 1,4,9,16,25
2-> 1,4
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

string LineNum(int numN, int p)
{
    string outLine = "1";
    for(int i = 2; i <= numN; i++)
    {
        outLine=outLine+"\t"+Math.Pow(i, p);
    }
    return outLine;
}

int numN = ReadData("Введите число N: ");

string lineTop=LineNum(numN, 1);
string lineDown=LineNum(numN, 2);

PrintData("", lineTop);
PrintData("", lineDown);