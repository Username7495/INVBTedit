using System;
using System.Drawing;
using System.Windows.Forms;

namespace NBTedit {
	public partial class SearchForm : Form {
		private static string lastName = "";
		private static string lastValue = "";
		private static int lastIndex = 0;
		
		public bool cancel = true;
		
		public SearchForm() {
			InitializeComponent();
			comboBoxTags.SelectedIndex = 0;
			textBoxName.Text = lastName;
			textBoxValue.Text = lastValue;
			comboBoxTags.SelectedIndex = lastIndex;
			textBoxName.KeyDown += KeyDown;
			textBoxValue.KeyDown += KeyDown;
			comboBoxTags.KeyDown += KeyDown;
		}
		
		private new void KeyDown(object sender,KeyEventArgs e) {
			if (e.KeyCode==Keys.Escape) { Close(); }
			if (e.KeyCode==Keys.Enter) {
				lastName = textBoxName.Text;
				lastValue = textBoxValue.Text;
				lastIndex = comboBoxTags.SelectedIndex;
				cancel = false;
				Close();
			}
		}
	}
}
