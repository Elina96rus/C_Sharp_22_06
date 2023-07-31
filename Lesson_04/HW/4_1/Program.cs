// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень B

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);

double PowNum(int A, int B){
    double n_pow = 1;
    int b_abs = Math.Abs(B);

    for (int i = 1; i <= b_abs; i++)
    {
        if (B > 0)
           n_pow *= A;
        else
           n_pow /= A;
    }
    return n_pow;
}

Console.WriteLine("введите цифру А: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите цифру В: ");
int num_2 = int.Parse(Console.ReadLine()!); 
Console.WriteLine(PowNum(num_1, num_2));