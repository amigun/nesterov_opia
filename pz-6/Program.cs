/*
    Задание:
        Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи оно является, то есть выведите
        такое число n, что φn=A. Если А не является числом Фибоначчи, выведите число -1.
        входные данные 8
        выходные данные 6
    Последовательность чисел Фибоначчи:
        1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
    Тестовые данные:
        1   -> 1
        2   -> 3
        3   -> 4
        5   -> 5
        8   -> 6
        13  -> 7
        21  -> 8
        34  -> 9
        55  -> 10
        89  -> 11
        144 -> 12
        14  -> -1
        64  -> -1
        228 -> -1
 */
 
 int a = Convert.ToInt32(Console.ReadLine());
 
 int number_1 = 1, number_2 = 1, counter = 2, sum;

 while (true)
 {
     if (a == 1)
     {
         Console.WriteLine(1);
         break;
     }
     
     sum = number_1 + number_2;
     number_1 = number_2;
     number_2 = sum;

     counter++;
     
     if (a == number_2)
     {
         Console.WriteLine(counter);
         break;
     }
     else if (a < number_2)
     {
         Console.WriteLine(-1);
         break;
     }
 }