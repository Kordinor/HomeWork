using System;

class Program
{
    static void Main()
    {   
        Console.WriteLine("Введите ваш балл от 1 до 100");
        int a = Int32.Parse(Console.ReadLine());
        int counter = -1;
        bool action = false;
        string[] A ={"A", "B", "C", "D"};
        if(a>-1 && a<101){
            for(int i=95; i>=50; i-=15){
                i+=5*counter;
                if(a>=i){
                    Console.WriteLine(A[counter+1]);
                    action = true;
                    break;
        }
                counter++;
    }
            if(!action){
                Console.WriteLine("E");
    }
        }
        else{
            Console.WriteLine("Балл не находится в диапазоне возможных для данного теста");
        }
    }
}