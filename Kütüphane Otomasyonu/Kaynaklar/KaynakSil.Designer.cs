
namespace Kütüphane_Otomasyonu
{
    partial class KaynakSil
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
            this.buttonSilKaynak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSilKaynak
            // 
            this.buttonSilKaynak.BackColor = System.Drawing.Color.Red;
            this.buttonSilKaynak.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSilKaynak.ForeColor = System.Drawing.Color.White;
            this.buttonSilKaynak.Location = new System.Drawing.Point(28, 12);
            this.buttonSilKaynak.Name = "buttonSilKaynak";
            this.buttonSilKaynak.Size = new System.Drawing.Size(705, 60);
            this.buttonSilKaynak.TabIndex = 1;
            this.buttonSilKaynak.Text = "SİL";
            this.buttonSilKaynak.UseVisualStyleBackColor = false;
            this.buttonSilKaynak.Click += new System.EventHandler(this.buttonSilKaynak_Click);
            // 
            // KaynakSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(759, 447);
            this.Controls.Add(this.buttonSilKaynak);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KaynakSil";
            this.Text = "KaynakSil";
            this.Load += new System.EventHandler(this.KaynakSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSilKaynak;
    }
}