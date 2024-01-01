// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// Console.Clear();
// char [] array = new char[]{'a', 'b', 'c', 'd', 'f'};
// string res = "";
// for(int i = 0; i < array.Length; i++)
//     res += array[i];
// Console.Write(res);
//---------------------------------------------------------------------------------------
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Console.Clear();
// Console.WriteLine("Введите строку");
// string res = Console.ReadLine();
// string new_res = "";
// for(int i = 0; i < res.Length; i++)   
//       new_res += res.ToLower()[i];
// Console.Write(new_res);
// --------------------------------------------------------------------------------------
// Задайте произвольную строку. Выясните, является ли она палиндромом.
Console.Clear();
Console.WriteLine("Введите строку");
string res = Console.ReadLine();
res = res.Replace(" ","" );
res = res.ToLower();
for (int i = res.Length - 1; i >= 0; i--)
    if (res[i] != res - 1 )
    {
        Console.Write("Строка является палиндромом");
    }
    else
    {
        Console.Write("Строка не является палиндромом");
    }






