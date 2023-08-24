namespace Istenilen_Proje
{
    partial class Düzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Düzenle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.silBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soyisimTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isimTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Validasyon3 = new System.Windows.Forms.Label();
            this.Validasyon2 = new System.Windows.Forms.Label();
            this.Validasyon1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Red;
            this.silBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.silBtn.Location = new System.Drawing.Point(348, 178);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(70, 23);
            this.silBtn.TabIndex = 68;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click_1);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kaydetBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kaydetBtn.Location = new System.Drawing.Point(447, 178);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(70, 23);
            this.kaydetBtn.TabIndex = 67;
            this.kaydetBtn.Text = "KAYDET";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // telTxt
            // 
            this.telTxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telTxt.Location = new System.Drawing.Point(348, 138);
            this.telTxt.Multiline = true;
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(169, 20);
            this.telTxt.TabIndex = 64;
            this.telTxt.TextChanged += new System.EventHandler(this.telTxt_TextChanged);
            this.telTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(273, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "TELEFON NO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // soyisimTxt
            // 
            this.soyisimTxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisimTxt.Location = new System.Drawing.Point(348, 94);
            this.soyisimTxt.Multiline = true;
            this.soyisimTxt.Name = "soyisimTxt";
            this.soyisimTxt.Size = new System.Drawing.Size(169, 20);
            this.soyisimTxt.TabIndex = 62;
            this.soyisimTxt.TextChanged += new System.EventHandler(this.soyisimTxt_TextChanged);
            this.soyisimTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyisimTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(273, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "SOYİSİM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // isimTxt
            // 
            this.isimTxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimTxt.Location = new System.Drawing.Point(348, 54);
            this.isimTxt.Multiline = true;
            this.isimTxt.Name = "isimTxt";
            this.isimTxt.Size = new System.Drawing.Size(169, 20);
            this.isimTxt.TabIndex = 60;
            this.isimTxt.TextChanged += new System.EventHandler(this.isimTxt_TextChanged);
            this.isimTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isimTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(273, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "İSİM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Validasyon3);
            this.groupBox1.Controls.Add(this.Validasyon2);
            this.groupBox1.Controls.Add(this.Validasyon1);
            this.groupBox1.Controls.Add(this.isimTxt);
            this.groupBox1.Controls.Add(this.kaydetBtn);
            this.groupBox1.Controls.Add(this.silBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.telTxt);
            this.groupBox1.Controls.Add(this.soyisimTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(22, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 266);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DÜZENLE";
            // 
            // Validasyon3
            // 
            this.Validasyon3.AutoSize = true;
            this.Validasyon3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Validasyon3.Location = new System.Drawing.Point(345, 161);
            this.Validasyon3.Name = "Validasyon3";
            this.Validasyon3.Size = new System.Drawing.Size(66, 14);
            this.Validasyon3.TabIndex = 71;
            this.Validasyon3.Text = "Validasyon3";
            // 
            // Validasyon2
            // 
            this.Validasyon2.AutoSize = true;
            this.Validasyon2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Validasyon2.Location = new System.Drawing.Point(345, 117);
            this.Validasyon2.Name = "Validasyon2";
            this.Validasyon2.Size = new System.Drawing.Size(66, 14);
            this.Validasyon2.TabIndex = 70;
            this.Validasyon2.Text = "Validasyon2";
            // 
            // Validasyon1
            // 
            this.Validasyon1.AutoSize = true;
            this.Validasyon1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Validasyon1.Location = new System.Drawing.Point(345, 77);
            this.Validasyon1.Name = "Validasyon1";
            this.Validasyon1.Size = new System.Drawing.Size(66, 14);
            this.Validasyon1.TabIndex = 69;
            this.Validasyon1.Text = "Validasyon1";
            // 
            // Düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(596, 285);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Düzenle";
            this.Text = "Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyisimTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isimTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Validasyon3;
        private System.Windows.Forms.Label Validasyon2;
        private System.Windows.Forms.Label Validasyon1;
        private System.Windows.Forms.Button kaydetBtn;
    }
}