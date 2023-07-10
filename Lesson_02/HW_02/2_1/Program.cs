﻿//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

string GetSumNum(int num){
//     Console.WriteLine(num);
    if((-1000 < num && num < -99) || (num < 1000 && num > 99)){
       var numOne = $"{num / 100}"; 
       var numTwo = $"{num % 10}";
       string numOut =  string.Concat(numOne, numTwo);
       return numOut;
    }
    return "Число не трехзначное";
}

Console.WriteLine(GetSumNum(int.Parse(Console.ReadLine()!)));