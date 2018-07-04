using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        string a = Console.ReadLine();
        int sum = 0;
        int product = 1;
        for(int i=0; i<a.Length; i++){
            sum += a[i] - '0';
            product *= a[i] - '0';
        }
        Console.WriteLine("Сумма цифр данного числа = " + sum);
        Console.WriteLine("Произведение цифр данного числа = " + product);
    }
}