namespace WindowsFormsApp2
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbGames = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvGames = new System.Windows.Forms.ListView();
            this.chGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGameGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGamePlatforms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGameRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.pnTytul = new System.Windows.Forms.Panel();
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.GroupBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbGatunek = new System.Windows.Forms.TextBox();
            this.txbOcena = new System.Windows.Forms.TextBox();
            this.lblOcena = new System.Windows.Forms.Label();
            this.gbGames.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.pnTytul.SuspendLayout();
            this.lblOpis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGames
            // 
            this.gbGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGames.Controls.Add(this.button2);
            this.gbGames.Controls.Add(this.button1);
            this.gbGames.Controls.Add(this.lvGames);
            this.gbGames.Location = new System.Drawing.Point(437, 12);
            this.gbGames.Name = "gbGames";
            this.gbGames.Size = new System.Drawing.Size(303, 323);
            this.gbGames.TabIndex = 0;
            this.gbGames.TabStop = false;
            this.gbGames.Text = "Moje gry";
            this.gbGames.Enter += new System.EventHandler(this.gbGames_Enter);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(140, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(222, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvGames
            // 
            this.lvGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGameName,
            this.chGameGenre,
            this.chGamePlatforms,
            this.chGameRating});
            this.lvGames.Location = new System.Drawing.Point(6, 19);
            this.lvGames.Name = "lvGames";
            this.lvGames.Size = new System.Drawing.Size(291, 251);
            this.lvGames.TabIndex = 0;
            this.lvGames.UseCompatibleStateImageBehavior = false;
            this.lvGames.View = System.Windows.Forms.View.Details;
            this.lvGames.SelectedIndexChanged += new System.EventHandler(this.lvGames_SelectedIndexChanged);
            // 
            // chGameName
            // 
            this.chGameName.Text = "Nazwa gry";
            // 
            // chGameGenre
            // 
            this.chGameGenre.Text = "Gatunek";
            // 
            // chGamePlatforms
            // 
            this.chGamePlatforms.Text = "Platformy";
            // 
            // chGameRating
            // 
            this.chGameRating.Text = "Ocena";
            this.chGameRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbDetails.Controls.Add(this.groupBox1);
            this.gbDetails.Controls.Add(this.lblOpis);
            this.gbDetails.Controls.Add(this.pnTytul);
            this.gbDetails.Location = new System.Drawing.Point(8, 12);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(424, 312);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Szczegóły";
            // 
            // pnTytul
            // 
            this.pnTytul.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnTytul.Controls.Add(this.lblTytul);
            this.pnTytul.Location = new System.Drawing.Point(6, 19);
            this.pnTytul.Name = "pnTytul";
            this.pnTytul.Size = new System.Drawing.Size(412, 34);
            this.pnTytul.TabIndex = 0;
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.Location = new System.Drawing.Point(3, 5);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(60, 24);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "label1";
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpis.Controls.Add(this.rtbOpis);
            this.lblOpis.Location = new System.Drawing.Point(6, 59);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(412, 182);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.TabStop = false;
            this.lblOpis.Text = "Opis gry";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOpis.Location = new System.Drawing.Point(3, 16);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(406, 163);
            this.rtbOpis.TabIndex = 0;
            this.rtbOpis.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txbOcena);
            this.groupBox1.Controls.Add(this.lblOcena);
            this.groupBox1.Controls.Add(this.txbGatunek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane dodatkowe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gatunek:";
            // 
            // txbGatunek
            // 
            this.txbGatunek.Location = new System.Drawing.Point(64, 16);
            this.txbGatunek.Name = "txbGatunek";
            this.txbGatunek.Size = new System.Drawing.Size(102, 20);
            this.txbGatunek.TabIndex = 1;
            // 
            // txbOcena
            // 
            this.txbOcena.Location = new System.Drawing.Point(223, 16);
            this.txbOcena.Name = "txbOcena";
            this.txbOcena.Size = new System.Drawing.Size(102, 20);
            this.txbOcena.TabIndex = 3;
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(175, 19);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(42, 13);
            this.lblOcena.TabIndex = 2;
            this.lblOcena.Text = "Ocena:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 335);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbGames);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbGames.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.pnTytul.ResumeLayout(false);
            this.pnTytul.PerformLayout();
            this.lblOpis.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGames;
        private System.Windows.Forms.ListView lvGames;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader chGameName;
        private System.Windows.Forms.ColumnHeader chGameGenre;
        private System.Windows.Forms.ColumnHeader chGamePlatforms;
        private System.Windows.Forms.ColumnHeader chGameRating;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.GroupBox lblOpis;
        private System.Windows.Forms.Panel pnTytul;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbOcena;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.TextBox txbGatunek;
        private System.Windows.Forms.Label label1;
    }
}

