int age = 20;
if (age >= 21)
{
    Console.WriteLine("Доступ разрешен");
}
Console.WriteLine("Программа продолжает работу");




int age = 15;
if (age >= 18)
{
    Console.WriteLine("Доступ разрешен");
}
else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия {18 - age}лет");
}




int age = 14;
if (age < 13)
{
    Console.WriteLine("Ребенок");
}else if (age < 18)
{
    Console.WriteLine("Подросток");
}else if (age <60)
{
    Console.WriteLine("Взрослый");
}else
{
    Console.WriteLine("Пенсионер");
}




int age = 16;
double height = 1.55;
bool check = true;
if (age >= 14 && height >= 1.5)
{
    Console.WriteLine("Можно кататься");
} else if (age>=14 && check)
{
    Console.WriteLine("Можно кататься при сопровождении взрослого");
}else
{
    Console.WriteLine("Пока нельзя");
}
