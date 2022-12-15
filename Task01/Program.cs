﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int SIZE = 4;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 1000;

int[] array = new int[SIZE];

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0 ; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int EvenNumbers(int[] arr)
{
    int count = 0;
    for(int i = 0 ; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
int count = EvenNumbers(array);
Console.WriteLine($"[{string.Join(", ", array)}] -> {count}");