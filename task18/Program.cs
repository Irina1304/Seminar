/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]


int[] arr = new int[8];
Random rnd = new Random();

for (int i = 0; i < 8; i++)
{
    arr[i] = rnd.Next(0,2);
    Console.Write(" "+arr[i]);
}
*/

Console.WriteLine("Введите размерность массива:");
int demension = int.Parse(Console.ReadLine());
Random rnd = new Random();
int[] arr = new int[demension];

for (int i = 0; i < demension; i++)
{
arr[i] = rnd.Next(0,2);
}

var result = string.Join(", ", arr);
Console.WriteLine(result);
