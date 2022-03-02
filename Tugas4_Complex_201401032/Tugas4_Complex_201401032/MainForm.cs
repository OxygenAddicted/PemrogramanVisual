/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/2/2022
 * Time: 3:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas4_201401032
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void SubmitClick(object sender, EventArgs e)
		{
			string sample = "Nama: "+nama.Text+"\nNIM: "+nim.Text+"\nKelas: "+kelas.Text+"\n\nBerhasil terdaftar pada mata kuliah "+matkul.Text;
			MessageBox.Show(sample);
		}
	}
}
