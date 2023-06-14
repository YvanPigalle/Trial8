//Задача: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void FillArray(int [,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
  {
    for (int j=0; j<array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(1,10);
    }
  }
}

void Regression(int [,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ArrayRegression = new int[3, 4];
FillArray(ArrayRegression);
PrintArray(ArrayRegression);
Regression(ArrayRegression);
Console.WriteLine("_______");
PrintArray(ArrayRegression);
*/
//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int [,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
  {
    for (int j=0; j<array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(1,10);
    }
  }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}