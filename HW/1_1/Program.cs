// Напишите программу, которая принимает на вход три числа
// и выдает максимальное из них

Console.WriteLine("Введите ваши числa");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
if(a > b&&a > c){
    Console.Write("Максимальное число " + $"{a}" );
}
if(b > a&&b > c){
    Console.Write("Максимальное число " + $"{b} ");
}
if(c > a&&c > b){
    Console.Write("Максимальное число " + $"{c} ");
}
else if(c==a&&c==b){
    Console.Write("Числа равны");
}