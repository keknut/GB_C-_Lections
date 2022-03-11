// Показать кубы чисел, заканчивающихся на четную цифру
/*Возможно имеллось в виду вывести кубы чисел от 1 до N заканчивающихся на четные цифры.
*/

void cubesEvenNumbers(int number)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i}^3: {i*i*i}");
        }
    }
}

Console.Write("Input N: ");
int n = int.Parse(Console.ReadLine());

cubesEvenNumbers(n);