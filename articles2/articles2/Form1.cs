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
            _lstArticles = new();
            _lstNewspappers = new();
            _lstCompos = new();
            BSArticle.DataSource = _lstArticles;
            BSJounal.DataSource = _lstNewspappers;
            BSComps.DataSource = _lstCompos;
            DGVArticles.DataSource = BSArticle;
            DGVJournaux.DataSource = BSJounal;
            DGVCompos.DataSource = BSComps;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTCreate_Click(object sender, EventArgs e)
        {
            _DBCall.InsertArticle(TXTtitre.text,);
        }

        private void FLPContainerBTN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}