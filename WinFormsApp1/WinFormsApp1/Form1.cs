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
            this.Text = "articles.";

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
            using (journaux frm = new journaux())
            {
                frm.Text = "Les journaux";
                //DialogResult resJournaux = frm.ShowDialog();
                frm.ShowDialog();

                var newspapers = _dbRequest.GetAllNewspapers();
                _lstNewspaper.Clear();
                foreach (Newspapers newspaper in newspapers)
                {
                    _lstNewspaper.Add(newspaper);
                }


            }
        }

        private void BTNcreate_Click(object sender, EventArgs e)
        {

            _dbRequest.InsertArticle(TXTtitle.Text, TXTcontent.Text, TXTautor.Text);
            BTNread.PerformClick();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            {
                var current = BsArticle.Current as Article;

                if (current is not null)
                {
                    if (MessageBox.Show($"Accepter la suppression de l'article {current.Titre} ?", "Suprression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    {
                        _dbRequest.DeleteArticle
                            (current.IDArticle);
                        BTNread.PerformClick();
                    }
                    _dbRequest.DeleteArticle(current.IDArticle);
                    BTNread.PerformClick();
                }

            }
        }


        private void BTNupdate_Click(object sender, EventArgs e)
        {
            var current = BsArticle.Current as Article;


            if (current is not null)
            {
                var updated = _dbRequest.UpdateArticle(current.IDArticle, current.Titre, current.Corps, current.Auteur, TXTtitle.Text, TXTcontent.Text, TXTautor.Text);
                if (updated > 0)
                {
                    MessageBox.Show($"article: {current.Titre} de:{current.Auteur} à bien été mis à jour avec comme titre: {TXTtitle.Text} et auteur: {TXTautor}.");
                }
                else
                {
                    MessageBox.Show($"la mise à jour de l'article: {current.Titre} de:{current.Auteur} n'a pas réussie.");
                }
                BTNread.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTrearticle_Click(object sender, EventArgs e)
        {

        }
    }
}

