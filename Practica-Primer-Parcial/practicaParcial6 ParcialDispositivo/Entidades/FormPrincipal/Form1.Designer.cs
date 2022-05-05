namespace FormPrincipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAppInstaladas = new System.Windows.Forms.RichTextBox();
            this.rtbAppNoInstaladas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAppInstaladas
            // 
            this.rtbAppInstaladas.BackColor = System.Drawing.Color.Black;
            this.rtbAppInstaladas.ForeColor = System.Drawing.Color.White;
            this.rtbAppInstaladas.Location = new System.Drawing.Point(32, 27);
            this.rtbAppInstaladas.Name = "rtbAppInstaladas";
            this.rtbAppInstaladas.Size = new System.Drawing.Size(276, 603);
            this.rtbAppInstaladas.TabIndex = 0;
            this.rtbAppInstaladas.Text = "";
            // 
            // rtbAppNoInstaladas
            // 
            this.rtbAppNoInstaladas.BackColor = System.Drawing.Color.Black;
            this.rtbAppNoInstaladas.ForeColor = System.Drawing.Color.White;
            this.rtbAppNoInstaladas.Location = new System.Drawing.Point(456, 27);
            this.rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            this.rtbAppNoInstaladas.Size = new System.Drawing.Size(276, 603);
            this.rtbAppNoInstaladas.TabIndex = 1;
            this.rtbAppNoInstaladas.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.rtbAppNoInstaladas);
            this.Controls.Add(this.rtbAppInstaladas);
            this.Name = "Form1";
            this.Text = "Parcial El Dispositivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAppInstaladas;
        private System.Windows.Forms.RichTextBox rtbAppNoInstaladas;
    }
}
