using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace NBTedit {
	public partial class AboutForm : Form {
		public AboutForm() {
			InitializeComponent();
			label1.Text = label1.Text.Replace("{version}",Assembly.GetExecutingAssembly().GetName().Version.ToString(3));
			label1.Text = label1.Text.Replace("{net-version}",Environment.Version.ToString());
		}
		
		private void LinkLabel1LinkClicked(object sender,LinkLabelLinkClickedEventArgs e) {
			Process.Start("http://www.icsharpcode.net/OpenSource/SD/");
		}
		private void LinkLabel2LinkClicked(object sender,LinkLabelLinkClickedEventArgs e) {
			Process.Start("http://www.minecraft.net/docs/NBT.txt");
		}
		private void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("http://www.famfamfam.com/lab/icons/silk/");
		}
	}
}
