using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Article_List
{
    public class Article
    {
        string autor, titlu;
        DateTime data_publicatiei, data_modificarii;
        int likes, dislikes;
        public Article()
        {
        }
        public Article(string titlu, string autor, DateTime data_publicatiei, DateTime data_modificarii, int likes, int dislikes)
        {
            this.autor = autor;
            this.titlu = titlu;
            this.data_publicatiei = data_publicatiei;
            this.data_modificarii = data_modificarii;
            this.likes = likes;
            this.dislikes = dislikes;
        }
        static List<Article> load()
        {
            List<Article> toR = new List<Article>();
            DateTime p1 = new DateTime(1971, 10, 28);
            DateTime m1 = new DateTime(2010, 5, 1);
            DateTime p2 = new DateTime(2012, 12, 12);
            DateTime m2 = new DateTime(2022, 2, 14);
            DateTime p3 = new DateTime(2015, 2, 22);
            DateTime m3 = new DateTime(2020, 5, 9);
            DateTime p4 = new DateTime(1980, 1, 23);
            DateTime m4 = new DateTime(2000, 5, 10);
            DateTime p5 = new DateTime(2002, 12, 1);
            DateTime m5 = new DateTime(2007, 12, 1);
            DateTime p6 = new DateTime(1992, 4, 13);
            DateTime m6 = new DateTime(2018, 5, 19);
            Article A = new Article("Analiza Matematica", "Solomon Marcus", p1, m1, 1234, 89);
            Article B = new Article("Politica", "Cristian Tudor Popescu", p2, m2, 433, 37);
            Article C = new Article("Football Today", "Martin Taylor and Alan Smith", p3, m3, 19852, 3);
            Article D = new Article("Mate", "Solomon Marcus", p4, m4, 198, 3);
            Article E = new Article("Romania", "Cristian Tudor Popescu", p5, m5, 777, 30);
            Article F = new Article("Champions League", "Martin Taylor and Alan Smith", p6, m6, 12346, 2);
            toR.Add(A);
            toR.Add(B);
            toR.Add(C);
            toR.Add(D);
            toR.Add(E);
            toR.Add(F);
            return toR;
        }
        public void view()
        {
            List<Article> a = load();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].show(0));
            }
            Console.WriteLine();
        }
        public void Autor(string autor)
        {
            List<Article> a = load();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].autor == autor)
                    Console.WriteLine(a[i].show(0));
            }
            Console.WriteLine();
        }
        public void IntervalTimp(DateTime data1, DateTime data2)
        {
            List<Article> a = load();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].data_publicatiei >= data1 && a[i].data_publicatiei <= data2)
                    Console.WriteLine(a[i].show(0));
            }
            Console.WriteLine();
        }
        public void OrdineCronologica()
        {
            List<Article> a = load();
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                    if (a[i].data_publicatiei > a[j].data_publicatiei)
                    {
                        Article aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
            }
            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i].show(0));
            Console.WriteLine();
        }
        public void OrdineLikes()
        {
            List<Article> a = load();
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                    if (a[i].likes > a[j].likes)
                    {
                        Article aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
            }
            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i].show(0));
            Console.WriteLine();
        }
        public void OrdineDisikes()
        {
            List<Article> a = load();
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                    if (a[i].dislikes > a[j].dislikes)
                    {
                        Article aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
            }
            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i].show(0));
            Console.WriteLine();
        }
        public void NumarArticole(DateTime data1, DateTime data2)
        {
            int k = 0;
            List<Article> a = load();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].data_publicatiei >= data1 && a[i].data_publicatiei <= data2)
                    k++;
            }
            Console.WriteLine(k);
        }
        public void NumarArticole(string autor)
        {
            int k = 0;
            List<Article> a = load();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].autor == autor)
                    k++;
            }
            Console.WriteLine($"{autor} a publicat {k} articole");
        }
        public string show(int p)
        {
            switch (p)
            {
                case 0:
                    return (titlu + ", " + autor + ", " + data_publicatiei + ", " + data_modificarii + ", " + likes + ", " + dislikes);
                case 1:
                    return "Autor: " + autor;
                case 2:
                    return "Titlu: " + titlu;
                case 3:
                    return "Data publicatiei: " + Convert.ToString(data_publicatiei);
                case 4:
                    return "Data ultimei modificari: " + Convert.ToString(data_modificarii);
                case 5:
                    return "Likes: " + Convert.ToString(likes);
                case 6:
                    return "Dislikes:" + Convert.ToString(dislikes);
                default:
                    return "ERROR";
            }
        }
    }
}