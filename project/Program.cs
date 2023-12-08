// Напишите функцию, которая заполняет список случайными числами в диапазоне, указанном пользователем.
// Функция принимает начало диапазона и его конец, и возвращает целочисленный массив.
// С помощью специальной формы цикла for выведете элементы получившегося массив в одну строку, с пробелами;

using System;
using System.Collections.Generic;
class work_1_4
{
    static void Main()
    {
        Console.Write("Введите начало диапазона: "); 
        int x = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Введите конец диапазона: "); 
        int y = Convert.ToInt32(Console.ReadLine()); 
        
        int[] array = new int[10]; 
        Random rand = new Random(); 
        
        Console.Write("Массив: "); 
        for (int i = 0; i < 10; i++)
        {
            array[i] = rand.Next(x, y); 
        }
        var str = string.Join(" ", array); 
        Console.WriteLine(str); 
    }
}
