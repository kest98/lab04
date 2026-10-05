// using System.Data.Common;

// int age = 20;
// if (age >= 21)
// {
//     Console.WriteLine("Доступ разрешен");
// }
// Console.WriteLine("Программа продолжает работу");




// int age = 15;
// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешен");
// }
// else
// {
//     Console.WriteLine("Доступ запрещён");
//     Console.WriteLine($"До совершеннолетия {18 - age}лет");
// }




// int age = 14;
// if (age < 13)
// {
//     Console.WriteLine("Ребенок");
// }else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// }else if (age <60)
// {
//     Console.WriteLine("Взрослый");
// }else
// {
//     Console.WriteLine("Пенсионер");
// }




// int age = 16;
// double height = 1.55;
// bool check = true;
// if (age >= 14 && height >= 1.5)
// {
//     Console.WriteLine("Можно кататься");
// } else if (age>=14 && check)
// {
//     Console.WriteLine("Можно кататься при сопровождении взрослого");
// }else
// {
//     Console.WriteLine("Пока нельзя");
// }




// //Сам. задания
// //А
// int number = int.Parse(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Четное");
// }
// else
// {
//     Console.WriteLine("Нечетное");
// }
// //Б
// int numbers = int.Parse(Console.ReadLine());
// switch (numbers)
// {
//     case 5:
//         Console.WriteLine("Отлично");
//         break;
//     case 4:
//         Console.WriteLine("Хорошо");
//         break;
//     case 3:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case 2:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     default:
//         Console.WriteLine("Другое");
//         break;
// }




Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");



//Вариант 6
int numbr = int.Parse(Console.ReadLine());
if (numbr < 60)
{
    Console.WriteLine("Неудовлетворительно");
}
else if (numbr < 75)
{
    Console.WriteLine("Удовлетворительно");
}
else if (numbr < 90)
{
    Console.WriteLine("Хорошо");
}
else if (numbr <= 100)
{
    Console.WriteLine("Отлично");
}
else
{
    Console.WriteLine("Другое");
}
