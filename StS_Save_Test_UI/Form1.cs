using STS_Save;
using System;
using System.Windows.Forms;

namespace StS_Save_Test_UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
			btnDecode.Click += btnDecode_Click;
			btnEncode.Click += btnEncode_Click;
		}

		private void btnDecode_Click(object sender, EventArgs e)
		{
			var base64String = (string.IsNullOrWhiteSpace(txtJsonField.Text))
							   ? Clipboard.GetText()
							   : txtJsonField.Text
							   ;

			string jsonString = SaveDecoder.Decode(base64String);

			txtJsonField.Text = jsonString;
		}

		private void btnEncode_Click(object sender, EventArgs e)
		{
			string base64String = SaveDecoder.Encode(txtJsonField.Text);

			txtJsonField.Text = base64String;
		}
	}
}