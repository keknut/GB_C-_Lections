// Найти максимальное из трех чисел

Console.Write("Input first number: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Input second number: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Input third number: ");
int number_3 = int.Parse(Console.ReadLine());

int max = number_1;
if(number_2 > max){
    max = number_2;
}
if(number_3 > max){
    max = number_3;
}
if(number_1 == number_2 && number_1 == number_3){ //если числа равны, то выводит сообщение
    Console.WriteLine("The numbers are equal!");
}
Console.WriteLine("Max: " + max);