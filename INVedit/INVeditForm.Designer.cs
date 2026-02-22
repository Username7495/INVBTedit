/*
 * Created by SharpDevelop.
 * User: CHIEFTEC
 * Date: 19.02.2026
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NBTedit
{
	partial class INVeditForm
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
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.boxItems = new System.Windows.Forms.ListView();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.boxSearch = new System.Windows.Forms.TextBox();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVeditForm));
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnSave,
			                        this.btnClose});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(672, 25);
			this.toolStrip.TabIndex = 4;
			// 
			// btnClose
			// 
			this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(32, 22);
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnSave
			// 
			this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(32, 22);
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			this.btnSave.Enabled = false;
			// 
			// tabControl
			// 
			this.tabControl.AllowDrop = true;
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl.Location = new System.Drawing.Point(5, 29);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(481, 323);
			this.tabControl.TabIndex = 1;
			this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlSelected);
			this.tabControl.DragOver += new System.Windows.Forms.DragEventHandler(this.TabControlDragOver);
			// 
			// boxItems
			// 
			this.boxItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.boxItems.Location = new System.Drawing.Point(518, 51);
			this.boxItems.MultiSelect = false;
			this.boxItems.Name = "boxItems";
			this.boxItems.Size = new System.Drawing.Size(150, 301);
			this.boxItems.TabIndex = 3;
			this.boxItems.TileSize = new System.Drawing.Size(128, 19);
			this.boxItems.UseCompatibleStateImageBehavior = false;
			this.boxItems.View = System.Windows.Forms.View.Tile;
			// 
			// boxSearch
			// 
			this.boxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.boxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boxSearch.ForeColor = System.Drawing.Color.Gray;
			this.boxSearch.Location = new System.Drawing.Point(518, 29);
			this.boxSearch.Name = "boxSearch";
			this.boxSearch.Size = new System.Drawing.Size(150, 20);
			this.boxSearch.TabIndex = 2;
			this.boxSearch.Text = "Search...";
			this.boxSearch.TextChanged += new System.EventHandler(this.BoxSearchTextChanged);
			this.boxSearch.Enter += new System.EventHandler(this.BoxSearchEnter);
			this.boxSearch.Leave += new System.EventHandler(this.BoxSearchLeave);
			// 
			// INVeditForm
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(672, 356);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.boxItems);
			this.Controls.Add(this.boxSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "INVeditForm";
			this.Text = "INVedit - Minecraft Inventory Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.INVeditFormFormClosing);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.ListView boxItems;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripButton btnClose;
		private System.Windows.Forms.TextBox boxSearch;
	}
}
