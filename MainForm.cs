/*
 * Created by SharpDevelop.
 * User: AUDITOR
 * Date: 1/16/2023
 * Time: 4:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			double firstnumber;
			string noperation;
			double secondnumber;
			double result;
			int seter = 0;
			int delete;
			char mminus = '-';
			int minusguy;
			int fullstop = 1;
		
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
		
		void Button1Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "1";
				textBox1.Text = "1";
				seter=0;
				
			}
				else 
	{
		richTextBox1.Text = richTextBox1.Text+ "1";
		textBox1.Text = textBox1.Text+ "1";
	}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "2";
				textBox1.Text = "2";
				seter = 0;
			}
				else 
	{
		richTextBox1.Text = richTextBox1.Text + "2";
		textBox1.Text = textBox1.Text+ "2";
	}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
		
		}
		void Button6Click(object sender, EventArgs e)
		{
	if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "6";
				textBox1.Text = "6";
				seter = 0;
				
			}
		else 
	{
		richTextBox1.Text = richTextBox1.Text+ "6";
		textBox1.Text = textBox1.Text+ "6";
	}
		}
		void Button4Click(object sender, EventArgs e)
		{
	if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1 )
			{
				richTextBox1.Text= "4";
				textBox1.Text = "4";
				seter = 0;
				
				
			}
	else 
	{
		richTextBox1.Text = richTextBox1.Text+ "4";
		textBox1.Text = textBox1.Text+ "4";
	}
		}
		void Button3Click(object sender, EventArgs e)
		{
	if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "3";
				textBox1.Text = "3";
				seter = 0;
				
			}
	else 
	{
		richTextBox1.Text = richTextBox1.Text+ "3";
		textBox1.Text = textBox1.Text+ "3";
	}
		}
		void Button5Click(object sender, EventArgs e)
		{
	if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "5";
				textBox1.Text = "5";
				seter = 0;
				
			}
	else 
	{
		richTextBox1.Text = richTextBox1.Text+ "5";
		textBox1.Text = textBox1.Text+ "5";
	}
		}
		void Button7Click(object sender, EventArgs e)
		{
	if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "7";
				textBox1.Text = "7";
				seter = 0;
				
			}
	else 
	{
		richTextBox1.Text = richTextBox1.Text+ "7";
		textBox1.Text = textBox1.Text+ "7";
	}
		}
		void Button8Click(object sender, EventArgs e)
		{
	if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "8";
				textBox1.Text = "8";
				seter = 0;
				
			}
	else 
	{
		
		richTextBox1.Text = richTextBox1.Text+ "8";
		textBox1.Text = textBox1.Text+ "8";
	}
		}
		void Button9Click(object sender, EventArgs e)
		{
	if (richTextBox1.Text=="0" && richTextBox1.Text!=null||seter == 1  )
			{
				richTextBox1.Text= "9";
				textBox1.Text = "9";
				seter = 0;
			}
	else 
	{
		richTextBox1.Text = richTextBox1.Text+ "9";
		textBox1.Text = textBox1.Text+ "9";
	}
		}
		void NxClick(object sender, EventArgs e)
		{
	firstnumber = Convert.ToDouble(richTextBox1.Text);
			seter = 1;
			noperation = "x";
			textBox1.Text = noperation;
			fullstop = 1;
		}
		void NclearClick(object sender, EventArgs e)
		{
			richTextBox1.Text = "0";
			textBox1.Text = "0";
			fullstop = 1;
		}
		void NdivClick(object sender, EventArgs e)
		{
			firstnumber = Convert.ToDouble(richTextBox1.Text);
			seter = 1;
			noperation = "/";
			textBox1.Text = noperation;
			fullstop = 1;
		}
		void NminnusClick(object sender, EventArgs e)
		{
	        firstnumber = Convert.ToDouble(richTextBox1.Text);
	        seter = 1;
			noperation = "-";
			textBox1.Text = noperation;
			fullstop = 1;
		}
		void NplusClick(object sender, EventArgs e)
		{
	       firstnumber = Convert.ToDouble(richTextBox1.Text);
	       seter =1;
			noperation = "+";
			textBox1.Text = noperation;
			fullstop = 1;
		}
		void NeqClick(object sender, EventArgs e)
		{
			
			seter = 0;
			secondnumber = Convert.ToDouble(richTextBox1.Text);
			//for additon
			if (noperation == "+")
			{
				textBox1.Text=Convert.ToString(firstnumber) + " + " + Convert.ToString(secondnumber) + " =";
				result =(firstnumber + secondnumber);
				richTextBox1.Text = Convert.ToString(result);
				firstnumber = result;
			}
			
				//for subtraction
			if (noperation == "-")
			{
				textBox1.Text=Convert.ToString(firstnumber) + " - "+ Convert.ToString(secondnumber) + " =";
				result =(firstnumber - secondnumber);
				richTextBox1.Text = Convert.ToString(result);
				firstnumber = result;
			}
			
				//for multiplication
			if (noperation == "x")
			{
				textBox1.Text=Convert.ToString(firstnumber) + " x "+ Convert.ToString(secondnumber) + " =";
				result =(firstnumber * secondnumber);
				richTextBox1.Text = Convert.ToString(result);
				firstnumber = result;
			}
				//for division
			if (noperation == "/")
			{
				textBox1.Text=Convert.ToString(firstnumber) + " / " + Convert.ToString(secondnumber) + " =";
				if(secondnumber == 0)
			{ 
				richTextBox1.Text = "sorry cannot divide by zero";
			}
				else
				{
					result =(firstnumber / secondnumber);
				richTextBox1.Text = Convert.ToString(result);
				firstnumber = result;
					
				}
			}
			if (noperation =="%")
			{
				result=(firstnumber/100);
				richTextBox1.Text = Convert.ToString(result);
			firstnumber = result;
			}
		}
		void N_Click(object sender, EventArgs e)
		{ 

			if(fullstop == 1)
			{
		if(richTextBox1.Text== "0" && richTextBox1.Text!=null || seter == 1 )
		{richTextBox1.Text= "0"+".";
			textBox1.Text = "0"+".";
			seter = 0;
			fullstop =2;}
		else
		{
			richTextBox1.Text= richTextBox1.Text + ".";
			textBox1.Text = textBox1.Text + ".";
			fullstop =2;
		}
			}
			else 
			{seter =0;}
		}
		void NperrcentClick(object sender, EventArgs e)
		{
			firstnumber = Convert.ToDouble(richTextBox1.Text);
			textBox1.Text = Convert.ToString(firstnumber) + "%";
			noperation = "%";
			seter = 1;
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void NdelClick(object sender, EventArgs e)
		{ 
						
			delete = Convert.ToInt32(richTextBox1.Text);
		
			richTextBox1.Text = Convert.ToString(delete/10);
			textBox1.Text = richTextBox1.Text;
		
		}
		void ReverseClick(object sender, EventArgs e)
		{
	 if(richTextBox1.Text== "0" && richTextBox1.Text !=null || seter == 1 )
	 {
	 	richTextBox1.Text= Convert.ToString(mminus);
			textBox1.Text = Convert.ToString(mminus);
			seter = 0;}
		else
		{  
			minusguy = Convert.ToInt32(richTextBox1.Text);
			richTextBox1.Text= Convert.ToString(mminus) + Convert.ToString(0 - minusguy);
			textBox1.Text =Convert.ToString(mminus) + Convert.ToString(0 - minusguy);
		}
			
		}
		void N0Click(object sender, EventArgs e)
		{
	if(richTextBox1.Text== "0" && richTextBox1.Text !=null || seter == 1 )
		{richTextBox1.Text= "0";
			textBox1.Text = "0";
			seter = 0;}
		else
		{
			richTextBox1.Text= richTextBox1.Text + "0";
			textBox1.Text = textBox1.Text + "0";
		}
			
		}
	}
}
