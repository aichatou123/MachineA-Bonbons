using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Projet03
{
    class Data
    {
        //fonction de chargement des données bonbons à partir du fichier candies.data : output => 3 tableau
        // tableau string[] des noms des bonbons
        //tableau decimal[] des prix des bonbons
        //tableau int[] des stock des bonbons
        public static String[] LoadCandiesName()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            const String file  = "candies.data";
            const char DELIMITER = '|';
            String[] candiesName = new String[0];
            String line;
            StreamReader note = new StreamReader(@"C:\Users\toure\candiess.txt");
            while ((line = note.ReadLine()) != null)
            {
                String name = line.Split(DELIMITER)[1];
                 candiesName = AddCandyName(candiesName, name);

            }

            note.Close();
            return candiesName;

        }
        public static decimal[] LoadCandiesPrice()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            const String liste = "candies.data";
            const char DELIMITER = '|';
            decimal[] candiesPrice = new decimal[0];
            String line;
            StreamReader note = new StreamReader(@"C:\Users\toure\candiess.txt");        
            while ((line = note.ReadLine()) != null)
            {
             
                decimal price = Convert.ToDecimal(line.Split(DELIMITER)[2]);
                decimal newCandyPrice = price;
                candiesPrice = AddCandyPrice(candiesPrice, newCandyPrice);

            }

            note.Close();
            return candiesPrice;

        }
        public static int[] LoadCandiesStock()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            const String file = "candies.data";
            const char DELIMITER = '|';
            int[] candiesStock = new int[0];
            String line;
            StreamReader liste = new StreamReader(@"C:\Users\toure\candiess.txt");
            while ((line = liste.ReadLine()) != null)
            {
                
                int stock = int.Parse(line.Split(DELIMITER)[3]);
                int newCandyStock = stock;
                candiesStock = AddCandyStock(candiesStock, newCandyStock);

            }

            liste.Close();
            return candiesStock;

        }
        private static String[] AddCandyName(String[] candiesName, String candyName)
        {
            String[] newCandiesName = new String[candiesName.Length + 1];
            for (int i = 0; i < candiesName.Length; i++)
            {
                newCandiesName[i] = candiesName[i];
            }
            newCandiesName[candiesName.Length] = candyName;
            return newCandiesName;
        }
        private static decimal[] AddCandyPrice(decimal[] candiesPrice, decimal candyPrice)
        {
            decimal[] newCandiesPrice = new decimal[candiesPrice.Length + 1];
            for (int i = 0; i < candiesPrice.Length; i++)
            {
                newCandiesPrice[i] = candiesPrice[i];
            }
            newCandiesPrice[candiesPrice.Length] = candyPrice;
            return newCandiesPrice;
        }
        private static int[] AddCandyStock(int[] candiesStock, int candyStock)
        {
            int[] newCandiesStock = new int[candiesStock.Length + 1];
            for (int i = 0; i < candiesStock.Length; i++)
            {
                newCandiesStock[i] = candiesStock[i];
            }
            newCandiesStock[candiesStock.Length] = candyStock;
            return newCandiesStock;
        }
    }
}
