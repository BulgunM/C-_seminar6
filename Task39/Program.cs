// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

//Array.Reverse(array); встроенный метод переворота массива

// [1 2 3 4 5] -> [5 4 3 2 1]
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++) // делим на 2, потому что нужно сделать в 2 раза меньше итераций в цикле
    {
        int temp = array[i]; // 1
        array[i] = array[array.Length - 1 - i]; //array[i] = 50
        array[array.Length - 1 - i] = temp; // array[array.Length - 1 - i] = 1
    }
}

int[] arr = CreateArrayRndInt(5, -23, 34);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
Array.Reverse(arr);
PrintArray(arr);