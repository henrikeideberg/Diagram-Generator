﻿namespace Diagram_Generator
{
	partial class Diagram_Generator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.diagramPanel = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortXdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortYdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClearDiagram = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// diagramPanel
			// 
			this.diagramPanel.BackColor = System.Drawing.Color.White;
			this.diagramPanel.Location = new System.Drawing.Point(404, 63);
			this.diagramPanel.Name = "diagramPanel";
			this.diagramPanel.Size = new System.Drawing.Size(669, 569);
			this.diagramPanel.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportXMLToolStripMenuItem,
            this.importXMLToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// dataToolStripMenuItem
			// 
			this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortXdirToolStripMenuItem,
            this.sortYdirToolStripMenuItem});
			this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
			this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.dataToolStripMenuItem.Text = "Data";
			// 
			// exportXMLToolStripMenuItem
			// 
			this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
			this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exportXMLToolStripMenuItem.Text = "Export XML";
			// 
			// importXMLToolStripMenuItem
			// 
			this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
			this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.importXMLToolStripMenuItem.Text = "Import XML";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// sortXdirToolStripMenuItem
			// 
			this.sortXdirToolStripMenuItem.Name = "sortXdirToolStripMenuItem";
			this.sortXdirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.sortXdirToolStripMenuItem.Text = "Sort x-dir";
			// 
			// sortYdirToolStripMenuItem
			// 
			this.sortYdirToolStripMenuItem.Name = "sortYdirToolStripMenuItem";
			this.sortYdirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.sortYdirToolStripMenuItem.Text = "Sort y-dir";
			// 
			// btnClearDiagram
			// 
			this.btnClearDiagram.Location = new System.Drawing.Point(884, 658);
			this.btnClearDiagram.Name = "btnClearDiagram";
			this.btnClearDiagram.Size = new System.Drawing.Size(189, 34);
			this.btnClearDiagram.TabIndex = 2;
			this.btnClearDiagram.Text = "Clear Diagram";
			this.btnClearDiagram.UseVisualStyleBackColor = true;
			// 
			// Diagram_Generator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1085, 704);
			this.Controls.Add(this.btnClearDiagram);
			this.Controls.Add(this.diagramPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Diagram_Generator";
			this.Text = "Diagram Generator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel diagramPanel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortXdirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortYdirToolStripMenuItem;
		private System.Windows.Forms.Button btnClearDiagram;
	}
}

