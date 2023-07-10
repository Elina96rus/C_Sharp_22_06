﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет , является ли этот день выходным.

void GetDayWeek(int num){
    int[] numbers = {1, 2, 3, 4, 5, 6, 7};
    Console.WriteLine($"Введенное число: {num}");
    if(numbers.Contains(num)){
        if (num == 6 || num == 7){
            Console.WriteLine($"{num} -> Выходной");
        }else{
            Console.WriteLine($"{num} -> Рабочий");
        }
    }else{
        Console.WriteLine($"{num} -> Это не день недели");
    }

}

GetDayWeek(int.Parse(Console.ReadLine()!));