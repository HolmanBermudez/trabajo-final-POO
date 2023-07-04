namespace trabajo_final_POO.Presentacion
{
    partial class Cliente
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
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApe1 = new System.Windows.Forms.Label();
            this.labelApe2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textApe1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(113, 23);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(262, 20);
            this.textCodigo.TabIndex = 0;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(18, 26);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Codigo";
            this.labelCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(18, 62);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelApe1
            // 
            this.labelApe1.AutoSize = true;
            this.labelApe1.Location = new System.Drawing.Point(18, 105);
            this.labelApe1.Name = "labelApe1";
            this.labelApe1.Size = new System.Drawing.Size(79, 13);
            this.labelApe1.TabIndex = 3;
            this.labelApe1.Text = "Primer Apellido ";
            // 
            // labelApe2
            // 
            this.labelApe2.AutoSize = true;
            this.labelApe2.Location = new System.Drawing.Point(18, 149);
            this.labelApe2.Name = "labelApe2";
            this.labelApe2.Size = new System.Drawing.Size(90, 13);
            this.labelApe2.TabIndex = 4;
            this.labelApe2.Text = "Segundo Apellido";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textApe1
            // 
            this.textApe1.Location = new System.Drawing.Point(113, 102);
            this.textApe1.Name = "textApe1";
            this.textApe1.Size = new System.Drawing.Size(262, 20);
            this.textApe1.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(262, 20);
            this.textBox4.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.textCodigo);
            this.groupBox1.Controls.Add(this.labelApe2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.labelApe1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.textApe1);
            this.groupBox1.Controls.Add(this.labelCodigo);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 286);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Lime;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(122, 224);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(83, 31);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(312, 224);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(80, 31);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cliente";
            this.Text = "Cliente Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApe1;
        private System.Windows.Forms.Label labelApe2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textApe1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}