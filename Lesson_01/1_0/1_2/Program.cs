// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Напишите программу, которая будет выдавать название дня недели по заданному номеру

string a = Console.ReadLine()!;
switch (a){
    case "1":
    Console.Write("Пн");
    break;
    case "2":
    Console.Write("Вт");
    break;
    case "3":
    Console.Write("Ср");
    break;
    case "4":
    Console.Write("Чт");
    break;
    case "5":
    Console.Write("Пт");
    break;
    case "6":
    Console.Write("Сб");
    break;
    case "7":
    Console.Write("Вс");
    break;
    default:
    Console.Write("Такого дня недели нет");
    break;
}