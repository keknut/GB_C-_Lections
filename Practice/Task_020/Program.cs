// Задать номер четверти, показать диапазоны для возможных координат

void coordinateRanges(byte quarterNumber)
{
    if (quarterNumber == 1)
    {
        Console.WriteLine("X>0, Y>0");
    }
    if (quarterNumber == 2)
    {
        Console.WriteLine("X<0, Y>0");
    }
    if (quarterNumber == 3)
    {
        Console.WriteLine("X<0, Y<0");
    }
    if (quarterNumber == 4)
    {
        Console.WriteLine("X>0, Y<0");
    }
    if (quarterNumber < 1 || quarterNumber > 4)
    {
        Console.WriteLine("The quarter number must be between 1 and 4!");
    }
}

Console.Write("Enter the quarter number: ");
byte quarterNumber = byte.Parse(Console.ReadLine());

coordinateRanges(quarterNumber);