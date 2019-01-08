/*
 * Created by SharpDevelop.
 * User: C1-C02
 * Date: 1/8/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace thiOOP_1706020002
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolstripbtline = new System.Windows.Forms.ToolStripButton();
			this.toolStriptriangle = new System.Windows.Forms.ToolStripButton();
			this.toolstripRhombus = new System.Windows.Forms.ToolStripButton();
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolstripbtline,
									this.toolStriptriangle,
									this.toolstripRhombus});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(348, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolstripbtline
			// 
			this.toolstripbtline.CheckOnClick = true;
			this.toolstripbtline.Image = ((System.Drawing.Image)(resources.GetObject("toolstripbtline.Image")));
			this.toolstripbtline.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolstripbtline.Name = "toolstripbtline";
			this.toolstripbtline.Size = new System.Drawing.Size(30, 35);
			this.toolstripbtline.Text = "line";
			this.toolstripbtline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStriptriangle
			// 
			this.toolStriptriangle.CheckOnClick = true;
			this.toolStriptriangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStriptriangle.Image")));
			this.toolStriptriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStriptriangle.Name = "toolStriptriangle";
			this.toolStriptriangle.Size = new System.Drawing.Size(51, 35);
			this.toolStriptriangle.Text = "triangle";
			this.toolStriptriangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolstripRhombus
			// 
			this.toolstripRhombus.CheckOnClick = true;
			this.toolstripRhombus.Image = ((System.Drawing.Image)(resources.GetObject("toolstripRhombus.Image")));
			this.toolstripRhombus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolstripRhombus.Name = "toolstripRhombus";
			this.toolstripRhombus.Size = new System.Drawing.Size(59, 35);
			this.toolstripRhombus.Text = "rhombus";
			this.toolstripRhombus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.White;
			this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraw.Location = new System.Drawing.Point(0, 38);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(348, 280);
			this.pbDraw.TabIndex = 1;
			this.pbDraw.TabStop = false;
			this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PdDrawMouseUp);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(184, 9);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(265, 9);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoadClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 318);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.pbDraw);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "paint";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ToolStripButton toolstripRhombus;
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.ToolStripButton toolStriptriangle;
		private System.Windows.Forms.ToolStripButton toolstripbtline;
		private System.Windows.Forms.ToolStrip toolStrip1;
		
		 
	}
}
