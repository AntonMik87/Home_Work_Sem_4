// Написать программу копирования массива
Console.Clear();
int[] array = { 11, 22, 34, 43, 55, 65, 7, 16, 9, 105 };
Console.Write("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}

Console.WriteLine();

int[] arr = new int[10];
array.CopyTo(arr, 0);
Console.Write("Копия массива:");
for (int j = 0; j < arr.Length; j++)
    Console.Write($" {arr[j]}");


// Второй вариант.

// Console.Clear();
// int[] arrCopy = new int[10];
// int j = 0;
// int[] array = { 11, 22, 34, 43, 55, 65, 7, 16, 9, 105 };
// Console.Write("Исходный массив:");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($" {array[i]}");
// }
// Console.WriteLine();
// Console.Write("Скопированый массив:");
// for (int i = 0; i < array.Length; i++)
// {
//     arrCopy[j] = array[i];
//     Console.Write($" {arrCopy[j]}");
// }
