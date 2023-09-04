namespace WinFormsApp1
{
    partial class journaux
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVjournaux = new System.Windows.Forms.DataGridView();
            this.TLPjournal_champs = new System.Windows.Forms.TableLayoutPanel();
            this.LBnum = new System.Windows.Forms.Label();
            this.LBtitre = new System.Windows.Forms.Label();
            this.LBdate = new System.Windows.Forms.Label();
            this.TXTtitre = new System.Windows.Forms.TextBox();
            this.DTPdate = new System.Windows.Forms.DateTimePicker();
            this.NUDid = new System.Windows.Forms.NumericUpDown();
            this.BSnewspaper = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVjournaux)).BeginInit();
            this.TLPjournal_champs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSnewspaper)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGVjournaux, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TLPjournal_champs, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.88406F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.11594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVjournaux
            // 
            this.DGVjournaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVjournaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVjournaux.Location = new System.Drawing.Point(3, 3);
            this.DGVjournaux.Name = "DGVjournaux";
            this.DGVjournaux.RowTemplate.Height = 25;
            this.DGVjournaux.Size = new System.Drawing.Size(794, 151);
            this.DGVjournaux.TabIndex = 0;
            // 
            // TLPjournal_champs
            // 
            this.TLPjournal_champs.ColumnCount = 2;
            this.TLPjournal_champs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.11335F));
            this.TLPjournal_champs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.88665F));
            this.TLPjournal_champs.Controls.Add(this.LBnum, 0, 0);
            this.TLPjournal_champs.Controls.Add(this.LBtitre, 0, 1);
            this.TLPjournal_champs.Controls.Add(this.LBdate, 0, 2);
            this.TLPjournal_champs.Controls.Add(this.TXTtitre, 1, 1);
            this.TLPjournal_champs.Controls.Add(this.DTPdate, 1, 2);
            this.TLPjournal_champs.Controls.Add(this.NUDid, 1, 0);
            this.TLPjournal_champs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPjournal_champs.Location = new System.Drawing.Point(3, 160);
            this.TLPjournal_champs.Name = "TLPjournal_champs";
            this.TLPjournal_champs.RowCount = 3;
            this.TLPjournal_champs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPjournal_champs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPjournal_champs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TLPjournal_champs.Size = new System.Drawing.Size(794, 113);
            this.TLPjournal_champs.TabIndex = 1;
            // 
            // LBnum
            // 
            this.LBnum.AutoSize = true;
            this.LBnum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBnum.Location = new System.Drawing.Point(3, 0);
            this.LBnum.Name = "LBnum";
            this.LBnum.Size = new System.Drawing.Size(114, 37);
            this.LBnum.TabIndex = 0;
            this.LBnum.Text = "Numéro";
            this.LBnum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBtitre
            // 
            this.LBtitre.AutoSize = true;
            this.LBtitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBtitre.Location = new System.Drawing.Point(3, 37);
            this.LBtitre.Name = "LBtitre";
            this.LBtitre.Size = new System.Drawing.Size(114, 37);
            this.LBtitre.TabIndex = 1;
            this.LBtitre.Text = "Titre";
            this.LBtitre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBdate
            // 
            this.LBdate.AutoSize = true;
            this.LBdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBdate.Location = new System.Drawing.Point(3, 74);
            this.LBdate.Name = "LBdate";
            this.LBdate.Size = new System.Drawing.Size(114, 39);
            this.LBdate.TabIndex = 2;
            this.LBdate.Text = "date de parution";
            this.LBdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TXTtitre
            // 
            this.TXTtitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTtitre.Location = new System.Drawing.Point(123, 40);
            this.TXTtitre.Name = "TXTtitre";
            this.TXTtitre.Size = new System.Drawing.Size(668, 23);
            this.TXTtitre.TabIndex = 3;
            // 
            // DTPdate
            // 
            this.DTPdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPdate.Location = new System.Drawing.Point(123, 77);
            this.DTPdate.Name = "DTPdate";
            this.DTPdate.Size = new System.Drawing.Size(668, 23);
            this.DTPdate.TabIndex = 4;
            // 
            // NUDid
            // 
            this.NUDid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDid.Location = new System.Drawing.Point(123, 3);
            this.NUDid.Name = "NUDid";
            this.NUDid.Size = new System.Drawing.Size(668, 23);
            this.NUDid.TabIndex = 5;
            // 
            // journaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "journaux";
            this.Text = "Les journaux";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVjournaux)).EndInit();
            this.TLPjournal_champs.ResumeLayout(false);
            this.TLPjournal_champs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSnewspaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DGVjournaux;
        private TableLayoutPanel TLPjournal_champs;
        private Label LBnum;
        private Label LBtitre;
        private Label LBdate;
        private TextBox TXTtitre;
        private DateTimePicker DTPdate;
        private NumericUpDown NUDid;
        private BindingSource BSnewspaper;
    }
}