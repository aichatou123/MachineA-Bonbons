using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet03
{
    static class Program
    {
        /*=====> NOTRE TABLEAU DES DONNÉES BONBONS : variable globale que vous pouvez utiliser dans tous les fichiers de code <=====*/
        public static String[] candiesName;
        public static decimal[] candiesPrice;
        public static int[] candiesStock;
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            //chargement des données des bonbon du fichier candies.data
            candiesName = Data.LoadCandiesName();
            candiesPrice = Data.LoadCandiesPrice();
            candiesStock = Data.LoadCandiesStock();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipale());
        }
        public static string GetCandyName(int selection)
        {
            return candiesName[selection - 1];
        }
        public static decimal GetCandyPrice(int selection)
        {
            return candiesPrice[selection - 1];
        }
        public static int GetCandyStock(int selection)
        {
            return candiesStock[selection - 1];
        }

        internal static object GetCandy_X(int v)
        {
            throw new NotImplementedException();
        }
    }
}
