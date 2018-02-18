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
            this.gbTytul = new System.Windows.Forms.GroupBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.gbDodatkowe = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txbOcena = new System.Windows.Forms.TextBox();
            this.lblOcena = new System.Windows.Forms.Label();
            this.txbGatunek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOpis = new System.Windows.Forms.GroupBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.btnDdodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbDetails.SuspendLayout();
            this.gbTytul.SuspendLayout();
            this.gbDodatkowe.SuspendLayout();
            this.gbOpis.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.Controls.Add(this.checkBox1);
            this.gbDetails.Controls.Add(this.groupBox2);
            this.gbDetails.Controls.Add(this.gbTytul);
            this.gbDetails.Controls.Add(this.gbDodatkowe);
            this.gbDetails.Controls.Add(this.gbOpis);
            this.gbDetails.Location = new System.Drawing.Point(13, 10);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetails.Size = new System.Drawing.Size(643, 510);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Dane gry";
            this.gbDetails.Enter += new System.EventHandler(this.gbDetails_Enter);
            // 
            // gbTytul
            // 
            this.gbTytul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTytul.Controls.Add(this.tbTitle);
            this.gbTytul.Enabled = false;
            this.gbTytul.Location = new System.Drawing.Point(8, 95);
            this.gbTytul.Margin = new System.Windows.Forms.Padding(4);
            this.gbTytul.Name = "gbTytul";
            this.gbTytul.Padding = new System.Windows.Forms.Padding(4);
            this.gbTytul.Size = new System.Drawing.Size(620, 49);
            this.gbTytul.TabIndex = 3;
            this.gbTytul.TabStop = false;
            this.gbTytul.Text = "Tytuł";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(9, 17);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(603, 22);
            this.tbTitle.TabIndex = 0;
            // 
            // gbDodatkowe
            // 
            this.gbDodatkowe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDodatkowe.Controls.Add(this.label2);
            this.gbDodatkowe.Controls.Add(this.dateTimePicker2);
            this.gbDodatkowe.Controls.Add(this.txbOcena);
            this.gbDodatkowe.Controls.Add(this.lblOcena);
            this.gbDodatkowe.Controls.Add(this.txbGatunek);
            this.gbDodatkowe.Controls.Add(this.label1);
            this.gbDodatkowe.Enabled = false;
            this.gbDodatkowe.Location = new System.Drawing.Point(8, 388);
            this.gbDodatkowe.Margin = new System.Windows.Forms.Padding(4);
            this.gbDodatkowe.Name = "gbDodatkowe";
            this.gbDodatkowe.Padding = new System.Windows.Forms.Padding(4);
            this.gbDodatkowe.Size = new System.Drawing.Size(620, 114);
            this.gbDodatkowe.TabIndex = 2;
            this.gbDodatkowe.TabStop = false;
            this.gbDodatkowe.Text = "Dane dodatkowe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data wydania:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // txbOcena
            // 
            this.txbOcena.Location = new System.Drawing.Point(272, 20);
            this.txbOcena.Margin = new System.Windows.Forms.Padding(4);
            this.txbOcena.Name = "txbOcena";
            this.txbOcena.Size = new System.Drawing.Size(135, 22);
            this.txbOcena.TabIndex = 3;
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(210, 23);
            this.lblOcena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(54, 17);
            this.lblOcena.TabIndex = 2;
            this.lblOcena.Text = "Ocena:";
            // 
            // txbGatunek
            // 
            this.txbGatunek.Location = new System.Drawing.Point(83, 20);
            this.txbGatunek.Margin = new System.Windows.Forms.Padding(4);
            this.txbGatunek.Name = "txbGatunek";
            this.txbGatunek.Size = new System.Drawing.Size(110, 22);
            this.txbGatunek.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gatunek:";
            // 
            // gbOpis
            // 
            this.gbOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOpis.Controls.Add(this.rtbOpis);
            this.gbOpis.Enabled = false;
            this.gbOpis.Location = new System.Drawing.Point(8, 148);
            this.gbOpis.Margin = new System.Windows.Forms.Padding(4);
            this.gbOpis.Name = "gbOpis";
            this.gbOpis.Padding = new System.Windows.Forms.Padding(4);
            this.gbOpis.Size = new System.Drawing.Size(620, 232);
            this.gbOpis.TabIndex = 1;
            this.gbOpis.TabStop = false;
            this.gbOpis.Text = "Opis gry";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOpis.Location = new System.Drawing.Point(4, 19);
            this.rtbOpis.Margin = new System.Windows.Forms.Padding(4);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(612, 209);
            this.rtbOpis.TabIndex = 0;
            this.rtbOpis.Text = "";
            // 
            // btnDdodaj
            // 
            this.btnDdodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDdodaj.Location = new System.Drawing.Point(551, 528);
            this.btnDdodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDdodaj.Name = "btnDdodaj";
            this.btnDdodaj.Size = new System.Drawing.Size(100, 34);
            this.btnDdodaj.TabIndex = 3;
            this.btnDdodaj.Text = "Dodaj";
            this.btnDdodaj.UseVisualStyleBackColor = true;
            this.btnDdodaj.Click += new System.EventHandler(this.btnDdodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(435, 528);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 34);
            this.btnAnuluj.TabIndex = 4;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(620, 49);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukuj w IGDB.com";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(481, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Wypełnij ręcznie";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 570);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDdodaj);
            this.Controls.Add(this.gbDetails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdd";
            this.Text = "Dodaj grę";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbTytul.ResumeLayout(false);
            this.gbTytul.PerformLayout();
            this.gbDodatkowe.ResumeLayout(false);
            this.gbDodatkowe.PerformLayout();
            this.gbOpis.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.GroupBox gbTytul;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox gbDodatkowe;
        private System.Windows.Forms.TextBox txbOcena;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.TextBox txbGatunek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOpis;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Button btnDdodaj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}