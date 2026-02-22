/*
 * Created by SharpDevelop.
 * User: CHIEFTEC
 * Date: 19.02.2026
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using NBTedit.INVedit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using INVedit;
using NamedBinaryTag;

namespace NBTedit
{
	/// <summary>
	/// Description of INVeditForm.
	/// </summary>
	public partial class INVeditForm : Form
	{
		static string appdata;
		static INVeditForm() {
			if (Platform.Current == Platform.Windows) {
				appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"/.minecraft";
			} else if (Platform.Current == Platform.Mac) {
				appdata = Environment.ExpandEnvironmentVariables("HOME")+"/Library/Application Support/minecraft";
			} else {
				appdata = Environment.ExpandEnvironmentVariables("HOME")+"/.minecraft";
			}
		}

		List<CheckBox> groups = new List<CheckBox>();

		public INVeditForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Data.Init("items.txt");
			
			boxItems.LargeImageList = Data.list;
			boxItems.ItemDrag += ItemDrag;
			
			foreach (Data.Group group in Data.groups.Values) {
				CheckBox box = new CheckBox();
				box.Size = new Size(26, 26);
				box.Location = new Point(Width-189 + (groups.Count / 12) * 27, 29 + (groups.Count % 12) * 27);
				box.ImageList = Data.list;
				box.ImageIndex = group.imageIndex;
				box.Appearance = Appearance.Button;
				box.Checked = true;
				box.Tag = group;
				box.MouseDown += ItemMouseDown;
				Controls.Add(box);
				groups.Add(box);
			}
			Width += ((groups.Count-1) / 12) * 27;
			
			UpdateItems();
			
			Open();
		}
		
		void TabControlDragOver(object sender, DragEventArgs e)
		{
			Point point = tabControl.PointToClient(new Point(e.X, e.Y));
			TabPage hover = null;
			for (int i = 0; i < tabControl.TabPages.Count; ++i)
				if (tabControl.GetTabRect(i).Contains(point)) {
				hover = tabControl.TabPages[i];
				break;
			}
			if (hover == null) return;
			if (!e.Data.GetDataPresent(typeof(Item))) return;
			tabControl.SelectedTab = hover;
		}
		
		void TabControlSelected(object sender, TabControlEventArgs e)
		{
			if (e.TabPage != null) {
				Text = "INVedit - "+e.TabPage.Text;
			} else {
				Text = "INVedit - Minecraft Inventory Editor";
			}
			
		}
		
		void ItemDrag(object sender, ItemDragEventArgs e)
		{
			if (e.Button != MouseButtons.Left) return;
			Item item = (Item)((ListViewItem)e.Item).Tag;
			item = new Item(item.ID, 1, 0, item.Damage);
			DoDragDrop(item, DragDropEffects.Copy | DragDropEffects.Move);
		}
		
		void ItemMouseDown(object sender, MouseEventArgs e)
		{
			CheckBox self = (CheckBox)sender;
			bool changed = false;
			if (e.Button == MouseButtons.Right) {
				bool other = true;
				foreach (CheckBox box in groups)
					if (box.Checked == (self!=box))
						other = false;
				foreach (CheckBox box in groups)
					if (box.Checked == (self!=box) || other) {
					changed = true;
					box.Checked = (self==box) || other;
				}
			} else if (e.Button == MouseButtons.Left) {
				self.Checked = !self.Checked;
				changed = true;
			} else return;
			self.Select();
			if (changed) UpdateItems();
			if (e.Button == MouseButtons.Left)
				self.Checked = !self.Checked;
		}
		
		void UpdateItems()
		{
			boxItems.BeginUpdate();
			boxItems.Clear();
			if (boxSearch.Text == "" || boxSearch.Font.Italic) {
				foreach (CheckBox box in groups) if (box.Checked)
					foreach (Data.Item item in ((Data.Group)box.Tag).items)
						boxItems.Items.Add(new ListViewItem(item.name, item.imageIndex){ Tag = new Item(item.id, 0, 0, item.damage) });
			} else {
				short id;
				if (short.TryParse(boxSearch.Text, out id)) {
					if (Data.items.ContainsKey(id))
						foreach (Data.Item item in Data.items[id].Values)
							boxItems.Items.Add(new ListViewItem(item.name, item.imageIndex){ Tag = new Item(item.id, 0, 0, item.damage) });
					else boxItems.Items.Add(new ListViewItem("Unknown item "+id, 0){ Tag = new Item(id) });
				} else foreach (CheckBox box in groups) if (box.Checked)
					foreach (Data.Item item in ((Data.Group)box.Tag).items)
						if (item.name.IndexOf(boxSearch.Text, StringComparison.InvariantCultureIgnoreCase) >= 0)
							boxItems.Items.Add(new ListViewItem(item.name, item.imageIndex){ Tag = new Item(item.id, 0, 0, item.damage) });
			}
			boxItems.EndUpdate();
		}
		
		void BoxSearchEnter(object sender, EventArgs e)
		{
			if (!boxSearch.Font.Italic) return;
			boxSearch.Font = new Font(boxSearch.Font, FontStyle.Regular);
			boxSearch.ForeColor = SystemColors.ControlText;
			boxSearch.Text = "";
		}
		
		void BoxSearchLeave(object sender, EventArgs e)
		{
			if (boxSearch.Text != "") return;
			boxSearch.Font = new Font(boxSearch.Font, FontStyle.Italic);
			boxSearch.ForeColor = Color.Gray;
			boxSearch.Text = "Search...";
		}
		
		void BoxSearchTextChanged(object sender, EventArgs e)
		{
			UpdateItems();
		}
		
		void Open()
		{
			TreeNode node = MainForm.selectedNode;
			if (node.Parent.Nodes.ContainsKey("id")) {
				string id = (string)((TagCompound)node.Parent.Tag)["id"];
				if (id == "Chest") {
					Page page = new PageChest();
					Open(page, node);
					tabControl.TabPages.Add(page);
					tabControl.SelectedTab = page;
				} else if (id == "Furnace") {
					Page page = new PageFurnace();
					Open(page, node);
					tabControl.TabPages.Add(page);
					tabControl.SelectedTab = page;
				} else if (id == "LocalPlayer") {
					Page page = new Page();
					Open(page, node);
					tabControl.TabPages.Add(page);
					tabControl.SelectedTab = page;
				} else {
					MessageBox.Show("Unknown TileEntity id. \n" +
					                "Expect an unknown result.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Page page = new Page();
					Open(page, node);
					tabControl.TabPages.Add(page);
					tabControl.SelectedTab = page;
				}
			} else if (node.Name == "Inventory") {
				Page page = new Page();
				Open(page, node);
				tabControl.TabPages.Add(page);
				tabControl.SelectedTab = page;
			} else {
				MessageBox.Show("Unknown TagList name. \n" +
					            "Expect an unknown result.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Page page = new Page();
				Open(page, node);
				tabControl.TabPages.Add(page);
				tabControl.SelectedTab = page;
			}
		}
		
		void Open(Page page, TreeNode tag)
		{
			try {
				page.file = tag.Name;
				page.Text = tag.Name;
				Inventory.Load((TagList)tag.Tag, page.slots);
				Text = "INVedit - "+page.Text;
				btnSave.Enabled = true;
			} catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			Page page = (Page)tabControl.SelectedTab;
			TreeNode node = MainForm.selectedNode;
			Save(node, page);
			Data.items.Clear();
			Data.groups.Clear();
			Close();
		}
		
		void Save(TreeNode tag, Page page)
		{
			try {
				page.file = tag.Name;
				Inventory.Save(tag, page.slots);
			} catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			Data.items.Clear();
			Data.groups.Clear();
			Close();
		}
		
		void INVeditFormFormClosing(object sender, FormClosingEventArgs e)
	    {
			Data.items.Clear();
			Data.groups.Clear();
	    }
	}
}
