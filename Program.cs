using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int[] Bavarian = new int[] { 5, 7, 2, 7, 5, 4, 9, 3, 1, 5 };
            int[] Scandinavian = new int[] { 3, 5, 8, 2, 8, 2, 5, 9, 2, 6 };
            int quantityBav = 0, quantityScand = 0;
            for (int i = 0; i < Bavarian.Length&&i<Scandinavian.Length; i++)
            {
                if (Bavarian[i] == 5)
                {
                    quantityBav++;
                }
                if (Scandinavian[i] == 5)
                {
                    quantityScand++;
                }
            }
            if (quantityBav == quantityScand)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
            Console.WriteLine("Задание 2");
            string alphabet = @"64list";
            IEnumerable<string> img = Directory.EnumerateFiles(alphabet, "*.jpeg");
            List<string> images = img.ToList();
            foreach (string title in images)
            {
                Console.WriteLine(title);
            }
            Random rnd = new Random();
                for (int i = images.Count - 1; i >= 1; i--)
                {
                    int j = rnd.Next(i + 1);

                string tmp = images[j];
                images[j] = images[i];
                images[i] = tmp;
                }
            Console.WriteLine("\nПеремешанный список:");
            foreach (string titles in images)
            {
                Console.WriteLine(titles);
            }
        }
    }
}

