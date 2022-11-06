/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
namespace CA_9
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPalindrome(num));
            Console.ReadKey(true);
        }
        
        static bool IsPalindrome(int num)
        {
            if (num >= 0 && num <10)
                return true;
            int numLength = GetLength(num);
            int[] digits = new int[numLength];
            for (int i = numLength - 1; i >= 0; i--) {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength/2; i++) {
                if (digits[i] != digits[numLength - i - 1])
                    return false;
            }
            return true;
        }
        
        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0) {
                num /= 10;
                n++;
            }
            return n;
        }
    }
}
*/

/*
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*

      using System;
namespace Otrezok{ 
    class Program{
        
        static void Main(string[] args)
        {
           int x1=int.Parse(Console.ReadLine());
           int x2=int.Parse(Console.ReadLine());
           int x3=int.Parse(Console.ReadLine());
           int y1=int.Parse(Console.ReadLine());
           int y2=int.Parse(Console.ReadLine());
           int y3=int.Parse(Console.ReadLine());
           Function.Otr(x1,x2,x3, y1, y2, y3);
           Console.ReadLine();
         }
}
    
    class Function{
    public static void Otr(int x1, int x2, int x3, int y1, int y2, int y3){
              double c=Math.Sqrt(Math.Pow(y1-x1, 2)+Math.Pow(y2-x2, 2)+Math.Pow(y3-x3, 2));
            Console.WriteLine("Отрезок= " +c );                     }
        }
}
*/

/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;
 
class Program
{
 
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine("{0} = {1}", i, i*i*i);
        Console.ReadKey(true);
    }
}