using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Article_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article b = new Article();
            Console.WriteLine("Articolele din baza de date sunt:");
            b.view();
            Console.WriteLine("Articolele publicate de Solomon Marcus sunt:");
            b.Autor("Solomon Marcus");
            Console.WriteLine("Articolele publicate intre 2000 si 2019 sunt:");
            b.IntervalTimp(new DateTime(2000, 12, 12), new DateTime(2019, 3, 1));
            Console.WriteLine("Articolele publicate in ordine cronologica sunt:");
            b.OrdineCronologica();
            Console.WriteLine("Articolele publicate in ordine dupa numarul de likes sunt:");
            b.OrdineLikes();
            Console.WriteLine("Articolele publicate in ordine dupa numarul de dislikes sunt:");
            b.OrdineDisikes();
            Console.WriteLine("Numarul articolelor publicate intre 1970 si 2022 este:");
            b.NumarArticole(new DateTime(1970, 1, 1), new DateTime(2022, 1, 1));
            b.NumarArticole("Cristian Tudor Popescu");
        }
    }
}
