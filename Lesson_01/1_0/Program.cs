// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя).
// Например
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Write a number: ");
string num_str = Console.ReadLine()!;
int num = int.Parse(num_str);
Console.WriteLine(num * num);