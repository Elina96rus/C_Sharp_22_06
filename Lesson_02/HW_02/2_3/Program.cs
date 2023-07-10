﻿//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void GetNumThree(int num){
    Console.WriteLine($"Введенное число: {num}");
    if(num < 100){
        Console.WriteLine("Третьего числа нет!");
        return;
    }

    while(num > 999){
        num /= 10;
    }
    Console.WriteLine($"Третья цифра: " + num % 10);
}

GetNumThree(int.Parse(Console.ReadLine()!));