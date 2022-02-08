// Показать вторую цифру трёхзначного числа

Console.Write("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("The second digit in the number: " + number / 10 % 10);