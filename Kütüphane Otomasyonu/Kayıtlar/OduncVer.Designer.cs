
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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı TC Giriniz :";
            // 
            // textBoxTcBul
            // 
            this.textBoxTcBul.Location = new System.Drawing.Point(12, 28);
            this.textBoxTcBul.Name = "textBoxTcBul";
            this.textBoxTcBul.Size = new System.Drawing.Size(202, 20);
            this.textBoxTcBul.TabIndex = 2;
            // 
            // buttonBul
            // 
            this.buttonBul.BackColor = System.Drawing.Color.Lime;
            this.buttonBul.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBul.ForeColor = System.Drawing.Color.White;
            this.buttonBul.Location = new System.Drawing.Point(12, 63);
            this.buttonBul.Name = "buttonBul";
            this.buttonBul.Size = new System.Drawing.Size(202, 39);
            this.buttonBul.TabIndex = 3;
            this.buttonBul.Text = "BUL";
            this.buttonBul.UseVisualStyleBackColor = false;
            this.buttonBul.Click += new System.EventHandler(this.buttonBul_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(247, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(365, 196);
            this.dataGridView2.TabIndex = 5;
            // 
            // textBoxFiltrele
            // 
            this.textBoxFiltrele.Location = new System.Drawing.Point(339, 9);
            this.textBoxFiltrele.Name = "textBoxFiltrele";
            this.textBoxFiltrele.Size = new System.Drawing.Size(272, 20);
            this.textBoxFiltrele.TabIndex = 6;
            this.textBoxFiltrele.TextChanged += new System.EventHandler(this.textBoxFiltrele_TextChanged);
            // 
            // buttonOduncVer
            // 
            this.buttonOduncVer.BackColor = System.Drawing.Color.Teal;
            this.buttonOduncVer.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOduncVer.ForeColor = System.Drawing.Color.White;
            this.buttonOduncVer.Location = new System.Drawing.Point(628, 9);
            this.buttonOduncVer.Name = "buttonOduncVer";
            this.buttonOduncVer.Size = new System.Drawing.Size(122, 223);
            this.buttonOduncVer.TabIndex = 7;
            this.buttonOduncVer.Text = "ÖDÜNÇ VER";
            this.buttonOduncVer.UseVisualStyleBackColor = false;
            this.buttonOduncVer.Click += new System.EventHandler(this.buttonOduncVer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kaynak Ara :";
            // 
            // OduncVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(759, 447);
            this.Controls.Add(this.label3);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label3;
    }
}