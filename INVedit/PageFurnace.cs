/*
 * Created by SharpDevelop.
 * User: CHIEFTEC
 * Date: 22.02.2026
 * Time: 13:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Windows.Forms;

using INVedit;

namespace NBTedit.INVedit
{
	/// <summary>
	/// Description of PageFurnace.
	/// </summary>
	public class PageFurnace : Page
	{
		public override string NameINV() {
			return "Furnace";
		}
		
		public override void ControlsINV(GroupBox boxInventory) {
			boxInventory.Controls.Add(new PictureBox(){Image = fire, Location = new Point(0 + 150, 125), Size = new Size(48,48), SizeMode=PictureBoxSizeMode.CenterImage});
			boxInventory.Controls.Add(new PictureBox(){Image = arrow, Location = new Point(0 + 200, 125), Size = new Size(64,48), SizeMode=PictureBoxSizeMode.CenterImage});
		}
		
		public override void CreateINV() {
			CreateSlot((byte)0, 0 + 150, 75);
			CreateSlot((byte)1, 0 + 150, 175);
			CreateSlot((byte)2, 14 + 250, 125);
		}
	}
}
