// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool truthTable(bool x, bool y)
{
    if (!(x || y) == (!x && !y))
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("X | Y | F(X,Y)");
Console.WriteLine("----------------");
bool x = false;
bool y = false;
byte F = 0;
//Console.WriteLine($"X:{x} | Y:{y} | F(x,y): {truthTable(x,y)}");

for (byte i = 0; i < 2; i++)
{
    if (i == 0)
    {
        x = false;
    }
    else
    {
        x = true;
    }
    for (byte j = 0; j < 2; j++)
    {
        if (j == 0)
        {
            y = false;
        }
        else
        {
            y = true;
        }
        if (truthTable(x, y))
        {
            F = 1;
        }
        else
        {
            F = 0;
        }
        Console.WriteLine($"{i} | {j} | {F}");
    }
}
