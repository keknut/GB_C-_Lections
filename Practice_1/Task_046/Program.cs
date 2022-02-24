//  Написать программу масштабирования фигуры
/*  Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком
    (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)"
    коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
    В результате показать координаты, которые получатся.
    при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/

double[] ArrayParseStringToInt(string[] coordinatesString){
    double[] coordinatesDouble = new double[coordinatesString.Length];
    for (int i = 0; i < coordinatesString.Length; i++)
    {
        coordinatesDouble[i] = double.Parse(coordinatesString[i]);
    }
    return coordinatesDouble;
}

void ScalingArray(double[] array, double k){
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * k;
    }
}

void PrintNewCoordinates(double[] array) //метод выводит массив в консоль
{
    for (int i = 0; i < array.Length; i+=2)
    {
        Console.Write($"({array[i]},{array[i+1]}) ");
    }
    Console.WriteLine();
}

Console.Write("Input coordinates: ");
string[] coordinates = Console.ReadLine().Replace("(", "").Replace(",", " ").Replace(")", "").Split(" ");
double[] coordinatesDouble = ArrayParseStringToInt(coordinates);
Console.Write("Input scaling factor: ");
double k  = double.Parse(Console.ReadLine());
ScalingArray(coordinatesDouble, k);
PrintNewCoordinates(coordinatesDouble);