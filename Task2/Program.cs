/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
1. создать одномерный массив, заполненый случайными цифрами. 
2. Печать одномерного массива
3. Поиск суммы элементов, стоящих на нечётных позициях.
4. Печать сыммы элементов.
*/

int[] NewArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
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

int FindSumElemNoEvenInd(int[] findSum)
{
    int result = 0;
    for (int i = 0; i < findSum.Length; i++)
    {
        if (findSum[i] % 2 != 0) result += findSum[i];
    }
    return result;
}
void PrintNewFindSum(int elements)
{
    Console.Write($"{elements}");
}

int[] array = NewArray(8);

PrintArray(array);
Console.WriteLine();
PrintNewFindSum(FindSumElemNoEvenInd(array));