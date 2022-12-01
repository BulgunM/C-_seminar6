﻿// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

string BinaryNumber(int num)
{
    string digit = string.Empty;
    while (num > 0)
    {
        digit = num % 2 + digit; // переворот 
        Console.WriteLine(digit);
        num = num / 2;
    }
    return digit;
}

// int[] BinaryCode(int num)
// {
//     int num2 = num;
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 2;
//         count++;
//     }
//     int[] arr = new int[count];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = num2 % 2;
//         num2 = num2 / 2;
//     }
//     return arr;
// }

Console.WriteLine(BinaryNumber(number));