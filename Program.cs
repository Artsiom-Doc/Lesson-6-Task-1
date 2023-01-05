/*Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.

M=5 ; 0, 7, 8, -2, -2 -> 2
M=5 ; -1, -7, 567, 89, 223 -> 3*/

Console.WriteLine("Количество вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа через пробел: ");
string[] str = Console.ReadLine().Split();

int sum = 0;
for(int i = 0; i < M; i++)
{
    if(int.Parse(str [i]) > 0)
    {
         sum += 1;
    }
}

Console.WriteLine("Количество введеных чисел больше 0 -> " + sum);
