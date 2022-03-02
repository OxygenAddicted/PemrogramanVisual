/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/2/2022
 * Time: 3:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas4_201401032
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button submit;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox nim;
		private System.Windows.Forms.TextBox kelas;
		private System.Windows.Forms.TextBox matkul;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.submit = new System.Windows.Forms.Button();
			this.nama = new System.Windows.Forms.TextBox();
			this.nim = new System.Windows.Forms.TextBox();
			this.kelas = new System.Windows.Forms.TextBox();
			this.matkul = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// submit
			// 
			this.submit.Location = new System.Drawing.Point(282, 196);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(81, 34);
			this.submit.TabIndex = 0;
			this.submit.Text = "Daftar";
			this.submit.UseVisualStyleBackColor = true;
			this.submit.Click += new System.EventHandler(this.SubmitClick);
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(138, 71);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(225, 20);
			this.nama.TabIndex = 1;
			// 
			// nim
			// 
			this.nim.Location = new System.Drawing.Point(138, 99);
			this.nim.Name = "nim";
			this.nim.Size = new System.Drawing.Size(225, 20);
			this.nim.TabIndex = 2;
			// 
			// kelas
			// 
			this.kelas.Location = new System.Drawing.Point(138, 127);
			this.kelas.Name = "kelas";
			this.kelas.Size = new System.Drawing.Size(225, 20);
			this.kelas.TabIndex = 3;
			// 
			// matkul
			// 
			this.matkul.Location = new System.Drawing.Point(138, 156);
			this.matkul.Name = "matkul";
			this.matkul.Size = new System.Drawing.Size(225, 20);
			this.matkul.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "NIM";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Kelas";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Mata Kuliah";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "FORM PENDAFTARAN MATA KULIAH";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 287);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.matkul);
			this.Controls.Add(this.kelas);
			this.Controls.Add(this.nim);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.submit);
			this.Name = "MainForm";
			this.Text = "Tugas4_201401032";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
