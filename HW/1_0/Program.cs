// Напишите программу, которая на вход принимает два числа и выдает,
// какое число больше, а какое число меньше

Console.WriteLine("Введите ваши числa");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if(a > b){
    Console.Write("Максимальное число " + $"{a}" + ". Минимальное число, " + $"{b} ");
}
if(b > a){
    Console.Write("Максимальное число " + $"{b} " + ". Минимальное число " + $"{a} ");
}
else if(b==a){
    Console.Write("Числа равны");
}