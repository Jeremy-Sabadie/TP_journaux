using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class composition : Form
    {
        public int IDArticle { get; set; }
        public int IDJournal { get; set; }
        DBconnect _DBCompo = new();
        BindingList<composition> _lstCompo;
        public composition()
        {
            InitializeComponent();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            _lstCompo = new();

            BScompo.DataSource = _lstCompo;
            DGVcompo.DataSource = BScompo.DataSource = _lstCompo;

            NUMarticle.DataBindings.Add("Text", BScompo, "IDArticle", false, DataSourceUpdateMode.Never);
            NUMnewspaper.DataBindings.Add("Text", BScompo, "IDJournal", false, DataSourceUpdateMode.Never);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void composition_Load(object sender, EventArgs e)
        {

        }

        private void BTview_compo_Click(object sender, EventArgs e)
        {
            var compos = _DBCompo.GetAllCompo();
            _lstCompo.Clear();
            foreach (composition compo in compos)
            {
                _lstCompo.Add(compo);
            }

        }

        private void BTlink_Click(object sender, EventArgs e)
        {
            _DBCompo.CreateCompo(NUMarticle.Value, NUMJournal.Value);
        }

        private void BTupdateCompo_Click(object sender, EventArgs e)
        {
            var current = BScompo.Current as composition;
            if (current is not null)
            {
                _DBCompo.UpdateCompo(current.IDArticle, current.IDArticle,
                NUMarticle.Value, NUMJournal.Value);
            }
        }
    }
}
