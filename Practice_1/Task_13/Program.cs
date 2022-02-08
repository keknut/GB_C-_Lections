// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int numberDivider(int number, int divider)
{
    return number % divider;
}

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Inpunt divider: ");
int divider = int.Parse(Console.ReadLine());

if (numberDivider(number, divider) == 0) Console.WriteLine("Yes");
else Console.WriteLine("No, remainder of the division: " + numberDivider(number, divider));
