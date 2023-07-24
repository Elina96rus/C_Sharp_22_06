// Напишите программу, которая принимает на вход число N и выдает таблицу кубов от 1 до N

void Square (int n){
    double[] num = new double[n];
    int index = 0;
    Console.Write($"{n} --> ");

    while (index < n){
        num[index] = Math.Pow((index + 1), 3);
        Console.Write($"{num[index]}, ");
        index += 1;
    }
    Console.WriteLine();
}
Square(int.Parse(Console.ReadLine()!));