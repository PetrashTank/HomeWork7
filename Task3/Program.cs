/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] number = new int[4,4];
FillArray(number);
Console.Write("Среднеарифметическое столбцов: ");
MeanNumber(number); 
 
void FillArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0,10); 
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}
void MeanNumber (int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write(Math.Round(sum / array.GetLength(0),2) + " ");
    }
   
}