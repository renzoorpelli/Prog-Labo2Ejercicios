namespace FrmTorneo
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
            this.btnDesafiar = new System.Windows.Forms.Button();
            this.cmbEquipo1 = new System.Windows.Forms.ComboBox();
            this.cmbEquipo2 = new System.Windows.Forms.ComboBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.rchtDatosTorneo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesafiar
            // 
            this.btnDesafiar.Location = new System.Drawing.Point(232, 93);
            this.btnDesafiar.Name = "btnDesafiar";
            this.btnDesafiar.Size = new System.Drawing.Size(281, 35);
            this.btnDesafiar.TabIndex = 0;
            this.btnDesafiar.Text = "Desafiar";
            this.btnDesafiar.UseVisualStyleBackColor = true;
            this.btnDesafiar.Click += new System.EventHandler(this.btnDesafiar_Click);
            // 
            // cmbEquipo1
            // 
            this.cmbEquipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipo1.FormattingEnabled = true;
            this.cmbEquipo1.Location = new System.Drawing.Point(36, 46);
            this.cmbEquipo1.Name = "cmbEquipo1";
            this.cmbEquipo1.Size = new System.Drawing.Size(289, 23);
            this.cmbEquipo1.TabIndex = 1;
            this.cmbEquipo1.SelectedIndexChanged += new System.EventHandler(this.cmbEquipo1_SelectedIndexChanged);
            // 
            // cmbEquipo2
            // 
            this.cmbEquipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipo2.FormattingEnabled = true;
            this.cmbEquipo2.Location = new System.Drawing.Point(424, 46);
            this.cmbEquipo2.Name = "cmbEquipo2";
            this.cmbEquipo2.Size = new System.Drawing.Size(319, 23);
            this.cmbEquipo2.TabIndex = 2;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(36, 180);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowTemplate.Height = 25;
            this.dgvResultados.Size = new System.Drawing.Size(720, 196);
            this.dgvResultados.TabIndex = 3;
            // 
            // rchtDatosTorneo
            // 
            this.rchtDatosTorneo.Location = new System.Drawing.Point(36, 436);
            this.rchtDatosTorneo.Name = "rchtDatosTorneo";
            this.rchtDatosTorneo.Size = new System.Drawing.Size(720, 214);
            this.rchtDatosTorneo.TabIndex = 4;
            this.rchtDatosTorneo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.rchtDatosTorneo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.cmbEquipo2);
            this.Controls.Add(this.cmbEquipo1);
            this.Controls.Add(this.btnDesafiar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orpelli.Renzo.2E";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesafiar;
        private System.Windows.Forms.ComboBox cmbEquipo1;
        private System.Windows.Forms.ComboBox cmbEquipo2;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.RichTextBox rchtDatosTorneo;
    }
}
