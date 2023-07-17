/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

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
