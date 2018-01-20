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
            if(!string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                g = new Game();
                g.Name = textBox1.Text;
                g.Summary = rtbOpis.Text;
                g.Genre = txbGatunek.Text;
                try
                {
                    g.Rating = Convert.ToDecimal(txbOcena.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    g = null;
                    return;
                }
                this.Close();
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
