// Выяснить является ли число чётным

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0) Console.WriteLine("Number is even");
else Console.WriteLine("Number is odd");