// Найти третью цифру числа или сообщить, что её нет

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
string s = number.ToString();
if (s.Length > 2) Console.WriteLine("Third digit in number: " + s[2]);
else Console.WriteLine("There is no third digit in the given number");