/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

// метод, который меняет положительные значения на отрицательные и наоборот
int [] NewArray(int[] array)
{
    int[] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = -array[i];
    }
    return resultArray;
}

int[] array = InitArray(4);
PrintArray(array);
Console.WriteLine();
int[] resultArray = NewArray(array);
PrintArray(resultArray);
