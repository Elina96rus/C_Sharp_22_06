// Напишите программу, которая на хвод принимет одно число
//  а на выходе показывает все целые числа в прмоежутке от -N до N

int a = int.Parse(Console.ReadLine()!);
int count = -a;
Console.WriteLine(count);
while (count!=a){
    if (a>0)
    count++;
    else
    count--;  
    Console.WriteLine(count);
}    