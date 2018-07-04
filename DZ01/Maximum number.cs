using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число");
        int max = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число");
        int b = Int32.Parse(Console.ReadLine());
        if(max<a){	
            max += a; 
	        a = max - a; 
	        max -= a;
	        if(max<b){
		        max += b; 
		        b = max - b; 
		        max -= b;
	}
}
        else{
	       if(max<b){
                max += b; 
		        b = max - b; 
		        max -= b;
	}	
}  
        Console.WriteLine("Найбольшее число - " + max);   
    }
}