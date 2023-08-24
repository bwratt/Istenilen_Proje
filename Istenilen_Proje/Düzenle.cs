using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Istenilen_Proje
{
    public partial class Düzenle : Form
    {
        public Düzenle(Form1 form1)
        {
            InitializeComponent();
        }

        public Düzenle()
        {
        }

        Form1 form1 = System.Windows.Forms.Application.OpenForms["Form1"] as Form1;
        public void DataGridViewiGuncelle()
        {
            
            form1.dataGridView1.DataSource = null;
            form1.dataGridView1.Rows.Clear();

           
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "SELECT * FROM Kisiler";
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            form1.dataGridView1.DataSource = dataTable;
            bag.Close();
        }

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=veritabanı.mdb");
        OleDbCommand komut = new OleDbCommand();

        DataTable veritablosu = new DataTable();
        internal void SetVeriler(string isim, string soyisim, string telefon)
        {
            isimTxt.Text = isim;
            soyisimTxt.Text = soyisim;
            telTxt.Text = telefon;
            
        }


        private void düzenleBtn_Click(object sender, EventArgs e)
        {
            
        }

       

        private void silBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult onay;
            onay = MessageBox.Show("Bu kişiyi silmek istediğinize emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                
                string seciliTelefon = form1.dataGridView1.SelectedRows[0].Cells["Telefon"].Value.ToString();

               
                bag.Open();
                komut.Connection = bag;
                komut.CommandText = "DELETE FROM Kisiler WHERE Telefon = @Telefon";
                komut.Parameters.AddWithValue("@Telefon", seciliTelefon);
                komut.ExecuteNonQuery();
                bag.Close();

                MessageBox.Show("Kişi silindi!");

                

                DataGridViewiGuncelle();

                this.Close();
            }
            }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string yeniIsim = isimTxt.Text;
                string yeniSoyisim = soyisimTxt.Text;
                string yeniTelefon = telTxt.Text;

                

                if (form1 != null)
                {
                    DialogResult onay;
                    onay = MessageBox.Show("Bu işlemi yapmak istediğinize emin misiniz? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                        if (form1.dataGridView1.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = form1.dataGridView1.SelectedRows[0];
                            int seciliSatirIndex = selectedRow.Index;

                            
                            selectedRow.Cells["Isim"].Value = yeniIsim;
                            selectedRow.Cells["Soyisim"].Value = yeniSoyisim;
                            selectedRow.Cells["Telefon"].Value = yeniTelefon;

                            if (String.IsNullOrWhiteSpace(yeniIsim) || String.IsNullOrWhiteSpace(yeniSoyisim) || String.IsNullOrWhiteSpace(yeniTelefon))
                            {
                                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;  
                            }
                            if (yeniTelefon.Length != 10 || !yeniTelefon.All(char.IsDigit))
                            {
                                MessageBox.Show("Telefon numarası 10 adet rakam içermeli.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }


                            bag.Open();
                            komut.Connection = bag;
                            komut.CommandText = "UPDATE Kisiler SET Isim = @YeniIsim, Soyisim = @YeniSoyisim, Telefon = @YeniTelefon  WHERE Telefon = @Telefon";
                            komut.Parameters.AddWithValue("@YeniIsim", yeniIsim);
                            komut.Parameters.AddWithValue("@YeniSoyisim", yeniSoyisim);
                            komut.Parameters.AddWithValue("@YeniTelefon", yeniTelefon);
                            komut.Parameters.AddWithValue("@Telefon", yeniTelefon);
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kişi Güncellendi!");
                            bag.Close();

                            // Form3'ü kapatın
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void isimTxt_TextChanged(object sender, EventArgs e)
        {
            string isim = isimTxt.Text.Trim();

            if (String.IsNullOrWhiteSpace(isim))
            {
                Validasyon1.Text = "İsim alanı boş bırakılamaz";
                Validasyon1.Visible = true;
            }
            else
            {
                Validasyon1.Visible = false;
            }
        }

        private void telTxt_TextChanged(object sender, EventArgs e)
        {
            if (telTxt.Text.StartsWith("0"))
            {
                telTxt.Text = "";
            }

            if (telTxt.Text.Length > 10)
            {
                telTxt.Text = telTxt.Text.Substring(0, 10);
                telTxt.SelectionStart = telTxt.Text.Length;
            }

            string telefon = telTxt.Text.Trim();

            if (String.IsNullOrWhiteSpace(telefon))
            {
                Validasyon3.Text = "Telefon alanı boş bırakılamaz";
                Validasyon3.Visible = true;
            }
            else
            {
                Validasyon3.Visible = false;
            }
        }

        private void soyisimTxt_TextChanged(object sender, EventArgs e)
        {
            string soyisim = soyisimTxt.Text.Trim();

            if (String.IsNullOrWhiteSpace(soyisim))
            {
                Validasyon2.Text = "Soyisim alanı boş bırakılamaz";
                Validasyon2.Visible = true;
            }
            else
            {
                Validasyon2.Visible = false;
            }
        }

        private void telTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void soyisimTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void isimTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }

