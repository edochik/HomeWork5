/*
Задача 3: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
1. Созадать массив вещественных чисел.
2. Печать массива вещественных чисел.
3. Метод поиска максимального и минимального элемента и вычисления разницы между ними.
4. Печать метода поиска мак/мин.

*/

double[] RandArraRealNum(int numbers)
{
    double[] array = new double[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void PrintArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

double FindDifMaxMIn(double[] array)
{
    double Min = array[0];
    double Max = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] > Max) Max = array[i];
        if(array [i] < Min) Min = array[i];
        result = Max - Min;
    }
    return result; 
}

void PrintFindDifMaxMin(double information)
{
    Console.Write(information);
}


double[] newArray = RandArraRealNum(6);


PrintArr(newArray);
Console.WriteLine();
PrintFindDifMaxMin(FindDifMaxMIn(newArray));