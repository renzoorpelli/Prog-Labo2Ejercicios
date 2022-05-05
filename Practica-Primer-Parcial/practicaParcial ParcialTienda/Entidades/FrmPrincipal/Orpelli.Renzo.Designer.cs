namespace FrmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.labelCatalogo = new System.Windows.Forms.Label();
            this.btnNuevaOFerta = new System.Windows.Forms.Button();
            this.richTextBoxOfertas = new System.Windows.Forms.RichTextBox();
            this.labelOfertas = new System.Windows.Forms.Label();
            this.rtb_catalogo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(209, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 37);
            this.lblTitulo.TabIndex = 0;
            // 
            // labelCatalogo
            // 
            this.labelCatalogo.AutoSize = true;
            this.labelCatalogo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCatalogo.Location = new System.Drawing.Point(26, 80);
            this.labelCatalogo.Name = "labelCatalogo";
            this.labelCatalogo.Size = new System.Drawing.Size(110, 28);
            this.labelCatalogo.TabIndex = 1;
            this.labelCatalogo.Text = "CATALOGO";
            // 
            // btnNuevaOFerta
            // 
            this.btnNuevaOFerta.Location = new System.Drawing.Point(513, 358);
            this.btnNuevaOFerta.Name = "btnNuevaOFerta";
            this.btnNuevaOFerta.Size = new System.Drawing.Size(193, 37);
            this.btnNuevaOFerta.TabIndex = 2;
            this.btnNuevaOFerta.Text = "Nueva Oferta!";
            this.btnNuevaOFerta.UseVisualStyleBackColor = true;
            this.btnNuevaOFerta.Click += new System.EventHandler(this.btnNuevaOFerta_Click);
            // 
            // richTextBoxOfertas
            // 
            this.richTextBoxOfertas.Location = new System.Drawing.Point(513, 126);
            this.richTextBoxOfertas.Name = "richTextBoxOfertas";
            this.richTextBoxOfertas.Size = new System.Drawing.Size(193, 208);
            this.richTextBoxOfertas.TabIndex = 3;
            this.richTextBoxOfertas.Text = "";
            // 
            // labelOfertas
            // 
            this.labelOfertas.AutoSize = true;
            this.labelOfertas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOfertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelOfertas.Location = new System.Drawing.Point(562, 80);
            this.labelOfertas.Name = "labelOfertas";
            this.labelOfertas.Size = new System.Drawing.Size(91, 28);
            this.labelOfertas.TabIndex = 4;
            this.labelOfertas.Text = "OFERTAS";
            // 
            // rtb_catalogo
            // 
            this.rtb_catalogo.Location = new System.Drawing.Point(26, 126);
            this.rtb_catalogo.Name = "rtb_catalogo";
            this.rtb_catalogo.Size = new System.Drawing.Size(208, 246);
            this.rtb_catalogo.TabIndex = 5;
            this.rtb_catalogo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_catalogo);
            this.Controls.Add(this.labelOfertas);
            this.Controls.Add(this.richTextBoxOfertas);
            this.Controls.Add(this.btnNuevaOFerta);
            this.Controls.Add(this.labelCatalogo);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orpelli.Renzo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label labelCatalogo;
        private System.Windows.Forms.Button btnNuevaOFerta;
        private System.Windows.Forms.RichTextBox richTextBoxOfertas;
        private System.Windows.Forms.Label labelOfertas;
        private System.Windows.Forms.RichTextBox rtb_catalogo;
    }
}
