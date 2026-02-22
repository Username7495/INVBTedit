using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using NamedBinaryTag;

namespace NBTedit {
	public partial class NBTView : TreeView {
		private Dictionary<Tag,TreeNode> list =
			new Dictionary<Tag,TreeNode>();

		public readonly TagCompound root = new TagCompound();
		
		public NBTView() {
			TreeViewNodeSorter = new NodeSorter();
			SetStyle(ControlStyles.EnableNotifyMessage,true);
			Clear();
		}
		protected override void InitLayout() {
			Clear();
		}
		
		public void Add(TreeNode node,Tag value) {
			Add(node,value,null);
		}
		public void Add(TreeNode node,Tag value,string wanted) {
			if (node==null) { throw new ArgumentNullException("node"); }
			if (value==null) { throw new ArgumentNullException("value"); }
			if (!CanAdd(node,value.GetType())) { throw new ArgumentException("Can't add '"+value.GetType()+"' to this node."); }
			string name = "";
			TreeNode thisNode;
			if (node.Tag.GetType()==typeof(TagCompound)) {
				TagCompound compound = (TagCompound)node.Tag;
				for (int i=(wanted!=null)?0:1;;i++) {
					name = (i==0)?wanted:"property"+i;
					if (!compound.Contains(name)) { break; }
				}
			} if (SelectedNode.IsEditing) { SelectedNode.EndEdit(false); }
			if (value.GetType()==typeof(TagList)) {
				thisNode = AddList(name,(TagList)value);
			} else if (value.GetType()==typeof(TagCompound)) {
				thisNode = AddCompound(name,(TagCompound)value);
			} else {
				string text;
				if (node.Tag.GetType()==typeof(TagList)) { text = ValueOf(value); }
				else { text = name+": "+ValueOf(value); }
				byte id = NamedBinaryTag.Tag.GetId(value.GetType());
				thisNode = new TreeNode(text,id-1,id-1){Name=name,Tag=value};
			} list.Add(value,thisNode);
			node.Nodes.Add(thisNode);
			if (node.Tag.GetType()==typeof(TagCompound)) {
				((TagCompound)node.Tag)[name] = value;
			} else if (node.Tag.GetType()==typeof(TagList)) {
				TagList tagList = (TagList)node.Tag;
				tagList += value;
			} node.Expand();
			SelectedNode = thisNode;
			node.Text = TextOf(node);
			node.Expand();
			if (CanRename(SelectedNode)) { StartLabelEdit(); }
		}
		
		public TreeNode AddTag(TreeNode node,Tag value,string name) {
			if (node==null) { throw new ArgumentNullException("node"); }
			if (value==null) { throw new ArgumentNullException("value"); }
			if (!CanAdd(node,value.GetType())) { throw new ArgumentException("Can't add '"+value.GetType()+"' to this node."); }
			TreeNode thisNode;
			if (value.GetType()==typeof(TagList)) {
				thisNode = AddList(name,(TagList)value);
			} else if (value.GetType()==typeof(TagCompound)) {
				thisNode = AddCompound(name,(TagCompound)value);
			} else {
				string text;
				if (node.Tag.GetType()==typeof(TagList)) { text = ValueOf(value); }
				else { text = name+": "+ValueOf(value); }
				byte id = NamedBinaryTag.Tag.GetId(value.GetType());
				thisNode = new TreeNode(text,id-1,id-1){Name=name,Tag=value};
			}
			list.Add(value,thisNode);
			node.Nodes.Add(thisNode);
			if (node.Tag.GetType()==typeof(TagCompound)) {
				((TagCompound)node.Tag)[name] = value;
			} else if (node.Tag.GetType()==typeof(TagList)) {
				TagList tagList = (TagList)node.Tag;
				tagList += value;
			}
			node.Text = TextOf(node);
			return thisNode;
		}
		
