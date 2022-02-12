// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("The number is divisible by 7 and 23");
else Console.WriteLine("The number is not divisible by 7 and 23");
