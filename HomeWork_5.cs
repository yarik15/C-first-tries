// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//  void InputMatrix(int[,] matrix)
//  {
//      for(int i = 0; i < matrix.GetLength(0); i++)
//          for(int j = 0; j < matrix.GetLength(1); j++)
//              matrix[i, j] = new Random().Next(0, 10);
//  }
//  void PrintMatrix(int[,] matrix)
//  {
//      for(int i = 0; i < matrix.GetLength(0); i++)
//      {
//          for(int j = 0; j < matrix.GetLength(1); j++)
//              Console.Write(matrix[i, j] + "\t");
//          Console.WriteLine();
//      }
//  }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
//  Console.WriteLine("Введите координаты");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a > size[0] && b > size[1])
//  Console.WriteLine("Такого числа нет");
//  else
//  {
//  object c = matrix.GetValue(a,b);
//  Console.WriteLine(c);
//  }
// ------------------------------------------------------------------------------------------------
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

//  var array = new int[4, 4]
//  { 
//      { 86, 90, 111, 23 },
//      { 33, 12, 4, 67 },
//      { 34, 45, 1, 23 },
//      { 0, 7, 54, 2 }
//  };
//  for(int i = 0; i < array.GetLength(1); i++)
//  {
//      var tmp = array[3, i];
//      array[3, i] = array[0, i];
//      array[0, i] = tmp;
//  }
//  for(int i = 0; i < array.GetLength(0); i++)
//  {
//      for(int j = 0; j < array.GetLength(1); j++)
//          {
//              Console.Write(array[i,j] + " ");
//          }
//          Console.WriteLine();
//  }
//  Console.ReadKey(true);
//---------------------------------------------------------------------------------------

int [,] matrix = {
    {23, 43, 54},
    {65, 76, 87},
    {98, 100, 0}
};
int min_sumM = 0;
int min_sum = int.MaxValue;
int sum_ = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum_ += matrix[i, j];
    }
    if (sum_ < min_sum)
    {
        min_sum = sum_;
        min_sumM = i;
    }
}
Console.WriteLine("В этой строке наименьшая сумма элементов: ");
for (int f = 0; f < matrix.GetLength(1); f++)
{
    Console.WriteLine(matrix[min_sumM, f] + "\t");
}

