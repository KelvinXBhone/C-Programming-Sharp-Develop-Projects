/*
 * Created by SharpDevelop.
 * User: Kelvin
 * Date: 2/8/2024
 * Time: 2:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace TestCaseProject
{
	/// <summary>
	/// Description of DynamicForm.
	/// </summary>
	public partial class DynamicForm : Form
	{
		ArrayList nums;
		int curIndex;
			public DynamicForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DynamicFormLoad(object sender, EventArgs e)
		{
			nums =new ArrayList();
			curIndex=0;
		}
		
		void AddBtnClick(object sender, EventArgs e)
		{
			int num = Int32.Parse(txtInput.Text);
			nums.Add(num);
			curIndex++;
			lblOutput.Text=curIndex.ToString();
		}
		
		void LblOutputClick(object sender, EventArgs e)
		{
			
		}
	}
}
