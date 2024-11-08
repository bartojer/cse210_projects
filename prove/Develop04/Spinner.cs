using System;
using System.Threading;

class Spinner{
    
    public void Spin(int spinTime){
        
        int i = 0;
        while(i < spinTime){
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b");
            i++;
        }
    }
}