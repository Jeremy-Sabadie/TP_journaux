namespace articles2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TC1 = new System.Windows.Forms.TabControl();
            this.tabPageArticle = new System.Windows.Forms.TabPage();
            this.DGVArticles = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVJournaux = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVCompos = new System.Windows.Forms.DataGridView();
            this.FLPContainerBTN = new System.Windows.Forms.FlowLayoutPanel();
            this.BTCreate = new System.Windows.Forms.Button();
            this.BTRead = new System.Windows.Forms.Button();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTDelete = new System.Windows.Forms.Button();
            this.BSArticle = new System.Windows.Forms.BindingSource(this.components);
            this.BSJounal = new System.Windows.Forms.BindingSource(this.components);
            this.BSComps = new System.Windows.Forms.BindingSource(this.components);
            this.TLPcontainer = new System.Windows.Forms.TableLayoutPanel();
            this.TXTtitr = new System.Windows.Forms.TextBox();
            this.TXTcontenu = new System.Windows.Forms.TextBox();
            this.TXTauteur = new System.Windows.Forms.TextBox();
            this.LBtitre = new System.Windows.Forms.Label();
            this.LBcorps = new System.Windows.Forms.Label();
            this.LBauteur = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.TC1.SuspendLayout();
            this.tabPageArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJournaux)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCompos)).BeginInit();
            this.FLPContainerBTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSJounal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComps)).BeginInit();
            this.TLPcontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TC1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FLPContainerBTN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TLPcontainer, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.95628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.04372F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 455);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TC1
            // 
            this.TC1.Controls.Add(this.tabPageArticle);
            this.TC1.Controls.Add(this.tabPage2);
            this.TC1.Controls.Add(this.tabPage1);
            this.TC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC1.Location = new System.Drawing.Point(3, 3);
            this.TC1.Name = "TC1";
            this.TC1.SelectedIndex = 0;
            this.TC1.Size = new System.Drawing.Size(794, 243);
            this.TC1.TabIndex = 0;
            // 
            // tabPageArticle
            // 
            this.tabPageArticle.Controls.Add(this.DGVArticles);
            this.tabPageArticle.Location = new System.Drawing.Point(4, 24);
            this.tabPageArticle.Name = "tabPageArticle";
            this.tabPageArticle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArticle.Size = new System.Drawing.Size(786, 215);
            this.tabPageArticle.TabIndex = 0;
            this.tabPageArticle.Text = "Article";
            this.tabPageArticle.UseVisualStyleBackColor = true;
            // 
            // DGVArticles
            // 
            this.DGVArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVArticles.Location = new System.Drawing.Point(3, 3);
            this.DGVArticles.Name = "DGVArticles";
            this.DGVArticles.ReadOnly = true;
            this.DGVArticles.RowTemplate.Height = 25;
            this.DGVArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVArticles.Size = new System.Drawing.Size(780, 209);
            this.DGVArticles.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVJournaux);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Journaux";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVJournaux
            // 
            this.DGVJournaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVJournaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVJournaux.Location = new System.Drawing.Point(3, 3);
            this.DGVJournaux.Name = "DGVJournaux";
            this.DGVJournaux.RowTemplate.Height = 25;
            this.DGVJournaux.Size = new System.Drawing.Size(780, 209);
            this.DGVJournaux.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVCompos);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(786, 215);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Compositions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVCompos
            // 
            this.DGVCompos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCompos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCompos.Location = new System.Drawing.Point(0, 0);
            this.DGVCompos.Name = "DGVCompos";
            this.DGVCompos.RowTemplate.Height = 25;
            this.DGVCompos.Size = new System.Drawing.Size(786, 215);
            this.DGVCompos.TabIndex = 0;
            // 
            // FLPContainerBTN
            // 
            this.FLPContainerBTN.Controls.Add(this.BTCreate);
            this.FLPContainerBTN.Controls.Add(this.BTRead);
            this.FLPContainerBTN.Controls.Add(this.BTUpdate);
            this.FLPContainerBTN.Controls.Add(this.BTDelete);
            this.FLPContainerBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPContainerBTN.Location = new System.Drawing.Point(3, 252);
            this.FLPContainerBTN.Name = "FLPContainerBTN";
            this.FLPContainerBTN.Size = new System.Drawing.Size(794, 72);
            this.FLPContainerBTN.TabIndex = 1;
            this.FLPContainerBTN.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPContainerBTN_Paint);
            // 
            // BTCreate
            // 
            this.BTCreate.Location = new System.Drawing.Point(93, 3);
            this.BTCreate.Margin = new System.Windows.Forms.Padding(93, 3, 23, 3);
            this.BTCreate.Name = "BTCreate";
            this.BTCreate.Size = new System.Drawing.Size(111, 47);
            this.BTCreate.TabIndex = 0;
            this.BTCreate.Text = "Créer";
            this.BTCreate.UseVisualStyleBackColor = true;
            this.BTCreate.Click += new System.EventHandler(this.BTCreate_Click);
            // 
            // BTRead
            // 
            this.BTRead.Location = new System.Drawing.Point(250, 3);
            this.BTRead.Margin = new System.Windows.Forms.Padding(23, 3, 23, 3);
            this.BTRead.Name = "BTRead";
            this.BTRead.Size = new System.Drawing.Size(111, 47);
            this.BTRead.TabIndex = 1;
            this.BTRead.Text = "Lire les données";
            this.BTRead.UseVisualStyleBackColor = true;
            // 
            // BTUpdate
            // 
            this.BTUpdate.Location = new System.Drawing.Point(407, 3);
            this.BTUpdate.Margin = new System.Windows.Forms.Padding(23, 3, 23, 3);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(109, 47);
            this.BTUpdate.TabIndex = 2;
            this.BTUpdate.Text = "Mettre à jour";
            this.BTUpdate.UseVisualStyleBackColor = true;
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(562, 3);
            this.BTDelete.Margin = new System.Windows.Forms.Padding(23, 3, 23, 3);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(121, 47);
            this.BTDelete.TabIndex = 3;
            this.BTDelete.Text = "Supprimer";
            this.BTDelete.UseVisualStyleBackColor = true;
            // 
            // TLPcontainer
            // 
            this.TLPcontainer.ColumnCount = 2;
            this.TLPcontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPcontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TLPcontainer.Controls.Add(this.TXTtitr, 1, 0);
            this.TLPcontainer.Controls.Add(this.TXTcontenu, 1, 1);
            this.TLPcontainer.Controls.Add(this.TXTauteur, 1, 2);
            this.TLPcontainer.Controls.Add(this.LBtitre, 0, 0);
            this.TLPcontainer.Controls.Add(this.LBcorps, 0, 1);
            this.TLPcontainer.Controls.Add(this.LBauteur, 0, 2);
            this.TLPcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPcontainer.Location = new System.Drawing.Point(3, 330);
            this.TLPcontainer.Name = "TLPcontainer";
            this.TLPcontainer.RowCount = 3;
            this.TLPcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPcontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TLPcontainer.Size = new System.Drawing.Size(794, 122);
            this.TLPcontainer.TabIndex = 2;
            // 
            // TXTtitr
            // 
            this.TXTtitr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTtitr.Location = new System.Drawing.Point(161, 3);
            this.TXTtitr.Name = "TXTtitr";
            this.TXTtitr.Size = new System.Drawing.Size(630, 23);
            this.TXTtitr.TabIndex = 0;
            // 
            // TXTcontenu
            // 
            this.TXTcontenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTcontenu.Location = new System.Drawing.Point(161, 34);
            this.TXTcontenu.Name = "TXTcontenu";
            this.TXTcontenu.Size = new System.Drawing.Size(630, 23);
            this.TXTcontenu.TabIndex = 1;
            // 
            // TXTauteur
            // 
            this.TXTauteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTauteur.Location = new System.Drawing.Point(161, 65);
            this.TXTauteur.Name = "TXTauteur";
            this.TXTauteur.Size = new System.Drawing.Size(630, 23);
            this.TXTauteur.TabIndex = 2;
            // 
            // LBtitre
            // 
            this.LBtitre.AutoSize = true;
            this.LBtitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBtitre.Location = new System.Drawing.Point(3, 0);
            this.LBtitre.Name = "LBtitre";
            this.LBtitre.Size = new System.Drawing.Size(152, 31);
            this.LBtitre.TabIndex = 3;
            this.LBtitre.Text = "Ttre";
            this.LBtitre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBcorps
            // 
            this.LBcorps.AutoSize = true;
            this.LBcorps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBcorps.Location = new System.Drawing.Point(3, 31);
            this.LBcorps.Name = "LBcorps";
            this.LBcorps.Size = new System.Drawing.Size(152, 31);
            this.LBcorps.TabIndex = 4;
            this.LBcorps.Text = "Contenu";
            this.LBcorps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBauteur
            // 
            this.LBauteur.AutoSize = true;
            this.LBauteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBauteur.Location = new System.Drawing.Point(3, 62);
            this.LBauteur.Name = "LBauteur";
            this.LBauteur.Size = new System.Drawing.Size(152, 60);
            this.LBauteur.TabIndex = 5;
            this.LBauteur.Text = "Auteur";
            this.LBauteur.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TC1.ResumeLayout(false);
            this.tabPageArticle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVJournaux)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCompos)).EndInit();
            this.FLPContainerBTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BSArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSJounal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComps)).EndInit();
            this.TLPcontainer.ResumeLayout(false);
            this.TLPcontainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl TC1;
        private TabPage tabPageArticle;
        private DataGridView DGVArticles;
        private TabPage tabPage2;
        private DataGridView DGVJournaux;
        private TabPage tabPage1;
        private DataGridView DGVCompos;
        private FlowLayoutPanel FLPContainerBTN;
        private Button BTCreate;
        private Button BTRead;
        private Button BTUpdate;
        private Button BTDelete;
        private BindingSource BSArticle;
        private BindingSource BSJounal;
        private BindingSource BSComps;
        private TableLayoutPanel TLPcontainer;
        private TextBox TXTtitr;
        private TextBox TXTcontenu;
        private TextBox TXTauteur;
        private Label LBtitre;
        private Label LBcorps;
        private Label LBauteur;
    }
}