		public void Delete(TreeNode node) {
			TreeNode parentNode = node.Parent;
			Tag tag = TagOf(node);
			Remove(node);
		}
		private void Remove(TreeNode node) {
			TreeNode parentNode = node.Parent;
			node.Remove();
			list.Remove(TagOf(node));
			if (parentNode.Tag.GetType()==typeof(TagCompound)) {
				((TagCompound)parentNode.Tag).Remove(node.Name);
			} else if (parentNode.Tag.GetType()==typeof(TagList)) {
				((TagList)parentNode.Tag).Remove((Tag)node.Tag);
			} parentNode.Text = TextOf(parentNode);
		}
		public bool Rename(TreeNode node,string name) {
			if (!CanRename(node)) { return false; }
			if (TagOf(node)!=root) {
				TagCompound parent = (TagCompound)node.Parent.Tag;
				if (parent.Contains(name)) { return false; }
			} string oldName = node.Name;
			RenameTo(node,name);
			return true;
		}
		private bool RenameTo(TreeNode node,string name) {
			if (TagOf(node)!=root) {
				TagCompound parent = (TagCompound)node.Parent.Tag;
				if (parent.Contains(name)) { return false; }
				parent.Rename(node.Name,name);
			} node.Name = name;
			node.Text = TextOf(node);
			if (node.Parent!=null) {
				TreeNode parent = node.Parent;
				BeginUpdate();
				node.Remove();
				parent.Nodes.Add(node);
				SelectedNode = node;
				EndUpdate();
			} return true;
		}
		public void MoveUp(TreeNode node) {
			TreeNode parent = node.Parent;
			TagList list = (TagList)parent.Tag;
			list.Reverse(node.Index-1,2);
			Sorted = false;
			parent.Nodes.Remove(node);
			parent.Nodes.Insert(node.Index-1,node);
			Sorted = true;
			SelectedNode = node;
		}
		public void MoveDown(TreeNode node) {
			TreeNode parent = node.Parent;
			TagList list = (TagList)parent.Tag;
			list.Reverse(node.Index,2);
			Sorted = false;
			parent.Nodes.Remove(node);
			parent.Nodes.Insert(node.Index+1,node);
			Sorted = true;
			SelectedNode = node;
		}
		public void Clear() {
			list.Clear();
			Nodes.Clear();
			root.Clear();
			TreeNode node = new TreeNode("root [0 entries]",9,9){Name="root"};
			list.Add(root,node);
			Nodes.Add(node);
			Nodes[0].Tag = root;
			SelectedNode = Nodes[0];
		}
		
		public void Edit(TreeNode node,object value) {
			Tag tag = (Tag)node.Tag;
			if (tag is TagByte) { ((TagByte)tag).value = (byte)value; }
			if (tag is TagShort) { ((TagShort)tag).value = (short)value; }
			if (tag is TagInt) { ((TagInt)tag).value = (int)value; }
			if (tag is TagLong) { ((TagLong)tag).value = (long)value; }
			if (tag is TagFloat) { ((TagFloat)tag).value = (float)value; }
			if (tag is TagDouble) { ((TagDouble)tag).value = (double)value; }
			if (tag is TagByteArray) { ((TagByteArray)tag).value = (byte[])value; }
			if (tag is TagString) { ((TagString)tag).value = (string)value; }
			node.Text = TextOf(node);
		}
		
		public void Load(string filename) {
			Clear();
			string name;
			try { root.Load(filename,out name); }
			catch (Exception e) { Clear(); throw e; }
			list.Clear();
			Nodes.Clear();
			BeginUpdate();
			TreeNode node = AddCompound(name,root);
			list.Add(root,node);
			Nodes.Add(node);
			EndUpdate();
			node.Expand();
			SelectedNode = node;
		}
		public void Save(string filename) {
			root.Save(filename,Nodes[0].Name);
		}
		private TreeNode AddList(string name,TagList node) {
			TreeNode treeNode = new TreeNode(){Tag=node,ImageIndex=8,SelectedImageIndex=8,Name=name};
			foreach (Tag tag in node) {
				TreeNode newNode;
				if (tag.GetType()==typeof(TagList)) { newNode = AddList("",(TagList)tag); }
				else if (tag.GetType()==typeof(TagCompound)) { newNode = AddCompound("",(TagCompound)tag); }
				else {
					byte id = NamedBinaryTag.Tag.GetId(tag.GetType());
					newNode = new TreeNode(ValueOf(tag),id-1,id-1);
				} list.Add(tag,newNode);
				treeNode.Nodes.Insert(0,newNode);
				newNode.Tag = tag;
			} treeNode.Text = TextOf(treeNode);
			return treeNode;
		}
		private TreeNode AddCompound(string name,TagCompound node) {
			TreeNode treeNode = new TreeNode(){Tag=node,ImageIndex=9,SelectedImageIndex=9,Name=name};
			foreach (KeyValuePair<string,Tag> tag in node) {
				TreeNode newNode;
				if (tag.Value.GetType()==typeof(TagList)) { newNode = AddList(tag.Key,(TagList)tag.Value); }
				else if (tag.Value.GetType()==typeof(TagCompound)) { newNode = AddCompound(tag.Key,(TagCompound)tag.Value); }
				else {
					byte id = NamedBinaryTag.Tag.GetId(tag.Value.GetType());
					newNode = new TreeNode(tag.Key+": "+ValueOf(tag.Value),id-1,id-1){Name=tag.Key};
				} list.Add(tag.Value,newNode);
				treeNode.Nodes.Add(newNode);
				newNode.Tag = tag.Value;
			} treeNode.Text = TextOf(treeNode);
			return treeNode;
		}
		
