namespace formEstacionamiento
{
    partial class frmEstacionamiento
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.cmbTipoMoto = new System.Windows.Forms.ComboBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listVehiculos = new System.Windows.Forms.ListBox();
            this.txtNombreEstacionamiento = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(39, 439);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 92);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Vehiculo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(150, 101);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(195, 25);
            this.cmbTipoVehiculo.TabIndex = 1;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoVehiculo.Location = new System.Drawing.Point(12, 105);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(127, 21);
            this.lblTipoVehiculo.TabIndex = 2;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // cmbTipoMoto
            // 
            this.cmbTipoMoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoMoto.FormattingEnabled = true;
            this.cmbTipoMoto.Location = new System.Drawing.Point(150, 234);
            this.cmbTipoMoto.Name = "cmbTipoMoto";
            this.cmbTipoMoto.Size = new System.Drawing.Size(195, 25);
            this.cmbTipoMoto.TabIndex = 3;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatente.Location = new System.Drawing.Point(12, 171);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(64, 21);
            this.lblPatente.TabIndex = 6;
            this.lblPatente.Text = "Patente:";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(150, 169);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(195, 23);
            this.txtPatente.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(360, 236);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(195, 23);
            this.txtMarca.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 3;
            // 
            // listVehiculos
            // 
            this.listVehiculos.BackColor = System.Drawing.Color.PaleGreen;
            this.listVehiculos.FormattingEnabled = true;
            this.listVehiculos.ItemHeight = 15;
            this.listVehiculos.Location = new System.Drawing.Point(637, 226);
            this.listVehiculos.Name = "listVehiculos";
            this.listVehiculos.Size = new System.Drawing.Size(773, 304);
            this.listVehiculos.TabIndex = 9;
            this.listVehiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listVehiculos_MouseDoubleClick);
            // 
            // txtNombreEstacionamiento
            // 
            this.txtNombreEstacionamiento.BackColor = System.Drawing.Color.PaleGreen;
            this.txtNombreEstacionamiento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreEstacionamiento.Location = new System.Drawing.Point(637, 28);
            this.txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            this.txtNombreEstacionamiento.Size = new System.Drawing.Size(773, 43);
            this.txtNombreEstacionamiento.TabIndex = 10;
            this.txtNombreEstacionamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(12, 238);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 21);
            this.lblTipo.TabIndex = 11;
            // 
            // frmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1462, 567);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombreEstacionamiento);
            this.Controls.Add(this.listVehiculos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.cmbTipoMoto);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEstacionamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoMoto;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listVehiculos;
        private System.Windows.Forms.TextBox txtNombreEstacionamiento;
        private System.Windows.Forms.Label lblTipo;
    }
}
