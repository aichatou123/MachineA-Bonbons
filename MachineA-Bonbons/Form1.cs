using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet03
{
    public partial class FrmPrincipale : Form
    {
        //on récupère ici le bonbon que l'utilisateur a séléctionné une fois la selection est valide.
        private static string Nom_bonbonChoisi;
        private static decimal Prix_bonbonChoisi;
        private static int Stock_bonbonChoisi;
        private decimal MonnaiePercue = 0;
        public FrmPrincipale()
        {
            InitializeComponent();
            ResetMachine();
            //initialisation des textbox
        }
        private void ResetMachine()
        {
            TxtChoix.Text = "";
            TxtMonnaie.Text = "";
            lblSelection.Text = "";
            lblBonbon.Text = "";
            lblPercu.Text = "0";
            lblRemis.Text = "0";
            //on désactive les composants mentionnés dans les étapes (voir énoncé)
            //exemple
            cmdAjouter.Enabled = false;
            lblMessage.Visible = false;
            //...
            cmdAcheter.Enabled = false;
            cmdRecommencer.Enabled = false;
            TxtMonnaie.Enabled = false;

        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            ResetMachine();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TxtMonnaie.Text, out decimal monnaieAjoutee) &&
                (monnaieAjoutee == 0.05m || monnaieAjoutee == 0.1m || monnaieAjoutee == 0.25m || monnaieAjoutee == 1 || monnaieAjoutee == 2))
            {
                MonnaiePercue += monnaieAjoutee;
                lblPercu.Text = MonnaiePercue.ToString("C");
                TxtMonnaie.Text = "";
            }
            else
            {
                MessageBox.Show("Monnaie invalide. Ajoutez seulement 5c, 10c, 25c, 1$ ou 2$", "Erreur");
            }
        }
        

        private void cmdAcheter_Click(object sender, EventArgs e)
        {
            if (MonnaiePercue >= Prix_bonbonChoisi)
            {
                decimal monnaieRendue = MonnaiePercue - Prix_bonbonChoisi;
                lblRemis.Text = monnaieRendue.ToString("C");
                lblBonbon.Text = Nom_bonbonChoisi.ToUpper();
                lblMessage.Text = "Prenez votre friandise";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Visible = true;
                MonnaiePercue = 0;

                MessageBox.Show($"Vous avez acheté un {Nom_bonbonChoisi}. Monnaie rendue : {monnaieRendue:C}", "Achat réussi");
            }
            else
            {
                MessageBox.Show("Fonds insuffisants. Ajoutez plus de monnaie.", "Erreur");
            }
        }
        

        private void TxtChoix_TextChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "";
        }
        //bouton vérifier stock: fonction de vérification de la selection puis le stock
        private void cmdVerifierStock_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtChoix.Text, out int selection) || selection < 1 || selection > 25)
            {
                MessageBox.Show("selection du bonbon invalide, il faut choisir de 1 à 25","Erreur");
                return;
            }
            Nom_bonbonChoisi = Program.GetCandyName(selection);
            Prix_bonbonChoisi = Program.GetCandyPrice(selection);
            Stock_bonbonChoisi = Program.GetCandyStock(selection);

            if (Stock_bonbonChoisi <= 0)
            {
                MessageBox.Show("Ce bonbon est en rupture de stock", "Stock épuisé");
            }

            else
            {
                lblSelection.Text = Nom_bonbonChoisi;
                lblPrix.Text = Prix_bonbonChoisi.ToString("C");

                // Enable components
                cmdAjouter.Enabled = true;
                cmdAcheter.Enabled = true;
                cmdRecommencer.Enabled = true;
                TxtMonnaie.Enabled = true;
                //on vérifie si le bonbon choisi est en stock, sinon on affiche un MessageBox
                //...
                //si oui, on active les autres composants (voir énoncé)
            }


        }

        private void cmdRecommencer_Click(object sender, EventArgs e)
        {
            if (MonnaiePercue > 0)
            {
                MessageBox.Show($"Monnaie rendue: {MonnaiePercue:C}", "Remise de monnaie");
            }
            MonnaiePercue = 0;
            ResetMachine();
            //remettre la machine à zéro
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter la machine à bonbon?",
                          "Message de confirmation",
                          MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
