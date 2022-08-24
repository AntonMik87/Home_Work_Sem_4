// Написать программу масштабирования фигуры (0,0) (2,0) (2,2) (0,2)

Console.WriteLine("Введите вершины: ");
int n = int.Parse(Console.ReadLine() ?? "0");
double[] arrX = new double[n];
double[] arrY = new double[n];
int top = 1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите значение вершинны : x{top}");
    arrX[i] = double.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine($"Введите значение вершинны : x{top}");
    arrY[i] = double.Parse(Console.ReadLine() ?? "0");
    top++;
}
Console.WriteLine("Введите коофицент K: ");
double k = double.Parse(Console.ReadLine() ?? "0");
for (int i = 0; i < n; i++)
{
    Console.Write("(" + arrX[i] + ", " + arrY[i] + ") ");
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    double x = arrX[i] * k;
    double y = arrY[i] * k;
    Console.Write("(" + x + ", " + y + ") ");
}











