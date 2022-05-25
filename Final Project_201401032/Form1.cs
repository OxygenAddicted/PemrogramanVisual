using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Final_Project_201401032
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        
        //====================
        //= Menampilkan Form =
        //====================

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilData();
            Bersihkan();
            PilihanKelas();
            NISOtomatis();
        }

        //==================================================
        //= Menampilkan Data Pada Database ke DataGridView =
        //==================================================
        void TampilData()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM data_siswa", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "data_siswa");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "data_siswa";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 158;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 80;
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

        //==============================================
        //= Mencari Data Sesuai Isi Text Box Pencarian =
        //==============================================
        void CariData()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM data_siswa WHERE NIS LIKE '%" + textBoxCari.Text + "%' OR Nama LIKE '%" + textBoxCari.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "data_siswa");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "data_siswa";
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
        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        //=====================================
        //= Membersihkan Isi Seluruh Text Box =
        //=====================================
        void Bersihkan()
        {
            textBoxNis.Text = "";
            textBoxNama.Text = "";
            comboBoxKelas.Text = "";
            textBoxMtk.Text = "0";
            textBoxInd.Text = "0";
            textBoxEng.Text = "0";
            textBoxBio.Text = "0";
            textBoxFis.Text = "0";
            textBoxKim.Text = "0";
            TampilData();
            NISOtomatis();
        }

        //=======================================================================
        //= Menampilkan Data yang Ada di DataGridView ke Text Box Ketika diklik =
        //=======================================================================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxNis.Text = row.Cells["NIS"].Value.ToString();
                textBoxNama.Text = row.Cells["Nama"].Value.ToString();
                comboBoxKelas.Text = row.Cells["Kelas"].Value.ToString();
                textBoxMtk.Text = row.Cells["Matematika"].Value.ToString();
                textBoxInd.Text = row.Cells["BIndonesia"].Value.ToString();
                textBoxEng.Text = row.Cells["BInggris"].Value.ToString();
                textBoxBio.Text = row.Cells["Biologi"].Value.ToString();
                textBoxFis.Text = row.Cells["Fisika"].Value.ToString();
                textBoxKim.Text = row.Cells["Kimia"].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        //===================================
        //= Opsi Untuk Isi Text Box "Kelas" =
        //===================================
        void PilihanKelas()
        {
            comboBoxKelas.Items.Add("12 IPA 1");
            comboBoxKelas.Items.Add("12 IPA 2");
            comboBoxKelas.Items.Add("12 IPA 3");
        }

        //=========================
        //= Generate NIS Otomatis =
        //=========================
        void NISOtomatis()
        {
            long hitung;
            string urutan;

            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();

            conn.Open();
            cmd = new SqlCommand("SELECT NIS FROM data_siswa WHERE NIS IN (SELECT MAX (NIS) FROM data_siswa) ORDER BY NIS DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NIS"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "201" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "201001";
            }

            rd.Close();
            textBoxNis.Text = urutan;
            conn.Close();
        }

        //======================
        //= Button Simpan Data =
        //======================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //Memeriksa Apakah Text Box Masih Kosong

            if (textBoxNis.Text.Trim() == "" ||
                textBoxNama.Text.Trim() == "" ||
                comboBoxKelas.Text.Trim() == "" ||
                textBoxMtk.Text.Trim() == "" ||
                textBoxInd.Text.Trim() == "" ||
                textBoxEng.Text.Trim() == "" ||
                textBoxBio.Text.Trim() == "" ||
                textBoxFis.Text.Trim() == "" ||
                textBoxKim.Text.Trim() == "")
            {
                MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
            }
            else
            {

                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("INSERT INTO data_siswa VALUES ('" + textBoxNis.Text + "','" + textBoxNama.Text + "','" + comboBoxKelas.Text + "','" + textBoxMtk.Text + "','" + textBoxInd.Text + "','" + textBoxEng.Text + "','" + textBoxBio.Text + "','" + textBoxFis.Text + "','" + textBoxKim.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil!");
                    TampilData();
                    Bersihkan();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Tidak dapat menyimpan data");
                }

                conn.Close();
            }
        }

        //======================
        //= Button Update Data =
        //======================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Memeriksa Apakah Text Box Masih Kosong

            if (textBoxNis.Text.Trim() == "" ||
                textBoxNama.Text.Trim() == "" ||
                comboBoxKelas.Text.Trim() == "" ||
                textBoxMtk.Text.Trim() == "" ||
                textBoxInd.Text.Trim() == "" ||
                textBoxEng.Text.Trim() == "" ||
                textBoxBio.Text.Trim() == "" ||
                textBoxFis.Text.Trim() == "" ||
                textBoxKim.Text.Trim() == "")
            {
                MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("UPDATE data_siswa SET NIS = '" + textBoxNis.Text + "', Nama ='" + textBoxNama.Text + "', Kelas = '" + comboBoxKelas.Text + "', Matematika = '" + textBoxMtk.Text + "', BIndonesia = '" + textBoxInd.Text + "', BInggris = '" + textBoxEng.Text + "', Biologi = '" + textBoxBio.Text + "', Fisika = '" + textBoxFis.Text + "', Kimia = '" + textBoxKim.Text + "' WHERE NIS = '" + textBoxNis.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Berhasil!");
                    TampilData();
                    Bersihkan();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Tidak dapat mengupdate data");
                }

                conn.Close();
            }
        }

        //=====================
        //= Button Hapus Data =
        //=====================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            //Memberi Warning Apakah Data Yakin Ingin Dihapuskan
            //Jika ditekan "Yes", Maka Data Akan Dihapus

            if (MessageBox.Show(textBoxNis.Text + ", yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("DELETE data_siswa WHERE NIS = '" + textBoxNis.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus Data Berhasil!");
                    TampilData();
                    Bersihkan();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Tidak dapat Menghapus data");
                }

                conn.Close();
            }
        }

        //==================
        //= Button Refresh =
        //==================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        //===========================
        //= Validasi Text Box Nilai =
        //===========================
        private void textBoxMtk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBoxInd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBoxEng_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBoxBio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBoxFis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBoxKim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}