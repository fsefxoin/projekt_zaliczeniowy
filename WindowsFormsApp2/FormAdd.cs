using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAdd : Form
    {
        public Game g;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnDdodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.tbTitle.Text))
            {
                g = new Game();
                g.name = tbTitle.Text;
                g.summary = rtbOpis.Text;
                g.genre = txbGatunek.Text;
                try
                {
                    g.rating = Convert.ToDecimal(txbOcena.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    g = null;
                    return;
                }
                this.Close();
            }
            else
                MessageBox.Show("Należy uzupelnić przynajmniej tytuł!");
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            TopMost = false;
            this.MinimumSize = this.Size;
            this.button1.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                List<Game> games = IGDB.GetGames(textBox1.Text);
                if (games.Count > 1)
                {
                    FormGamesFound form = new FormGamesFound(games);
                    form.ShowDialog();
                    g = form.Game;
                    form.Dispose();
                }
                txbGatunek.Text = g.GetGenresString();
                txbOcena.Text = Math.Round(g.rating,2).ToString();
                tbTitle.Text = g.name;
                rtbOpis.Text = g.summary;
            }

        }

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gbDodatkowe.Enabled = checkBox1.Checked;
            gbOpis.Enabled = checkBox1.Checked;
            gbTytul.Enabled = checkBox1.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = (String.IsNullOrWhiteSpace(textBox1.Text)) ? false : true;
        }


    }
}
