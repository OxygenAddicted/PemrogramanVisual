﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/2/2022
 * Time: 4:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas4_Simple_201401032
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
			MessageBox.Show("Hello World, "+name.Text);
		}
	}
}
