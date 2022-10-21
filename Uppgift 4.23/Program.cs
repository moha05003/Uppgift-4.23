using System;
namespace Uppgift_4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriva in ett heltal");
            string tal = Console.ReadLine();
            int störst = int.Parse(tal);
            
            string svar = "";
            while ( svar != "n") 
            {
                Console.WriteLine("vill du skriva  ett heltal till eller inte?j/n");
                svar = Console.ReadLine();
                if ( svar == "n")
                {
                    break;
                }
                   
                    Console.WriteLine("skriva in ett heltal");
                string tal2 = Console.ReadLine();
                int nytal = int.Parse(tal2);
                if ( nytal > störst)
                {
                    störst = nytal;
                }


            }
            Console.WriteLine("Det är största tal du skriva in var " +  störst);




        }
    }
}