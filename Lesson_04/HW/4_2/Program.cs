// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumN(int num){
    int n_sum = 0;
    while(num > 0){
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}
Console.WriteLine("введите число ");
int Num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumN(Num_1));