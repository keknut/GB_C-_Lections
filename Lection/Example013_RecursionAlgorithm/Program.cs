/*string[,] table = new string[2, 5];
table[1, 2] = "слово";*/

void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++) //GetLength(0) забирает количество строк а (1) забирает количество столбцов.
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++) //GetLength(0) забирает количество строк а (1) забирает количество столбцов.
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("+");
            }
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void FillImage(int[,] pic, int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(pic, row - 1, col);
        FillImage(pic, row, col - 1);
        FillImage(pic, row + 1, col);
        FillImage(pic, row, col + 1);
    }
}

int[,] pic = new int[,]{
{0,0,0,0,1,0,0,0,0},
{0,0,0,1,0,1,0,0,0},
{0,0,1,0,0,0,1,0,0},
{0,1,0,0,0,0,0,1,0},
{1,1,1,1,1,1,1,1,1}
};

/*int[,] matrix = new int[2, 5];
PrintImage(pic);
FillImage(pic, 2, 3);
PrintImage(pic);*/

double Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

//Console.WriteLine(Factorial(40));

/*f(1) = 1
f(2) = 1
f(n) = (f(n-1)+ f(n-2))
*/

double Fibonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonacci(i));
}