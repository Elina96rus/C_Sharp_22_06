// Напишите программу , которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0 )
{
Console.WriteLine("1");
}
else if ( a > 0 )
{
while (Math.Pow(count,2) <= a)
{
Console.WriteLine(Math.Pow(count, 2));
count++;
}
}
else if ( a < 0 )
{
while (Math.Pow(count,2) >= a )
{
Console.WriteLine(Math.Pow(count, 2));
count--;
}

}