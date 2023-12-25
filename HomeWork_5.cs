// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
 void InputMatrix(int[,] matrix)
 {
     for(int i = 0; i < matrix.GetLength(0); i++)
         for(int j = 0; j < matrix.GetLength(1); j++)
             matrix[i, j] = new Random().Next(0, 10);
 }
 void PrintMatrix(int[,] matrix)
 {
     for(int i = 0; i < matrix.GetLength(0); i++)
     {
         for(int j = 0; j < matrix.GetLength(1); j++)
             Console.Write(matrix[i, j] + "\t");
         Console.WriteLine();
     }
 }
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a > size[0] && b > size[1])
 Console.WriteLine("Такого числа нет");
 else
 {
 object c = matrix.GetValue(a,b);
 Console.WriteLine(c);
 }