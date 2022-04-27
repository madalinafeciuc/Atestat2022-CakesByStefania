
namespace Atestat_2022_Cofetarie
{
    partial class MainMenu
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
            this.cakes_btn = new System.Windows.Forms.Button();
            this.comenzi_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cakes_btn
            // 
            this.cakes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakes_btn.Location = new System.Drawing.Point(311, 442);
            this.cakes_btn.Name = "cakes_btn";
            this.cakes_btn.Size = new System.Drawing.Size(269, 51);
            this.cakes_btn.TabIndex = 1;
            this.cakes_btn.Text = "Meniu prajituri";
            this.cakes_btn.UseVisualStyleBackColor = true;
            this.cakes_btn.Click += new System.EventHandler(this.cakes_btn_Click);
            // 
            // comenzi_btn
            // 
            this.comenzi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comenzi_btn.Location = new System.Drawing.Point(311, 534);
            this.comenzi_btn.Name = "comenzi_btn";
            this.comenzi_btn.Size = new System.Drawing.Size(269, 51);
            this.comenzi_btn.TabIndex = 1;
            this.comenzi_btn.Text = "Comenzi";
            this.comenzi_btn.UseVisualStyleBackColor = true;
            this.comenzi_btn.Click += new System.EventHandler(this.comenzi_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(311, 620);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(269, 51);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Iesire";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atestat_2022_Cofetarie.Properties.Resources.logo_pers;
            this.pictureBox1.Location = new System.Drawing.Point(217, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(864, 701);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.comenzi_btn);
            this.Controls.Add(this.cakes_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cakes by Stefania";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cakes_btn;
        private System.Windows.Forms.Button comenzi_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

