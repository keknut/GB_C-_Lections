// Написать программу вычисления произведения чисел от 1 до N

int factorial(int number) //Вариант через цикл
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

int factorialAlternative(int number) //альтернативный вариант через рекурсию. Здесь функция вызывает сама себя,
{ // при этом уменьшая заданное число при каждом вызове на единицу.
    if (number == 1) //на этом условии мы выходим из рекурсии
    {
        return 1;
    }
    return number * factorialAlternative(number - 1);
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Factorial {number} = {factorialAlternative(number)}");
