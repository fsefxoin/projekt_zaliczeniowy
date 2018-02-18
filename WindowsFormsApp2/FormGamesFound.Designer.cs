namespace WindowsFormsApp2
{
    partial class FormGamesFound
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvGamesFound = new System.Windows.Forms.ListView();
            this.chGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGameGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGamePlatforms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGameRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbGameName = new System.Windows.Forms.TextBox();
            this.btgSearchAgain = new System.Windows.Forms.Button();
            this.btnWybierz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvGamesFound);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki wyszukiwania IGDB";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lvGamesFound
            // 
            this.lvGamesFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGameName,
            this.chGameGenre,
            this.chGamePlatforms,
            this.chGameRating});
            this.lvGamesFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGamesFound.FullRowSelect = true;
            this.lvGamesFound.Location = new System.Drawing.Point(3, 18);
            this.lvGamesFound.MultiSelect = false;
            this.lvGamesFound.Name = "lvGamesFound";
            this.lvGamesFound.Size = new System.Drawing.Size(686, 327);
            this.lvGamesFound.TabIndex = 0;
            this.lvGamesFound.UseCompatibleStateImageBehavior = false;
            this.lvGamesFound.View = System.Windows.Forms.View.Details;
            this.lvGamesFound.SelectedIndexChanged += new System.EventHandler(this.lvGamesFound_SelectedIndexChanged);
            // 
            // chGameName
            // 
            this.chGameName.Text = "Tytuł";
            this.chGameName.Width = 208;
            // 
            // chGameGenre
            // 
            this.chGameGenre.Text = "Gatunek";
            this.chGameGenre.Width = 127;
            // 
            // chGamePlatforms
            // 
            this.chGamePlatforms.Text = "Platformy";
            this.chGamePlatforms.Width = 171;
            // 
            // chGameRating
            // 
            this.chGameRating.Text = "Ocena";
            this.chGameRating.Width = 138;
            // 
            // tbGameName
            // 
            this.tbGameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbGameName.Location = new System.Drawing.Point(15, 365);
            this.tbGameName.Name = "tbGameName";
            this.tbGameName.Size = new System.Drawing.Size(149, 22);
            this.tbGameName.TabIndex = 2;
            this.tbGameName.TextChanged += new System.EventHandler(this.tbGameName_TextChanged);
            // 
            // btgSearchAgain
            // 
            this.btgSearchAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btgSearchAgain.Location = new System.Drawing.Point(170, 361);
            this.btgSearchAgain.Name = "btgSearchAgain";
            this.btgSearchAgain.Size = new System.Drawing.Size(149, 30);
            this.btgSearchAgain.TabIndex = 3;
            this.btgSearchAgain.Text = "Wyszukaj ponownie";
            this.btgSearchAgain.UseVisualStyleBackColor = true;
            this.btgSearchAgain.Click += new System.EventHandler(this.btgSearchAgain_Click);
            // 
            // btnWybierz
            // 
            this.btnWybierz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWybierz.Location = new System.Drawing.Point(583, 362);
            this.btnWybierz.Name = "btnWybierz";
            this.btnWybierz.Size = new System.Drawing.Size(118, 30);
            this.btnWybierz.TabIndex = 4;
            this.btnWybierz.Text = "Wybierz";
            this.btnWybierz.UseVisualStyleBackColor = true;
            this.btnWybierz.Click += new System.EventHandler(this.btnWybierz_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(459, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGamesFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWybierz);
            this.Controls.Add(this.btgSearchAgain);
            this.Controls.Add(this.tbGameName);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGamesFound";
            this.Text = "FormGamesFound";
            this.Load += new System.EventHandler(this.FormGamesFound_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvGamesFound;
        private System.Windows.Forms.ColumnHeader chGameName;
        private System.Windows.Forms.ColumnHeader chGameGenre;
        private System.Windows.Forms.ColumnHeader chGamePlatforms;
        private System.Windows.Forms.ColumnHeader chGameRating;
        private System.Windows.Forms.TextBox tbGameName;
        private System.Windows.Forms.Button btgSearchAgain;
        private System.Windows.Forms.Button btnWybierz;
        private System.Windows.Forms.Button button1;
    }
}