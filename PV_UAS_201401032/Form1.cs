using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace PV_UAS_201401032
{
    public partial class Form1 : Form
    {
        string jenis1;

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
            Clear();
        }

        void Show()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM data_obat", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "data_obat");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "data_obat";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxKodeObat.Text = row.Cells["kode_obat"].Value.ToString();
                textBoxNamaObat.Text = row.Cells["nama_obat"].Value.ToString();
                comboBoxJenisObat.Text = row.Cells["jenis_obat"].Value.ToString();
                if (row.Cells["gol_obat"].Value == "Obat Bebas")
                {
                    btnObatBebas.Checked = true;
                }
                if (row.Cells["gol_obat"].Value == "Obat Keras")
                {
                    btnObatKeras.Checked = true;
                }
                textBoxHarga.Text = row.Cells["harga"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
        void Clear()
        {
            textBoxKodeObat.Text = "";
            textBoxNamaObat.Text = "";
            comboBoxJenisObat.Text = "";
            btnObatBebas.Checked = false;
            btnObatKeras.Checked = false;
            textBoxHarga.Text = "";
            Show();
        }

        private void getGol()
        {
            if (btnObatBebas.Checked)
            {
                jenis1 = btnObatBebas.Text;
            }
            else if (btnObatKeras.Checked)
            {
                jenis1 = btnObatKeras.Text;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            getGol();

            if (textBoxKodeObat.Text.Trim() == "" ||
               textBoxNamaObat.Text.Trim() == "" ||
               comboBoxJenisObat.Text.Trim() == "" ||
               textBoxHarga.Text.Trim() == "")
            {
                MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
            }
            else
            {

                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("INSERT INTO data_obat VALUES ('" + textBoxKodeObat.Text + "','" + textBoxNamaObat.Text + "','" + comboBoxJenisObat.Text + "','" + jenis1 + "','" + textBoxHarga.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil!");
                    Show();
                    Clear();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Tidak dapat menyimpan data");
                }

                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah yakin " + textBoxNamaObat.Text + " ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("DELETE data_obat WHERE kode_obat = '" + textBoxKodeObat.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus Data Berhasil!");
                    Show();
                    Clear();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Tidak dapat Menghapus data");
                }

                conn.Close();
            }


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}