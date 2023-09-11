namespace WinFormsApp1
{
    partial class composition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TLPcompo = new System.Windows.Forms.TableLayoutPanel();
            this.DGVcompo = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.NUMnewspaper = new System.Windows.Forms.Label();
            this.NUMarticle = new System.Windows.Forms.NumericUpDown();
            this.NUMJournal = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTview_compo = new System.Windows.Forms.Button();
            this.BTlink = new System.Windows.Forms.Button();
            this.BTupdateCompo = new System.Windows.Forms.Button();
            this.BScompo = new System.Windows.Forms.BindingSource(this.components);
            this.TLPcompo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcompo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMarticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMJournal)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BScompo)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPcompo
            // 
            this.TLPcompo.ColumnCount = 1;
            this.TLPcompo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPcompo.Controls.Add(this.DGVcompo, 0, 0);
            this.TLPcompo.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TLPcompo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPcompo.Location = new System.Drawing.Point(0, 0);
            this.TLPcompo.Name = "TLPcompo";
            this.TLPcompo.RowCount = 2;
            this.TLPcompo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPcompo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPcompo.Size = new System.Drawing.Size(800, 450);
            this.TLPcompo.TabIndex = 0;
            // 
            // DGVcompo
            // 
            this.DGVcompo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcompo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVcompo.Location = new System.Drawing.Point(3, 3);
            this.DGVcompo.Name = "DGVcompo";
            this.DGVcompo.RowTemplate.Height = 25;
            this.DGVcompo.Size = new System.Drawing.Size(794, 219);
            this.DGVcompo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 228);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.05479F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.94521F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 219);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.12862F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.87138F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NUMnewspaper, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.NUMarticle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NUMJournal, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(622, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDArticle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NUMnewspaper
            // 
            this.NUMnewspaper.AutoSize = true;
            this.NUMnewspaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUMnewspaper.Location = new System.Drawing.Point(3, 50);
            this.NUMnewspaper.Name = "NUMnewspaper";
            this.NUMnewspaper.Size = new System.Drawing.Size(57, 50);
            this.NUMnewspaper.TabIndex = 1;
            this.NUMnewspaper.Text = "IDJournal";
            this.NUMnewspaper.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NUMarticle
            // 
            this.NUMarticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUMarticle.Location = new System.Drawing.Point(66, 3);
            this.NUMarticle.Name = "NUMarticle";
            this.NUMarticle.Size = new System.Drawing.Size(553, 23);
            this.NUMarticle.TabIndex = 2;
            // 
            // NUMJournal
            // 
            this.NUMJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUMJournal.Location = new System.Drawing.Point(66, 53);
            this.NUMJournal.Name = "NUMJournal";
            this.NUMJournal.Size = new System.Drawing.Size(553, 23);
            this.NUMJournal.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BTview_compo);
            this.flowLayoutPanel1.Controls.Add(this.BTlink);
            this.flowLayoutPanel1.Controls.Add(this.BTupdateCompo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BTview_compo
            // 
            this.BTview_compo.Location = new System.Drawing.Point(3, 3);
            this.BTview_compo.Name = "BTview_compo";
            this.BTview_compo.Size = new System.Drawing.Size(107, 49);
            this.BTview_compo.TabIndex = 0;
            this.BTview_compo.Text = "Voir la table";
            this.BTview_compo.UseVisualStyleBackColor = true;
            this.BTview_compo.Click += new System.EventHandler(this.BTview_compo_Click);
            // 
            // BTlink
            // 
            this.BTlink.Location = new System.Drawing.Point(116, 3);
            this.BTlink.Name = "BTlink";
            this.BTlink.Size = new System.Drawing.Size(128, 49);
            this.BTlink.TabIndex = 1;
            this.BTlink.Text = "Etablir la liaison";
            this.BTlink.UseVisualStyleBackColor = true;
            this.BTlink.Click += new System.EventHandler(this.BTlink_Click);
            // 
            // BTupdateCompo
            // 
            this.BTupdateCompo.Location = new System.Drawing.Point(250, 3);
            this.BTupdateCompo.Name = "BTupdateCompo";
            this.BTupdateCompo.Size = new System.Drawing.Size(109, 49);
            this.BTupdateCompo.TabIndex = 2;
            this.BTupdateCompo.Text = "Mettre à jour la liaison";
            this.BTupdateCompo.UseVisualStyleBackColor = true;
            this.BTupdateCompo.Click += new System.EventHandler(this.BTupdateCompo_Click);
            // 
            // BScompo
            // 
            this.BScompo.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TLPcompo);
            this.Name = "composition";
            this.Text = "composition";
            this.Load += new System.EventHandler(this.composition_Load);
            this.TLPcompo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcompo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMarticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMJournal)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BScompo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPcompo;
        private DataGridView DGVcompo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label NUMnewspaper;
        private NumericUpDown NUMarticle;
        private NumericUpDown NUMJournal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BTview_compo;
        private Button BTlink;
        private BindingSource BScompo;
        private Button BTupdateCompo;
    }
}