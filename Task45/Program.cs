// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int[] arr = { 5, 4, 6, 7 };
int[] newArr = CopyArray(arr);
PrintArray(newArr);
