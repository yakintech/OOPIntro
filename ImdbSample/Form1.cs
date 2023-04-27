using ImdbSample.Models;
using System.Net;

namespace ImdbSample
{
    public partial class Form1 : Form
    {
        List<Film> films = new List<Film>();
        bool orderStatus = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        void LoadData()
        {
            WebClient wc = new WebClient();
            string imdbData = wc.DownloadString("https://www.imdb.com/chart/top/");


            int contentStartIndex = imdbData.IndexOf("class=\"lister-list\">");

            int contentEndIndex = imdbData.IndexOf("</tbody>");

            string content = imdbData.Substring(contentStartIndex, contentEndIndex - contentStartIndex);

            List<string> list = new List<string>();

            while (content.Contains("<tr>"))
            {
                int trStartIndex = content.IndexOf("<tr>");
                int trEndIndex = content.IndexOf("</tr>");

                string filmContent = content.Substring(trStartIndex, trEndIndex - trStartIndex);

                list.Add(filmContent);

                content = content.Substring(trEndIndex + 6);

            }


    

            foreach (string str in list)
            {
                Film film = new Film();

                int ratingIndexOf = str.IndexOf("</strong>");
                film.Rating = Convert.ToDouble(str.Substring(ratingIndexOf - 3, 3));

                int yearIndexOf = str.IndexOf(")</span>");
                film.Year = Convert.ToInt32(str.Substring(yearIndexOf - 4, 4));


                int nameIndex = str.IndexOf("alt=");
                int nameEndIndex = str.IndexOf("</a>");

                film.Name = str.Substring(nameIndex + 5, nameEndIndex - nameIndex - 9);

                films.Add(film);
            }

            dataGridView1.DataSource = films;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if(orderStatus == false)
            {
                films = films.OrderByDescending(x => x.Year).ToList();
                orderStatus= true;
            }
            else
            {
                films = films.OrderBy(x => x.Year).ToList();
                orderStatus = false;
            }
          

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = films;

        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtCount.Text);

            List<Film> films2 = films.Take(count).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = films2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower().Trim();
            var filmList2 = films.Where(x => x.Name.ToLower().Contains(searchText)).ToList();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filmList2;

        }

        private void btnSearchByYear_Click(object sender, EventArgs e)
        {
            int startYear = Convert.ToInt32(txtStartYear.Text);
            int endYear = Convert.ToInt32(txtEndYear.Text);

            List<Film> filmList2 = films.Where(x => x.Year >= startYear && x.Year <= endYear).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filmList2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = films.Where(q => q.Name.ToLower().StartsWith('a')).ToList();

            MessageBox.Show(data.Count().ToString());

        }
    }
}