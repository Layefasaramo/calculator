/*
 * Created by SharpDevelop.
 * User: AUDITOR
 * Date: 1/16/2023
 * Time: 4:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button n1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button n3;
		private System.Windows.Forms.Button n6;
		private System.Windows.Forms.Button n5;
		private System.Windows.Forms.Button n4;
		private System.Windows.Forms.Button n9;
		private System.Windows.Forms.Button n8;
		private System.Windows.Forms.Button n7;
		private System.Windows.Forms.Button n_;
		private System.Windows.Forms.Button n0;
		private System.Windows.Forms.Button nplusminus;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button reverse;
		private System.Windows.Forms.Button neq;
		private System.Windows.Forms.Button nplus;
		private System.Windows.Forms.Button nminnus;
		private System.Windows.Forms.Button nx;
		private System.Windows.Forms.Button nperrcent;
		private System.Windows.Forms.Button nclear;
		private System.Windows.Forms.Button ndel;
		private System.Windows.Forms.Button ndiv;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		
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
			this.n1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.n3 = new System.Windows.Forms.Button();
			this.n6 = new System.Windows.Forms.Button();
			this.n5 = new System.Windows.Forms.Button();
			this.n4 = new System.Windows.Forms.Button();
			this.n9 = new System.Windows.Forms.Button();
			this.n8 = new System.Windows.Forms.Button();
			this.n7 = new System.Windows.Forms.Button();
			this.n_ = new System.Windows.Forms.Button();
			this.n0 = new System.Windows.Forms.Button();
			this.nplusminus = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.reverse = new System.Windows.Forms.Button();
			this.neq = new System.Windows.Forms.Button();
			this.nplus = new System.Windows.Forms.Button();
			this.nminnus = new System.Windows.Forms.Button();
			this.nx = new System.Windows.Forms.Button();
			this.nperrcent = new System.Windows.Forms.Button();
			this.nclear = new System.Windows.Forms.Button();
			this.ndel = new System.Windows.Forms.Button();
			this.ndiv = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// n1
			// 
			this.n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n1.Location = new System.Drawing.Point(0, 231);
			this.n1.Name = "n1";
			this.n1.Size = new System.Drawing.Size(63, 43);
			this.n1.TabIndex = 1;
			this.n1.Text = "1";
			this.n1.UseVisualStyleBackColor = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(5, 80);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.richTextBox1.Size = new System.Drawing.Size(271, 79);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "0";
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
			// 
			// n3
			// 
			this.n3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n3.Location = new System.Drawing.Point(138, 231);
			this.n3.Name = "n3";
			this.n3.Size = new System.Drawing.Size(63, 43);
			this.n3.TabIndex = 4;
			this.n3.Text = "3";
			this.n3.UseVisualStyleBackColor = false;
			// 
			// n6
			// 
			this.n6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n6.Location = new System.Drawing.Point(138, 280);
			this.n6.Name = "n6";
			this.n6.Size = new System.Drawing.Size(63, 43);
			this.n6.TabIndex = 7;
			this.n6.Text = "6";
			this.n6.UseVisualStyleBackColor = false;
			// 
			// n5
			// 
			this.n5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n5.Location = new System.Drawing.Point(69, 280);
			this.n5.Name = "n5";
			this.n5.Size = new System.Drawing.Size(63, 43);
			this.n5.TabIndex = 6;
			this.n5.Text = "5";
			this.n5.UseVisualStyleBackColor = false;
			// 
			// n4
			// 
			this.n4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n4.Location = new System.Drawing.Point(0, 280);
			this.n4.Name = "n4";
			this.n4.Size = new System.Drawing.Size(63, 43);
			this.n4.TabIndex = 5;
			this.n4.Text = "4";
			this.n4.UseVisualStyleBackColor = false;
			// 
			// n9
			// 
			this.n9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n9.Location = new System.Drawing.Point(138, 329);
			this.n9.Name = "n9";
			this.n9.Size = new System.Drawing.Size(63, 43);
			this.n9.TabIndex = 10;
			this.n9.Text = "9";
			this.n9.UseVisualStyleBackColor = false;
			// 
			// n8
			// 
			this.n8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n8.Location = new System.Drawing.Point(69, 329);
			this.n8.Name = "n8";
			this.n8.Size = new System.Drawing.Size(63, 43);
			this.n8.TabIndex = 9;
			this.n8.Text = "8";
			this.n8.UseVisualStyleBackColor = false;
			// 
			// n7
			// 
			this.n7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n7.Location = new System.Drawing.Point(0, 329);
			this.n7.Name = "n7";
			this.n7.Size = new System.Drawing.Size(63, 43);
			this.n7.TabIndex = 8;
			this.n7.Text = "7";
			this.n7.UseVisualStyleBackColor = false;
			// 
			// n_
			// 
			this.n_.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n_.Location = new System.Drawing.Point(138, 378);
			this.n_.Name = "n_";
			this.n_.Size = new System.Drawing.Size(63, 43);
			this.n_.TabIndex = 13;
			this.n_.Text = ".";
			this.n_.UseVisualStyleBackColor = false;
			this.n_.Click += new System.EventHandler(this.N_Click);
			// 
			// n0
			// 
			this.n0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n0.Location = new System.Drawing.Point(69, 378);
			this.n0.Name = "n0";
			this.n0.Size = new System.Drawing.Size(63, 43);
			this.n0.TabIndex = 12;
			this.n0.Text = "0";
			this.n0.UseVisualStyleBackColor = false;
			this.n0.Click += new System.EventHandler(this.N0Click);
			// 
			// nplusminus
			// 
			this.nplusminus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.nplusminus.Location = new System.Drawing.Point(0, 378);
			this.nplusminus.Name = "nplusminus";
			this.nplusminus.Size = new System.Drawing.Size(63, 43);
			this.nplusminus.TabIndex = 11;
			this.nplusminus.Text = "+-";
			this.nplusminus.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(0, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(63, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(138, 231);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(63, 43);
			this.button3.TabIndex = 4;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(0, 280);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(63, 43);
			this.button4.TabIndex = 5;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(69, 280);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(63, 43);
			this.button5.TabIndex = 6;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(138, 280);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(63, 43);
			this.button6.TabIndex = 7;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(0, 329);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(63, 43);
			this.button7.TabIndex = 8;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(69, 329);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(63, 43);
			this.button8.TabIndex = 9;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(138, 329);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(63, 43);
			this.button9.TabIndex = 10;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// reverse
			// 
			this.reverse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reverse.Location = new System.Drawing.Point(0, 378);
			this.reverse.Name = "reverse";
			this.reverse.Size = new System.Drawing.Size(63, 43);
			this.reverse.TabIndex = 11;
			this.reverse.Text = "+-";
			this.reverse.UseVisualStyleBackColor = false;
			this.reverse.Click += new System.EventHandler(this.ReverseClick);
			// 
			// neq
			// 
			this.neq.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.neq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.neq.Location = new System.Drawing.Point(213, 378);
			this.neq.Name = "neq";
			this.neq.Size = new System.Drawing.Size(63, 43);
			this.neq.TabIndex = 14;
			this.neq.Text = "=";
			this.neq.UseVisualStyleBackColor = false;
			this.neq.Click += new System.EventHandler(this.NeqClick);
			// 
			// nplus
			// 
			this.nplus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.nplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nplus.Location = new System.Drawing.Point(213, 329);
			this.nplus.Name = "nplus";
			this.nplus.Size = new System.Drawing.Size(63, 43);
			this.nplus.TabIndex = 15;
			this.nplus.Text = "+";
			this.nplus.UseVisualStyleBackColor = false;
			this.nplus.Click += new System.EventHandler(this.NplusClick);
			// 
			// nminnus
			// 
			this.nminnus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.nminnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nminnus.Location = new System.Drawing.Point(213, 280);
			this.nminnus.Name = "nminnus";
			this.nminnus.Size = new System.Drawing.Size(63, 43);
			this.nminnus.TabIndex = 16;
			this.nminnus.Text = "-";
			this.nminnus.UseVisualStyleBackColor = false;
			this.nminnus.Click += new System.EventHandler(this.NminnusClick);
			// 
			// nx
			// 
			this.nx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.nx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nx.Location = new System.Drawing.Point(213, 230);
			this.nx.Name = "nx";
			this.nx.Size = new System.Drawing.Size(63, 43);
			this.nx.TabIndex = 17;
			this.nx.Text = "x";
			this.nx.UseVisualStyleBackColor = false;
			this.nx.Click += new System.EventHandler(this.NxClick);
			// 
			// nperrcent
			// 
			this.nperrcent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.nperrcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nperrcent.Location = new System.Drawing.Point(0, 182);
			this.nperrcent.Name = "nperrcent";
			this.nperrcent.Size = new System.Drawing.Size(63, 43);
			this.nperrcent.TabIndex = 18;
			this.nperrcent.Text = "%";
			this.nperrcent.UseVisualStyleBackColor = false;
			this.nperrcent.Click += new System.EventHandler(this.NperrcentClick);
			// 
			// nclear
			// 
			this.nclear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.nclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nclear.Location = new System.Drawing.Point(69, 182);
			this.nclear.Name = "nclear";
			this.nclear.Size = new System.Drawing.Size(63, 43);
			this.nclear.TabIndex = 19;
			this.nclear.Text = "C";
			this.nclear.UseVisualStyleBackColor = false;
			this.nclear.Click += new System.EventHandler(this.NclearClick);
			// 
			// ndel
			// 
			this.ndel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndel.Location = new System.Drawing.Point(138, 182);
			this.ndel.Name = "ndel";
			this.ndel.Size = new System.Drawing.Size(63, 43);
			this.ndel.TabIndex = 20;
			this.ndel.Text = "DEL";
			this.ndel.UseVisualStyleBackColor = false;
			this.ndel.Click += new System.EventHandler(this.NdelClick);
			// 
			// ndiv
			// 
			this.ndiv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ndiv.Location = new System.Drawing.Point(213, 181);
			this.ndiv.Name = "ndiv";
			this.ndiv.Size = new System.Drawing.Size(63, 43);
			this.ndiv.TabIndex = 21;
			this.ndiv.Text = " /";
			this.ndiv.UseVisualStyleBackColor = false;
			this.ndiv.Click += new System.EventHandler(this.NdivClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(69, 232);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(63, 42);
			this.button2.TabIndex = 22;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(17, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(259, 16);
			this.textBox1.TabIndex = 23;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 422);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.ndiv);
			this.Controls.Add(this.ndel);
			this.Controls.Add(this.nclear);
			this.Controls.Add(this.nperrcent);
			this.Controls.Add(this.nx);
			this.Controls.Add(this.nminnus);
			this.Controls.Add(this.nplus);
			this.Controls.Add(this.neq);
			this.Controls.Add(this.n_);
			this.Controls.Add(this.n0);
			this.Controls.Add(this.reverse);
			this.Controls.Add(this.nplusminus);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.n9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.n8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.n7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.n6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.n5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.n4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.n3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.n1);
			this.Name = "MainForm";
			this.Text = "calculator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
