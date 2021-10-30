
namespace Kütüphane_Otomasyonu
{
    partial class KullanıcıSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonKullaniciSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonKullaniciSil
            // 
            this.buttonKullaniciSil.Location = new System.Drawing.Point(12, 12);
            this.buttonKullaniciSil.Name = "buttonKullaniciSil";
            this.buttonKullaniciSil.Size = new System.Drawing.Size(776, 50);
            this.buttonKullaniciSil.TabIndex = 1;
            this.buttonKullaniciSil.Text = "SİL";
            this.buttonKullaniciSil.UseVisualStyleBackColor = true;
            this.buttonKullaniciSil.Click += new System.EventHandler(this.buttonKullaniciSil_Click);
            // 
            // KullanıcıSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKullaniciSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullanıcıSil";
            this.Text = "KullanıcıSil";
            this.Load += new System.EventHandler(this.KullanıcıSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKullaniciSil;
    }
}