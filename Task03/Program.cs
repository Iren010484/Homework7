/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

void ArithmeticMean(int[,] matr)
{for (int j = 0; j < matr.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
            {
                result = result +  matr[i,j];
            }
        result = result/matr.GetLength(1);
        result = Math.Round(result,2, MidpointRounding.ToEven);
        Console.Write ($" {result}; ");
      }  }

int n = ReadInt("Введите количество строк массива");
int m = ReadInt("Введите количество столбцов массива");
int[,] matrix = new int[n, m];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix,n,m);
ArithmeticMean(matrix);


