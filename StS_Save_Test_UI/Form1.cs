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

			btnCopyClipboard.Click += btnCopyClipboard_Click;

			btnFind.Click += btnFind_Click;
		}

		private void btnDecode_Click(object sender, EventArgs e)
		{
			var base64String = (string.IsNullOrWhiteSpace(txtJsonField.Text))
							   ? Clipboard.GetText()
							   : txtJsonField.Text
							   ;

			txtJsonField.Text = SaveDecoder.Decode(base64String);
		}

		private void btnEncode_Click(object sender, EventArgs e)
		{
			txtJsonField.Text = SaveDecoder.Encode(txtJsonField.Text);
		}

		private void btnCopyClipboard_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtJsonField.Text))
			{
				Clipboard.SetText(txtJsonField.Text);
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			FinderForm ff = new FinderForm();
			ff.Show(this);
		}
	}
}