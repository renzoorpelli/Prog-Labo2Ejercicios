namespace i01
{
    partial class FormMensaje
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lablMateria = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.cmbMateriaFavorita = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(31, 69);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(156, 23);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(285, 69);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(156, 23);
            this.textBoxApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(31, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(285, 40);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lablMateria
            // 
            this.lablMateria.AutoSize = true;
            this.lablMateria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablMateria.Location = new System.Drawing.Point(31, 119);
            this.lablMateria.Name = "lablMateria";
            this.lablMateria.Size = new System.Drawing.Size(98, 15);
            this.lablMateria.TabIndex = 4;
            this.lablMateria.Text = "Materia Favorita";
            // 
            // btnSaludar
            // 
            this.btnSaludar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaludar.Location = new System.Drawing.Point(434, 171);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(75, 23);
            this.btnSaludar.TabIndex = 5;
            this.btnSaludar.Text = "Saludar!";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // cmbMateriaFavorita
            // 
            this.cmbMateriaFavorita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaFavorita.FormattingEnabled = true;
            this.cmbMateriaFavorita.Location = new System.Drawing.Point(31, 147);
            this.cmbMateriaFavorita.Name = "cmbMateriaFavorita";
            this.cmbMateriaFavorita.Size = new System.Drawing.Size(220, 23);
            this.cmbMateriaFavorita.TabIndex = 6;
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 206);
            this.Controls.Add(this.cmbMateriaFavorita);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.lablMateria);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormMensaje";
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.FormMensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lablMateria;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.ComboBox cmbMateriaFavorita;
    }
}