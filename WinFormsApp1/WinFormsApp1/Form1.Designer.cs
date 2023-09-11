namespace WinFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TLPmain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewdatas = new System.Windows.Forms.DataGridView();
            this.FLPbuttons = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNcreate = new System.Windows.Forms.Button();
            this.BTNread = new System.Windows.Forms.Button();
            this.BTNupdate = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNshowNews = new System.Windows.Forms.Button();
            this.BTshowCompo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBtitle = new System.Windows.Forms.Label();
            this.LBbody = new System.Windows.Forms.Label();
            this.LBautor = new System.Windows.Forms.Label();
            this.TXTtitle = new System.Windows.Forms.TextBox();
            this.TXTcontent = new System.Windows.Forms.TextBox();
            this.TXTautor = new System.Windows.Forms.TextBox();
            this.NUDnum = new System.Windows.Forms.NumericUpDown();
            this.LBnum = new System.Windows.Forms.Label();
            this.BsArticle = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TLPmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatas)).BeginInit();
            this.FLPbuttons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPmain
            // 
            this.TLPmain.ColumnCount = 1;
            this.TLPmain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.375F));
            this.TLPmain.Controls.Add(this.dataGridViewdatas, 0, 0);
            this.TLPmain.Controls.Add(this.FLPbuttons, 0, 2);
            this.TLPmain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TLPmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPmain.Location = new System.Drawing.Point(0, 0);
            this.TLPmain.Name = "TLPmain";
            this.TLPmain.RowCount = 3;
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.11111F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.11111F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.TLPmain.Size = new System.Drawing.Size(800, 450);
            this.TLPmain.TabIndex = 0;
            // 
            // dataGridViewdatas
            // 
            this.dataGridViewdatas.AllowUserToAddRows = false;
            this.dataGridViewdatas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewdatas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewdatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewdatas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewdatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewdatas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewdatas.Name = "dataGridViewdatas";
            this.dataGridViewdatas.ReadOnly = true;
            this.dataGridViewdatas.RowTemplate.Height = 25;
            this.dataGridViewdatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewdatas.Size = new System.Drawing.Size(794, 205);
            this.dataGridViewdatas.TabIndex = 0;
            // 
            // FLPbuttons
            // 
            this.FLPbuttons.Controls.Add(this.BTNcreate);
            this.FLPbuttons.Controls.Add(this.BTNread);
            this.FLPbuttons.Controls.Add(this.BTNupdate);
            this.FLPbuttons.Controls.Add(this.BTNdelete);
            this.FLPbuttons.Controls.Add(this.BTNshowNews);
            this.FLPbuttons.Controls.Add(this.BTshowCompo);
            this.FLPbuttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPbuttons.Location = new System.Drawing.Point(3, 371);
            this.FLPbuttons.Name = "FLPbuttons";
            this.FLPbuttons.Size = new System.Drawing.Size(794, 76);
            this.FLPbuttons.TabIndex = 1;
            // 
            // BTNcreate
            // 
            this.BTNcreate.Location = new System.Drawing.Point(3, 3);
            this.BTNcreate.Name = "BTNcreate";
            this.BTNcreate.Size = new System.Drawing.Size(98, 54);
            this.BTNcreate.TabIndex = 0;
            this.BTNcreate.Text = "Create";
            this.BTNcreate.UseVisualStyleBackColor = true;
            this.BTNcreate.Click += new System.EventHandler(this.BTNcreate_Click);
            // 
            // BTNread
            // 
            this.BTNread.Location = new System.Drawing.Point(107, 3);
            this.BTNread.Name = "BTNread";
            this.BTNread.Size = new System.Drawing.Size(130, 54);
            this.BTNread.TabIndex = 1;
            this.BTNread.Text = "Voir les articles";
            this.BTNread.UseVisualStyleBackColor = true;
            this.BTNread.Click += new System.EventHandler(this.BTNread_Click);
            // 
            // BTNupdate
            // 
            this.BTNupdate.Location = new System.Drawing.Point(243, 3);
            this.BTNupdate.Name = "BTNupdate";
            this.BTNupdate.Size = new System.Drawing.Size(97, 54);
            this.BTNupdate.TabIndex = 2;
            this.BTNupdate.Text = "Mettre à jour la liaison";
            this.BTNupdate.UseVisualStyleBackColor = true;
            this.BTNupdate.Click += new System.EventHandler(this.BTNupdate_Click);
            // 
            // BTNdelete
            // 
            this.BTNdelete.Location = new System.Drawing.Point(346, 3);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(93, 54);
            this.BTNdelete.TabIndex = 3;
            this.BTNdelete.Text = "Delete";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // BTNshowNews
            // 
            this.BTNshowNews.Location = new System.Drawing.Point(445, 3);
            this.BTNshowNews.Name = "BTNshowNews";
            this.BTNshowNews.Size = new System.Drawing.Size(109, 54);
            this.BTNshowNews.TabIndex = 4;
            this.BTNshowNews.Text = "Voir les journaux";
            this.BTNshowNews.UseVisualStyleBackColor = true;
            this.BTNshowNews.Click += new System.EventHandler(this.BTNshowNews_Click);
            // 
            // BTshowCompo
            // 
            this.BTshowCompo.Location = new System.Drawing.Point(560, 3);
            this.BTshowCompo.Name = "BTshowCompo";
            this.BTshowCompo.Size = new System.Drawing.Size(135, 54);
            this.BTshowCompo.TabIndex = 5;
            this.BTshowCompo.Text = "Voir les compositions";
            this.BTshowCompo.UseVisualStyleBackColor = true;
            this.BTshowCompo.Click += new System.EventHandler(this.BTshowCompo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.14173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.85827F));
            this.tableLayoutPanel1.Controls.Add(this.LBtitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBbody, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBautor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TXTtitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXTcontent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXTautor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NUDnum, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBnum, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 214);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 141);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LBtitle
            // 
            this.LBtitle.AutoSize = true;
            this.LBtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBtitle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LBtitle.Location = new System.Drawing.Point(3, 0);
            this.LBtitle.Name = "LBtitle";
            this.LBtitle.Size = new System.Drawing.Size(116, 44);
            this.LBtitle.TabIndex = 0;
            this.LBtitle.Text = "titre";
            this.LBtitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBbody
            // 
            this.LBbody.AutoSize = true;
            this.LBbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBbody.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LBbody.Location = new System.Drawing.Point(3, 44);
            this.LBbody.Name = "LBbody";
            this.LBbody.Size = new System.Drawing.Size(116, 44);
            this.LBbody.TabIndex = 1;
            this.LBbody.Text = "contenu";
            this.LBbody.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBautor
            // 
            this.LBautor.AutoSize = true;
            this.LBautor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBautor.Location = new System.Drawing.Point(3, 88);
            this.LBautor.Name = "LBautor";
            this.LBautor.Size = new System.Drawing.Size(116, 33);
            this.LBautor.TabIndex = 2;
            this.LBautor.Text = "auteur";
            this.LBautor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TXTtitle
            // 
            this.TXTtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTtitle.Location = new System.Drawing.Point(125, 10);
            this.TXTtitle.Name = "TXTtitle";
            this.TXTtitle.Size = new System.Drawing.Size(634, 23);
            this.TXTtitle.TabIndex = 3;
            this.TXTtitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXTcontent
            // 
            this.TXTcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTcontent.Location = new System.Drawing.Point(125, 54);
            this.TXTcontent.Name = "TXTcontent";
            this.TXTcontent.Size = new System.Drawing.Size(634, 23);
            this.TXTcontent.TabIndex = 4;
            // 
            // TXTautor
            // 
            this.TXTautor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTautor.Location = new System.Drawing.Point(125, 93);
            this.TXTautor.Name = "TXTautor";
            this.TXTautor.Size = new System.Drawing.Size(634, 23);
            this.TXTautor.TabIndex = 5;
            // 
            // NUDnum
            // 
            this.NUDnum.Location = new System.Drawing.Point(125, 124);
            this.NUDnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDnum.Name = "NUDnum";
            this.NUDnum.Size = new System.Drawing.Size(633, 23);
            this.NUDnum.TabIndex = 6;
            this.NUDnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBnum
            // 
            this.LBnum.AutoSize = true;
            this.LBnum.Location = new System.Drawing.Point(3, 121);
            this.LBnum.Name = "LBnum";
            this.LBnum.Size = new System.Drawing.Size(108, 15);
            this.LBnum.TabIndex = 7;
            this.LBnum.Text = "Numéro du journal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TLPmain);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TLPmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatas)).EndInit();
            this.FLPbuttons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPmain;
        private DataGridView dataGridViewdatas;
        private FlowLayoutPanel FLPbuttons;
        private Button BTNcreate;
        private Button BTNread;
        private Button BTNdelete;
        private Button BTNshowNews;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LBtitle;
        private Label LBbody;
        private Label LBautor;
        private TextBox TXTtitle;
        private TextBox TXTcontent;
        private TextBox TXTautor;
        private BindingSource BsArticle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label LBnum;
        private NumericUpDown NUDnum;
        private Button BTshowCompo;
        private Button BTNupdate;
    }
}