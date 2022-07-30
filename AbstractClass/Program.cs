using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MySpeed mySpeed = new MySpeed();
            int v = mySpeed.Speed(40,5);
            string answer = mySpeed.Answer(v.ToString());
            Console.WriteLine(answer);

            MyPower myPower = new MyPower();
            int F = myPower.Power(70, 6);
            string answer2 = myPower.Answer(F.ToString());
            Console.WriteLine(answer2);
          int[] arr = new int[] {3,10,1,4,2,15,7,9,5,6,8,18};
     
            Console.WriteLine(String.Join(" ",arr));
            int max = 0;
            int n=0;
            while (n < arr.Length)
            {
                for (int i = n; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        arr[i] = arr[n];
                        arr[n] = max;
                    }
                }
                max = 0;
                n++;
            }
           
            Console.WriteLine(String.Join(" ", arr));
            Console.Read();
        }
    }
}
