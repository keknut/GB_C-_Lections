// Показать четные числа от 1 до N

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

int count = 2;
if(number < 2) Console.WriteLine("No even numbers");

while(count <= number){
    Console.Write(count + " ");
    count = count + 2;
}