using System.ComponentModel;

namespace articles2
{
    public partial class Form1 : Form
    {
        DBqueries _DBCall = new();
        BindingList<Article> _lstArticles;
        BindingList<Newspapper> _lstNewspappers;
        BindingList<Composition> _lstCompos;
        BindingList<Article> _lstComposIsIn;
        BindingList<Article> _lstComposNotIn;
        BindingList<Newspapper> _lstComposJournal;
        public Form1()
        {

            InitializeComponent();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            //Création of the différents list:
            _lstArticles = new();
            _lstNewspappers = new();
            _lstCompos = new();
            _lstComposIsIn = new();
            _lstComposNotIn = new();
            _lstComposJournal = new();

            //Connection of the BindingSource whith the correspond list created:
            BSArticle.DataSource = _lstArticles;
            BSJounal.DataSource = _lstNewspappers;
            BSComps.DataSource = _lstCompos;
            BScomposIsIn.DataSource = _lstComposIsIn;
            BScomposNotIn.DataSource = _lstComposNotIn;
            DGVarticles.DataSource = BSArticle;
            DGVNewspappers.DataSource = BSJounal;
            DGVnotIn.DataSource = BSComps;
            DGVisIn.DataSource = BSJounal;
            DGVnotIn.DataSource = BSArticle;
            DGVcomposJournaux.DataSource = BScomposJournaux;
            DGVisIn.DataSource = BScomposIsIn;
            DGVnotIn.DataSource = BScomposNotIn;
            //Connection of the diffrent textbox:
            TXTtitre.DataBindings.Add("Text", BSArticle, "Titre", false, DataSourceUpdateMode.Never);
            TXTcorps.DataBindings.Add("Text", BSArticle, "Corps", false, DataSourceUpdateMode.Never);
            TXTauteur.DataBindings.Add("Text", BSArticle, "Auteur", false, DataSourceUpdateMode.Never);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTCreate_Click(object sender, EventArgs e)
        {
            _DBCall.InsertArticleAsync(TXTtitre.Text, TXTcorps.Text, TXTauteur.Text);
        }

        private void FLPContainerBTN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGVcopmpos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTcreateArticle_Click(object sender, EventArgs e)
        {
            _DBCall.InsertArticleAsync(TXTtitre.Text, TXTcorps.Text, TXTauteur.Text);
            BTreadArticle.PerformClick();
        }

        private void DGVcomposArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BTreadArticle_Click(object sender, EventArgs e)
        {
            var articles = await _DBCall.GetAllArticlesAsync();
            _lstArticles.Clear();
            foreach (Article a in articles)
            {
                _lstArticles.Add(a);

            }
        }

        private void BTupdateArticle_Click(object sender, EventArgs e)
        {
            Article current = BSArticle.Current as Article;
            if (current is not null)
            {
                Task<int> updated = _DBCall.UpdateArticleAsync(current.IDArticle, TXTtitre.Text, TXTcorps.Text, TXTauteur.Text);
                if (updated.Result > 0)
                {
                    MessageBox.Show($"L'aticle n° {current.IDArticle} {current.Titre} de: {current.Auteur} à bien été mis à jour avec le titre: {TXTtitre.Text} et auteur: {TXTauteur.Text}.");

                }
            }


        }

        private void BTdeleteArticle_Click(object sender, EventArgs e)
        {
            Article current = BSArticle.Current as Article;
            if (current is not null)
                _DBCall.DeleteArticle(current.IDArticle);
            BTreadArticle.PerformClick();
        }

        private void BTupdateNewspapper_Click(object sender, EventArgs e)
        {
            var current = BSJounal.Current as Newspapper;
            _DBCall.UpdateNewspapperAsync(current.IDJournal, current.Titre, current.DtParution);
        }

        private void BTreadNewspappers_Click(object sender, EventArgs e)
        {

            var news = _DBCall.GetAllNewspappersAsync();
            _lstNewspappers.Clear();
            foreach (Newspapper n in news.Result)
            {
                _lstNewspappers.Add(n);

            }
        }

        private void BTcreateNewspapper_Click(object sender, EventArgs e)
        {
            _DBCall.InsertNewspapperAsync(TXTitreJournal.Text, DTParutionJournal.Value);
            BTreadNewspappers.PerformClick();
        }

        private void BTdeleteNewspapper_Click(object sender, EventArgs e)
        {
            var current = BSJounal.Current as Newspapper;
            _DBCall.DeleteNewspapper(current.IDJournal);
            if (_DBCall.DeleteNewspapper(current.IDJournal) > 0)
            {
                MessageBox.Show($"Le journal {current.Titre} n°{current.IDJournal} à bien été supprimmé.");
                BTreadNewspappers.PerformClick();
            }
            else
            {
                MessageBox.Show($"Erreur lors de la suppéssion du  journal: {current.Titre}.");
            }
            BTreadNewspappers.PerformClick();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
