// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

void wherePoint(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Point in the first quarter (I)");
    if (x < 0 && y > 0) Console.WriteLine("Point in the second quarter (II)");
    if (x < 0 && y < 0) Console.WriteLine("Point in the third quarter (III)");
    if (x > 0 && y < 0) Console.WriteLine("Point in the fourth quarter (IV)");
    if (x==0 || y == 0) Console.WriteLine("X or Y equal zero. Quarter is impossible to determine.");
}

Console.Write("Input X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Input Y: ");
int y = int.Parse(Console.ReadLine());

wherePoint(x, y);