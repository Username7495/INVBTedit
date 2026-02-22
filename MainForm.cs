using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using NamedBinaryTag;

namespace NBTedit {
	public partial class MainForm : Form {
		private string file;
		private bool saved = true;
		private Tag copyTag;
		private string copyName;
		private SearchForm searchForm = new SearchForm();
		
		public static TreeNode selectedNode;
		
		public MainForm() {
			InitializeComponent();
			editToolStripMenuItem.ShortcutKeyDisplayString = "Enter";
		}
		public MainForm(string filename) : this() {
			reloadToolStripMenuItem.Enabled = true;
			file = filename;
			try {
				saved = true;
				nbtView.Load(file);
				Text = "NBTedit - "+new FileInfo(file).Name;
			} catch (Exception ex) {
				File.AppendAllText("error.log",ex+"\n");
				MessageBox.Show("Error when loading the file:\n"+ex.Message+"\n\n"+
				                "For detailed information see 'error.log'.",
				                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		private void INVedit(object sender,EventArgs e) {
			new INVeditForm().ShowDialog();
			if (saved) { Text += "*"; saved = false; }
		}
		
		private void New(object sender,EventArgs e) {
			if (AreYouSure()) { return; }
			saved = true;
			file = null;
			Text = "NBTedit - unnamed.nbt";
			nbtView.Clear();
			reloadToolStripMenuItem.Enabled = false;
		}
		private void Open(object sender,EventArgs e) {
			if (AreYouSure()) { return; }
			if (openFileDialog.ShowDialog()==DialogResult.OK) {
				reloadToolStripMenuItem.Enabled = true;
				file = openFileDialog.FileName;
				try {
					saved = true;
					nbtView.Load(file);
					Text = "NBTedit - "+new FileInfo(file).Name;
				} catch (Exception ex) {
					File.AppendAllText("error.log",ex+"\n");
					MessageBox.Show("Error when loading the file:\n"+ex.Message+"\n\n"+
					                "For detailed information see 'error.log'.",
					                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}
		private void Reload(object sender,EventArgs e) {
			if (AreYouSure()) { return; }
			if (file!=null) {
				if (File.Exists(file)) {
					try {
						saved = true;
						nbtView.Load(file);
						Text = "NBTedit - "+new FileInfo(file).Name;
					} catch (Exception ex) {
						File.AppendAllText("error.log",ex+"\n");
						MessageBox.Show("Error while loading the file:\n"+ex.Message+"\n\n"+
						                "For detailed information see 'error.log'.",
						                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}
			}
		}
		private void Save(object sender,EventArgs e) {
			if (file==null) {
				saveFileDialog.FileName = file??"unnamed.nbt";
				if (saveFileDialog.ShowDialog()!=DialogResult.OK) { return; }
				reloadToolStripMenuItem.Enabled = true;
				file = saveFileDialog.FileName;
			} saved = true;
			try {
				nbtView.Save(file);
				Text = "NBTedit - "+new FileInfo(file).Name;
			} catch (Exception ex) {
				File.AppendAllText("error.log",ex+"\n");
				MessageBox.Show("Error while saving the file:\n"+ex.Message+"\n\n"+
				                "For detailed information see 'error.log'.",
				                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		private void SaveAs(object sender,EventArgs e) {
			saveFileDialog.FileName = file??"unnamed.nbt";
			if (saveFileDialog.ShowDialog()!=DialogResult.OK) { return; }
			reloadToolStripMenuItem.Enabled = true;
			file = saveFileDialog.FileName;
			saved = true;
			nbtView.Save(file);
			Text = "NBTedit - "+new FileInfo(file).Name;
		}
		private void Exit(object sender,EventArgs e) {
			Close();
		}
		
		private void Add(object sender,EventArgs e) {
			byte index;
			if (sender==byteToolStripButton) { index = 1; }
			else if (sender==shortToolStripButton) { index = 2; }
			else if (sender==intToolStripButton) { index = 3; }
			else if (sender==longToolStripButton) { index = 4; }
			else if (sender==floatToolStripButton) { index = 5; }
			else if (sender==doubleToolStripButton) { index = 6; }
			else if (sender==byteArrayToolStripButton) { index = 7; }
			else if (sender==stringToolStripButton) { index = 8; }
			else if (sender==compoundToolStripButton) { index = 10; }
			else { return; }
			nbtView.Add(nbtView.SelectedNode,(Tag)Activator.CreateInstance(NamedBinaryTag.Tag.FromId(index)));
			if (nbtView.CanRename(nbtView.SelectedNode)) { nbtView.StartLabelEdit(); }
			if (saved) { Text += "*"; saved = false; }
		}
		private void AddList(object sender,EventArgs e) {
			byte index;
			if (sender==byteToolStripMenuItem) { index = 1; }
			else if (sender==shortToolStripMenuItem) { index = 2; }
			else if (sender==intToolStripMenuItem) { index = 3; }
			else if (sender==longToolStripMenuItem) { index = 4; }
			else if (sender==floatToolStripMenuItem) { index = 5; }
			else if (sender==doubleToolStripMenuItem) { index = 6; }
			else if (sender==byteArrayToolStripMenuItem) { index = 7; }
			else if (sender==stringToolStripMenuItem) { index = 8; }
			else if (sender==listToolStripMenuItem) { index = 9; }
			else if (sender==compoundToolStripMenuItem) { index = 10; }
			else { return; }
			nbtView.Add(nbtView.SelectedNode,new TagList(NamedBinaryTag.Tag.FromId(index)));
			if (saved) { Text += "*"; saved = false; }
		}
		private void Rename(object sender,EventArgs e) {
			nbtView.StartLabelEdit();
		}
		private void Edit(object sender,EventArgs e) {
			if (nbtView.SelectedNode.Tag is TagByteArray) {
				ByteArrayEditForm editForm = new ByteArrayEditForm(((TagByteArray)nbtView.SelectedNode.Tag).value);
				editForm.ShowDialog();
				if (!editForm.cancel) {
					nbtView.Edit(nbtView.SelectedNode,editForm.value);
					if (saved) { Text += "*"; saved = false; }
				}
				editForm.Dispose();
			} else {
				EditForm editForm = new EditForm(((Tag)nbtView.SelectedNode.Tag).Value);
				editForm.ShowDialog();
				if (!editForm.cancel) {
					nbtView.Edit(nbtView.SelectedNode,editForm.value);
					if (saved) { Text += "*"; saved = false; }
				}
				editForm.Dispose();
			}
		}
		private void Delete(object sender,EventArgs e) {
			if (nbtView.SelectedNode.IsEditing) { return; }
			nbtView.Delete(nbtView.SelectedNode);
			if (saved) { Text += "*"; saved = false; }
		}
		private void Cut(object sender,EventArgs e) {
			Copy(sender,e);
			Delete(sender,e);
		}
		private void Copy(object sender,EventArgs e) {
			copyTag = (Tag)((Tag)nbtView.SelectedNode.Tag).Clone();
			copyName = nbtView.SelectedNode.Name;
			pasteToolStripMenuItem.Enabled = nbtView.CanAdd(nbtView.SelectedNode,copyTag.GetType());
		}
		private void Paste(object sender,EventArgs e) {
			nbtView.Add(nbtView.SelectedNode,(Tag)copyTag.Clone(),copyName);
			if (saved) { Text += "*"; saved = false; }
		}
		private void MoveUp(object sender,EventArgs e) {
			nbtView.MoveUp(nbtView.SelectedNode);
		}
		private void MoveDown(object sender,EventArgs e) {
			nbtView.MoveDown(nbtView.SelectedNode);
		}
		
		private void Find(object sender,EventArgs e) {
			searchForm.ShowDialog();
			if (!searchForm.cancel) {
				if (searchForm.textBoxName.Text=="" &&
				    searchForm.textBoxValue.Text=="" &&
				    searchForm.comboBoxTags.SelectedIndex==0) {
					findNextToolStripMenuItem.Enabled = false;
				} else {
					findNextToolStripMenuItem.Enabled = true;
					FindNext(sender,e);
				}
			}
		}
		private void FindNext(object sender,EventArgs e) {
			TreeNode next = nbtView.SelectedNode;
			do {
				next = nbtView.GetNextNode(next)??nbtView.Nodes[0];
				byte id = ((Tag)next.Tag).GetId();
				bool isInteger = (id==1 || id==2 || id==3 || id==4);
				bool isFloating = (id==5 || id==6);
				bool isNumber = (isInteger || isFloating);
				bool isContainer = (id==9 || id==10);
				if ((searchForm.textBoxName.Text=="" || next.Name.Contains(searchForm.textBoxName.Text)) &&
				    (searchForm.textBoxValue.Text=="" || ((Tag)next.Tag).ToString().Contains(searchForm.textBoxValue.Text)) &&
				    (searchForm.comboBoxTags.SelectedIndex==0 ||
				     (searchForm.comboBoxTags.SelectedIndex==1 && isNumber) ||
				     (searchForm.comboBoxTags.SelectedIndex==2 && isInteger) ||
				     (searchForm.comboBoxTags.SelectedIndex==3 && isFloating) ||
				     (searchForm.comboBoxTags.SelectedIndex==4 && isContainer) ||
				     (searchForm.comboBoxTags.SelectedIndex==5 && id==1) ||
				     (searchForm.comboBoxTags.SelectedIndex==6 && id==2) ||
				     (searchForm.comboBoxTags.SelectedIndex==7 && id==3) ||
				     (searchForm.comboBoxTags.SelectedIndex==8 && id==4) ||
				     (searchForm.comboBoxTags.SelectedIndex==9 && id==5) ||
				     (searchForm.comboBoxTags.SelectedIndex==10 && id==6) ||
				     (searchForm.comboBoxTags.SelectedIndex==11 && id==7) ||
				     (searchForm.comboBoxTags.SelectedIndex==12 && id==8) ||
				     (searchForm.comboBoxTags.SelectedIndex==13 && id==9) ||
				     (searchForm.comboBoxTags.SelectedIndex==14 && id==10))) {
					nbtView.SelectedNode = next;
					return;
				}
			} while (next!=nbtView.SelectedNode);
			MessageBox.Show("Can't find results for search query.","Not found",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
		}
		
		private void About(object sender,EventArgs e) {
			new AboutForm().ShowDialog();
		}
		private bool AreYouSure() {
			if (saved) { return false; }
			switch (MessageBox.Show(file==null?"Save file?":("Save file \""+file+"\" ?"),"Save",
			                        MessageBoxButtons.YesNoCancel,
			                        MessageBoxIcon.Question)) {
				case DialogResult.Yes:
					Save(this,new EventArgs());
					break;
				case DialogResult.Cancel:
					return true;
			} return false;
		}

		protected override void OnFormClosing(FormClosingEventArgs e) {
			if (e.CloseReason==CloseReason.FormOwnerClosing ||
			    e.CloseReason==CloseReason.UserClosing) {
				if (AreYouSure()) { e.Cancel = true; }
			} base.OnFormClosing(e);
		}
		protected override void OnDragEnter(DragEventArgs drgevent) {
			if (drgevent.Data.GetDataPresent(DataFormats.FileDrop))
				drgevent.Effect = DragDropEffects.Copy;
		}
		protected override void OnDragDrop(DragEventArgs drgevent) {
			if (AreYouSure()) { return; }
			BringToFront();
			reloadToolStripMenuItem.Enabled = true;
			file = ((string[])drgevent.Data.GetData(DataFormats.FileDrop))[0];
			try {
				saved = true;
				nbtView.Load(file);
				Text = "NBTedit - "+new FileInfo(file).Name;
			} catch (Exception ex) {
				MessageBox.Show("Error while loading the file:\n"+ex.Message,
				                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		private void AfterLabelEdit(object sender,NodeLabelEditEventArgs e) {
			if (!nbtView.Rename(e.Node,e.Label)) {
				System.Media.SystemSounds.Beep.Play();
			} else if (saved) { Text += "*"; saved = false; }
			e.Node.Text = nbtView.TextOf(e.Node);
		}
		private void BeforeCollapse(object sender,TreeViewCancelEventArgs e) {
			if (e.Node==((TreeView)sender).Nodes[0]) { e.Cancel = true; }
		}
		private void AfterSelect(object sender,TreeViewEventArgs e) {
			bool isRoot = (e.Node==((TreeView)sender).Nodes[0]);
			cutToolStripMenuItem.Enabled = !isRoot;
			pasteToolStripMenuItem.Enabled = (copyTag!=null && nbtView.CanAdd(e.Node,copyTag.GetType()));
			deleteToolStripMenuItem.Enabled = !isRoot;
			renameToolStripMenuItem.Enabled = nbtView.CanRename(e.Node);
			editToolStripMenuItem.Enabled = nbtView.CanEdit(e.Node);
			editToolStripButton.Enabled = nbtView.CanEdit(e.Node);
			renameToolStripButton.Enabled = nbtView.CanRename(e.Node);
			deleteToolStripButton.Enabled = !isRoot;
			moveUpToolStripMenuItem.Enabled = nbtView.CanMoveUp(e.Node);
			moveDownToolStripMenuItem.Enabled = nbtView.CanMoveDown(e.Node);
			byteToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagByte));
			shortToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagShort));
			intToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagInt));
			longToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagLong));
			floatToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagFloat));
			doubleToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagDouble));
			byteArrayToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagByteArray));
			stringToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagString));
			listToolStripDropDownButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagList));
			compoundToolStripButton.Enabled = nbtView.CanAdd(e.Node,typeof(TagCompound));
			inveditToolStripButton.Enabled = (e.Node.Tag.GetType() == typeof(TagList) && ((TagList)e.Node.Tag).Type == typeof(TagCompound));
			inveditToolStripMenuItem.Enabled = (e.Node.Tag.GetType() == typeof(TagList) && ((TagList)e.Node.Tag).Type == typeof(TagCompound));
			selectedNode = e.Node;
		}
		private new void KeyDown(object sender,KeyEventArgs e) {
			if (e.Control && !e.Shift && !e.Alt) switch (e.KeyCode) {
					case Keys.D1: byteToolStripButton.PerformClick(); break;
					case Keys.D2: shortToolStripButton.PerformClick(); break;
					case Keys.D3: intToolStripButton.PerformClick(); break;
					case Keys.D4: longToolStripButton.PerformClick(); break;
					case Keys.D5: floatToolStripButton.PerformClick(); break;
					case Keys.D6: doubleToolStripButton.PerformClick(); break;
					case Keys.D7: byteArrayToolStripButton.PerformClick(); break;
					case Keys.D8: stringToolStripButton.PerformClick(); break;
					case Keys.D0: compoundToolStripButton.PerformClick(); break;
			} else if (e.KeyData==Keys.Enter &&
			           nbtView.CanEdit(nbtView.SelectedNode)) {
				Edit(sender,e);
			}
		}
		private void NodeDoubleClick(object sender,TreeNodeMouseClickEventArgs e) {
			if (nbtView.CanEdit(nbtView.SelectedNode)) { Edit(sender,e); }
		}
	}
}
