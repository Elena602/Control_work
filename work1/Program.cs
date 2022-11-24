// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Console.WriteLine("Введите количество строк (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [n, m];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random random = new Random();
            matr[i, j] = random.Next(-1500, 1500);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           int variable = matr[i, j] / 10;
           if (variable > -100 && variable < 100)
           {
             Console.Write($"{matr[i, j]}" + " ");
           }
        }
    }
}