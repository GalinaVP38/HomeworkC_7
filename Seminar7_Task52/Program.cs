// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце
int [,] matrix = new int [3,3];

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,20);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}

 

for (int j=0; j<matrix.GetLength(1); j++)
{
    double Sum = 0;
    double averageNum = 0;
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        Sum+= matrix[i,j];
        averageNum = Sum/3;
        averageNum = Math.Round(averageNum, 1);
    }
    Console.WriteLine($"Сумма элементов {j+1} столбца = {averageNum}");
}
