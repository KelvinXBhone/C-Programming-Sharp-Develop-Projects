/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 12/14/2023
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LuckyDraw
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
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnClick(object sender, EventArgs e)
		{
			int num;
			string message;
			
			lblOutput.Text ="";
			Random random=new Random();
			num=random.Next(1,7);
			
			//num = int.Parse(txtNum.Text);
			
			if (num==1)
				message = "You have won a fan ticket of Wonyoung !";
			else if (num==2)
				message = "You won a favourite choice of IVE album !";
			else if (num==3)
				message = "You got a chance to participate in live show of any choice of idol group";
			else if (num==4)
				message = "You got a date with Wonyoung!";
			else if (num==5)
				message = "You won a PCs of any favourite idol!";
			else if (num==6)
				message = "You won a any choice of your favourite lightstick!";
			else 
				message ="You are a scam or wrong lucky draw number";
			
			lblOutput.Text=message;
		}
	}
}
