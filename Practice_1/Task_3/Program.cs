// По заданному номеру дня недели вывести его название

Console.Write("Input day of the week number: "); //выводит на консоль сообщение о вводе дня недели
int dayNumber = int.Parse(Console.ReadLine());
if(dayNumber == 1){
    Console.Write("Monday");
}
if(dayNumber == 2){
    Console.Write("Tuesday");
}
if(dayNumber == 3){
    Console.Write("Wednesday");
}
if(dayNumber == 4){
    Console.Write("Thursday");
}
if(dayNumber == 5){
    Console.Write("Friday");
}
if(dayNumber == 6){
    Console.Write("Saturday");
}
if(dayNumber == 7){
    Console.Write("Sunday");
}
if(dayNumber < 0 || dayNumber > 7){
    Console.WriteLine("Number day of week out of range");
}