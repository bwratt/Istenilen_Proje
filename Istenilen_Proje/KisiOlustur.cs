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


namespace Istenilen_Proje
{
    public partial class KisiOlustur : Form
    {
        public KisiOlustur()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=veritabanı.mdb");
        OleDbCommand komut = new OleDbCommand();

        DataTable veritablosu = new DataTable();

        public void DataGridViewiGuncelle()
        {
            // DataGridView'in veri kaynağını temizle
            Form1 form1 = Application.OpenForms["Form1"] as Form1; // Form1'e erişim
            form1.dataGridView1.DataSource = null;
            form1.dataGridView1.Rows.Clear();

            // Veritabanından verileri al ve DataGridView'e ekle
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "SELECT * FROM Kisiler";
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            form1.dataGridView1.DataSource = dataTable;
            bag.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult onay;
                onay = MessageBox.Show("Bu işlemi yapmak istediğinize emin misiniz? ", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    string isim, soyisim, telefon;


                    isim = yeniisimtxt.Text.Trim();
                    soyisim = yenisoytxt.Text.Trim();
                    telefon = yeniteltxt.Text.Trim();

                    bag.Open();
                    komut.Connection = bag;
                    komut.CommandText = "insert into Kisiler (Isim,Soyisim,Telefon) values ('" + isim + "','" + soyisim + "','" + telefon + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kişi Kayıt Edildi!");
                    bag.Close();

                    yeniisimtxt.Text = "";
                    yenisoytxt.Text = "";
                    yeniteltxt.Text = "";


                    this.Close();

                    DataGridViewiGuncelle();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tekrar Deneyiniz.");
            }
        }

        private void Validasyon2_Click(object sender, EventArgs e)
        {

        }

        private void yeniteltxt_TextChanged(object sender, EventArgs e)
        {
            if (yeniteltxt.Text.StartsWith("0"))
            {
                yeniteltxt.Text = "";
            }

            if (yeniteltxt.Text.Length > 10)
            {
                yeniteltxt.Text = yeniteltxt.Text.Substring(0, 10);
                yeniteltxt.SelectionStart = yeniteltxt.Text.Length; 
            }

            string telefon = yeniteltxt.Text.Trim();

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

        private void yeniisimtxt_TextChanged(object sender, EventArgs e)
        {
            string isim = yeniisimtxt.Text.Trim();

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

        private void yeniisimtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void yenisoytxt_TextChanged(object sender, EventArgs e)
        {
            string soyisim = yenisoytxt.Text.Trim();

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

        private void yeniteltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void yenisoytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
        
}

        

        

    

