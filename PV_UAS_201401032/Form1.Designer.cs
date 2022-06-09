namespace PV_UAS_201401032
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKodeObat = new System.Windows.Forms.TextBox();
            this.textBoxNamaObat = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.comboBoxJenisObat = new System.Windows.Forms.ComboBox();
            this.btnObatBebas = new System.Windows.Forms.RadioButton();
            this.btnObatKeras = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(211, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apotek Jaya Raya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Obat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Golongan Obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga";
            // 
            // textBoxKodeObat
            // 
            this.textBoxKodeObat.Location = new System.Drawing.Point(146, 124);
            this.textBoxKodeObat.Name = "textBoxKodeObat";
            this.textBoxKodeObat.Size = new System.Drawing.Size(197, 23);
            this.textBoxKodeObat.TabIndex = 6;
            // 
            // textBoxNamaObat
            // 
            this.textBoxNamaObat.Location = new System.Drawing.Point(146, 173);
            this.textBoxNamaObat.Name = "textBoxNamaObat";
            this.textBoxNamaObat.Size = new System.Drawing.Size(197, 23);
            this.textBoxNamaObat.TabIndex = 7;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(146, 344);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(197, 23);
            this.textBoxHarga.TabIndex = 8;
            // 
            // comboBoxJenisObat
            // 
            this.comboBoxJenisObat.FormattingEnabled = true;
            this.comboBoxJenisObat.Items.AddRange(new object[] {
            "Tablet",
            "Kapsul",
            "Cair",
            "Oles"});
            this.comboBoxJenisObat.Location = new System.Drawing.Point(146, 224);
            this.comboBoxJenisObat.Name = "comboBoxJenisObat";
            this.comboBoxJenisObat.Size = new System.Drawing.Size(197, 23);
            this.comboBoxJenisObat.TabIndex = 9;
            // 
            // btnObatBebas
            // 
            this.btnObatBebas.AutoSize = true;
            this.btnObatBebas.Location = new System.Drawing.Point(10, 24);
            this.btnObatBebas.Name = "btnObatBebas";
            this.btnObatBebas.Size = new System.Drawing.Size(85, 19);
            this.btnObatBebas.TabIndex = 10;
            this.btnObatBebas.Text = "Obat Bebas";
            this.btnObatBebas.UseVisualStyleBackColor = true;
            // 
            // btnObatKeras
            // 
            this.btnObatKeras.AutoSize = true;
            this.btnObatKeras.Location = new System.Drawing.Point(108, 24);
            this.btnObatKeras.Name = "btnObatKeras";
            this.btnObatKeras.Size = new System.Drawing.Size(82, 19);
            this.btnObatKeras.TabIndex = 11;
            this.btnObatKeras.Text = "Obat Keras";
            this.btnObatKeras.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(411, 306);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObatBebas);
            this.groupBox1.Controls.Add(this.btnObatKeras);
            this.groupBox1.Location = new System.Drawing.Point(146, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 57);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(254, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(11, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(146, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxJenisObat);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaObat);
            this.Controls.Add(this.textBoxKodeObat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PV_UAS :  Apotek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxKodeObat;
        private TextBox textBoxNamaObat;
        private TextBox textBoxHarga;
        private ComboBox comboBoxJenisObat;
        private RadioButton btnObatBebas;
        private RadioButton btnObatKeras;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnSave;
    }
}