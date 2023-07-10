// Напишите программу, которая выводит случайное число из открезка [10,99]
// и показывает наибольшую цифру числа
//78->8

int  Max (int num){
    if (num/10 > num %10 )
    return num/10;
    return num % 10;
}
int RNum = new Random().Next (10,100);
Console.WriteLine("" + RNum);
int result = Max(RNum);
Console.WriteLine("" + result);