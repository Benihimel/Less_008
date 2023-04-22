// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Enter num row matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num columns matrix: ");
int m = Convert.ToInt32(Console.ReadLine());


void Matrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)        
        {
            matr[i, j] = new Random().Next(0,10);
        }
    }

}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void SumMinValueString(int[,] matr)
{
    int minString = 0;
    int minSum = 0;
    int sumString = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
        sumString += matr[i, j];
        if (sumString < minString)
        {
            minString = sumString;
            minSum = i;
        }
        sumString = 0;
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            minString += matr[0, k];
        }
        }
    }
    Console.Write($"String {minSum + 1}");
}


int[,] matrix = new int [m , n];
Console.WriteLine($"Matrix: ");
Matrix(matrix);
PrintMatrix(matrix);
SumMinValueString(matrix);



