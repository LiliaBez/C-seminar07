/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

/*пока не поняла как вывести и отрицательные и дробные числа..
float выдает отрицательные и положительные числа в диапазоне, 
 а new Random ().NextDouble() выдает только дробные от 0 до 1;*/

int height = EnterInt("Enter height: "); //высота массива
int width = EnterInt("Enter widht: ");  //ширина массива

float[,] numbers = new float[height, width];

Fill2DArray(numbers, height, width);
Print2dArray(numbers, height, width);


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(float[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 10);
        }
    }
}

void Print2dArray(float[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{Math.Round(numbers[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}



