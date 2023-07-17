/*Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

void PrintArray(int[,] matr, int a, int b) 
{
for (int i = 0; i < a; i++)
{
 for (int j = 0; j < b; j++)
 {
 Console.Write($"  {matr[i, j]} ");
 }
 Console.WriteLine();
}
}

void FillArray(int[,] matr) 
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);//[1; 10)
 }
 }
}

int n = ReadInt("Введите количество строк массива");
int m = ReadInt("Введите количество столбцов массива");
int[,] matrix = new int[n, m];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix,n,m);


int coord1 = ReadInt("Введите позицию элемента в строке массива");
int coord2 = ReadInt("Введите позицию элемента в столбце массива");
if (coord1 <= n && coord2 <= m && coord1 > 0 && coord2 > 0)
    {
        Console.WriteLine($"Элемент [{coord1}, {coord2}] равен {matrix[coord1-1, coord2-1]} ");
    } 
    else {Console.WriteLine($" Такого элемента нет ");}
