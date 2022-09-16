// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int [,] matrix = new int [5,5];

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,51);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите индекс строки от 0 до 4: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца от 0 до 4: ");
int column = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (row>=0 && row<=4 && column>=0 && column<=4)
{
    result = matrix[row,column];
    Console.WriteLine($"Элемент с индексами [{row},{column}] = {result}");
}
else
{
    Console.WriteLine($"Элемента с индексами [{row},{column}] не существует.");
}
