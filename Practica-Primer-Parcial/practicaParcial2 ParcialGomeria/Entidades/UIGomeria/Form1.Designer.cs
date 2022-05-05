namespace UIGomeria
{
    partial class FrmGomeria
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
            this.btnCargarVehiculo = new System.Windows.Forms.Button();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.dataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarVehiculo
            // 
            this.btnCargarVehiculo.Location = new System.Drawing.Point(37, 32);
            this.btnCargarVehiculo.Name = "btnCargarVehiculo";
            this.btnCargarVehiculo.Size = new System.Drawing.Size(153, 53);
            this.btnCargarVehiculo.TabIndex = 0;
            this.btnCargarVehiculo.Text = "Cargar Vehiculo";
            this.btnCargarVehiculo.UseVisualStyleBackColor = true;
            this.btnCargarVehiculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarInfo
            // 
            this.btnMostrarInfo.Location = new System.Drawing.Point(355, 32);
            this.btnMostrarInfo.Name = "btnMostrarInfo";
            this.btnMostrarInfo.Size = new System.Drawing.Size(153, 53);
            this.btnMostrarInfo.TabIndex = 1;
            this.btnMostrarInfo.Text = "Mostrar Info";
            this.btnMostrarInfo.UseVisualStyleBackColor = true;
            this.btnMostrarInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridVehiculos
            // 
            this.dataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehiculos.Location = new System.Drawing.Point(37, 104);
            this.dataGridVehiculos.Name = "dataGridVehiculos";
            this.dataGridVehiculos.RowTemplate.Height = 25;
            this.dataGridVehiculos.Size = new System.Drawing.Size(471, 171);
            this.dataGridVehiculos.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(37, 312);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 227);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // FrmGomeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(537, 576);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridVehiculos);
            this.Controls.Add(this.btnMostrarInfo);
            this.Controls.Add(this.btnCargarVehiculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGomeria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gomeria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarVehiculo;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.DataGridView dataGridVehiculos;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
