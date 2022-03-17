// Написать программу, упорядочивания по убыванию
// элементы каждой строки двумерной массива.

void FillArray(int[,] array) //метод заполняет массив случайными числами [0; 10]
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) //метод выводит массив в консоль.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortingLines(int[,] array)
{
    // Перебираем каждый элемент массива (кроме последнего, он уже будет отсортирован к тому времени, когда мы до него доберемся)
    int tmp = 0;
    int maxIndex = 0;
    int startIndex = 0;
    int currentIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (startIndex = 0; startIndex < array.GetLength(1) - 1; startIndex++)
        {
            // В переменной maxIndex хранится индекс наибольшего значения, которое мы нашли в этой итерации.
            // Начинаем с того, что наибольший элемент в этой итерации - это первый элемент (индекс 0)
            maxIndex = startIndex;

            // Затем ищем элемент побольше в остальной части массива
            for (currentIndex = startIndex + 1; currentIndex < array.GetLength(1); currentIndex++)
            {
                // Если мы нашли элемент, который больше нашего наибольшего элемента,
                if (array[i, currentIndex] > array[i, maxIndex])
                    // то запоминаем его
                    maxIndex = currentIndex;
            }
            // maxIndex теперь наибольший элемент.
            // Меняем местами наше начальное наибольшее число с тем, которое мы обнаружили
            tmp = array[i, startIndex];
            array[i, startIndex] = array[i, maxIndex];
            array[i, maxIndex] = tmp;
        }
    }
}

Console.WriteLine("Enter the dimension of the array.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SortingLines(array);
Console.WriteLine();
PrintArray(array);