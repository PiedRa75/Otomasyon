
namespace Kütüphane_Otomasyonu
{
    partial class KaynakGüncelle
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
            this.buttonKaynakGüncelle = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxYayinciKaynak = new System.Windows.Forms.TextBox();
            this.textBoxYazarKaynak = new System.Windows.Forms.TextBox();
            this.textBoxAdKaynak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKaynakGüncelle
            // 
            this.buttonKaynakGüncelle.Location = new System.Drawing.Point(83, 199);
            this.buttonKaynakGüncelle.Name = "buttonKaynakGüncelle";
            this.buttonKaynakGüncelle.Size = new System.Drawing.Size(100, 34);
            this.buttonKaynakGüncelle.TabIndex = 22;
            this.buttonKaynakGüncelle.Text = "GÜNCELLE";
            this.buttonKaynakGüncelle.UseVisualStyleBackColor = true;
            this.buttonKaynakGüncelle.Click += new System.EventHandler(this.buttonKaynakGüncelle_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // textBoxYayinciKaynak
            // 
            this.textBoxYayinciKaynak.Location = new System.Drawing.Point(83, 79);
            this.textBoxYayinciKaynak.Name = "textBoxYayinciKaynak";
            this.textBoxYayinciKaynak.Size = new System.Drawing.Size(100, 20);
            this.textBoxYayinciKaynak.TabIndex = 19;
            // 
            // textBoxYazarKaynak
            // 
            this.textBoxYazarKaynak.Location = new System.Drawing.Point(83, 43);
            this.textBoxYazarKaynak.Name = "textBoxYazarKaynak";
            this.textBoxYazarKaynak.Size = new System.Drawing.Size(100, 20);
            this.textBoxYazarKaynak.TabIndex = 18;
            // 
            // textBoxAdKaynak
            // 
            this.textBoxAdKaynak.Location = new System.Drawing.Point(83, 12);
            this.textBoxAdKaynak.Name = "textBoxAdKaynak";
            this.textBoxAdKaynak.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdKaynak.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Basım Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Yayıncı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yazar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 375);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // KaynakGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonKaynakGüncelle);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxYayinciKaynak);
            this.Controls.Add(this.textBoxYazarKaynak);
            this.Controls.Add(this.textBoxAdKaynak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KaynakGüncelle";
            this.Text = "KaynakGüncelle";
            this.Load += new System.EventHandler(this.KaynakGüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaynakGüncelle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxYayinciKaynak;
        private System.Windows.Forms.TextBox textBoxYazarKaynak;
        private System.Windows.Forms.TextBox textBoxAdKaynak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}