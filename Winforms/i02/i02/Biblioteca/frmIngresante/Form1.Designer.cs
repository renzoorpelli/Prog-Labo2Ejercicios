namespace frmIngresante
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
            this.groupInfoIngresante = new System.Windows.Forms.GroupBox();
            this.numericEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkJS = new System.Windows.Forms.CheckBox();
            this.chkCPlus = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioNoBinario = new System.Windows.Forms.RadioButton();
            this.radioFemenino = new System.Windows.Forms.RadioButton();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupInfoIngresante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfoIngresante
            // 
            this.groupInfoIngresante.Controls.Add(this.numericEdad);
            this.groupInfoIngresante.Controls.Add(this.txtDireccion);
            this.groupInfoIngresante.Controls.Add(this.txtNombre);
            this.groupInfoIngresante.Controls.Add(this.lblEdad);
            this.groupInfoIngresante.Controls.Add(this.lblDireccion);
            this.groupInfoIngresante.Controls.Add(this.lblNombre);
            this.groupInfoIngresante.Location = new System.Drawing.Point(29, 52);
            this.groupInfoIngresante.Name = "groupInfoIngresante";
            this.groupInfoIngresante.Size = new System.Drawing.Size(218, 169);
            this.groupInfoIngresante.TabIndex = 0;
            this.groupInfoIngresante.TabStop = false;
            this.groupInfoIngresante.Text = "Detalles del usuario";
            // 
            // numericEdad
            // 
            this.numericEdad.Location = new System.Drawing.Point(84, 108);
            this.numericEdad.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericEdad.Name = "numericEdad";
            this.numericEdad.Size = new System.Drawing.Size(120, 23);
            this.numericEdad.TabIndex = 5;
            this.numericEdad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 68);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(15, 108);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(15, 68);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.chkJS);
            this.groupBox1.Controls.Add(this.chkCPlus);
            this.groupBox1.Controls.Add(this.chkCSharp);
            this.groupBox1.Location = new System.Drawing.Point(320, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos";
            // 
            // chkJS
            // 
            this.chkJS.AutoSize = true;
            this.chkJS.Location = new System.Drawing.Point(31, 112);
            this.chkJS.Name = "chkJS";
            this.chkJS.Size = new System.Drawing.Size(78, 19);
            this.chkJS.TabIndex = 6;
            this.chkJS.Text = "JavaScript";
            this.chkJS.UseVisualStyleBackColor = true;
            this.chkJS.CheckedChanged += new System.EventHandler(this.chkJS_CheckedChanged);
            // 
            // chkCPlus
            // 
            this.chkCPlus.AutoSize = true;
            this.chkCPlus.Location = new System.Drawing.Point(31, 77);
            this.chkCPlus.Name = "chkCPlus";
            this.chkCPlus.Size = new System.Drawing.Size(50, 19);
            this.chkCPlus.TabIndex = 5;
            this.chkCPlus.Text = "C++";
            this.chkCPlus.UseVisualStyleBackColor = true;
            this.chkCPlus.CheckedChanged += new System.EventHandler(this.chkCPlus_CheckedChanged);
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(31, 37);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkCSharp.TabIndex = 4;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            this.chkCSharp.CheckedChanged += new System.EventHandler(this.chkCSharp_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.radioNoBinario);
            this.groupBox2.Controls.Add(this.radioFemenino);
            this.groupBox2.Controls.Add(this.radioMasculino);
            this.groupBox2.Location = new System.Drawing.Point(320, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del usuario";
            // 
            // radioNoBinario
            // 
            this.radioNoBinario.AutoSize = true;
            this.radioNoBinario.Location = new System.Drawing.Point(21, 112);
            this.radioNoBinario.Name = "radioNoBinario";
            this.radioNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radioNoBinario.TabIndex = 2;
            this.radioNoBinario.TabStop = true;
            this.radioNoBinario.Text = "No binario";
            this.radioNoBinario.UseVisualStyleBackColor = true;
            this.radioNoBinario.CheckedChanged += new System.EventHandler(this.radioNoBinario_CheckedChanged);
            // 
            // radioFemenino
            // 
            this.radioFemenino.AutoSize = true;
            this.radioFemenino.Location = new System.Drawing.Point(21, 75);
            this.radioFemenino.Name = "radioFemenino";
            this.radioFemenino.Size = new System.Drawing.Size(78, 19);
            this.radioFemenino.TabIndex = 1;
            this.radioFemenino.TabStop = true;
            this.radioFemenino.Text = "Femenino";
            this.radioFemenino.UseVisualStyleBackColor = true;
            this.radioFemenino.CheckedChanged += new System.EventHandler(this.radioFemenino_CheckedChanged);
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(21, 41);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioMasculino.TabIndex = 0;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            this.radioMasculino.CheckedChanged += new System.EventHandler(this.radioMasculino_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxPaises);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(44, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 169);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del usuario";
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.ItemHeight = 15;
            this.listBoxPaises.Location = new System.Drawing.Point(21, 37);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(135, 94);
            this.listBoxPaises.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupInfoIngresante);
            this.Name = "Form1";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupInfoIngresante.ResumeLayout(false);
            this.groupInfoIngresante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfoIngresante;
        private System.Windows.Forms.NumericUpDown numericEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkJS;
        private System.Windows.Forms.CheckBox chkCPlus;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioNoBinario;
        private System.Windows.Forms.RadioButton radioFemenino;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxPaises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
