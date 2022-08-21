// Написать программу копирования массива
Console.Clear();
int[] array = {1,2,3,4,5,6,7,8,9,10};
Console.Write("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}

Console.WriteLine();

int[] arr = new int[10];
array.CopyTo(arr, 0);
Console.Write("Копия массива:");
for(int j = 0; j < arr.Length;  j++)
Console.Write($" {arr[j]}" );


// // Второй вариант.

// Console.Clear();
// int[] arrCopy = new int[10];
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Console.Write("Исходный массив:");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($" {array[i]}");
// }
// Console.WriteLine();
// Console.Write("Скопированый массив:");
// for (int j = 0;arrCopy[j] < array.Length; arrCopy[j]++)
// {
//     Console.Write($" {arrCopy[j]+1}");
// }