		public TreeNode GetNextNode(TreeNode node) {
			return GetNextNode(node,false);
		}
		public TreeNode GetNextNode(TreeNode node,bool nextOnly) {
			if (node.FirstNode!=null && !nextOnly) { return node.FirstNode; }
			if (node.NextNode!=null) { return node.NextNode; }
			if (node.Parent!=null) { return GetNextNode(node.Parent,true); }
			else { return null; }
		}
		public string TextOf(TreeNode node) {
			if (node.Name=="") { return ValueOf((Tag)node.Tag); }
			else { return node.Name+": "+ValueOf((Tag)node.Tag); }
		}
		public string ValueOf(Tag tag) {
			string value = tag.Value.ToString();
			if (tag.GetType()==typeof(TagList)) {
				int count = ((TagList)tag).Count;
				value = count+(count==1?" entry":" entries")+" of type "+((TagList)tag).Type.Name;
			} else if (tag.GetType()==typeof(TagCompound)) {
				int count = ((TagCompound)tag).Count;
				value = count+(count==1?" entry":" entries");
			} else if (tag.GetType()==typeof(TagByteArray)) {
				int count = ((TagByteArray)tag).value.Length;
				value = "["+count+(count==1?" byte]":" bytes]");
			} return value;
		}
		public Tag TagOf(TreeNode node) {
			return (Tag)node.Tag;
		}
		
		public bool CanRename(TreeNode node) {
			if (node.TreeView.Nodes[0]==node) { return true; }
			return (node.Parent.Tag.GetType()!=typeof(TagList));
		}
		public bool CanEdit(TreeNode node) {
			Type type = node.Tag.GetType();
			return (type!=typeof(TagList) &&
			        type!=typeof(TagCompound));
		}
		public bool CanAdd(TreeNode node,Type type) {
			Type nodeType = node.Tag.GetType();
			if (nodeType==typeof(TagCompound)) { return true; }
			else if (nodeType==typeof(TagList)) {
				return (type==((TagList)node.Tag).Type);
			} else { return false; }
		}
		public bool CanMoveUp(TreeNode node) {
			return (Nodes[0]!=node &&
			        node.Parent.Tag.GetType()==typeof(TagList) &&
			        node.Parent.FirstNode!=node);
		}
		public bool CanMoveDown(TreeNode node) {
			return (Nodes[0]!=node &&
			        node.Parent.Tag.GetType()==typeof(TagList) &&
			        node.Parent.LastNode!=node);
		}
		
		private class NodeSorter : IComparer {
			public int Compare(object x,object y) {
				TreeNode a = (TreeNode)x;
				TreeNode b = (TreeNode)y;
				int c = a.ImageIndex-b.ImageIndex;
				if (c == 0 && a.Parent!=null &&
				    a.Parent.Tag.GetType()!=typeof(TagList)) {
					c = Math.Sign(a.Name.CompareTo(b.Name));
				} return c;
			}
		}
		
		#region LabelEdit
		private const int WM_TIMER = 0x0113;
		private bool triggerLabelEdit = false;
		private bool wasDoubleClick = false;
		private string viewedLabel;
		private string editedLabel;
		
		protected override void OnBeforeLabelEdit(NodeLabelEditEventArgs e) {
			SelectedNode.Text = viewedLabel;
		}
		protected override void OnAfterLabelEdit(NodeLabelEditEventArgs e) {
			LabelEdit = false;
			e.CancelEdit = true;
			if (e.Label==null) { return; }
			base.OnAfterLabelEdit(e);
		}
		protected override void OnNotifyMessage(Message m) {
			if (triggerLabelEdit && m.Msg==WM_TIMER) {
				triggerLabelEdit = false;
				StartLabelEdit();
			} base.OnNotifyMessage(m);
		}
		public void StartLabelEdit() {
			if (SelectedNode.IsEditing) { return; }
			SelectedNode.Text = TextOf(SelectedNode);
			viewedLabel = SelectedNode.Text;
			if (!CanRename(SelectedNode)) { return; }
			SelectedNode.Text = SelectedNode.Name;
			editedLabel = SelectedNode.Text;
			LabelEdit = true;
			SelectedNode.BeginEdit();
		}
		protected override void OnMouseDown(MouseEventArgs e) {
			if (e.Button==MouseButtons.Right) {
				TreeNode tn = GetNodeAt(e.X,e.Y);
				if (tn!=null) { SelectedNode = tn; }
			} base.OnMouseDown(e);
		}
		protected override void OnMouseUp(MouseEventArgs e) {
			if (e.Button==MouseButtons.Left) {
				if(SelectedNode==GetNodeAt(e.X,e.Y)) {
					if (!wasDoubleClick) { triggerLabelEdit = true; }
					wasDoubleClick = false;
				}
			} base.OnMouseUp(e);
		}
		protected override void OnClick(EventArgs e) {
			triggerLabelEdit = false;
			base.OnClick(e);
		}
		protected override void OnDoubleClick(EventArgs e) {
			wasDoubleClick = true;
			base.OnDoubleClick(e);
		}
		#endregion
	}
}
