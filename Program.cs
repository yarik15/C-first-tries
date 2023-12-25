// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// Console.Clear();
// Console.WriteLine("Please, enter the length of the array: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[n];
// int count = 0;

// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1,101);
// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 20 && array[i] <= 90)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"The quantity is {count}");
// Console.WriteLine(string.Join(",",array));
//---------------------------------------------------------------------------------------------------------------
// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.
// Console.Clear();
// int n = 10;
// int [] array = new int[n];
// int count = 0;

// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0,11);
// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"The quantity of the even numbers {count}");
// Console.WriteLine(string.Join(",",array));
//---------------------------------------------------------------------------------------
// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// double dif_ = 0;
// double [] Array = new double[a];


// Random rand = new Random();
// for (int i = 0; i < a; i++)
//     Array[i] = rand.NextDouble();
// dif_ = Array[Array.Length - 1] - Array[0];
// Console.WriteLine($"The difference of numbers is {dif_}");
// Console.WriteLine(string.Join(";",Array));


