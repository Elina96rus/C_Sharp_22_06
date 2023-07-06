// Напишите программу, которая на вход принимает число N, 
// а на выходе показывает все четные сичла от 1 до N

Console.WriteLine("Введите ваше число");
int N = int.Parse(Console.ReadLine()!);
int b = 2;
while(b <= N){
    if ((b % 2) == 0)
    Console.Write($"{b} ");
    b ++;
}
