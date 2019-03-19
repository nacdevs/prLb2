using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int miEntero;
        static string miPalabra;
        static bool miBoolean;

        static void Main(string[] args) {

            Double aaa = 235.535;
            String menu = "A.Opcion a \nB.Opcion b \nC.Opcion c";

            miPalabra = "I named the big one Cuca";
            for (int i = 0; i < 250; i++)
            {
                Console.WriteLine(miPalabra + i);
                Console.WriteLine(menu);
                //System.Threading.Thread.Sleep(2000);                
                //ConsoleKeyInfo cki = Console.ReadKey();
                miPalabra = Console.ReadLine();                
                myMethod(miPalabra, i);



            }
            try {//EXPLOTA

            } catch (Exception e) {
                Console.Write(e.StackTrace);
            }


        }



        static void myMethod(string i, int j)
        {
            
            switch (i)
            {  
                case "A":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "5":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.White;

                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                     Console.BackgroundColor = ConsoleColor.Black;
                    break;


            }
            if (i.Equals("5"))
            {
                Console.Clear();
                Console.Write("───────────────────────────────────────\n" +
                                "───▐▀▄───────▄▀▌───▄▄▄▄▄▄▄─────────────\n" +
                                "───▌▒▒▀▄▄▄▄▄▀▒▒▐▄▀▀▒██▒██▒▀▀▄──────────\n" +
                                "──▐▒▒▒▒▀▒▀▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄────────\n" +
                                "──▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▒▒▒▒▒▒▒▒▒▒▒▒▀▄──────\n" +
                                "▀█▒▒▒█▌▒▒█▒▒▐█▒▒▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌─────\n" +
                                "▀▌▒▒▒▒▒▒▀▒▀▒▒▒▒▒▒▀▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐───▄▄\n" +
                                "▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌▄█▒█\n" +
                                "▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒█▀─\n" +
                                "▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀───\n" +
                                "▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌────\n" +
                                "─▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐─────\n");                
            }
            if (i.Equals("6"))
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("         , ,\\ ,'\\,'\\ ,'\\ ,\\ ,\n"+
                               "    ,  ;\\/ \' `'     `   '  /|\n" +
                                   "|\\/                      |\n" +
                                   ":                        |\n" +
                                   ":                        |\n" +
                                    "|                       |\n" +
                                    "|                       |\n" +
                                    ":               -._ |\n"+
                                     ":                     `.\n" +
                                     "| ________:______\n" +
                                     ":       ,'o       / o    ;\n" +
                                     ":       -       ,'-----./\n" +
                                      "_      `--.--'        )\n" +
                                     ",` `.              ,---'|\n" +
                                     ": `                     |\n" +
                                      "`,-'                   |\n" +
                                      "/      ,---.          ,'\n" +
                                   ",-'            `-,------'\n" +
                                  "'   `.        ,--'\n" +
                                        "`-.____ /\n" );
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Eligio la letra:\n" + i);
            }
         
        }
    }
}
