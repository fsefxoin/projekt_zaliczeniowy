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
    public partial class FormMain : Form
    {
        private string path = "gamesList.xml";
        public FormMain()
        {
            InitializeComponent();
        }
        static List<Game> GamesList = new List<Game>();
        static Dictionary<ListViewItem,Game> LvGamesPair = new Dictionary<ListViewItem, Game>();


        private void FormMain_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            //for (int i = 0; i < 10; i++)
            //{
            //    Game g = new Game() { Name = "Fifa 18"+i, Genre = "Symulator", Rating = 90.3M };
            //    GamesList.Add(g);
            //}
            ////Game g = new Game() { Name = "Fifa 18", Genre = "Symulator", Rating = 90.3M };
            ////GamesList.Add(g);
            LoadgameLV();

        }
        void LoadgameLV()

        {
            GamesList = (List<Game>)XmlSer.Deserialize(path);
            if (GamesList.Count == 0)
                return;

            foreach (Game g in GamesList)
            {
                ListViewItem lvItem = new ListViewItem(new string[] { g.Name, g.Genre, "", g.Rating.ToString() });
                lvGames.Items.Add(lvItem);
                LvGamesPair.Add(lvItem, g);
            }
        }

        private void lvGames_SelectedIndexChanged(object sender, EventArgs e)
        {

            IEnumerable<ListViewItem> lviList = ((ListView)sender).SelectedItems.Cast<ListViewItem>();
            if (lviList.Count() == 0)
                return;
            ListViewItem lvItem = lviList.FirstOrDefault();
            ReloadGameInfo(lvItem);

        }
        private void ReloadGameInfo(ListViewItem lvItem)
        {
            try
            {
                Game g = LvGamesPair[lvItem];
                lblTytul.Text = g.Name;
                rtbOpis.Text = g.Summary;
                txbGatunek.Text = g.Genre;
                txbOcena.Text = g.Rating.ToString();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
                


        }

        private void gbGames_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.TopMost = true;
            formAdd.ShowDialog();
            if (formAdd.g != null)
            {
                Game g = formAdd.g;
                GamesList.Add(g);
                XmlSer.Serialize(GamesList, path);
                LoadgameLV();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<ListViewItem> lviList = lvGames.SelectedItems.Cast<ListViewItem>();
            if (lviList.Count() == 0)
                return;
            ListViewItem lvItem = lviList.FirstOrDefault();
            GamesList.Remove(LvGamesPair[lvItem]);
            LvGamesPair.Remove(lvItem);
            lvGames.Items.Remove(lvItem);
            XmlSer.Serialize(GamesList, path);
        }
    }
}
