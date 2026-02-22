//using NBT;
using NBTedit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NamedBinaryTag;

namespace INVedit
{
	public static class Inventory
	{
		public static void Load(TagList inventory, Dictionary<byte, ItemSlot> slots)
		{
			try {
				foreach (ItemSlot slot in slots.Values) slot.Item = null;
				foreach (TagCompound tag in inventory) {
					short id = (short)tag["id"];
					byte slot = (byte)tag["Slot"];
					byte count = (byte)tag["Count"];
					if (!slots.ContainsKey(slot)) {
						MessageBox.Show("Unknown slot '"+slot+"', discarded item.",
						                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						continue;
					}
					ItemSlot itemSlot = slots[slot];
					itemSlot.Item = new Item(id, (sbyte)count, slot, (short)tag["Damage"]);
				}
			} finally { foreach (ItemSlot slot in slots.Values) slot.Refresh(); }
		}
		
		public static void Save(TreeNode tag, Dictionary<byte, ItemSlot> slots)
		{
			MainForm mainForm = new MainForm();
			mainForm.nbtView.BeginUpdate();
			TreeNode parent = tag.Parent;
			if (parent.Nodes.Contains(tag)) mainForm.nbtView.Delete(tag);
			TagList list = new TagList(typeof(TagCompound));
			TreeNode inventory = mainForm.nbtView.AddTag(parent, list, tag.Name);
			foreach (ItemSlot slot in slots.Values) {
				if (slot.Item == null) continue;
				TagCompound compound = new TagCompound();
				TreeNode item = mainForm.nbtView.AddTag(inventory, compound, null);
				mainForm.nbtView.AddTag(item, new TagShort(slot.Item.ID), "id");
				mainForm.nbtView.AddTag(item, new TagByte(slot.Slot), "Slot");
				mainForm.nbtView.AddTag(item, new TagByte((byte)slot.Item.Count), "Count");
				mainForm.nbtView.AddTag(item, new TagShort(slot.Item.Damage), "Damage");
			}
			mainForm.nbtView.EndUpdate();
		}
	}
}
