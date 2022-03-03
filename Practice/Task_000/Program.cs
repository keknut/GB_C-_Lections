// Вывести квадрат числа

//int number = new Random().Next(1, 10); //присваивает переменной случайное число 1.. 10
Console.Write("Input number:");
int number = int.Parse(Console.ReadLine());
Console.Write("Квадрат вашего числа: " + number*number);