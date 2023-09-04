using System.ComponentModel;

namespace WinFormsApp1
{

    public partial class journaux : Form
    {
        BindingList<Newspapers> LstNewspaper;
        DBconnect _Query = new();
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
    }
}
