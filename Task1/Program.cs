/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

1. создать массив заполненный случайными положительными трёхзначными числами
2. Напечатать данный массив.
3. Метод показывающий кол-во чётных чисел в массиве.
4. Напечатать данный метод.
*/

int[] RandArray(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int FindEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result; 
}

void PrintInfor(int information)
{
    Console.WriteLine($" {information}");
}

int[] newArray = RandArray(6);

PrintArray(newArray);
Console.WriteLine();
PrintInfor(FindEven(newArray));