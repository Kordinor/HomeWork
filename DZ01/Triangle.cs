using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первую сторону");
        int max = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите третью сторону");
        int b = Int32.Parse(Console.ReadLine());
        
        if(max>0 && a>0 && b>0){
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
     if(max<(a+b)){
	        Console.WriteLine("Это треугольник");
}
    else{
	        Console.WriteLine("Не является треугольником");
}  
        }
        else{
            Console.WriteLine("Невозможные значения длин сторон");
        }
        
    }
}