// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] twoArray = new double [rows,columns];

for (int i=0; i<twoArray.GetLength(0); i++)
{
    for (int j=0; j<twoArray.GetLength(1); j++)
    {
        twoArray [i,j] = Math.Round(new Random().Next(-10,11) + new Random().NextDouble(),2);
        Console.Write(twoArray[i,j]+"\t");
    }
    Console.WriteLine();
}
