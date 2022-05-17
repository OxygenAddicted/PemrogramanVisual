using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Tugas10_201401032
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContectClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilBarang();
            Bersihkan();
        }
        void TampilBarang()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_BARANG", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_BARANG");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_BARANG";
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

        void CariBarang()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_BARANG WHERE kodebarang LIKE '%" + textBoxCari.Text + "%' OR namabarang LIKE '%" + textBoxCari.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_BARANG");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_BARANG";
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

        void Bersihkan()
        {
            textBoxKodeBarang.Text = "";
            textBoxNamaBarang.Text = "";
            textBoxHargaBeli.Text = "0";
            textBoxHargaJual.Text = "0";
            textBoxJumlah.Text = "0";
            textBoxSatuan.Text = "";
            textBoxCari.Text = "";
            TampilBarang();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxKodeBarang.Text.Trim() == "" ||
                textBoxNamaBarang.Text.Trim() == "" ||
                textBoxHargaBeli.Text.Trim() == "" ||
                textBoxHargaJual.Text.Trim() == "" ||
                textBoxJumlah.Text.Trim() == "" ||
                textBoxSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
            }
            else
            {
                
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("INSERT INTO TBL_BARANG VALUES ('" + textBoxKodeBarang.Text + "','" + textBoxNamaBarang.Text + "','" + textBoxHargaBeli.Text + "','" + textBoxHargaJual.Text + "','" + textBoxJumlah.Text + "','" + textBoxSatuan.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil!");
                    TampilBarang();
                    Bersihkan();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Tidak dapat menyimpan data");
                }

                conn.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxKodeBarang.Text.Trim() == "" ||
                textBoxNamaBarang.Text.Trim() == "" ||
                textBoxHargaBeli.Text.Trim() == "" ||
                textBoxHargaJual.Text.Trim() == "" ||
                textBoxJumlah.Text.Trim() == "" ||
                textBoxSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("UPDATE TBL_BARANG SET KodeBarang = '" + textBoxKodeBarang.Text + "', NamaBarang ='" + textBoxNamaBarang.Text + "', HargaBeli = '" + textBoxHargaBeli.Text + "', HargaJual = '" + textBoxHargaJual.Text + "', JumlahBarang = '" + textBoxJumlah.Text + "', SatuanBarang = '" + textBoxSatuan.Text + "' WHERE KodeBarang = '" + textBoxKodeBarang.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Berhasil!");
                    TampilBarang();
                    Bersihkan();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Tidak dapat mengupdate data");
                }

                conn.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(textBoxNamaBarang.Text + ", yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("DELETE TBL_BARANG WHERE KodeBarang = '" + textBoxKodeBarang.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus Data Berhasil!");
                    TampilBarang();
                    Bersihkan();
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
            Bersihkan();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }
    }
}