using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace FileToByteArray
{
	public partial class Form1 : Form
	{
		private byte[] FileBytes;
		private static string OutputFilename = "OutputBytes.txt";

		public Form1()
		{
			InitializeComponent();

			// Sett standardformat.
			lstFormatValg.SetSelected(lstFormatValg.FindString("90 90"),true); // 3 (0-basert indeks).
		}

		private void btnVelgFile_Click(object sender, EventArgs e)
		{
			try {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			//openFileDialog.Filter = "DLL  (*.dll)|*.dll";
			openFileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Skriv bytes fra valgt fil til tekstfil i samme lokasjon.
				FileBytes = File.ReadAllBytes(Path.GetFullPath(openFileDialog.FileName));

				if (lstFormatValg.SelectedIndex == 0) { // 0x90, 0x90
					string ByteString = BitConverter.ToString(FileBytes).Replace("-",", 0x");
					File.WriteAllText(OutputFilename, "0x"+ ByteString, Encoding.ASCII);

				} else if (lstFormatValg.SelectedIndex == 1) { // 0x90 0x90
					string ByteString = BitConverter.ToString(FileBytes).Replace("-"," 0x");
					File.WriteAllText(OutputFilename, "0x"+ ByteString, Encoding.ASCII);

				} else if (lstFormatValg.SelectedIndex == 2) { // 90, 90
					string ByteString = BitConverter.ToString(FileBytes).Replace("-",", ");
					File.WriteAllText(OutputFilename, ByteString, Encoding.ASCII);

				} else if (lstFormatValg.SelectedIndex == 3) { // 90 90
					string ByteString = BitConverter.ToString(FileBytes).Replace("-"," ");
					File.WriteAllText(OutputFilename, ByteString, Encoding.ASCII);
				}
				
				File.WriteAllText("LastOutPutExtensionType_("+ Path.GetExtension(openFileDialog.FileName) +")", "");
				MessageBox.Show("Bytes skrevet til "+ OutputFilename);
			}

			} catch (Exception ee) {
				MessageBox.Show(ee.ToString());
			}
		}

		private void btnConvertBackToFile_Click(object sender, EventArgs e)
		{
			try {
			if (!File.Exists(OutputFilename)) {
				MessageBox.Show("Create an output file first...");
				return;
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Skriv bytes fra valgt fil til tekstfil i samme lokasjon.
				string[] OutputStringArray = File.ReadAllText(OutputFilename).Split(' ');
				List<byte> OutputByteArray = new List<byte>();
				foreach (string s in OutputStringArray) {
					try {
						if (lstFormatValg.SelectedIndex == 0) {
							OutputByteArray.Add(Convert.ToByte(s.Replace("0x","").Replace(",",""),16));

						} else if (lstFormatValg.SelectedIndex == 1) {
							OutputByteArray.Add(Convert.ToByte(s.Replace("0x",""),16));

						} else if (lstFormatValg.SelectedIndex == 2) {
							OutputByteArray.Add(Convert.ToByte(s.Replace(",",""),16));

						} else if (lstFormatValg.SelectedIndex == 3) {
							OutputByteArray.Add(Convert.ToByte(s,16));
						}

					} catch (Exception ee) {
						MessageBox.Show(ee.Message +", "+ s);
						break;
					}
				}

				File.WriteAllBytes(saveFileDialog.FileName, OutputByteArray.ToArray());
				MessageBox.Show("Bytes skrevet til "+ saveFileDialog.FileName);
			}

			} catch (Exception ee) {
				MessageBox.Show(ee.ToString());
			}
		}
	}
}
