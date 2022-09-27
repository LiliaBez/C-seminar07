/*Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.*/

int height = EnterInt("Введите количество строк: "); //высота массива
int width = EnterInt("Введите количество столбцов: ");  //ширина массива

int[,] numbers = new int[height, width];

Fill2DArray(numbers, height, width);
Print2dArray(numbers, height, width);

int indexHeight = EnterInt("Введите индекс строки искомого элемента: ");
int indexWidht = EnterInt("Введите индекс столбца искомого элемента: ");

if (indexHeight >= height || indexWidht >= width)
    Console.WriteLine("Такого числа в массиве нет");

FindElement(numbers, height, width);




int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2dArray(int[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}


void FindElement(int[,] numbers, int height, int widht)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == indexHeight && j == indexWidht)
            {
                Console.WriteLine($"Искомый элемент: {numbers[i, j]}");
            }
        }
    }
}
