// Выяснить являются ли три числа сторонами треугольника

void TriangleInequality(int FirstNumber, int SecondNumber, int ThirdNumber){
    if(FirstNumber + SecondNumber > ThirdNumber 
        && FirstNumber + ThirdNumber > SecondNumber
        && SecondNumber + ThirdNumber > FirstNumber){
            Console.WriteLine($"Numbers {FirstNumber}, {SecondNumber} and {ThirdNumber} are the sides of the triangle.");
        } else{
            Console.WriteLine($"Numbers {FirstNumber}, {SecondNumber} and {ThirdNumber} are not sides of a triangle.");
        }
} 

Console.Write($"Input first number: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.Write($"Input second number: ");
int SecondNumber = int.Parse(Console.ReadLine());
Console.Write($"Input third number: ");
int ThirdNumber = int.Parse(Console.ReadLine());

TriangleInequality(FirstNumber, SecondNumber, ThirdNumber);