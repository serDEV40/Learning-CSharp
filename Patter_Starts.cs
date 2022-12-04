// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for(var k = 1; k<3; k++){
            for(var x = 1; x < 10 ;x++){
                for(var y = 1; y < x ;y++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("");
            for(var i = 10; i >= 1; i--){
                for(var j = 1; j < i; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
