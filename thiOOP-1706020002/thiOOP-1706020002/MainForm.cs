/*
 * Created by SharpDevelop.
 * User: C1-C02
 * Date: 1/8/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace thiOOP_1706020002
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsPoint D1 = new clsPoint();
		clsPoint D2 = new clsPoint();
		
		bool isDrawing = false;
		List<clsHinh>lsHinh= new List<clsHinh>();
		BindingList<clsHinh> bindingList;
		BindingSource source;
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
		
		void PbDrawMouseDown(object sender, MouseEventArgs e)
		{
			if(toolstripbtline.Checked == true)
			{
				isDrawing = true;
				D1.X = e.X;
				D1.Y = e.Y;
			}
		}
		
		void PbDrawMouseMove(object sender, MouseEventArgs e)
		{
			if(isDrawing == true)
			{
				if(toolstripbtline.Checked == true)
				{
					System.Drawing.Graphics g = pbDraw.CreateGraphics();
					g.DrawLine(new Pen(Color.White),D1.X,D1.Y,D2.X,D2.Y);
					D2.X = e.X;
					D2.Y = e.Y;
					foreach (var element in lsHinh) {
						element.Draw(g,new Pen(Color.Black));
					}
					g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				}
			}
		}
		
		void PdDrawMouseUp(object sender, MouseEventArgs e)
		{
			if(toolstripbtline.Checked == true)
			{
				D2.X = e.X;
				D2.Y = e.Y;
				System.Drawing.Graphics g = pbDraw.CreateGraphics();
				g.DrawLine(new Pen(Color.Black),D1.X,D1.Y,D2.X,D2.Y);
				isDrawing = false;
				
			 
				clsLine l = new clsLine(D1,D2);
				lsHinh.Add(l);
				foreach (var element in lsHinh) {
						element.Draw(g,new Pen(Color.Black));
					}
			}
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Json Files|*.json|All Files|*.*";
			if(save.ShowDialog() == DialogResult.OK)
			{
				string sFileName = save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(pbDraw);
				StreamWriter writer ;
				writer = new StreamWriter(sFileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("Saved !");
}
		}
		
		void BtnLoadClick(object sender, EventArgs e)
		{
			
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Json Files|*.json|All Files|*.*";
			if(open.ShowDialog() == DialogResult.OK)
			{
				string sFileName = open.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var deserializeObject = serializer.Deserialize<List<clsHinh>>(json);
				source.Clear();
				foreach (var element in deserializeObject) {
					source.Add(element);
				}
				MessageBox.Show("Load OK !");
			}
		}
	}
}
