// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void PrintNumber(int N, int number)
{

    if(number > N)
    {
        return;
    }
    PrintNumber(N, number+1);
    Console.Write(number + " ");
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
PrintNumber(N, number);
