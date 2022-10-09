/*
Напишите программу, которая перевернет одномерныймассив (первый элемент станет последним, последний первым и т.д.)
*/

int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 20);
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach(int item in arr)
    {
        Console.Write($"{item}");
    }
    Console.WriteLine();
}

int [] ReverseArray(int[] array)
{
    int index = array.Length;
    int[] result = new int[array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        index--;
        result[i] = array[index];
    }
    return result;
}

int[] array = InitArray(10);
Console.WriteLine("Исходный массив: ");
PrintArray(array);

int[] reverseArr = ReverseArray(array);
Console.WriteLine("Перевернутый массив: ");
PrintArray(reverseArr);