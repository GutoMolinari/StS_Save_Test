using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StS_Save_Test_UI
{
    public partial class FinderForm : Form
    {
        public FinderForm()
        {
            InitializeComponent();

            btnLocalizarProxima.Click += BtnLocalizarProxima_Click;
        }

        private void BtnLocalizarProxima_Click(object sender, EventArgs e)
        {
            var searchText = txtLocalizar.Text;

            RichTextBox parentRichtTextBox = ((Form1)this.Owner).txtJsonField;

            var textoRichBox = parentRichtTextBox.Text.Replace("\n", Environment.NewLine);

            if (textoRichBox.Contains(searchText))
            {
                var localizacao = parentRichtTextBox.Find(searchText);
            }               

        }
    }
}
