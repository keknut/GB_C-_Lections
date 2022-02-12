// Найти расстояние между точками в пространстве 2D/3D

double distanceBetweenPoints(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double result = Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) + (Az - Bz) * (Az - Bz));
    return result;
}

Console.WriteLine("Space 2D or 3D? Enter 2D or 3D.");
string question = Console.ReadLine();
int Ax = 0;
int Ay = 0;
int Az = 0;

int Bx = 0;
int By = 0;
int Bz = 0;
if (question == "2D" || question == "2d")
{
    Console.Write("Input Ax: ");
    Ax = int.Parse(Console.ReadLine());
    Console.Write("Input Ay: ");
    Ay = int.Parse(Console.ReadLine());

    Console.Write("Input Bx: ");
    Bx = int.Parse(Console.ReadLine());
    Console.Write("Input By: ");
    By = int.Parse(Console.ReadLine());

    Console.WriteLine($"Distance between points: {distanceBetweenPoints(Ax, Ay, Az, Bx, By, Bz)}");
}
else if (question == "3D" || question == "3d")
{
    Console.Write("Input Ax: ");
    Ax = int.Parse(Console.ReadLine());
    Console.Write("Input Ay: ");
    Ay = int.Parse(Console.ReadLine());
    Console.Write("Input Az: ");
    Az = int.Parse(Console.ReadLine());

    Console.Write("Input Bx: ");
    Bx = int.Parse(Console.ReadLine());
    Console.Write("Input By: ");
    By = int.Parse(Console.ReadLine());
    Console.Write("Input Bz: ");
    Bz = int.Parse(Console.ReadLine());

    Console.WriteLine($"Distance between points: {distanceBetweenPoints(Ax, Ay, Az, Bx, By, Bz)}");
}
else
{
    Console.WriteLine("You entered a space out of range!");
}
