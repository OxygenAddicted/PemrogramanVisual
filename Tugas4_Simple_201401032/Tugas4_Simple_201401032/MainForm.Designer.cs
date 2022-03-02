/*
 * Created by SharpDevelop.
 * User: user
 * Date: 3/2/2022
 * Time: 4:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas4_Simple_201401032
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button submit;
		private System.Windows.Forms.TextBox name;
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
			this.name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// submit
			// 
			this.submit.Location = new System.Drawing.Point(160, 137);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(75, 23);
			this.submit.TabIndex = 0;
			this.submit.Text = "Submit";
			this.submit.UseVisualStyleBackColor = true;
			this.submit.Click += new System.EventHandler(this.SubmitClick);
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(79, 50);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(156, 20);
			this.name.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.name);
			this.Controls.Add(this.submit);
			this.Name = "MainForm";
			this.Text = "Tugas4_Simple_201401032";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
