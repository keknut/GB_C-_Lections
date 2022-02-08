// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

bool weekend(int numberDayOfWeek){
    if(numberDayOfWeek == 6 || numberDayOfWeek == 7) return true; //если день недели 6-ой или 7-ой (суббота или воскресенье), возвращает true
    else return false; //иначе false
}

Console.Write("Input day of the week: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());

if(weekend(numberDayOfWeek)) Console.WriteLine("Yes"); //обращение к методу weekend. Если true, то пишет Yes
else Console.WriteLine("No"); //если false, то пишет No
