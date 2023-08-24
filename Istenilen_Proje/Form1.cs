using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Istenilen_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=veritabanı.mdb");
        OleDbCommand komut = new OleDbCommand();

        DataTable veritablosu = new DataTable();

        public void listele()
        {
            try
            {
                veritablosu.Clear();
                OleDbDataAdapter siringa = new OleDbDataAdapter("select * from Kisiler", bag);
                siringa.Fill(veritablosu);
                dataGridView1.DataSource = veritablosu;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            veritablosu.Clear();

            OleDbDataAdapter siringa = new OleDbDataAdapter("select * from Kisiler where Isim like '" + aratxt.Text + "%'", bag);
            siringa.Fill(veritablosu);
            dataGridView1.DataSource = veritablosu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

            dataGridView1.ClearSelection();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            düzenleBtn.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                if (selectedRow.Selected)
                {
                    dataGridView1.ClearSelection();
                }
                else
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = selectedRow.Cells[0];
                    selectedRow.Selected = true;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                düzenleBtn.Visible = true; // Butonu göster
            }
            else
            {
                düzenleBtn.Visible = false; // Butonu gizle
            }
        }

        private void düzenleBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string isim = selectedRow.Cells["Isim"].Value.ToString(); // "Isim" burada DataGridView'deki isim sütununun adını temsil etmektedir
                string soyisim = selectedRow.Cells["Soyisim"].Value.ToString(); // "Soyisim" burada DataGridView'deki soyisim sütununun adını temsil etmektedir
                string telefon = selectedRow.Cells["Telefon"].Value.ToString(); // "Telefon" burada DataGridView'deki telefon sütununun adını temsil etmektedir
                 // "Adres" burada DataGridView'deki adres sütununun adını temsil etmektedir


                Form1 form1 = new Form1();
                // İkinci formu açmak ve verileri aktarmak için aşağıdaki gibi bir kod kullanabilirsiniz:
                Düzenle ikinciForm = new Düzenle(form1);
                ikinciForm.SetVeriler(isim, soyisim, telefon);
                ikinciForm.ShowDialog();
            }

           
           }

        private void kolusturBtn_Click(object sender, EventArgs e)
        {
            KisiOlustur form3 = new KisiOlustur();
            form3.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
