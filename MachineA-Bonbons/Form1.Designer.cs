
using System.Windows.Forms;
using System;

namespace Projet03
{
    partial class FrmPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {

            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtChoix = new System.Windows.Forms.TextBox();
            this.pictureBoxWM = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPercu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRemis = new System.Windows.Forms.Label();
            this.cmdAcheter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMonnaie = new System.Windows.Forms.TextBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblBonbon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.cmdVerifierStock = new System.Windows.Forms.Button();
            this.cmdRecommencer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(180, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(361, 33);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Machine à bonbons";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VOTRE CHOIX ?";
            // 
            // TxtChoix
            // 
            this.TxtChoix.Location = new System.Drawing.Point(148, 291);
            this.TxtChoix.Name = "TxtChoix";
            this.TxtChoix.Size = new System.Drawing.Size(80, 20);
            this.TxtChoix.TabIndex = 2;
            this.TxtChoix.TextChanged += new System.EventHandler(this.TxtChoix_TextChanged);
            // 
            // pictureBoxWM
            // 
            this.pictureBoxWM.Location = new System.Drawing.Point(403, 44);
            this.pictureBoxWM.Name = "pictureBoxWM";
            this.pictureBoxWM.Size = new System.Drawing.Size(385, 394);
            this.pictureBoxWM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxWM.TabIndex = 3;
            this.pictureBoxWM.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRIX";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(310, 156);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(21, 13);
            this.lblPrix.TabIndex = 5;
            this.lblPrix.Text = "0";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(310, 96);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(21, 13);
            this.lblSelection.TabIndex = 6;
            this.lblSelection.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "<-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PERÇU";
            // 
            // lblPercu
            // 
            this.lblPercu.AutoSize = true;
            this.lblPercu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercu.Location = new System.Drawing.Point(310, 216);
            this.lblPercu.Name = "lblPercu";
            this.lblPercu.Size = new System.Drawing.Size(21, 13);
            this.lblPercu.TabIndex = 10;
            this.lblPercu.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "REMIS";
            // 
            // lblRemis
            // 
            this.lblRemis.AutoSize = true;
            this.lblRemis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemis.Location = new System.Drawing.Point(310, 278);
            this.lblRemis.Name = "lblRemis";
            this.lblRemis.Size = new System.Drawing.Size(21, 13);
            this.lblRemis.TabIndex = 12;
            this.lblRemis.Text = "00";
            // 
            // cmdAcheter
            // 
            this.cmdAcheter.Location = new System.Drawing.Point(256, 376);
            this.cmdAcheter.Name = "cmdAcheter";
            this.cmdAcheter.Size = new System.Drawing.Size(95, 31);
            this.cmdAcheter.TabIndex = 13;
            this.cmdAcheter.Text = "Compléter achat";
            this.cmdAcheter.UseVisualStyleBackColor = true;
            this.cmdAcheter.Click += new System.EventHandler(this.cmdAcheter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "MONNAIE";
            // 
            // TxtMonnaie
            // 
            this.TxtMonnaie.Location = new System.Drawing.Point(148, 328);
            this.TxtMonnaie.Name = "TxtMonnaie";
            this.TxtMonnaie.Size = new System.Drawing.Size(80, 20);
            this.TxtMonnaie.TabIndex = 15;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(256, 337);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(95, 33);
            this.cmdAjouter.TabIndex = 16;
            this.cmdAjouter.Text = "Ajouter monnaie";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(41, 371);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(170, 16);
            this.lblMessage.TabIndex = 18;
            this.lblMessage.Text = "Prenez votre friandise...";
            // 
            // lblBonbon
            // 
            this.lblBonbon.AutoSize = true;
            this.lblBonbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonbon.Location = new System.Drawing.Point(41, 404);
            this.lblBonbon.Name = "lblBonbon";
            this.lblBonbon.Size = new System.Drawing.Size(127, 16);
            this.lblBonbon.TabIndex = 19;
            this.lblBonbon.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "1    ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(183, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(230, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(94, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(138, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "8";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(183, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "9";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(230, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(41, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(223, 16);
            this.label18.TabIndex = 30;
            this.label18.Text = "___________________________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(41, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(223, 16);
            this.label19.TabIndex = 31;
            this.label19.Text = "___________________________";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(41, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(223, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "___________________________";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(230, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 16);
            this.label21.TabIndex = 36;
            this.label21.Text = "15";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(183, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 16);
            this.label22.TabIndex = 35;
            this.label22.Text = "14";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(138, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 16);
            this.label23.TabIndex = 34;
            this.label23.Text = "13";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(94, 176);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 16);
            this.label24.TabIndex = 33;
            this.label24.Text = "12";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(53, 176);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 16);
            this.label25.TabIndex = 32;
            this.label25.Text = "11";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(41, 194);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(223, 16);
            this.label26.TabIndex = 43;
            this.label26.Text = "___________________________";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(230, 210);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 16);
            this.label27.TabIndex = 42;
            this.label27.Text = "20";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(183, 210);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 16);
            this.label28.TabIndex = 41;
            this.label28.Text = "19";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(138, 210);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 16);
            this.label29.TabIndex = 40;
            this.label29.Text = "18";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(94, 210);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 16);
            this.label30.TabIndex = 39;
            this.label30.Text = "17";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(53, 210);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 16);
            this.label31.TabIndex = 38;
            this.label31.Text = "16";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(41, 226);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(223, 16);
            this.label32.TabIndex = 49;
            this.label32.Text = "___________________________";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(230, 242);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 16);
            this.label33.TabIndex = 48;
            this.label33.Text = "25";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(183, 242);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 16);
            this.label34.TabIndex = 47;
            this.label34.Text = "24";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(138, 242);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(23, 16);
            this.label35.TabIndex = 46;
            this.label35.Text = "23";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(94, 242);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 16);
            this.label36.TabIndex = 45;
            this.label36.Text = "22";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(53, 242);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 16);
            this.label37.TabIndex = 44;
            this.label37.Text = "21";
            // 
            // cmdVerifierStock
            // 
            this.cmdVerifierStock.Location = new System.Drawing.Point(256, 299);
            this.cmdVerifierStock.Name = "cmdVerifierStock";
            this.cmdVerifierStock.Size = new System.Drawing.Size(95, 32);
            this.cmdVerifierStock.TabIndex = 50;
            this.cmdVerifierStock.Text = "Vérifier stock";
            this.cmdVerifierStock.UseVisualStyleBackColor = true;
            this.cmdVerifierStock.Click += new System.EventHandler(this.cmdVerifierStock_Click);

            // 
            // cmdRecommencer
            // 
            this.cmdRecommencer.Location = new System.Drawing.Point(106, 67);
            this.cmdRecommencer.Name = "cmdRecommencer";
            this.cmdRecommencer.Size = new System.Drawing.Size(93, 26);
            this.cmdRecommencer.TabIndex = 51;
            this.cmdRecommencer.Text = "Recommencer";
            this.cmdRecommencer.UseVisualStyleBackColor = true;
            this.cmdRecommencer.Click += new System.EventHandler(this.cmdRecommencer_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(256, 412);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(94, 25);
            this.cmdQuitter.TabIndex = 52;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdRecommencer);
            this.Controls.Add(this.cmdVerifierStock);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBonbon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.TxtMonnaie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdAcheter);
            this.Controls.Add(this.lblRemis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPercu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxWM);
            this.Controls.Add(this.TxtChoix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmPrincipale";
            this.Text = "Machine à bonbons";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;

        private System.Windows.Forms.TextBox TxtChoix;//champs de saisie de la selection de l'utilisateur (1 à 25)
        private System.Windows.Forms.PictureBox pictureBoxWM;//cadre d'affichage de l'image du bonbon affiché après la finalisation de l'achat
        private System.Windows.Forms.Label lblPrix;//label d'affichage du prix du bonbon séléctionné
        private System.Windows.Forms.Label lblSelection;//label d'affichage du choix de bonbon selectionné
        private System.Windows.Forms.Label lblPercu;//label d'affichage de la monnaie perçue
        private System.Windows.Forms.Label lblRemis;//label d'affichage de la monnaie remise
        private System.Windows.Forms.Button cmdAcheter;//bouton Acheter bonbon
        private System.Windows.Forms.TextBox TxtMonnaie;//champs de saisie de la monnaie:5c, 10c, 25c, 1$, 2 $
        private System.Windows.Forms.Button cmdAjouter;//bouton Ajouter monnaie
        private System.Windows.Forms.Label lblMessage;//label d'affichage du message 'Prenez votre friandise'
        private System.Windows.Forms.Label lblBonbon; //label d'affichage du nom de bonbon à la fin d'achat

        //autres labels d'affichage
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button cmdVerifierStock;
        private System.Windows.Forms.Button cmdRecommencer;
        private System.Windows.Forms.Button cmdQuitter;
        private decimal monnaiePercue;

    }

}


