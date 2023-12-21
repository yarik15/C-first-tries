// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Please, enter the length of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
int count = 0;

for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,101);
for(int i = 0; i < array.Length; i++)
{
    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
}

Console.WriteLine($"The quantity is {count}");
Console.WriteLine(string.Join(",",array));
