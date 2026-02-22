/*
 * Erstellt mit SharpDevelop.
 * Benutzer: copyboy
 * Datum: 24.01.2010
 * Zeit: 23:13
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace NBTedit
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("root [0 entries]", 9, 9);
			NamedBinaryTag.TagCompound tagCompound2 = new NamedBinaryTag.TagCompound();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.inveditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.inveditToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.renameToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.byteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.shortToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.intToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.longToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.floatToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.doubleToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.byteArrayToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.stringToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.listToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.byteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.floatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.byteArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compoundToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.imageListTypes = new System.Windows.Forms.ImageList(this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.nbtView = new NBTedit.NBTView();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenu,
									this.editToolStripMenu,
									this.searchToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(472, 24);
			this.menuStrip.TabIndex = 0;
			// 
			// fileToolStripMenu
			// 
			this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.openToolStripMenuItem,
									this.reloadToolStripMenuItem,
									this.toolStripSeparator1,
									this.saveToolStripMenuItem,
									this.saveAsToolStripMenuItem,
									this.toolStripSeparator2,
									this.exitToolStripMenuItem});
			this.fileToolStripMenu.Name = "fileToolStripMenu";
			this.fileToolStripMenu.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenu.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.New);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.Open);
			// 
			// reloadToolStripMenuItem
			// 
			this.reloadToolStripMenuItem.Enabled = false;
			this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
			this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
			this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.reloadToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.reloadToolStripMenuItem.Text = "Reload";
			this.reloadToolStripMenuItem.Click += new System.EventHandler(this.Reload);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.saveToolStripMenuItem.Text = "Save...";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
									| System.Windows.Forms.Keys.S)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.saveAsToolStripMenuItem.Text = "Save as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAs);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.exitToolStripMenuItem.Text = "Quit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
			// 
			// editToolStripMenu
			// 
			this.editToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cutToolStripMenuItem,
									this.copyToolStripMenuItem,
									this.pasteToolStripMenuItem,
									this.deleteToolStripMenuItem,
									this.toolStripSeparator5,
									this.renameToolStripMenuItem,
									this.editToolStripMenuItem,
									this.inveditToolStripMenuItem,
									this.toolStripSeparator6,
									this.moveUpToolStripMenuItem,
									this.moveDownToolStripMenuItem});
			this.editToolStripMenu.Name = "editToolStripMenu";
			this.editToolStripMenu.Size = new System.Drawing.Size(37, 20);
			this.editToolStripMenu.Text = "&Edit";
			// 
			// inveditToolStripButton
			// 
			this.inveditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inveditToolStripMenuItem.Image")));
			this.inveditToolStripMenuItem.Name = "inveditToolStripMenuItem";
			this.inveditToolStripMenuItem.Size = new System.Drawing.Size(23, 22);
			this.inveditToolStripMenuItem.Text = "INVedit...";
			this.inveditToolStripMenuItem.Click += new System.EventHandler(this.INVedit);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.Cut);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.Copy);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.Paste);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renameToolStripMenuItem.Image")));
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.Rename);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.editToolStripMenuItem.Text = "Edit...";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.Edit);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(199, 6);
			// 
			// moveUpToolStripMenuItem
			// 
			this.moveUpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveUpToolStripMenuItem.Image")));
			this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
			this.moveUpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
			this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.moveUpToolStripMenuItem.Text = "Move up";
			this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.MoveUp);
			// 
			// moveDownToolStripMenuItem
			// 
			this.moveDownToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moveDownToolStripMenuItem.Image")));
			this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
			this.moveDownToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
			this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.moveDownToolStripMenuItem.Text = "Move down";
			this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.MoveDown);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.findToolStripMenuItem,
									this.findNextToolStripMenuItem});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.searchToolStripMenuItem.Text = "&Search";
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.findToolStripMenuItem.Text = "Find...";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.Find);
			// 
			// findNextToolStripMenuItem
			// 
			this.findNextToolStripMenuItem.Enabled = false;
			this.findNextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findNextToolStripMenuItem.Image")));
			this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
			this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.findNextToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.findNextToolStripMenuItem.Text = "Find next";
			this.findNextToolStripMenuItem.Click += new System.EventHandler(this.FindNext);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About);
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripButton,
									this.openToolStripButton,
									this.saveToolStripButton,
									this.toolStripSeparator3,
									this.inveditToolStripButton,
									this.renameToolStripButton,
									this.editToolStripButton,
									this.deleteToolStripButton,
									this.toolStripSeparator4,
									this.byteToolStripButton,
									this.shortToolStripButton,
									this.intToolStripButton,
									this.longToolStripButton,
									this.floatToolStripButton,
									this.doubleToolStripButton,
									this.byteArrayToolStripButton,
									this.stringToolStripButton,
									this.listToolStripDropDownButton,
									this.compoundToolStripButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(472, 25);
			this.toolStrip.TabIndex = 2;
			// 
			// inveditToolStripButton
			// 
			this.inveditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.inveditToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("inveditToolStripButton.Image")));
			this.inveditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.inveditToolStripButton.Name = "inveditToolStripButton";
			this.inveditToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.inveditToolStripButton.Click += new System.EventHandler(this.INVedit);
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Click += new System.EventHandler(this.New);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Click += new System.EventHandler(this.Open);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Click += new System.EventHandler(this.Save);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// renameToolStripButton
			// 
			this.renameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.renameToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("renameToolStripButton.Image")));
			this.renameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.renameToolStripButton.Name = "renameToolStripButton";
			this.renameToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.renameToolStripButton.Click += new System.EventHandler(this.Rename);
			// 
			// editToolStripButton
			// 
			this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
			this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editToolStripButton.Name = "editToolStripButton";
			this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.editToolStripButton.Click += new System.EventHandler(this.Edit);
			// 
			// deleteToolStripButton
			// 
			this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
			this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteToolStripButton.Name = "deleteToolStripButton";
			this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.deleteToolStripButton.Click += new System.EventHandler(this.Delete);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// byteToolStripButton
			// 
			this.byteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.byteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("byteToolStripButton.Image")));
			this.byteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.byteToolStripButton.Name = "byteToolStripButton";
			this.byteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.byteToolStripButton.ToolTipText = "Byte (Ctrl+1)";
			this.byteToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// shortToolStripButton
			// 
			this.shortToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.shortToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("shortToolStripButton.Image")));
			this.shortToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.shortToolStripButton.Name = "shortToolStripButton";
			this.shortToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.shortToolStripButton.ToolTipText = "Short (Ctrl+2)";
			this.shortToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// intToolStripButton
			// 
			this.intToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.intToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("intToolStripButton.Image")));
			this.intToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.intToolStripButton.Name = "intToolStripButton";
			this.intToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.intToolStripButton.ToolTipText = "Int (Ctrl+3)";
			this.intToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// longToolStripButton
			// 
			this.longToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.longToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("longToolStripButton.Image")));
			this.longToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.longToolStripButton.Name = "longToolStripButton";
			this.longToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.longToolStripButton.ToolTipText = "Long (Ctrl+4)";
			this.longToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// floatToolStripButton
			// 
			this.floatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.floatToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("floatToolStripButton.Image")));
			this.floatToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.floatToolStripButton.Name = "floatToolStripButton";
			this.floatToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.floatToolStripButton.ToolTipText = "Float (Ctrl+5)";
			this.floatToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// doubleToolStripButton
			// 
			this.doubleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.doubleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("doubleToolStripButton.Image")));
			this.doubleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.doubleToolStripButton.Name = "doubleToolStripButton";
			this.doubleToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.doubleToolStripButton.ToolTipText = "Double (Ctrl+6)";
			this.doubleToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// byteArrayToolStripButton
			// 
			this.byteArrayToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.byteArrayToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("byteArrayToolStripButton.Image")));
			this.byteArrayToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.byteArrayToolStripButton.Name = "byteArrayToolStripButton";
			this.byteArrayToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.byteArrayToolStripButton.ToolTipText = "ByteArray (Ctrl+7)";
			this.byteArrayToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// stringToolStripButton
			// 
			this.stringToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stringToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stringToolStripButton.Image")));
			this.stringToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.stringToolStripButton.Name = "stringToolStripButton";
			this.stringToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.stringToolStripButton.ToolTipText = "String (Ctrl+8)";
			this.stringToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// listToolStripDropDownButton
			// 
			this.listToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.listToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.byteToolStripMenuItem,
									this.shortToolStripMenuItem,
									this.intToolStripMenuItem,
									this.longToolStripMenuItem,
									this.floatToolStripMenuItem,
									this.doubleToolStripMenuItem,
									this.byteArrayToolStripMenuItem,
									this.stringToolStripMenuItem,
									this.listToolStripMenuItem,
									this.compoundToolStripMenuItem});
			this.listToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("listToolStripDropDownButton.Image")));
			this.listToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.listToolStripDropDownButton.Name = "listToolStripDropDownButton";
			this.listToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
			this.listToolStripDropDownButton.ToolTipText = "List (Ctrl+Shift+X)";
			this.listToolStripDropDownButton.Click += new System.EventHandler(this.AddList);
			// 
			// byteToolStripMenuItem
			// 
			this.byteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("byteToolStripMenuItem.Image")));
			this.byteToolStripMenuItem.Name = "byteToolStripMenuItem";
			this.byteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D1)));
			this.byteToolStripMenuItem.ShowShortcutKeys = false;
			this.byteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.byteToolStripMenuItem.Text = "Byte";
			this.byteToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// shortToolStripMenuItem
			// 
			this.shortToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shortToolStripMenuItem.Image")));
			this.shortToolStripMenuItem.Name = "shortToolStripMenuItem";
			this.shortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D2)));
			this.shortToolStripMenuItem.ShowShortcutKeys = false;
			this.shortToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.shortToolStripMenuItem.Text = "Short";
			this.shortToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// intToolStripMenuItem
			// 
			this.intToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("intToolStripMenuItem.Image")));
			this.intToolStripMenuItem.Name = "intToolStripMenuItem";
			this.intToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D3)));
			this.intToolStripMenuItem.ShowShortcutKeys = false;
			this.intToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.intToolStripMenuItem.Text = "Int";
			this.intToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// longToolStripMenuItem
			// 
			this.longToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("longToolStripMenuItem.Image")));
			this.longToolStripMenuItem.Name = "longToolStripMenuItem";
			this.longToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D4)));
			this.longToolStripMenuItem.ShowShortcutKeys = false;
			this.longToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.longToolStripMenuItem.Text = "Long";
			this.longToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// floatToolStripMenuItem
			// 
			this.floatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("floatToolStripMenuItem.Image")));
			this.floatToolStripMenuItem.Name = "floatToolStripMenuItem";
			this.floatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D5)));
			this.floatToolStripMenuItem.ShowShortcutKeys = false;
			this.floatToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.floatToolStripMenuItem.Text = "Float";
			this.floatToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// doubleToolStripMenuItem
			// 
			this.doubleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doubleToolStripMenuItem.Image")));
			this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
			this.doubleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D6)));
			this.doubleToolStripMenuItem.ShowShortcutKeys = false;
			this.doubleToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.doubleToolStripMenuItem.Text = "Double";
			this.doubleToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// byteArrayToolStripMenuItem
			// 
			this.byteArrayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("byteArrayToolStripMenuItem.Image")));
			this.byteArrayToolStripMenuItem.Name = "byteArrayToolStripMenuItem";
			this.byteArrayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D7)));
			this.byteArrayToolStripMenuItem.ShowShortcutKeys = false;
			this.byteArrayToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.byteArrayToolStripMenuItem.Text = "ByteArray";
			this.byteArrayToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// stringToolStripMenuItem
			// 
			this.stringToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stringToolStripMenuItem.Image")));
			this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
			this.stringToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D8)));
			this.stringToolStripMenuItem.ShowShortcutKeys = false;
			this.stringToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.stringToolStripMenuItem.Text = "String";
			this.stringToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// listToolStripMenuItem
			// 
			this.listToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listToolStripMenuItem.Image")));
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D9)));
			this.listToolStripMenuItem.ShowShortcutKeys = false;
			this.listToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.listToolStripMenuItem.Text = "List";
			this.listToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// compoundToolStripMenuItem
			// 
			this.compoundToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compoundToolStripMenuItem.Image")));
			this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
			this.compoundToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.D0)));
			this.compoundToolStripMenuItem.ShowShortcutKeys = false;
			this.compoundToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.compoundToolStripMenuItem.Text = "Compound";
			this.compoundToolStripMenuItem.Click += new System.EventHandler(this.AddList);
			// 
			// compoundToolStripButton
			// 
			this.compoundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.compoundToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("compoundToolStripButton.Image")));
			this.compoundToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.compoundToolStripButton.Name = "compoundToolStripButton";
			this.compoundToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.compoundToolStripButton.ToolTipText = "Compound (Ctrl+0)";
			this.compoundToolStripButton.Click += new System.EventHandler(this.Add);
			// 
			// imageListTypes
			// 
			this.imageListTypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTypes.ImageStream")));
			this.imageListTypes.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListTypes.Images.SetKeyName(0, "Byte");
			this.imageListTypes.Images.SetKeyName(1, "Short");
			this.imageListTypes.Images.SetKeyName(2, "Int");
			this.imageListTypes.Images.SetKeyName(3, "Long");
			this.imageListTypes.Images.SetKeyName(4, "Float");
			this.imageListTypes.Images.SetKeyName(5, "Double");
			this.imageListTypes.Images.SetKeyName(6, "ByteArray");
			this.imageListTypes.Images.SetKeyName(7, "String");
			this.imageListTypes.Images.SetKeyName(8, "List");
			this.imageListTypes.Images.SetKeyName(9, "Compound");
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "nbt";
			this.openFileDialog.Filter = "All types (*.*)|*.*|NamedBinaryTag (*.nbt)|*.nbt";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "nbt";
			this.saveFileDialog.Filter = "All types (*.*)|*.*|NamedBinaryTag (*.nbt)|*.nbt";
			// 
			// nbtView
			// 
			this.nbtView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.nbtView.ImageIndex = 0;
			this.nbtView.ImageList = this.imageListTypes;
			this.nbtView.Location = new System.Drawing.Point(3, 52);
			this.nbtView.Name = "nbtView";
			treeNode2.ImageIndex = 9;
			treeNode2.Name = "root";
			treeNode2.SelectedImageIndex = 9;
			treeNode2.Tag = tagCompound2;
			treeNode2.Text = "root [0 entries]";
			this.nbtView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
									treeNode2});
			this.nbtView.SelectedImageIndex = 0;
			this.nbtView.ShowRootLines = false;
			this.nbtView.Size = new System.Drawing.Size(465, 311);
			this.nbtView.Sorted = true;
			this.nbtView.TabIndex = 5;
			this.nbtView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.NodeDoubleClick);
			this.nbtView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.AfterLabelEdit);
			this.nbtView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.BeforeCollapse);
			this.nbtView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfterSelect);
			this.nbtView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 366);
			this.Controls.Add(this.nbtView);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(420, 340);
			this.Name = "MainForm";
			this.Text = "NBTedit - unnamed.nbt";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem byteArrayToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton listToolStripDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem compoundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem floatToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem longToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shortToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem byteToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton inveditToolStripButton;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripButton byteToolStripButton;
		private System.Windows.Forms.ToolStripButton shortToolStripButton;
		private System.Windows.Forms.ToolStripButton intToolStripButton;
		private System.Windows.Forms.ToolStripButton longToolStripButton;
		private System.Windows.Forms.ToolStripButton floatToolStripButton;
		private System.Windows.Forms.ToolStripButton doubleToolStripButton;
		private System.Windows.Forms.ToolStripButton byteArrayToolStripButton;
		private System.Windows.Forms.ToolStripButton stringToolStripButton;
		private System.Windows.Forms.ToolStripButton compoundToolStripButton;
		private System.Windows.Forms.ToolStripButton renameToolStripButton;
		private System.Windows.Forms.ToolStripButton editToolStripButton;
		private System.Windows.Forms.ToolStripButton deleteToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
		private System.Windows.Forms.ToolStripMenuItem inveditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenu;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		public NBTedit.NBTView nbtView;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ImageList imageListTypes;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
	}
}
