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
    public partial class FormGamesFound : Form
    {
        static List<Game> GamesList = new List<Game>();
        static Dictionary<ListViewItem, Game> LvGamesPair = new Dictionary<ListViewItem, Game>();
        public FormGamesFound()
        {
            InitializeComponent();
        }
        public FormGamesFound(List<Game> gList)
        {
            InitializeComponent();
            GamesList = gList;
        }
        public Game Game = null;
        private void FormGamesFound_Load(object sender, EventArgs e)
        {
            LoadgameLV();
            this.MinimumSize = this.Size;
            lvGamesFound.MouseDoubleClick += this.btnWybierz_Click;
        }
        void LoadgameLV()

        {
            foreach (Game g in GamesList)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { g.name, g.GetGenresString(), "", Math.Round(g.rating, 2).ToString() });
                lvGamesFound.Items.Add(lvItem);
                LvGamesPair.Add(lvItem, g);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lvGamesFound_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btgSearchAgain_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbGameName.Text))
            {
                GamesList = IGDB.GetGames(tbGameName.Text);
                if(GamesList.Count>0)
                {
                    lvGamesFound.Items.Clear();
                    LvGamesPair.Clear();
                    LoadgameLV();
                }
            }          
        }

        private void tbGameName_TextChanged(object sender, EventArgs e)
        {
            btgSearchAgain.Enabled = (string.IsNullOrWhiteSpace(tbGameName.Text)) ? false : true;
        }

        private void btnWybierz_Click(object sender, EventArgs e)
        {
            IEnumerable<ListViewItem> lviList = lvGamesFound.SelectedItems.Cast<ListViewItem>();
            if (lviList.Count() == 0)
                return;
            ListViewItem lvItem = lviList.FirstOrDefault();
            this.Game = LvGamesPair[lvItem];
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game = null;
            this.Close();
        }
    }
}
