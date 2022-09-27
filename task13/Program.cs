/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Например:
А (3,6) В (2,1) -> 5,09 
А (7,-5) В (1,-1) -> 7,21
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double FindeLen(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int x1 = ReadData("Введите координату x первой точки: ");
int y1 = ReadData("Введите координату y первой точки: ");
int x2 = ReadData("Введите координату x второй точки: ");
int y2 = ReadData("Введите координату y второй точки: ");

double result = FindeLen (x1, y1, x2, y2);
result = Math.Round(result, 3);
PrintData("Расстояние между точками: ", result.ToString());

