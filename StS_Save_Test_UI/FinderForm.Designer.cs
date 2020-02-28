namespace StS_Save_Test_UI
{
    partial class FinderForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.lblLocalizar = new System.Windows.Forms.Label();
            this.btnLocalizarProxima = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtLocalizar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLocalizar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLocalizarProxima, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalizar.Location = new System.Drawing.Point(61, 30);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(205, 20);
            this.txtLocalizar.TabIndex = 0;
            // 
            // lblLocalizar
            // 
            this.lblLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalizar.AutoSize = true;
            this.lblLocalizar.Location = new System.Drawing.Point(3, 33);
            this.lblLocalizar.Name = "lblLocalizar";
            this.lblLocalizar.Size = new System.Drawing.Size(52, 13);
            this.lblLocalizar.TabIndex = 1;
            this.lblLocalizar.Text = "Localizar:";
            // 
            // btnLocalizarProxima
            // 
            this.btnLocalizarProxima.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLocalizarProxima.Location = new System.Drawing.Point(272, 28);
            this.btnLocalizarProxima.Name = "btnLocalizarProxima";
            this.btnLocalizarProxima.Size = new System.Drawing.Size(115, 23);
            this.btnLocalizarProxima.TabIndex = 2;
            this.btnLocalizarProxima.Text = " Localizar Próxima";
            this.btnLocalizarProxima.UseVisualStyleBackColor = true;
            // 
            // FinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 160);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FinderForm";
            this.Text = "FinderForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label lblLocalizar;
        private System.Windows.Forms.Button btnLocalizarProxima;
    }
}