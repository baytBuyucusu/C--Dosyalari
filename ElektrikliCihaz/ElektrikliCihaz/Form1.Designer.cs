namespace ElektrikliCihaz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCihazAdi = new System.Windows.Forms.TextBox();
            this.txtCihazGucu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanilanSaat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblAylikTuketim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cihaz Adı";
            // 
            // txtCihazAdi
            // 
            this.txtCihazAdi.Location = new System.Drawing.Point(194, 29);
            this.txtCihazAdi.Name = "txtCihazAdi";
            this.txtCihazAdi.Size = new System.Drawing.Size(184, 26);
            this.txtCihazAdi.TabIndex = 1;
            // 
            // txtCihazGucu
            // 
            this.txtCihazGucu.Location = new System.Drawing.Point(194, 61);
            this.txtCihazGucu.Name = "txtCihazGucu";
            this.txtCihazGucu.Size = new System.Drawing.Size(184, 26);
            this.txtCihazGucu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cihaz Gücü";
            // 
            // txtKullanilanSaat
            // 
            this.txtKullanilanSaat.Location = new System.Drawing.Point(194, 93);
            this.txtKullanilanSaat.Name = "txtKullanilanSaat";
            this.txtKullanilanSaat.Size = new System.Drawing.Size(184, 26);
            this.txtKullanilanSaat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanılan Saati";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(194, 136);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(184, 43);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblAylikTuketim
            // 
            this.lblAylikTuketim.AutoSize = true;
            this.lblAylikTuketim.Location = new System.Drawing.Point(59, 216);
            this.lblAylikTuketim.Name = "lblAylikTuketim";
            this.lblAylikTuketim.Size = new System.Drawing.Size(105, 20);
            this.lblAylikTuketim.TabIndex = 7;
            this.lblAylikTuketim.Text = "Aylık Tüketim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(495, 306);
            this.Controls.Add(this.lblAylikTuketim);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKullanilanSaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCihazGucu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCihazAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCihazAdi;
        private System.Windows.Forms.TextBox txtCihazGucu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullanilanSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblAylikTuketim;
    }
}

