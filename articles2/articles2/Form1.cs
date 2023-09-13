using System.ComponentModel;

namespace articles2
{
    public partial class Form1 : Form
    {
        DBqueries _DBCall = new();
        BindingList<Article> _lstArticles;
        BindingList<Newspapper> _lstNewspappers;
        BindingList<Composition> _lstCompos;
        public Form1()
        {

            InitializeComponent();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            //Cr�ation of the diff�rents list:
            _lstArticles = new();
            _lstNewspappers = new();
            _lstCompos = new();
            //Connection of the BindingSource whith the correspond list created:
            BSArticle.DataSource = _lstArticles;
            BSJounal.DataSource = _lstNewspappers;
            BSComps.DataSource = _lstCompos;
            DGVarticles.DataSource = BSArticle;
            DGVNewspappers.DataSource = BSJounal;
            DGVcomposArticles.DataSource = BSComps;
            DGVcomposNewspappers.DataSource = BSJounal;
            DGVcomposArticles.DataSource = BSArticle;
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
            _DBCall.InsertArticle(TXTtitre.Text, TXTcorps.Text, TXTauteur.Text);
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
            _DBCall.InsertArticle(TXTtitre.Text, TXTcorps.Text, TXTauteur.Text);
            BTreadArticle.PerformClick();
        }

        private void DGVcomposArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTreadArticle_Click(object sender, EventArgs e)
        {
            var articles = _DBCall.GetAllArticles();
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
                int updated = _DBCall.UpdateArticle(current.IDArticle, TXTtitre.Text, TXTcorps.Text, TXTauteur.Text);
                if (updated > 0)
                {
                    MessageBox.Show($"L'aticle n� {current.IDArticle} {current.Titre} de: {current.Auteur} � bien �t� mis � jour avec le titre: {TXTtitre.Text} et auteur: {TXTauteur.Text}.");

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
            _DBCall.UpdateNewspapper(current.IDJournal, current.Titre, current.DtParution);
        }

        private void BTreadNewspappers_Click(object sender, EventArgs e)
        {

            var news = _DBCall.GetAllNewspappers();
            _lstNewspappers.Clear();
            foreach (Newspapper n in news)
            {
                _lstNewspappers.Add(n);
                BTreadNewspappers.PerformClick();
            }
        }
    }
}
