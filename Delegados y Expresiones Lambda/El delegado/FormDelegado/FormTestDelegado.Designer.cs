namespace FormDelegado
{
    partial class FormTestDelegado
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bntActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(413, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // bntActualizar
            // 
            this.bntActualizar.Location = new System.Drawing.Point(32, 74);
            this.bntActualizar.Name = "bntActualizar";
            this.bntActualizar.Size = new System.Drawing.Size(413, 78);
            this.bntActualizar.TabIndex = 1;
            this.bntActualizar.Text = "Actualizar";
            this.bntActualizar.UseVisualStyleBackColor = true;
            this.bntActualizar.Click += new System.EventHandler(this.bntActualizar_Click);
            // 
            // FormTestDelegado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 175);
            this.Controls.Add(this.bntActualizar);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormTestDelegado";
            this.Text = "FormTestDelegado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button bntActualizar;
    }
}