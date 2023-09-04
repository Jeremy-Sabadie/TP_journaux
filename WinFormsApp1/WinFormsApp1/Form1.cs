using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DBconnect _dbRequest = new();
        BindingList<Article> _lstArticles;
        BindingList<Newspapers> _lstNewspaper;

        public Form1()
        {
            InitializeComponent();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            _lstNewspaper = new();
            _lstArticles = new();
            BsArticle.DataSource = _lstArticles;
            dataGridViewdatas.DataSource = BsArticle;

            TXTtitle.DataBindings.Add("Text", BsArticle, "Titre", false, DataSourceUpdateMode.Never);
            TXTcontent.DataBindings.Add("Text", BsArticle, "Corps", false, DataSourceUpdateMode.Never);
            TXTautor.DataBindings.Add("Text", BsArticle, "Auteur", false, DataSourceUpdateMode.Never);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNread_Click(object sender, EventArgs e)
        {
            var Articles = _dbRequest.GetAllArticles();
            _lstArticles.Clear();
            foreach (Article Article in Articles)
            {
                _lstArticles.Add(Article);
            }
        }

        private void BTNshowNews_Click(object sender, EventArgs e)
        {
            using (Form Journaux = new Form())
            {
                Journaux.Text = "journeaux";
                DialogResult res = Journaux.ShowDialog();




                var newspapers = _dbRequest.GetAllNewspapers();
                _lstNewspaper.Clear();
                foreach (Newspapers newspaper in newspapers)
                {
                    _lstNewspaper.Add(newspaper);
                }

            }
        }

        //private void TLPmain_Paint(object sender, PaintEventArgs e)
        //    {

        //    }
    }
}

