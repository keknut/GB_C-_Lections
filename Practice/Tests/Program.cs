void FillArray(int[] array) //метод заполняет массив случайными числами [0; 10]
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
            array[i] = k;
            k++;
    }
}

void PrintArray(int[] array) //метод выводит массив в консоль.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            Console.Write($"{array[i]} ");
    }
}

void SortingLines(int[] array)
{
    // Перебираем каждый элемент массива (кроме последнего, он уже будет отсортирован к тому времени, когда мы до него доберемся)
    int tmp = 0;
    int maxIndex = 0;
    int startIndex = 0;
    int currentIndex = 0;
        for (startIndex = 0; startIndex < array.GetLength(0) - 1; startIndex++)
        {
            // В переменной maxIndex хранится индекс наименьшего значения, которое мы нашли в этой итерации.
            // Начинаем с того, что наименьший элемент в этой итерации - это первый элемент (индекс 0)
            maxIndex = startIndex;

            // Затем ищем элемент поменьше в остальной части массива
            for (currentIndex = startIndex + 1; currentIndex < array.GetLength(0); currentIndex++)
            {
                // Если мы нашли элемент, который меньше нашего наименьшего элемента,
                if (array[currentIndex] > array[maxIndex])
                    // то запоминаем его
                    maxIndex = currentIndex;
            }
            // maxIndex теперь наименьший элемент.
            // Меняем местами наше начальное наименьшее число с тем, которое мы обнаружили
            tmp = array[startIndex];
            array[startIndex] = array[maxIndex];
            array[maxIndex] = tmp;
        }
}

Console.WriteLine("Enter the dimension of the array.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
int[] array = new int[m];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SortingLines(array);
PrintArray(array);