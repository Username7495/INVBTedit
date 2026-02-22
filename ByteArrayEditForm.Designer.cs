/*
 * Erstellt mit SharpDevelop.
 * Benutzer: copyboy
 * Datum: 09.02.2010
 * Zeit: 17:39
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace NBTedit
{
	partial class ByteArrayEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByteArrayEditForm));
			this.buttonImport = new System.Windows.Forms.Button();
			this.buttonExport = new System.Windows.Forms.Button();
			this.boxGZip = new System.Windows.Forms.CheckBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// buttonImport
			// 
			this.buttonImport.Image = ((System.Drawing.Image)(resources.GetObject("buttonImport.Image")));
			this.buttonImport.Location = new System.Drawing.Point(1, 1);
			this.buttonImport.Name = "buttonImport";
			this.buttonImport.Size = new System.Drawing.Size(76, 24);
			this.buttonImport.TabIndex = 0;
			this.buttonImport.Text = "Import";
			this.buttonImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonImport.UseVisualStyleBackColor = true;
			this.buttonImport.Click += new System.EventHandler(this.ImportClick);
			// 
			// buttonExport
			// 
			this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
			this.buttonExport.Location = new System.Drawing.Point(78, 1);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(76, 24);
			this.buttonExport.TabIndex = 0;
			this.buttonExport.Text = "Export";
			this.buttonExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.ExportClick);
			// 
			// boxGZip
			// 
			this.boxGZip.Location = new System.Drawing.Point(158, 2);
			this.boxGZip.Name = "boxGZip";
			this.boxGZip.Size = new System.Drawing.Size(53, 24);
			this.boxGZip.TabIndex = 1;
			this.boxGZip.Text = "GZip";
			this.boxGZip.UseVisualStyleBackColor = true;
			// 
			// buttonClose
			// 
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Location = new System.Drawing.Point(213, 1);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(60, 24);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			// 
			// ByteArrayEditForm
			// 
			this.AcceptButton = this.buttonClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(274, 26);
			this.Controls.Add(this.boxGZip);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonImport);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ByteArrayEditForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit value...";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.CheckBox boxGZip;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.Button buttonImport;
	}
}
