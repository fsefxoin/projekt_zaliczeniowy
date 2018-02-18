using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    public class Game
    {
        //public DateTime addDate;

        public DateTime releaseDate = new DateTime();
        public DateTime lastPlayedDate = new DateTime();

        public int id = 0;
        public string name = string.Empty;
        public string summary = string.Empty;
        public string genre = string.Empty;
        public decimal rating = 0;
        public int platform = 0;
        public int[] genres = new int[0];
        public Genre[] genresObj = new Genre[0];

        public string GetGenresString()
        {
            return (string.Join(", ",this.genresObj.Select(x => x.name)));
        }

    }
}
