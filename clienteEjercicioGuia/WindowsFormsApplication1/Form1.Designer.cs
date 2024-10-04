namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FtoC = new System.Windows.Forms.RadioButton();
            this.CtoF = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados para convertir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // temperatura
            // 
            this.temperatura.Location = new System.Drawing.Point(336, 60);
            this.temperatura.Margin = new System.Windows.Forms.Padding(6);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(324, 31);
            this.temperatura.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.FtoC);
            this.groupBox1.Controls.Add(this.CtoF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.temperatura);
            this.groupBox1.Location = new System.Drawing.Point(24, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(726, 542);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Location = new System.Drawing.Point(232, 175);
            this.FtoC.Margin = new System.Windows.Forms.Padding(6);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(364, 29);
            this.FtoC.TabIndex = 7;
            this.FtoC.TabStop = true;
            this.FtoC.Text = "Convertir de Fahrenheit a Celsius";
            this.FtoC.UseVisualStyleBackColor = true;
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Location = new System.Drawing.Point(232, 131);
            this.CtoF.Margin = new System.Windows.Forms.Padding(6);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(364, 29);
            this.CtoF.TabIndex = 8;
            this.CtoF.TabStop = true;
            this.CtoF.Text = "Convertir de Celsius a Fahrenheit";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.CheckedChanged += new System.EventHandler(this.Bonito_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "CONECTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 773);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "DESCONECTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1081);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FtoC;
        private System.Windows.Forms.RadioButton CtoF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

