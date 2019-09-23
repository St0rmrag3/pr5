using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            for (double i = 1; i<=20; i++)
              {
                 
                 Console.Write(Convert.ToString(i)+"\t"+i*2.54+"\n");
              }


            //2

             for (int i1 = 2; i1 <= 100; i1++)
               {
                 if (i1 % 2 == 0)
               {
                   Console.WriteLine(i1);
              }
             }

            //3

              int b = 0;
             for (int i2 = 1; i2 <= 99; i2++)
             {
                 if (i2 % 2 != 0)
                {
                  b = b + i2;     
                } 
              }
             Console.WriteLine(b);

            //4
             int b2 = int.Parse(Console.ReadLine());
            for (int i3 =1; i3<=b2; i3++)
             {
              if (b2 % i3 == 0)
              {
                 Console.Write(b2 / i3+" ");
             }
             }

            //5

            int a = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
             int nod = 0;    
             for (int i = 1; i<c; i++)
            {
               if (a%i==0 && c % i == 0)
                 {
                     nod = i;
                }

              }
             Console.WriteLine(nod);

            //7

            double n = double.Parse(Console.ReadLine());
            double b3 = 0;
            for (double i4 = 1; i4 <= n; i4++)
             {if (i4%2==0)
                {
                     b3 = b3 + Math.Pow(i4, 2);
                 }

              }
              Console.WriteLine(b3);

            //8 

            int b4 = 1;
            for (int i5 = 2; i5 <= 1024; i5 = i5+i5)
            {
                b4 = b4 + i5;
             }
             Console.WriteLine(b4);

           //9

             int h = 3;
             long g = 3;


               for (int i7 = 3; i7 <= 10; i7++)
              {
                h += i7;g *= h;
             }
             Console.WriteLine(g);

            //10
        
               double n1 = double.Parse(Console.ReadLine());
              double m1 = (double.Parse(Console.ReadLine()))*60;
             double k = m1;
             double l = 0;
              for(int i6 = 1; i6<=n1; i6++)
             {
                   l = l + k;
                   k = k + 10;


              }
             Console.WriteLine((l/60));



            //11

             int r = 0;
              int co = 0;
              for (int q = 0; q<10; q++)
             {
                for (int j = 0; j<10; j++)
                {
                for (int k1 = 0; k1<10; k1++)
                   {
              if (q+j+k1 == 13)
                       {
                         r = r + 1;
                           co = r*r;
                           
                      }   
                    }
                }

                }
             Console.WriteLine(co);

            //13

            double n3 = int.Parse(Console.ReadLine());
             double avr = 0;
             double o = 0;
             double b9 = 0;
             for (int i8 =0; i8 < n3; i8++)
             {
                b9 = double.Parse(Console.ReadLine());
                o = o + b9;
                avr = o/ n3;
             }
              Console.WriteLine(avr);

            //14

              int a8 = int.Parse(Console.ReadLine());
             int n4 = int.Parse(Console.ReadLine());
             int pr = 1;
             for (int i = 1; i <=n4; i++)
               {
                 pr = pr * a8;
             }
             Console.WriteLine(pr);

            //15

            int a1 = int.Parse(Console.ReadLine());
           int p = int.Parse(Console.ReadLine());
            int sum = 0;
             for (int i = 1; i <= p; i++)
             {
                sum = sum + a1;
            }
             Console.WriteLine(sum);

            //16

           double n5 = double.Parse(Console.ReadLine());
            double sum1 = 1;
             for (double i = 2  ; i <= n5; i++)
            {
               sum1 = sum1 + (1 / i);
                
             }
             Console.WriteLine(sum1);

            //17 
            int min = int.Parse(Console.ReadLine());
            int kol = 1;
            int sch = 1;
            for (int i = 1; i <= min; i++)
            {
                kol = kol * 2;
                sch = sch + kol;    
            }
            Console.WriteLine(sch);

        }
    }
}
