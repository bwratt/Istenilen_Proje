namespace Istenilen_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.düzenleBtn = new System.Windows.Forms.Button();
            this.kolusturBtn = new System.Windows.Forms.Button();
            this.listBtn = new System.Windows.Forms.Button();
            this.araBtn = new System.Windows.Forms.Button();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.düzenleBtn);
            this.groupBox1.Controls.Add(this.kolusturBtn);
            this.groupBox1.Controls.Add(this.listBtn);
            this.groupBox1.Controls.Add(this.araBtn);
            this.groupBox1.Controls.Add(this.aratxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 263);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 153);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // düzenleBtn
            // 
            this.düzenleBtn.BackColor = System.Drawing.Color.Blue;
            this.düzenleBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.düzenleBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.düzenleBtn.Location = new System.Drawing.Point(264, 229);
            this.düzenleBtn.Name = "düzenleBtn";
            this.düzenleBtn.Size = new System.Drawing.Size(98, 23);
            this.düzenleBtn.TabIndex = 47;
            this.düzenleBtn.Text = "DÜZENLE";
            this.düzenleBtn.UseVisualStyleBackColor = false;
            this.düzenleBtn.Click += new System.EventHandler(this.düzenleBtn_Click);
            // 
            // kolusturBtn
            // 
            this.kolusturBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kolusturBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolusturBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kolusturBtn.Location = new System.Drawing.Point(369, 229);
            this.kolusturBtn.Name = "kolusturBtn";
            this.kolusturBtn.Size = new System.Drawing.Size(164, 23);
            this.kolusturBtn.TabIndex = 46;
            this.kolusturBtn.Text = "YENİ KİŞİ OLUŞTUR";
            this.kolusturBtn.UseVisualStyleBackColor = false;
            this.kolusturBtn.Click += new System.EventHandler(this.kolusturBtn_Click);
            // 
            // listBtn
            // 
            this.listBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBtn.Location = new System.Drawing.Point(461, 27);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(72, 23);
            this.listBtn.TabIndex = 45;
            this.listBtn.Text = "LİSTELE";
            this.listBtn.UseVisualStyleBackColor = false;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // araBtn
            // 
            this.araBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.araBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.araBtn.Location = new System.Drawing.Point(380, 27);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(75, 23);
            this.araBtn.TabIndex = 43;
            this.araBtn.Text = "ARA";
            this.araBtn.UseVisualStyleBackColor = false;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // aratxt
            // 
            this.aratxt.Location = new System.Drawing.Point(45, 30);
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(233, 20);
            this.aratxt.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(596, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kişi Ekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button düzenleBtn;
        private System.Windows.Forms.Button kolusturBtn;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox aratxt;
    }
}

