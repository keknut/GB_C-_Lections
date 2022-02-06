// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Input number 1: "); //выводит на экран "введите первое число"
int number_1 = int.Parse(Console.ReadLine()); //Считывает в консоли число и присваивает его переменной number_1
Console.Write("Input number 2: "); //выводит на экран "введите второе число"
int number_2 = int.Parse(Console.ReadLine()); //Считывает в консоли число и присваивает его переменной number_2
if (number_1 == number_2 * number_2){ //если квадрат второго числа, равен первому, то выводим "да"
    Console.WriteLine("Yes!");
}else{ //иначе выводим "нет"
    Console.WriteLine("No(");
}
