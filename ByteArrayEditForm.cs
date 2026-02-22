using System;
using System.IO;
using System.IO.Compression;
using System.Drawing;
using System.Windows.Forms;

namespace NBTedit {
	public partial class ByteArrayEditForm : Form {
		public bool cancel = true;
		public byte[] value;
		
		public ByteArrayEditForm(byte[] value) {
			InitializeComponent();
			this.value = value;
		}
		
		public void ImportClick(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog()!=DialogResult.OK) { return; }
			try {
				Stream stream;
				using (stream = File.OpenRead(openFileDialog.FileName)) {
					if (boxGZip.Checked) { stream = new GZipStream(stream,CompressionMode.Decompress); }
					value = ReadAllBytes(stream);
				} cancel = false;
			} catch (Exception ex) {
				MessageBox.Show("Error while loading the file:\n"+ex.Message,
				                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		public void ExportClick(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog()!=DialogResult.OK) { return; }
			try {
				Stream stream;
				using (stream = File.OpenWrite(saveFileDialog.FileName)) {
					if (boxGZip.Checked) { stream = new GZipStream(stream,CompressionMode.Compress); }
					stream.Write(value,0,value.Length);
				}
			} catch (Exception ex) {
				MessageBox.Show("Error while saving the file:\n"+ex.Message,
				                "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		private static byte[] ReadAllBytes(Stream source) {
			long originalPosition = source.Position;
			source.Position = 0;
			try {
				byte[] readBuffer = new byte[4096];
				int totalBytesRead = 0;
				int bytesRead;
				while ((bytesRead = source.Read(readBuffer,totalBytesRead,readBuffer.Length-totalBytesRead))>0) {
					totalBytesRead += bytesRead;
					if (totalBytesRead==readBuffer.Length) {
						int nextByte = source.ReadByte();
						if (nextByte!=-1) {
							byte[] temp = new byte[readBuffer.Length*2];
							Buffer.BlockCopy(readBuffer,0,temp,0,readBuffer.Length);
							Buffer.SetByte(temp,totalBytesRead,(byte)nextByte);
							readBuffer = temp;
							totalBytesRead++;
						}
					}
				} byte[] buffer = readBuffer;
				if (readBuffer.Length!=totalBytesRead) {
					buffer = new byte[totalBytesRead];
					Buffer.BlockCopy(readBuffer,0,buffer,0,totalBytesRead);
				} return buffer;
			} finally { source.Position = originalPosition; }
		}
	}
}
