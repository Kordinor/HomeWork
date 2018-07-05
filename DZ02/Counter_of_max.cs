using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        string a = Console.ReadLine();
        int counter = 1; int b = a[0] - '0';
        for(int i = 1; i<a.Length; i++){
            if(a[i] - '0' > b){
                b = a[i] - '0';
                counter = 1;
            }
            else{
                if(a[i] - '0' == b){
                    counter++;
                }
            }
        }
        Console.WriteLine(b + " - найбольшее число, встречается  " + counter + " раз");
    }
}