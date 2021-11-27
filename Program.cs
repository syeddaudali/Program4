using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        { 
            //execute each block seperately
            int x = 20;
            int y = 35;
            x=y++ + x++;
            y= ++y + ++x;
            Console.WriteLine("value = {0} {1}" , x,y); 

            int x=10,y=15;
            x=x++;
            y=++y;
            Console.WriteLine("value = {0} {1}" , x,y); 

            
            int a=10;
            a++;
            Console.WriteLine("value = " + a); 
            
            int n=10;
            int x=0;
            x = n--;
            Console.WriteLine("value = "+ x); 

            int i=5,j=6,k=7,n=3;
            Console.WriteLine(i+j*k-k%n);
            Console.WriteLine(i/n);

            int n;
            float x =3.8f;
            n = (int)x;
            Console.WriteLine("n = " + n);

            int a = 6;
            Console.WriteLine(a); 
            a=a+3;
            Console.WriteLine(a); 
            a-=5;
            Console.WriteLine(a); 
            a++;
            Console.WriteLine(a); 
        }
    }
}