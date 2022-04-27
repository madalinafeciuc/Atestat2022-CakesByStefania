
namespace Atestat_2022_Cofetarie
{
    partial class Comenzi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comenziDataSet = new Atestat_2022_Cofetarie.ComenziDataSet();
            this.comenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comenziTableAdapter = new Atestat_2022_Cofetarie.ComenziDataSetTableAdapters.ComenziTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeprajituraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrbucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atestat_2022_Cofetarie.Properties.Resources.logo_pers;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.numeprajituraDataGridViewTextBoxColumn,
            this.nrbucDataGridViewTextBoxColumn,
            this.observatiiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comenziBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 541);
            this.dataGridView1.TabIndex = 1;
            // 
            // comenziDataSet
            // 
            this.comenziDataSet.DataSetName = "ComenziDataSet";
            this.comenziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comenziBindingSource
            // 
            this.comenziBindingSource.DataMember = "Comenzi";
            this.comenziBindingSource.DataSource = this.comenziDataSet;
            // 
            // comenziTableAdapter
            // 
            this.comenziTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 160;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.Width = 160;
            // 
            // numeprajituraDataGridViewTextBoxColumn
            // 
            this.numeprajituraDataGridViewTextBoxColumn.DataPropertyName = "Nume_prajitura";
            this.numeprajituraDataGridViewTextBoxColumn.HeaderText = "Nume_prajitura";
            this.numeprajituraDataGridViewTextBoxColumn.Name = "numeprajituraDataGridViewTextBoxColumn";
            this.numeprajituraDataGridViewTextBoxColumn.Width = 150;
            // 
            // nrbucDataGridViewTextBoxColumn
            // 
            this.nrbucDataGridViewTextBoxColumn.DataPropertyName = "Nr_buc";
            this.nrbucDataGridViewTextBoxColumn.HeaderText = "Nr_buc";
            this.nrbucDataGridViewTextBoxColumn.Name = "nrbucDataGridViewTextBoxColumn";
            this.nrbucDataGridViewTextBoxColumn.Width = 50;
            // 
            // observatiiDataGridViewTextBoxColumn
            // 
            this.observatiiDataGridViewTextBoxColumn.DataPropertyName = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.HeaderText = "Observatii";
            this.observatiiDataGridViewTextBoxColumn.Name = "observatiiDataGridViewTextBoxColumn";
            this.observatiiDataGridViewTextBoxColumn.Width = 240;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(704, 60);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(148, 42);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Inapoi";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(864, 701);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Comenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comenzi";
            this.Load += new System.EventHandler(this.Comenzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComenziDataSet comenziDataSet;
        private System.Windows.Forms.BindingSource comenziBindingSource;
        private ComenziDataSetTableAdapters.ComenziTableAdapter comenziTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeprajituraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrbucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observatiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back_btn;
    }
}