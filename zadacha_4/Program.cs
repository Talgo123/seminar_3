﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4

void FindSquareNumber(int number)
{
    int count = 1;
    while (count < number + 1)
    {
        int result = count * count;
        Console.Write($"{result} ");
        count++;
    }     
}

int EnterPointCoordinate(string str)
{
    Console.Write(str);
    int number1 = int.Parse(Console.ReadLine());
    return number1;
}

int digit = EnterPointCoordinate("Введите цифру: ");
FindSquareNumber(digit);
