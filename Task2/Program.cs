/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элемент 7
*/
int ReadIndex(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int iInd = ReadIndex ("Введите индекс строки ");
int jInd = ReadIndex ("Введите индекс столбца ");

int[,] number = new int[4,5];
FillArray(number);

if (iInd < number.GetLength(0) && jInd < number.GetLength(1)) Console.WriteLine($"Число с индексом [{iInd},{jInd}] -> {number[iInd, jInd]}");
else Console.WriteLine($"Числа с индексом {iInd} {jInd} в массиве нет");

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

