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
            this.TLPmain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewdatas = new System.Windows.Forms.DataGridView();
            this.FLPbuttons = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNcreate = new System.Windows.Forms.Button();
            this.BTNread = new System.Windows.Forms.Button();
            this.BTNupdate = new System.Windows.Forms.Button();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNshowNews = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBtitle = new System.Windows.Forms.Label();
            this.LBbody = new System.Windows.Forms.Label();
            this.LBautor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TLPmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatas)).BeginInit();
            this.FLPbuttons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPmain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPmain.Size = new System.Drawing.Size(800, 450);
            this.TLPmain.TabIndex = 0;
            // 
            // dataGridViewdatas
            // 
            this.dataGridViewdatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewdatas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewdatas.Name = "dataGridViewdatas";
            this.dataGridViewdatas.RowTemplate.Height = 25;
            this.dataGridViewdatas.Size = new System.Drawing.Size(794, 143);
            this.dataGridViewdatas.TabIndex = 0;
            // 
            // FLPbuttons
            // 
            this.FLPbuttons.Controls.Add(this.BTNcreate);
            this.FLPbuttons.Controls.Add(this.BTNread);
            this.FLPbuttons.Controls.Add(this.BTNupdate);
            this.FLPbuttons.Controls.Add(this.BTNdelete);
            this.FLPbuttons.Controls.Add(this.BTNshowNews);
            this.FLPbuttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPbuttons.Location = new System.Drawing.Point(3, 301);
            this.FLPbuttons.Name = "FLPbuttons";
            this.FLPbuttons.Size = new System.Drawing.Size(794, 146);
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
            // 
            // BTNread
            // 
            this.BTNread.Location = new System.Drawing.Point(107, 3);
            this.BTNread.Name = "BTNread";
            this.BTNread.Size = new System.Drawing.Size(91, 54);
            this.BTNread.TabIndex = 1;
            this.BTNread.Text = "Read";
            this.BTNread.UseVisualStyleBackColor = true;
            // 
            // BTNupdate
            // 
            this.BTNupdate.Location = new System.Drawing.Point(204, 3);
            this.BTNupdate.Name = "BTNupdate";
            this.BTNupdate.Size = new System.Drawing.Size(97, 54);
            this.BTNupdate.TabIndex = 2;
            this.BTNupdate.Text = "Update";
            this.BTNupdate.UseVisualStyleBackColor = true;
            // 
            // BTNdelete
            // 
            this.BTNdelete.Location = new System.Drawing.Point(307, 3);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(93, 54);
            this.BTNdelete.TabIndex = 3;
            this.BTNdelete.Text = "Delete";
            this.BTNdelete.UseVisualStyleBackColor = true;
            // 
            // BTNshowNews
            // 
            this.BTNshowNews.Location = new System.Drawing.Point(406, 3);
            this.BTNshowNews.Name = "BTNshowNews";
            this.BTNshowNews.Size = new System.Drawing.Size(109, 54);
            this.BTNshowNews.TabIndex = 4;
            this.BTNshowNews.Text = "Voir les journaux";
            this.BTNshowNews.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.005249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.99475F));
            this.tableLayoutPanel1.Controls.Add(this.LBtitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBbody, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBautor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 127);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LBtitle
            // 
            this.LBtitle.AutoSize = true;
            this.LBtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBtitle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LBtitle.Location = new System.Drawing.Point(3, 0);
            this.LBtitle.Name = "LBtitle";
            this.LBtitle.Size = new System.Drawing.Size(55, 47);
            this.LBtitle.TabIndex = 0;
            this.LBtitle.Text = "titre";
            this.LBtitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBbody
            // 
            this.LBbody.AutoSize = true;
            this.LBbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBbody.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LBbody.Location = new System.Drawing.Point(3, 47);
            this.LBbody.Name = "LBbody";
            this.LBbody.Size = new System.Drawing.Size(55, 47);
            this.LBbody.TabIndex = 1;
            this.LBbody.Text = "contenu";
            this.LBbody.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBautor
            // 
            this.LBautor.AutoSize = true;
            this.LBautor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBautor.Location = new System.Drawing.Point(3, 94);
            this.LBautor.Name = "LBautor";
            this.LBautor.Size = new System.Drawing.Size(55, 33);
            this.LBautor.TabIndex = 2;
            this.LBautor.Text = "auteur";
            this.LBautor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(64, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(64, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(695, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(64, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(695, 23);
            this.textBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TLPmain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TLPmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatas)).EndInit();
            this.FLPbuttons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPmain;
        private DataGridView dataGridViewdatas;
        private FlowLayoutPanel FLPbuttons;
        private Button BTNcreate;
        private Button BTNread;
        private Button BTNupdate;
        private Button BTNdelete;
        private Button BTNshowNews;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LBtitle;
        private Label LBbody;
        private Label LBautor;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}