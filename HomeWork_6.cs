// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// Console.Clear();
// char [] array = new char[]{'a', 'b', 'c', 'd', 'f'};
// string res = "";
// for(int i = 0; i < array.Length; i++)
//     res += array[i];
// Console.Write(res);
//---------------------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("Введите строку");
string res = Console.ReadLine();
string new_res = "";
for(int i = 0; i < res.Length; i++)   
      new_res += res.ToLower()[i];
Console.Write(new_res);






