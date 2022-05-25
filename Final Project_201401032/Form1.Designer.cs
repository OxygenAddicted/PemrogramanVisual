namespace Final_Project_201401032
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNis = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.textBoxInd = new System.Windows.Forms.TextBox();
            this.textBoxMtk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKim = new System.Windows.Forms.TextBox();
            this.textBoxFis = new System.Windows.Forms.TextBox();
            this.textBoxBio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.comboBoxKelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 391);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(881, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(12, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelas";
            // 
            // textBoxNis
            // 
            this.textBoxNis.Location = new System.Drawing.Point(131, 131);
            this.textBoxNis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNis.Name = "textBoxNis";
            this.textBoxNis.Size = new System.Drawing.Size(160, 25);
            this.textBoxNis.TabIndex = 5;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(131, 187);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(160, 25);
            this.textBoxNama.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(352, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai";
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(444, 248);
            this.textBoxEng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(52, 25);
            this.textBoxEng.TabIndex = 14;
            this.textBoxEng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEng_KeyPress);
            // 
            // textBoxInd
            // 
            this.textBoxInd.Location = new System.Drawing.Point(444, 190);
            this.textBoxInd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInd.Name = "textBoxInd";
            this.textBoxInd.Size = new System.Drawing.Size(52, 25);
            this.textBoxInd.TabIndex = 13;
            this.textBoxInd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInd_KeyPress);
            // 
            // textBoxMtk
            // 
            this.textBoxMtk.Location = new System.Drawing.Point(444, 131);
            this.textBoxMtk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMtk.Name = "textBoxMtk";
            this.textBoxMtk.Size = new System.Drawing.Size(52, 25);
            this.textBoxMtk.TabIndex = 12;
            this.textBoxMtk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMtk_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(351, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "B. Inggris";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(351, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Matematika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(351, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "B. Indonesia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(66, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Biodata";
            // 
            // textBoxKim
            // 
            this.textBoxKim.Location = new System.Drawing.Point(580, 248);
            this.textBoxKim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKim.Name = "textBoxKim";
            this.textBoxKim.Size = new System.Drawing.Size(52, 25);
            this.textBoxKim.TabIndex = 21;
            this.textBoxKim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKim_KeyPress);
            // 
            // textBoxFis
            // 
            this.textBoxFis.Location = new System.Drawing.Point(580, 190);
            this.textBoxFis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFis.Name = "textBoxFis";
            this.textBoxFis.Size = new System.Drawing.Size(52, 25);
            this.textBoxFis.TabIndex = 20;
            this.textBoxFis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFis_KeyPress);
            // 
            // textBoxBio
            // 
            this.textBoxBio.Location = new System.Drawing.Point(580, 131);
            this.textBoxBio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.Size = new System.Drawing.Size(52, 25);
            this.textBoxBio.TabIndex = 19;
            this.textBoxBio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(517, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kimia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(517, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Biologi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(517, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fisika";
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(702, 22);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(181, 25);
            this.textBoxCari.TabIndex = 22;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(645, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cari";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Location = new System.Drawing.Point(440, 321);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 31);
            this.btnSimpan.TabIndex = 24;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(539, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHapus.Location = new System.Drawing.Point(637, 321);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 31);
            this.btnHapus.TabIndex = 26;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // comboBoxKelas
            // 
            this.comboBoxKelas.FormattingEnabled = true;
            this.comboBoxKelas.Location = new System.Drawing.Point(131, 245);
            this.comboBoxKelas.Name = "comboBoxKelas";
            this.comboBoxKelas.Size = new System.Drawing.Size(160, 28);
            this.comboBoxKelas.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 651);
            this.Controls.Add(this.comboBoxKelas);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.textBoxKim);
            this.Controls.Add(this.textBoxFis);
            this.Controls.Add(this.textBoxBio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.textBoxInd);
            this.Controls.Add(this.textBoxMtk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxNis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Final Project: Database Nilai Rapor Siswa Jurusan IPA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRefresh;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNis;
        private TextBox textBoxNama;
        private Label label4;
        private TextBox textBoxEng;
        private TextBox textBoxInd;
        private TextBox textBoxMtk;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxKim;
        private TextBox textBoxFis;
        private TextBox textBoxBio;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxCari;
        private Label label12;
        private Button btnSimpan;
        private Button btnUpdate;
        private Button btnHapus;
        private ComboBox comboBoxKelas;
    }
}