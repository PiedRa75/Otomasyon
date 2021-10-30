
namespace Kütüphane_Otomasyonu
{
    partial class GeriAl
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
            this.buttonGeriAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonGeriAl
            // 
            this.buttonGeriAl.Location = new System.Drawing.Point(12, 12);
            this.buttonGeriAl.Name = "buttonGeriAl";
            this.buttonGeriAl.Size = new System.Drawing.Size(148, 109);
            this.buttonGeriAl.TabIndex = 1;
            this.buttonGeriAl.Text = "Geri Al";
            this.buttonGeriAl.UseVisualStyleBackColor = true;
            this.buttonGeriAl.Click += new System.EventHandler(this.buttonGeriAl_Click);
            // 
            // GeriAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 386);
            this.Controls.Add(this.buttonGeriAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GeriAl";
            this.Text = "GeriAl";
            this.Load += new System.EventHandler(this.GeriAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGeriAl;
    }
}