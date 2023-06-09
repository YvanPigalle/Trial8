﻿//Задача: Задайте двумерный массив. Напишите программу, 
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
                    int snail = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = snail;
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
/*
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

int[,] FillArrayRandom(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

int SumRowArray(int[,] array)
{
  int[] sumArr = new int[array.GetLength(0)];
  Console.WriteLine($"Sum in the rows: ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumArr[i] += array[i, j];
    }
    Console.WriteLine($"{i + 1} => {sumArr[i]}");
  }
  int minSum = sumArr[0];
  int minRow = 1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (sumArr[i] < minSum)
    {
      minSum = sumArr[i];
      minRow = i + 1;
    }
  }
  return minRow;
}

int [,] array = new int [3,4];
FillArrayRandom(array);
PrintArray(array);
int row = SumRowArray(array);
Console.WriteLine($"Minimal row is {row}.");
*/
//Задача: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.
/*
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
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

int[,] FillArrayRandom(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

int[,] MultiplyArray(int[,] firstArr, int[,] secondArr)
{
  int newRow, newCol;
  if (firstArr.GetLength(0) > secondArr.GetLength(0))
  {
    newRow = secondArr.GetLength(0);
  }
  else
  {
    newRow = firstArr.GetLength(0);
  }
  if (firstArr.GetLength(1) > secondArr.GetLength(1))
  {
    newCol = secondArr.GetLength(1);
  }
  else
  {
    newCol = firstArr.GetLength(1);
  }

  int[,] newArray = new int[newRow, newCol];

  for (int i = 0; i < newRow; i++)
  {
    for (int j = 0; j < newCol; j++)
    {
      for (int e = 0; e < newRow; e++)
      {
        newArray[i, j] += firstArr[i, e] * secondArr[e, j];
      }
    }
  }
  return newArray;
}

int[,] firstArr = CreateArray(Prompt("Input first array's rows: "), Prompt("Input number of columns: "));
int[,] secondArr = CreateArray(Prompt("Input second array's rows: "), Prompt("Input number of columns: "));
Console.WriteLine("_______");
FillArrayRandom(firstArr);
PrintArray(firstArr);
Console.WriteLine("_______");
FillArrayRandom(secondArr);
PrintArray(secondArr);
Console.WriteLine("The result is:");
int[,] newArray = MultiplyArray(firstArr, secondArr);
PrintArray(newArray);
*/


//Задачa: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,,] CreateArray(int a, int b, int c)
{
  int[,,] array = new int[a, b, c];
  return array;
}

void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
  }
}

int[,,] FillArrayRandom(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = new Random().Next(1, 10);
      }
    }
  }
  return array;
}

int[,,] newArr3D = CreateArray(Prompt("Input A: "), Prompt("Input B: "), Prompt("Input C: "));
Console.WriteLine();
FillArrayRandom(newArr3D);
PrintArray(newArr3D);
*/



int [,] Square = new int [4, 4];
int snail = 1;
int i = 0;
int j = 0;

while (snail <= Square.GetLength(0) * Square.GetLength(1))
{
  Square[i, j] = snail;
  snail++;
  if (i <= j + 1 && i + j < Square.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Square.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Square.GetLength(1) - 1)
    j--;
  else
    i--;
}
Console.WriteLine("LOOK, MUM! I'M A SNAIL!!!");
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

WriteArray(Square);
