/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

// метод инициализации массива
int[] InitArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

// метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// пользователь вводит число, которое нужно найти
Console.WriteLine("Введите цифру, которую необходимо найти в массиве");
int number = int.Parse(Console.ReadLine() ?? "");

// вывод массива на консоль
int[] array = InitArray(10);
PrintArray(array);

// проверяем числа до тех пор, пока не будет совпадения
bool existNum = false;
for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        existNum = true;
        break;
    }
} 

if (existNum != true)
Console.WriteLine("Числа нет в массиве");
else
Console.WriteLine("Число есть в массиве");