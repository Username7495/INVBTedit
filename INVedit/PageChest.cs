/*
 * Created by SharpDevelop.
 * User: CHIEFTEC
 * Date: 22.02.2026
 * Time: 13:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

using INVedit;

namespace NBTedit.INVedit
{
	/// <summary>
	/// Description of PageChest.
	/// </summary>
	public class PageChest : Page
	{
		public override string NameINV() {
			return "Chest";
		}
		
		public override void CreateINV()
		{
			for (int i = 0; i < 9; ++i) CreateSlot((byte)i, 7 + i*50, 75);
			for (int i = 0; i < 9; ++i) CreateSlot((byte)(9+i), 7 + i*50, 125);
			for (int i = 0; i < 9; ++i) CreateSlot((byte)(18+i), 7 + i*50, 175);
		}
	}
}
