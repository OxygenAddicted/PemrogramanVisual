/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/22/2022
 * Time: 7:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kalkulator_Sederhana
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox num1;
		private System.Windows.Forms.Label res;
		private System.Windows.Forms.TextBox num2;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button multiply;
		private System.Windows.Forms.Button divide;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button reset;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.num1 = new System.Windows.Forms.TextBox();
			this.num2 = new System.Windows.Forms.TextBox();
			this.res = new System.Windows.Forms.Label();
			this.plus = new System.Windows.Forms.Button();
			this.multiply = new System.Windows.Forms.Button();
			this.divide = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angka 1";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Angka2";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hasil";
			// 
			// num1
			// 
			this.num1.Location = new System.Drawing.Point(108, 32);
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(128, 20);
			this.num1.TabIndex = 3;
			// 
			// num2
			// 
			this.num2.Location = new System.Drawing.Point(108, 68);
			this.num2.Name = "num2";
			this.num2.Size = new System.Drawing.Size(128, 20);
			this.num2.TabIndex = 5;
			// 
			// res
			// 
			this.res.BackColor = System.Drawing.SystemColors.ControlLight;
			this.res.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.res.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.res.Location = new System.Drawing.Point(108, 104);
			this.res.Name = "res";
			this.res.Size = new System.Drawing.Size(128, 23);
			this.res.TabIndex = 6;
			// 
			// plus
			// 
			this.plus.BackColor = System.Drawing.SystemColors.ControlDark;
			this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.plus.Location = new System.Drawing.Point(45, 159);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(42, 36);
			this.plus.TabIndex = 7;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = false;
			this.plus.Click += new System.EventHandler(this.PlusClick);
			// 
			// multiply
			// 
			this.multiply.BackColor = System.Drawing.SystemColors.ControlDark;
			this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.multiply.Location = new System.Drawing.Point(102, 159);
			this.multiply.Name = "multiply";
			this.multiply.Size = new System.Drawing.Size(42, 36);
			this.multiply.TabIndex = 8;
			this.multiply.Text = "*";
			this.multiply.UseVisualStyleBackColor = false;
			this.multiply.Click += new System.EventHandler(this.MultiplyClick);
			// 
			// divide
			// 
			this.divide.BackColor = System.Drawing.SystemColors.ControlDark;
			this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.divide.Location = new System.Drawing.Point(102, 201);
			this.divide.Name = "divide";
			this.divide.Size = new System.Drawing.Size(42, 36);
			this.divide.TabIndex = 9;
			this.divide.Text = "/";
			this.divide.UseVisualStyleBackColor = false;
			this.divide.Click += new System.EventHandler(this.DivideClick);
			// 
			// minus
			// 
			this.minus.BackColor = System.Drawing.SystemColors.ControlDark;
			this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.minus.Location = new System.Drawing.Point(45, 201);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(42, 36);
			this.minus.TabIndex = 10;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = false;
			this.minus.Click += new System.EventHandler(this.MinusClick);
			// 
			// reset
			// 
			this.reset.BackColor = System.Drawing.SystemColors.ControlDark;
			this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.reset.Location = new System.Drawing.Point(162, 159);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(74, 78);
			this.reset.TabIndex = 11;
			this.reset.Text = "C";
			this.reset.UseVisualStyleBackColor = false;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.divide);
			this.Controls.Add(this.multiply);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.res);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Kalkulator Sederhana";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
