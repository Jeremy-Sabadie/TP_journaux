﻿namespace articles2
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
            this.BSArticle = new System.Windows.Forms.BindingSource(this.components);
            this.BSJounal = new System.Windows.Forms.BindingSource(this.components);
            this.BSComps = new System.Windows.Forms.BindingSource(this.components);
            this.TCobjedts = new System.Windows.Forms.TabControl();
            this.Articles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVarticles = new System.Windows.Forms.DataGridView();
            this.TLPNewspaperInputs = new System.Windows.Forms.TableLayoutPanel();
            this.FLPNewspappersBTN = new System.Windows.Forms.FlowLayoutPanel();
            this.BTcreateArticle = new System.Windows.Forms.Button();
            this.BTreadArticle = new System.Windows.Forms.Button();
            this.BTupdateArticle = new System.Windows.Forms.Button();
            this.BTdeleteArticle = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LBtitreArticle = new System.Windows.Forms.Label();
            this.LBcorpsArticle = new System.Windows.Forms.Label();
            this.LBauteurArticle = new System.Windows.Forms.Label();
            this.TXTtitre = new System.Windows.Forms.TextBox();
            this.TXTcorps = new System.Windows.Forms.TextBox();
            this.TXTauteur = new System.Windows.Forms.TextBox();
            this.newspappers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVNewspappers = new System.Windows.Forms.DataGridView();
            this.TLPinputs = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTcreateNewspapper = new System.Windows.Forms.Button();
            this.BTreadNewspappers = new System.Windows.Forms.Button();
            this.BTupdateNewspapper = new System.Windows.Forms.Button();
            this.BTdeleteNewspapper = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LBtitre = new System.Windows.Forms.Label();
            this.LBdate = new System.Windows.Forms.Label();
            this.TXTitreJournal = new System.Windows.Forms.TextBox();
            this.DTParutionJournal = new System.Windows.Forms.DateTimePicker();
            this.compositions = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVisIn = new System.Windows.Forms.DataGridView();
            this.DGVnotIn = new System.Windows.Forms.DataGridView();
            this.LBinclu = new System.Windows.Forms.Label();
            this.LBexclus = new System.Windows.Forms.Label();
            this.BTinclure = new System.Windows.Forms.Button();
            this.BTexcure = new System.Windows.Forms.Button();
            this.BTactualiserCompos = new System.Windows.Forms.Button();
            this.DGVcomposJournaux = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.BScomposIsIn = new System.Windows.Forms.BindingSource(this.components);
            this.BScomposNotIn = new System.Windows.Forms.BindingSource(this.components);
            this.BScomposJournaux = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BSArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSJounal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComps)).BeginInit();
            this.TCobjedts.SuspendLayout();
            this.Articles.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVarticles)).BeginInit();
            this.TLPNewspaperInputs.SuspendLayout();
            this.FLPNewspappersBTN.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.newspappers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewspappers)).BeginInit();
            this.TLPinputs.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.compositions.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVnotIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcomposJournaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScomposIsIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScomposNotIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScomposJournaux)).BeginInit();
            this.SuspendLayout();
            // 
            // TCobjedts
            // 
            this.TCobjedts.Controls.Add(this.Articles);
            this.TCobjedts.Controls.Add(this.newspappers);
            this.TCobjedts.Controls.Add(this.compositions);
            this.TCobjedts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCobjedts.Location = new System.Drawing.Point(0, 0);
            this.TCobjedts.Name = "TCobjedts";
            this.TCobjedts.SelectedIndex = 0;
            this.TCobjedts.Size = new System.Drawing.Size(800, 455);
            this.TCobjedts.TabIndex = 0;
            // 
            // Articles
            // 
            this.Articles.Controls.Add(this.tableLayoutPanel1);
            this.Articles.Location = new System.Drawing.Point(4, 24);
            this.Articles.Name = "Articles";
            this.Articles.Padding = new System.Windows.Forms.Padding(3);
            this.Articles.Size = new System.Drawing.Size(792, 427);
            this.Articles.TabIndex = 0;
            this.Articles.Text = "Articles";
            this.Articles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGVarticles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TLPNewspaperInputs, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.90499F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.09501F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVarticles
            // 
            this.DGVarticles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVarticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVarticles.Location = new System.Drawing.Point(3, 3);
            this.DGVarticles.Name = "DGVarticles";
            this.DGVarticles.RowTemplate.Height = 25;
            this.DGVarticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVarticles.Size = new System.Drawing.Size(780, 150);
            this.DGVarticles.TabIndex = 0;
            // 
            // TLPNewspaperInputs
            // 
            this.TLPNewspaperInputs.ColumnCount = 1;
            this.TLPNewspaperInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPNewspaperInputs.Controls.Add(this.FLPNewspappersBTN, 0, 1);
            this.TLPNewspaperInputs.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.TLPNewspaperInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPNewspaperInputs.Location = new System.Drawing.Point(3, 171);
            this.TLPNewspaperInputs.Name = "TLPNewspaperInputs";
            this.TLPNewspaperInputs.RowCount = 2;
            this.TLPNewspaperInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.60976F));
            this.TLPNewspaperInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.39024F));
            this.TLPNewspaperInputs.Size = new System.Drawing.Size(780, 247);
            this.TLPNewspaperInputs.TabIndex = 1;
            // 
            // FLPNewspappersBTN
            // 
            this.FLPNewspappersBTN.Controls.Add(this.BTcreateArticle);
            this.FLPNewspappersBTN.Controls.Add(this.BTreadArticle);
            this.FLPNewspappersBTN.Controls.Add(this.BTupdateArticle);
            this.FLPNewspappersBTN.Controls.Add(this.BTdeleteArticle);
            this.FLPNewspappersBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPNewspappersBTN.Location = new System.Drawing.Point(3, 140);
            this.FLPNewspappersBTN.Name = "FLPNewspappersBTN";
            this.FLPNewspappersBTN.Size = new System.Drawing.Size(774, 104);
            this.FLPNewspappersBTN.TabIndex = 0;
            // 
            // BTcreateArticle
            // 
            this.BTcreateArticle.Location = new System.Drawing.Point(83, 23);
            this.BTcreateArticle.Margin = new System.Windows.Forms.Padding(83, 23, 3, 3);
            this.BTcreateArticle.Name = "BTcreateArticle";
            this.BTcreateArticle.Size = new System.Drawing.Size(139, 47);
            this.BTcreateArticle.TabIndex = 0;
            this.BTcreateArticle.Text = "Créer";
            this.BTcreateArticle.UseVisualStyleBackColor = true;
            this.BTcreateArticle.Click += new System.EventHandler(this.BTcreateArticle_Click);
            // 
            // BTreadArticle
            // 
            this.BTreadArticle.Location = new System.Drawing.Point(238, 23);
            this.BTreadArticle.Margin = new System.Windows.Forms.Padding(13, 23, 3, 3);
            this.BTreadArticle.Name = "BTreadArticle";
            this.BTreadArticle.Size = new System.Drawing.Size(139, 47);
            this.BTreadArticle.TabIndex = 1;
            this.BTreadArticle.Text = "Voir les articles";
            this.BTreadArticle.UseVisualStyleBackColor = true;
            this.BTreadArticle.Click += new System.EventHandler(this.BTreadArticle_Click);
            // 
            // BTupdateArticle
            // 
            this.BTupdateArticle.Location = new System.Drawing.Point(393, 23);
            this.BTupdateArticle.Margin = new System.Windows.Forms.Padding(13, 23, 3, 3);
            this.BTupdateArticle.Name = "BTupdateArticle";
            this.BTupdateArticle.Size = new System.Drawing.Size(139, 47);
            this.BTupdateArticle.TabIndex = 2;
            this.BTupdateArticle.Text = "Mettre à jour l\'article";
            this.BTupdateArticle.UseVisualStyleBackColor = true;
            this.BTupdateArticle.Click += new System.EventHandler(this.BTupdateArticle_Click);
            // 
            // BTdeleteArticle
            // 
            this.BTdeleteArticle.Location = new System.Drawing.Point(548, 23);
            this.BTdeleteArticle.Margin = new System.Windows.Forms.Padding(13, 23, 3, 3);
            this.BTdeleteArticle.Name = "BTdeleteArticle";
            this.BTdeleteArticle.Size = new System.Drawing.Size(139, 47);
            this.BTdeleteArticle.TabIndex = 3;
            this.BTdeleteArticle.Text = "Supprimer l\'aticle";
            this.BTdeleteArticle.UseVisualStyleBackColor = true;
            this.BTdeleteArticle.Click += new System.EventHandler(this.BTdeleteArticle_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.83399F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.16601F));
            this.tableLayoutPanel4.Controls.Add(this.LBtitreArticle, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LBcorpsArticle, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LBauteurArticle, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.TXTtitre, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TXTcorps, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TXTauteur, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(193, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(193, 3, 3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(429, 131);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // LBtitreArticle
            // 
            this.LBtitreArticle.AutoSize = true;
            this.LBtitreArticle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LBtitreArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBtitreArticle.Location = new System.Drawing.Point(3, 0);
            this.LBtitreArticle.Name = "LBtitreArticle";
            this.LBtitreArticle.Size = new System.Drawing.Size(53, 45);
            this.LBtitreArticle.TabIndex = 0;
            this.LBtitreArticle.Text = "Titre";
            this.LBtitreArticle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBcorpsArticle
            // 
            this.LBcorpsArticle.AutoSize = true;
            this.LBcorpsArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBcorpsArticle.Location = new System.Drawing.Point(3, 45);
            this.LBcorpsArticle.Name = "LBcorpsArticle";
            this.LBcorpsArticle.Size = new System.Drawing.Size(53, 45);
            this.LBcorpsArticle.TabIndex = 1;
            this.LBcorpsArticle.Text = "Corps";
            this.LBcorpsArticle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBauteurArticle
            // 
            this.LBauteurArticle.AutoSize = true;
            this.LBauteurArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBauteurArticle.Location = new System.Drawing.Point(3, 90);
            this.LBauteurArticle.Name = "LBauteurArticle";
            this.LBauteurArticle.Size = new System.Drawing.Size(53, 41);
            this.LBauteurArticle.TabIndex = 2;
            this.LBauteurArticle.Text = "Auteur";
            this.LBauteurArticle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TXTtitre
            // 
            this.TXTtitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTtitre.Location = new System.Drawing.Point(62, 3);
            this.TXTtitre.Name = "TXTtitre";
            this.TXTtitre.Size = new System.Drawing.Size(364, 23);
            this.TXTtitre.TabIndex = 3;
            // 
            // TXTcorps
            // 
            this.TXTcorps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTcorps.Location = new System.Drawing.Point(62, 48);
            this.TXTcorps.Name = "TXTcorps";
            this.TXTcorps.Size = new System.Drawing.Size(364, 23);
            this.TXTcorps.TabIndex = 4;
            // 
            // TXTauteur
            // 
            this.TXTauteur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTauteur.Location = new System.Drawing.Point(62, 93);
            this.TXTauteur.Name = "TXTauteur";
            this.TXTauteur.Size = new System.Drawing.Size(364, 23);
            this.TXTauteur.TabIndex = 5;
            // 
            // newspappers
            // 
            this.newspappers.Controls.Add(this.tableLayoutPanel2);
            this.newspappers.Location = new System.Drawing.Point(4, 24);
            this.newspappers.Name = "newspappers";
            this.newspappers.Padding = new System.Windows.Forms.Padding(3);
            this.newspappers.Size = new System.Drawing.Size(792, 427);
            this.newspappers.TabIndex = 1;
            this.newspappers.Text = "Newspappers";
            this.newspappers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DGVNewspappers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TLPinputs, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.41805F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.58195F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 421);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DGVNewspappers
            // 
            this.DGVNewspappers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewspappers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVNewspappers.Location = new System.Drawing.Point(3, 3);
            this.DGVNewspappers.Name = "DGVNewspappers";
            this.DGVNewspappers.RowTemplate.Height = 25;
            this.DGVNewspappers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVNewspappers.Size = new System.Drawing.Size(780, 180);
            this.DGVNewspappers.TabIndex = 0;
            // 
            // TLPinputs
            // 
            this.TLPinputs.ColumnCount = 1;
            this.TLPinputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPinputs.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.TLPinputs.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.TLPinputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPinputs.Location = new System.Drawing.Point(3, 189);
            this.TLPinputs.Name = "TLPinputs";
            this.TLPinputs.RowCount = 2;
            this.TLPinputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPinputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPinputs.Size = new System.Drawing.Size(780, 229);
            this.TLPinputs.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BTcreateNewspapper);
            this.flowLayoutPanel1.Controls.Add(this.BTreadNewspappers);
            this.flowLayoutPanel1.Controls.Add(this.BTupdateNewspapper);
            this.flowLayoutPanel1.Controls.Add(this.BTdeleteNewspapper);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 109);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BTcreateNewspapper
            // 
            this.BTcreateNewspapper.Location = new System.Drawing.Point(133, 33);
            this.BTcreateNewspapper.Margin = new System.Windows.Forms.Padding(133, 33, 3, 3);
            this.BTcreateNewspapper.Name = "BTcreateNewspapper";
            this.BTcreateNewspapper.Size = new System.Drawing.Size(100, 41);
            this.BTcreateNewspapper.TabIndex = 0;
            this.BTcreateNewspapper.Text = "Créer";
            this.BTcreateNewspapper.UseVisualStyleBackColor = true;
            this.BTcreateNewspapper.Click += new System.EventHandler(this.BTcreateNewspapper_Click);
            // 
            // BTreadNewspappers
            // 
            this.BTreadNewspappers.Location = new System.Drawing.Point(269, 33);
            this.BTreadNewspappers.Margin = new System.Windows.Forms.Padding(33, 33, 3, 3);
            this.BTreadNewspappers.Name = "BTreadNewspappers";
            this.BTreadNewspappers.Size = new System.Drawing.Size(100, 41);
            this.BTreadNewspappers.TabIndex = 1;
            this.BTreadNewspappers.Text = "Voir les journaux";
            this.BTreadNewspappers.UseVisualStyleBackColor = true;
            this.BTreadNewspappers.Click += new System.EventHandler(this.BTreadNewspappers_Click);
            // 
            // BTupdateNewspapper
            // 
            this.BTupdateNewspapper.Location = new System.Drawing.Point(405, 33);
            this.BTupdateNewspapper.Margin = new System.Windows.Forms.Padding(33, 33, 3, 3);
            this.BTupdateNewspapper.Name = "BTupdateNewspapper";
            this.BTupdateNewspapper.Size = new System.Drawing.Size(100, 41);
            this.BTupdateNewspapper.TabIndex = 2;
            this.BTupdateNewspapper.Text = "Mettre à jour";
            this.BTupdateNewspapper.UseVisualStyleBackColor = true;
            this.BTupdateNewspapper.Click += new System.EventHandler(this.BTupdateNewspapper_Click);
            // 
            // BTdeleteNewspapper
            // 
            this.BTdeleteNewspapper.Location = new System.Drawing.Point(541, 33);
            this.BTdeleteNewspapper.Margin = new System.Windows.Forms.Padding(33, 33, 3, 3);
            this.BTdeleteNewspapper.Name = "BTdeleteNewspapper";
            this.BTdeleteNewspapper.Size = new System.Drawing.Size(100, 41);
            this.BTdeleteNewspapper.TabIndex = 3;
            this.BTdeleteNewspapper.Text = "Supprimer";
            this.BTdeleteNewspapper.UseVisualStyleBackColor = true;
            this.BTdeleteNewspapper.Click += new System.EventHandler(this.BTdeleteNewspapper_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.66483F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.33517F));
            this.tableLayoutPanel3.Controls.Add(this.LBtitre, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LBdate, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TXTitreJournal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DTParutionJournal, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(662, 100);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LBtitre
            // 
            this.LBtitre.AutoSize = true;
            this.LBtitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBtitre.Location = new System.Drawing.Point(3, 0);
            this.LBtitre.Name = "LBtitre";
            this.LBtitre.Size = new System.Drawing.Size(144, 50);
            this.LBtitre.TabIndex = 0;
            this.LBtitre.Text = "Titre";
            this.LBtitre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBdate
            // 
            this.LBdate.AutoSize = true;
            this.LBdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBdate.Location = new System.Drawing.Point(3, 50);
            this.LBdate.Name = "LBdate";
            this.LBdate.Size = new System.Drawing.Size(144, 50);
            this.LBdate.TabIndex = 1;
            this.LBdate.Text = "Date de parution";
            this.LBdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LBdate.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXTitreJournal
            // 
            this.TXTitreJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTitreJournal.Location = new System.Drawing.Point(153, 3);
            this.TXTitreJournal.Name = "TXTitreJournal";
            this.TXTitreJournal.Size = new System.Drawing.Size(506, 23);
            this.TXTitreJournal.TabIndex = 3;
            // 
            // DTParutionJournal
            // 
            this.DTParutionJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTParutionJournal.Location = new System.Drawing.Point(153, 53);
            this.DTParutionJournal.Name = "DTParutionJournal";
            this.DTParutionJournal.Size = new System.Drawing.Size(506, 23);
            this.DTParutionJournal.TabIndex = 4;
            // 
            // compositions
            // 
            this.compositions.Controls.Add(this.tableLayoutPanel5);
            this.compositions.Location = new System.Drawing.Point(4, 24);
            this.compositions.Name = "compositions";
            this.compositions.Size = new System.Drawing.Size(792, 427);
            this.compositions.TabIndex = 2;
            this.compositions.Text = "Compositions";
            this.compositions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 616F));
            this.tableLayoutPanel5.Controls.Add(this.DGVisIn, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.DGVnotIn, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.LBinclu, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.LBexclus, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.BTinclure, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.BTexcure, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.BTactualiserCompos, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.DGVcomposJournaux, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93617F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.06383F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(792, 427);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // DGVisIn
            // 
            this.DGVisIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVisIn.Location = new System.Drawing.Point(179, 37);
            this.DGVisIn.Name = "DGVisIn";
            this.DGVisIn.RowTemplate.Height = 25;
            this.DGVisIn.Size = new System.Drawing.Size(610, 104);
            this.DGVisIn.TabIndex = 0;
            this.DGVisIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DGVnotIn
            // 
            this.DGVnotIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVnotIn.Location = new System.Drawing.Point(179, 182);
            this.DGVnotIn.Name = "DGVnotIn";
            this.DGVnotIn.RowTemplate.Height = 25;
            this.DGVnotIn.Size = new System.Drawing.Size(610, 114);
            this.DGVnotIn.TabIndex = 1;
            this.DGVnotIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcomposArticles_CellContentClick);
            // 
            // LBinclu
            // 
            this.LBinclu.AutoSize = true;
            this.LBinclu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBinclu.Location = new System.Drawing.Point(179, 0);
            this.LBinclu.Name = "LBinclu";
            this.LBinclu.Size = new System.Drawing.Size(610, 34);
            this.LBinclu.TabIndex = 5;
            this.LBinclu.Text = "Inclus:";
            // 
            // LBexclus
            // 
            this.LBexclus.AutoSize = true;
            this.LBexclus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBexclus.Location = new System.Drawing.Point(179, 144);
            this.LBexclus.Name = "LBexclus";
            this.LBexclus.Size = new System.Drawing.Size(610, 35);
            this.LBexclus.TabIndex = 6;
            this.LBexclus.Text = "Exclus:";
            // 
            // BTinclure
            // 
            this.BTinclure.Location = new System.Drawing.Point(43, 212);
            this.BTinclure.Margin = new System.Windows.Forms.Padding(43, 33, 3, 3);
            this.BTinclure.Name = "BTinclure";
            this.BTinclure.Size = new System.Drawing.Size(83, 41);
            this.BTinclure.TabIndex = 3;
            this.BTinclure.Text = "Inclure";
            this.BTinclure.UseVisualStyleBackColor = true;
            // 
            // BTexcure
            // 
            this.BTexcure.Location = new System.Drawing.Point(43, 67);
            this.BTexcure.Margin = new System.Windows.Forms.Padding(43, 33, 3, 3);
            this.BTexcure.Name = "BTexcure";
            this.BTexcure.Size = new System.Drawing.Size(83, 39);
            this.BTexcure.TabIndex = 2;
            this.BTexcure.Text = "Exclure";
            this.BTexcure.UseVisualStyleBackColor = true;
            // 
            // BTactualiserCompos
            // 
            this.BTactualiserCompos.Location = new System.Drawing.Point(43, 329);
            this.BTactualiserCompos.Margin = new System.Windows.Forms.Padding(43, 3, 3, 3);
            this.BTactualiserCompos.Name = "BTactualiserCompos";
            this.BTactualiserCompos.Size = new System.Drawing.Size(83, 58);
            this.BTactualiserCompos.TabIndex = 4;
            this.BTactualiserCompos.Text = "Actualiser";
            this.BTactualiserCompos.UseVisualStyleBackColor = true;
            // 
            // DGVcomposJournaux
            // 
            this.DGVcomposJournaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcomposJournaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVcomposJournaux.Location = new System.Drawing.Point(179, 329);
            this.DGVcomposJournaux.Name = "DGVcomposJournaux";
            this.DGVcomposJournaux.RowTemplate.Height = 25;
            this.DGVcomposJournaux.Size = new System.Drawing.Size(610, 86);
            this.DGVcomposJournaux.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(179, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Journaux:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.TCobjedts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSJounal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComps)).EndInit();
            this.TCobjedts.ResumeLayout(false);
            this.Articles.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVarticles)).EndInit();
            this.TLPNewspaperInputs.ResumeLayout(false);
            this.FLPNewspappersBTN.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.newspappers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewspappers)).EndInit();
            this.TLPinputs.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.compositions.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVnotIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcomposJournaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScomposIsIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScomposNotIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BScomposJournaux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource BSArticle;
        private BindingSource BSJounal;
        private BindingSource BSComps;
        private TabControl TCobjedts;
        private TabPage Articles;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DGVarticles;
        private TabPage newspappers;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView DGVNewspappers;
        private TableLayoutPanel TLPinputs;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BTcreateNewspapper;
        private Button BTreadNewspappers;
        private Button BTupdateNewspapper;
        private Button BTdeleteNewspapper;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LBtitre;
        private Label LBdate;
        private TextBox TXTitreJournal;
        private TabPage compositions;
        private DateTimePicker DTParutionJournal;
        private TableLayoutPanel TLPNewspaperInputs;
        private FlowLayoutPanel FLPNewspappersBTN;
        private Button BTcreateArticle;
        private Button BTreadArticle;
        private Button BTupdateArticle;
        private Button BTdeleteArticle;
        private TableLayoutPanel tableLayoutPanel4;
        private Label LBcorpsArticle;
        private Label LBauteurArticle;
        private TextBox TXTtitre;
        private TextBox TXTcorps;
        private TextBox TXTauteur;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView DGVnotIn;
        private DataGridView DGVisIn;
        private Label LBtitreArticle;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button BTexcure;
        private Button BTinclure;
        private Button BTactualiserCompos;
        private Label LBinclu;
        private Label LBexclus;
        private DataGridView DGVcomposJournaux;
        private Label label1;
        private BindingSource BScomposIsIn;
        private BindingSource BScomposNotIn;
        private BindingSource BScomposJournaux;
    }
}