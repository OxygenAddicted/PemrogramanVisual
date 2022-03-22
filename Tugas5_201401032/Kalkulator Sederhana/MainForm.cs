/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/22/2022
 * Time: 7:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
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
		
		void PlusClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.num1.Text);
				b = int.Parse(this.num2.Text);
				c = a + b;
				this.res.Text = c.ToString();
			}
		}
		void MinusClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.num1.Text);
				b = int.Parse(this.num2.Text);
				c = a - b;
				this.res.Text = c.ToString();
			}
		}
		void MultiplyClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.num1.Text);
				b = int.Parse(this.num2.Text);
				c = a * b;
				this.res.Text = c.ToString();
			}
		}
		void DivideClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 Tidak Boleh Kosong");
			}
			else
			{
				int a,b,c;
				a = int.Parse(this.num1.Text);
				b = int.Parse(this.num2.Text);
				c = a / b;
				this.res.Text = c.ToString();
			}
		}
		void ResetClick(object sender, EventArgs e)
		{
			num1.Clear();
			num2.Clear();
			res.Text = "";
		}
		
		
		
	}
}
