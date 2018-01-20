namespace WindowsFormsApp2
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbOcena = new System.Windows.Forms.TextBox();
            this.lblOcena = new System.Windows.Forms.Label();
            this.txbGatunek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.GroupBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.gbTytul = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDdodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lblOpis.SuspendLayout();
            this.gbTytul.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.gbTytul);
            this.gbDetails.Controls.Add(this.groupBox1);
            this.gbDetails.Controls.Add(this.lblOpis);
            this.gbDetails.Location = new System.Drawing.Point(12, 8);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(424, 278);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Dane gry";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbOcena);
            this.groupBox1.Controls.Add(this.lblOcena);
            this.groupBox1.Controls.Add(this.txbGatunek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane dodatkowe";
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
            // txbGatunek
            // 
            this.txbGatunek.Location = new System.Drawing.Point(64, 16);
            this.txbGatunek.Name = "txbGatunek";
            this.txbGatunek.Size = new System.Drawing.Size(102, 20);
            this.txbGatunek.TabIndex = 1;
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
            // lblOpis
            // 
            this.lblOpis.Controls.Add(this.rtbOpis);
            this.lblOpis.Location = new System.Drawing.Point(6, 65);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(412, 158);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.TabStop = false;
            this.lblOpis.Text = "Opis gry";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOpis.Location = new System.Drawing.Point(3, 16);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(406, 139);
            this.rtbOpis.TabIndex = 0;
            this.rtbOpis.Text = "";
            // 
            // gbTytul
            // 
            this.gbTytul.Controls.Add(this.textBox1);
            this.gbTytul.Location = new System.Drawing.Point(6, 19);
            this.gbTytul.Name = "gbTytul";
            this.gbTytul.Size = new System.Drawing.Size(412, 40);
            this.gbTytul.TabIndex = 3;
            this.gbTytul.TabStop = false;
            this.gbTytul.Text = "Tytuł";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnDdodaj
            // 
            this.btnDdodaj.Location = new System.Drawing.Point(355, 292);
            this.btnDdodaj.Name = "btnDdodaj";
            this.btnDdodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDdodaj.TabIndex = 3;
            this.btnDdodaj.Text = "Dodaj";
            this.btnDdodaj.UseVisualStyleBackColor = true;
            this.btnDdodaj.Click += new System.EventHandler(this.btnDdodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(268, 292);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 4;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 321);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDdodaj);
            this.Controls.Add(this.gbDetails);
            this.Name = "FormAdd";
            this.Text = "Dodaj grę";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.gbDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblOpis.ResumeLayout(false);
            this.gbTytul.ResumeLayout(false);
            this.gbTytul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.GroupBox gbTytul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbOcena;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.TextBox txbGatunek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox lblOpis;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Button btnDdodaj;
        private System.Windows.Forms.Button btnAnuluj;
    }
}