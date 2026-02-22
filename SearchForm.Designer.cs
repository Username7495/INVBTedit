/*
 * Erstellt mit SharpDevelop.
 * Benutzer: copyboy
 * Datum: 27.01.2010
 * Zeit: 15:57
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace NBTedit
{
	partial class SearchForm
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxValue = new System.Windows.Forms.TextBox();
			this.comboBoxTags = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(45, 3);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(226, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Value:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxValue
			// 
			this.textBoxValue.Location = new System.Drawing.Point(45, 25);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(226, 20);
			this.textBoxValue.TabIndex = 1;
			// 
			// comboBoxTags
			// 
			this.comboBoxTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTags.Items.AddRange(new object[] {
									"All (Number, ByteArray, String, Container)",
									"Number (Integer, Floating point)",
									"Integer (Byte, Short, Int, Long)",
									"Floating point (Float, Double)",
									"Container (List, Compound)",
									"Byte",
									"Short",
									"Int",
									"Long",
									"Float",
									"Double",
									"ByteArray",
									"String",
									"List",
									"Compound"});
			this.comboBoxTags.Location = new System.Drawing.Point(45, 47);
			this.comboBoxTags.MaxDropDownItems = 5;
			this.comboBoxTags.Name = "comboBoxTags";
			this.comboBoxTags.Size = new System.Drawing.Size(226, 21);
			this.comboBoxTags.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tags:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 71);
			this.Controls.Add(this.comboBoxTags);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Find...";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.ComboBox comboBoxTags;
		public System.Windows.Forms.TextBox textBoxName;
		public System.Windows.Forms.TextBox textBoxValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
