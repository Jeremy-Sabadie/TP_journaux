using System.ComponentModel;

namespace WinFormsApp1
{

    public partial class journaux : Form
    {
        BindingList<Newspapers> LstNewspaper;
        DBconnect _dbQuery = new();
        public journaux()
        {
            InitializeComponent();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            LstNewspaper = new();
            BSnewspaper.DataSource = LstNewspaper;
            DGVjournaux.DataSource = BSnewspaper;

            NUDid.DataBindings.Add("value", BSnewspaper, "IDJournal", false, DataSourceUpdateMode.Never);
            TXTtitre.DataBindings.Add("Text", BSnewspaper, "Titre", false, DataSourceUpdateMode.Never);
            DTPdate.DataBindings.Add("value", BSnewspaper, "DtParution", false, DataSourceUpdateMode.Never);
        }

        private void BTNdeleteNewspaper_Click(object sender, EventArgs e)
        {
            var current = BSnewspaper.Current as Newspapers;



            if (current is not null)
            {


            }
            _dbQuery.DeleteArticle(current.IDJournal);
            BTNreadNewspaper.PerformClick();
        }

        private void BTupdate_Click(object sender, EventArgs e)
        {
            var current = BSnewspaper.Current as Newspapers;
            _dbQuery.UpdateNewspaper(current.IDJournal, current.Titre, current.DtParution, TXTtitre.Text, DTPdate.Value);
        }

        private void BBTNcreateNewspaper_Click(object sender, EventArgs e)
        {
            BSnewspaper.Clear();
            _dbQuery.InsertNewspaper(TXTtitre.Text, DTPdate.Value);
            BTNreadNewspaper.PerformClick();
        }

        private void BTNreadNewspaper_Click(object sender, EventArgs e)
        {
            var newspapers = _dbQuery.GetAllNewspapers();
            LstNewspaper.Clear();
            foreach (Newspapers newspaper in newspapers)
            {
                LstNewspaper.Add(newspaper);
            }
        }
    }
}
