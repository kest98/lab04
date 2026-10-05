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
}else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия {18 - age}лет");
}
