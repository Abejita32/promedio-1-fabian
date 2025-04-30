using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               int papas=Int32.Parse(Console.ReadLine());
               int pollo=Int32.Parse(Console.ReadLine());
                
             jugador papa=new jugador(papas,pollo);
             int perro=Int32.Parse(Console.ReadLine());
                List<enemigo> lista = new List<enemigo>();

                for (int i = 0; i < papas; i++)
                {
                    
                  int zorro=Int32.Parse(Console.ReadLine());
                  int gato=Int32.Parse(Console.ReadLine());
                   enemigo yuca=new enemigo(gato,perro);
                    lista.Add(yuca);
                }


            }
        }
    }
}
