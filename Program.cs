using System;
using System.Windows.Forms;
using System.Globalization;

namespace NBTedit {
	internal sealed class Program {
		[STAThread]
		private static void Main(string[] args) {
			CultureInfo cult = new CultureInfo("en-US");
			System.Threading.Thread.CurrentThread.CurrentCulture = cult;
			System.Threading.Thread.CurrentThread.CurrentUICulture = cult;
			Application.EnableVisualStyles();
			if (args.Length==1 && System.IO.File.Exists(args[0])) {
				Application.Run(new MainForm(args[0]));
			} else { Application.Run(new MainForm()); }
		}
	}
}
