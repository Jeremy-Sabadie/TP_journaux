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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVjournaux = new System.Windows.Forms.DataGridView();
            this.TLPjournal_champs = new System.Windows.Forms.TableLayoutPanel();
            this.LBtitre = new System.Windows.Forms.Label();
            this.LBdate = new System.Windows.Forms.Label();
            this.TXTtitre = new System.Windows.Forms.TextBox();
            this.DTPdate = new System.Windows.Forms.DateTimePicker();
            this.FLPbuttons = new System.Windows.Forms.FlowLayoutPanel();
            this.BBTNcreateNewspaper = new System.Windows.Forms.Button();
            this.BTNreadNewspaper = new System.Windows.Forms.Button();
            this.BTupdate = new System.Windows.Forms.Button();
            this.BTNdeleteNewspaper = new System.Windows.Forms.Button();
            this.BSnewspaper = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVjournaux)).BeginInit();
            this.TLPjournal_champs.SuspendLayout();
            this.FLPbuttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSnewspaper)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGVjournaux, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TLPjournal_champs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FLPbuttons, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.88406F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.11594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVjournaux
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVjournaux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVjournaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVjournaux.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVjournaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVjournaux.Location = new System.Drawing.Point(3, 3);
            this.DGVjournaux.Name = "DGVjournaux";
            this.DGVjournaux.RowTemplate.Height = 25;
            this.DGVjournaux.Size = new System.Drawing.Size(794, 169);
            this.DGVjournaux.TabIndex = 0;
            // 
            // TLPjournal_champs
            // 
            this.TLPjournal_champs.ColumnCount = 2;
            this.TLPjournal_champs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.11335F));
            this.TLPjournal_champs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.88665F));
            this.TLPjournal_champs.Controls.Add(this.LBtitre, 0, 1);
            this.TLPjournal_champs.Controls.Add(this.LBdate, 0, 2);
            this.TLPjournal_champs.Controls.Add(this.TXTtitre, 1, 1);
            this.TLPjournal_champs.Controls.Add(this.DTPdate, 1, 2);
            this.TLPjournal_champs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPjournal_champs.Location = new System.Drawing.Point(3, 178);
            this.TLPjournal_champs.Name = "TLPjournal_champs";
            this.TLPjournal_champs.RowCount = 3;
            this.TLPjournal_champs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.48352F));
            this.TLPjournal_champs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.51649F));
            this.TLPjournal_champs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TLPjournal_champs.Size = new System.Drawing.Size(794, 126);
            this.TLPjournal_champs.TabIndex = 1;
            // 
            // LBtitre
            // 
            this.LBtitre.AutoSize = true;
            this.LBtitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBtitre.Location = new System.Drawing.Point(3, 7);
            this.LBtitre.Name = "LBtitre";
            this.LBtitre.Size = new System.Drawing.Size(114, 40);
            this.LBtitre.TabIndex = 1;
            this.LBtitre.Text = "Titre";
            this.LBtitre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBdate
            // 
            this.LBdate.AutoSize = true;
            this.LBdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBdate.Location = new System.Drawing.Point(3, 47);
            this.LBdate.Name = "LBdate";
            this.LBdate.Size = new System.Drawing.Size(114, 79);
            this.LBdate.TabIndex = 2;
            this.LBdate.Text = "date de parution";
            this.LBdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TXTtitre
            // 
            this.TXTtitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTtitre.Location = new System.Drawing.Point(123, 10);
            this.TXTtitre.Name = "TXTtitre";
            this.TXTtitre.Size = new System.Drawing.Size(668, 23);
            this.TXTtitre.TabIndex = 3;
            // 
            // DTPdate
            // 
            this.DTPdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPdate.Location = new System.Drawing.Point(123, 50);
            this.DTPdate.Name = "DTPdate";
            this.DTPdate.Size = new System.Drawing.Size(668, 23);
            this.DTPdate.TabIndex = 4;
            // 
            // FLPbuttons
            // 
            this.FLPbuttons.Controls.Add(this.BBTNcreateNewspaper);
            this.FLPbuttons.Controls.Add(this.BTNreadNewspaper);
            this.FLPbuttons.Controls.Add(this.BTupdate);
            this.FLPbuttons.Controls.Add(this.BTNdeleteNewspaper);
            this.FLPbuttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPbuttons.Location = new System.Drawing.Point(3, 310);
            this.FLPbuttons.Name = "FLPbuttons";
            this.FLPbuttons.Size = new System.Drawing.Size(794, 137);
            this.FLPbuttons.TabIndex = 2;
            // 
            // BBTNcreateNewspaper
            // 
            this.BBTNcreateNewspaper.Location = new System.Drawing.Point(3, 3);
            this.BBTNcreateNewspaper.Name = "BBTNcreateNewspaper";
            this.BBTNcreateNewspaper.Size = new System.Drawing.Size(103, 49);
            this.BBTNcreateNewspaper.TabIndex = 0;
            this.BBTNcreateNewspaper.Text = "Create";
            this.BBTNcreateNewspaper.UseVisualStyleBackColor = true;
            this.BBTNcreateNewspaper.Click += new System.EventHandler(this.BBTNcreateNewspaper_Click);
            // 
            // BTNreadNewspaper
            // 
            this.BTNreadNewspaper.Location = new System.Drawing.Point(112, 3);
            this.BTNreadNewspaper.Name = "BTNreadNewspaper";
            this.BTNreadNewspaper.Size = new System.Drawing.Size(102, 49);
            this.BTNreadNewspaper.TabIndex = 1;
            this.BTNreadNewspaper.Text = "Read";
            this.BTNreadNewspaper.UseVisualStyleBackColor = true;
            this.BTNreadNewspaper.Click += new System.EventHandler(this.BTNreadNewspaper_Click);
            // 
            // BTupdate
            // 
            this.BTupdate.Location = new System.Drawing.Point(220, 3);
            this.BTupdate.Name = "BTupdate";
            this.BTupdate.Size = new System.Drawing.Size(106, 49);
            this.BTupdate.TabIndex = 2;
            this.BTupdate.Text = "Update";
            this.BTupdate.UseVisualStyleBackColor = true;
            this.BTupdate.Click += new System.EventHandler(this.BTupdate_Click);
            // 
            // BTNdeleteNewspaper
            // 
            this.BTNdeleteNewspaper.Location = new System.Drawing.Point(332, 3);
            this.BTNdeleteNewspaper.Name = "BTNdeleteNewspaper";
            this.BTNdeleteNewspaper.Size = new System.Drawing.Size(130, 49);
            this.BTNdeleteNewspaper.TabIndex = 3;
            this.BTNdeleteNewspaper.Text = "Delete";
            this.BTNdeleteNewspaper.UseVisualStyleBackColor = true;
            this.BTNdeleteNewspaper.Click += new System.EventHandler(this.BTNdeleteNewspaper_Click);
            // 
            // journaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "journaux";
            this.Text = "Les journaux";
            this.Load += new System.EventHandler(this.journaux_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVjournaux)).EndInit();
            this.TLPjournal_champs.ResumeLayout(false);
            this.TLPjournal_champs.PerformLayout();
            this.FLPbuttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BSnewspaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DGVjournaux;
        private TableLayoutPanel TLPjournal_champs;
        private Label LBtitre;
        private Label LBdate;
        private TextBox TXTtitre;
        private DateTimePicker DTPdate;
        private BindingSource BSnewspaper;
        private FlowLayoutPanel FLPbuttons;
        private Button BBTNcreateNewspaper;
        private Button BTNreadNewspaper;
        private Button BTupdate;
        private Button BTNdeleteNewspaper;
    }
}