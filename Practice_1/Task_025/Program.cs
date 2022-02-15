// Найти сумму чисел от 1 до А

int sum(int number) //
{
    int sum = 0;
    //sum = number * (number +1) / 2; //можно через формулу. Если вычислять через формулу при большом number, то времени будет затрачено меньше.
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Summ 1 to {number} = {sum(number)}");