namespace StS_Save_Test_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.tlpWorkspace = new System.Windows.Forms.TableLayoutPanel();
            this.txtJsonField = new System.Windows.Forms.RichTextBox();
            this.tlpWorkspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.AutoSize = true;
            this.btnCopyClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyClipboard.Location = new System.Drawing.Point(245, 3);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(100, 29);
            this.btnCopyClipboard.TabIndex = 3;
            this.btnCopyClipboard.Text = "Copy to clipboard";
            this.toolTips.SetToolTip(this.btnCopyClipboard, "Copy text to clipboard");
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(593, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(38, 29);
            this.btnFind.TabIndex = 4;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.AutoSize = true;
            this.btnEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncode.Location = new System.Drawing.Point(351, 3);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(236, 29);
            this.btnEncode.TabIndex = 1;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.AutoSize = true;
            this.btnDecode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecode.Location = new System.Drawing.Point(3, 3);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(236, 29);
            this.btnDecode.TabIndex = 0;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // tlpWorkspace
            // 
            this.tlpWorkspace.AllowDrop = true;
            this.tlpWorkspace.AutoSize = true;
            this.tlpWorkspace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpWorkspace.ColumnCount = 4;
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWorkspace.Controls.Add(this.btnDecode, 0, 0);
            this.tlpWorkspace.Controls.Add(this.btnEncode, 2, 0);
            this.tlpWorkspace.Controls.Add(this.txtJsonField, 0, 1);
            this.tlpWorkspace.Controls.Add(this.btnCopyClipboard, 1, 0);
            this.tlpWorkspace.Controls.Add(this.btnFind, 3, 0);
            this.tlpWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkspace.Location = new System.Drawing.Point(0, 0);
            this.tlpWorkspace.Name = "tlpWorkspace";
            this.tlpWorkspace.RowCount = 2;
            this.tlpWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWorkspace.Size = new System.Drawing.Size(634, 681);
            this.tlpWorkspace.TabIndex = 0;
            // 
            // txtJsonField
            // 
            this.txtJsonField.AcceptsTab = true;
            this.txtJsonField.AllowDrop = true;
            this.tlpWorkspace.SetColumnSpan(this.txtJsonField, 4);
            this.txtJsonField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJsonField.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtJsonField.Location = new System.Drawing.Point(3, 38);
            this.txtJsonField.MaxLength = 0;
            this.txtJsonField.Name = "txtJsonField";
            this.txtJsonField.Size = new System.Drawing.Size(628, 640);
            this.txtJsonField.TabIndex = 2;
            this.txtJsonField.Text = "";
            this.txtJsonField.WordWrap = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(634, 681);
            this.Controls.Add(this.tlpWorkspace);
            this.MinimumSize = new System.Drawing.Size(650, 720);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cheat The Game";
            this.tlpWorkspace.ResumeLayout(false);
            this.tlpWorkspace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TableLayoutPanel tlpWorkspace;
        public System.Windows.Forms.RichTextBox txtJsonField;
    }
}

