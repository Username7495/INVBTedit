using System;
using System.Drawing;
using System.Windows.Forms;

namespace NBTedit {
	public partial class EditForm : Form {
		public bool cancel = true;
		public bool cancelIfEqual = true;
		public object value;
		
		public EditForm(object value) {
			InitializeComponent();
			this.value = value;
			textBox.Text = value.ToString();
			textBox.KeyDown += delegate(object sender,KeyEventArgs e) {
				if (e.KeyCode==Keys.Escape) { Close(); }
				if (e.KeyCode==Keys.Enter) {
					object before = value;
					if (Validate()) {
						cancel = (before.Equals(this.value) && cancelIfEqual);
						Close();
					}
				}
			};
		}
		private new bool Validate() {
			Type type = value.GetType();
			if (type==typeof(byte)) {
				byte parsed = 0;
				if (!byte.TryParse(textBox.Text,out parsed)) { return false; }
				value = parsed; return true;
			} if (type==typeof(short)) {
				short parsed = 0;
				if (!short.TryParse(textBox.Text,out parsed)) { return false; }
				value = parsed; return true;
			} if (type==typeof(int)) {
				int parsed = 0;
				if (!int.TryParse(textBox.Text,out parsed)) { return false; }
				value = parsed; return true;
			} if (type==typeof(long)) {
				long parsed = 0;
				if (!long.TryParse(textBox.Text,out parsed)) { return false; }
				value = parsed; return true;
			} if (type==typeof(float)) {
				float parsed = 0;
				if (!float.TryParse(textBox.Text,out parsed)) { return false; }
				value = parsed; return true;
			} if (type==typeof(double)) {
				double parsed = 0;
				if (!double.TryParse(textBox.Text,out parsed)) { return false; }
				value = parsed; return true;
			} if (type==typeof(string)) {
				value = textBox.Text; return true;
			} return false;
		}
	}
}
