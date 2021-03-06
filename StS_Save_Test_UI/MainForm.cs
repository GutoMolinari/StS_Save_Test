﻿using STS_Save;
using System;
using System.Windows.Forms;

namespace StS_Save_Test_UI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			btnDecode.Click += btnDecode_Click;
			btnEncode.Click += btnEncode_Click;

			btnCopyClipboard.Click += btnCopyClipboard_Click;
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
	}
}