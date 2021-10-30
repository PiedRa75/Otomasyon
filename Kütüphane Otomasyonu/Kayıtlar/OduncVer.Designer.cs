
namespace Kütüphane_Otomasyonu
{
    partial class OduncVer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTcBul = new System.Windows.Forms.TextBox();
            this.buttonBul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxFiltrele = new System.Windows.Forms.TextBox();
            this.buttonOduncVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı TC Giriniz :";
            // 
            // textBoxTcBul
            // 
            this.textBoxTcBul.Location = new System.Drawing.Point(125, 12);
            this.textBoxTcBul.Name = "textBoxTcBul";
            this.textBoxTcBul.Size = new System.Drawing.Size(145, 20);
            this.textBoxTcBul.TabIndex = 2;
            // 
            // buttonBul
            // 
            this.buttonBul.Location = new System.Drawing.Point(287, 10);
            this.buttonBul.Name = "buttonBul";
            this.buttonBul.Size = new System.Drawing.Size(75, 23);
            this.buttonBul.TabIndex = 3;
            this.buttonBul.Text = "BUL";
            this.buttonBul.UseVisualStyleBackColor = true;
            this.buttonBul.Click += new System.EventHandler(this.buttonBul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(403, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(384, 142);
            this.dataGridView2.TabIndex = 5;
            // 
            // textBoxFiltrele
            // 
            this.textBoxFiltrele.Location = new System.Drawing.Point(652, 15);
            this.textBoxFiltrele.Name = "textBoxFiltrele";
            this.textBoxFiltrele.Size = new System.Drawing.Size(135, 20);
            this.textBoxFiltrele.TabIndex = 6;
            this.textBoxFiltrele.TextChanged += new System.EventHandler(this.textBoxFiltrele_TextChanged);
            // 
            // buttonOduncVer
            // 
            this.buttonOduncVer.Location = new System.Drawing.Point(125, 60);
            this.buttonOduncVer.Name = "buttonOduncVer";
            this.buttonOduncVer.Size = new System.Drawing.Size(145, 66);
            this.buttonOduncVer.TabIndex = 7;
            this.buttonOduncVer.Text = "ÖDÜNÇ VER";
            this.buttonOduncVer.UseVisualStyleBackColor = true;
            this.buttonOduncVer.Click += new System.EventHandler(this.buttonOduncVer_Click);
            // 
            // OduncVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 393);
            this.Controls.Add(this.buttonOduncVer);
            this.Controls.Add(this.textBoxFiltrele);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBul);
            this.Controls.Add(this.textBoxTcBul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OduncVer";
            this.Text = "OduncVer";
            this.Load += new System.EventHandler(this.OduncVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTcBul;
        private System.Windows.Forms.Button buttonBul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxFiltrele;
        private System.Windows.Forms.Button buttonOduncVer;
    }
}