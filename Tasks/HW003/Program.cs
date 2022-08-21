// Написать программу копирования массива
Console.Clear();
int[] array = {1,2,3,4,5,6,7,8,9,10};
for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}

Console.WriteLine();

int[] arr = new int[10];
array.CopyTo(arr, 0);
for(int j = 0; j < arr.Length;  j++)
Console.Write($" {arr[j]}" );


// Второй вариант.

// Console.Clear();
// int[] arr = new int[10];
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($" {array[i]}");
// }
// Console.WriteLine();
// for (int j = 1;arr[j] < array.Length; arr[j]++)
// {
//     Console.Write($" {arr[j]+1}");
// }


