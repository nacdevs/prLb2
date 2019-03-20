using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;
            int max=0;
            int min = 0;
            int count = 0;
            int suma = 0;
            while (i < 5) {
                if(int.TryParse(Console.ReadLine().ToString(),out n)){
                    if (n > max){
                        max = n;
                    }

                    if (min == 0){
                        min = n;
                    }
                    else if(n<min){
                        min = n;
                    }
                    count++;
                    suma = n + suma;
                    i++;
                }

                
            }


            Console.WriteLine("Maximo: " + max + "\n");
            Console.WriteLine("Minimo: " + min + "\n");
            Console.WriteLine("Promedio: " + (suma / count));
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("--- POW ---");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Ingrese un numero mayor a cero: ");

            int a = 0;
            double p2=0;
            double p3=0;
            int.TryParse(Console.ReadLine(), out a);
            if(a!=0 && a > 0)
            {
                p2=Math.Pow(a, 2);
                p3=Math.Pow(a, 3);
            }
            Console.WriteLine("Al 2: " +p2);
            Console.WriteLine("Al 3: " +p3);
            System.Threading.Thread.Sleep(2000);



            Console.WriteLine("--- NUMERO PERFECTO ---");

            int j = 0;
           
            int p = 0;
            int[] numeros = new int[5];
            //int.TryParse(Console.ReadLine(), out j);
            
            for(int y=0; y<2000; y++)
            {
                int sumador = 0;
                if (y != 0)
                {
                    for(int k = 1; k <= y; k++)
                    {
                        if (sumador == y)
                        {
                           Console.WriteLine(y + "\n");
                           break;

                        }
                        if (y % k== 0)
                        {
                            sumador = k + sumador;
                        }

                      
                    }
                }
            }





            /*for (int k = 0; k < 4; k++)
            {
                if (k != 0)
                {
                   int sumador = 0;
                    while (sumador == p)
                    {
                        if ((sumador%p)==0)
                        {
                            sumador++;
                        }

                        if (sumador == p)
                        {
                            Console.WriteLine(sumador + "\n");
                            break;
                     
                        }
                        p++;
                    }           
                    
                    
                }
                
            }*/

            
            System.Threading.Thread.Sleep(15000);



        }
    }
}
