// Напишите программу, которая принимает на вход трехзначное число и 
// На выходе показывает вторую цифрц этого числа

string GetNum(int num){
    if((-1000 < num && num < -100) || (num < 1000 && num > 100)){
        return $"{num / 10 % 10}";
    }
    return "Число не трехзначное";
}
Console.WriteLine("Введите ваше число: ");
Console.WriteLine(GetNum(int.Parse(Console.ReadLine()!)));