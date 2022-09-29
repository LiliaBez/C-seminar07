/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/


int height = EnterInt("Enter height: "); //высота массива
int width = EnterInt("Enter widht: ");  //ширина массива

double[,] numbers = new double[height, width];

Fill2DArray(numbers, height, width);
Print2dArray(numbers, height, width);


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-10, 11), 1);
        }
    }
}

void Print2dArray(double[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j]}   ", 5);
        }
        Console.WriteLine();
    }
}



