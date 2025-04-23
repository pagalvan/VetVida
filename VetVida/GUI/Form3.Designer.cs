namespace GUI
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboespecie = new System.Windows.Forms.ComboBox();
            this.comboraza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnespecie = new System.Windows.Forms.Button();
            this.btnraza = new System.Windows.Forms.Button();
            this.txtprop = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 12;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(213, 144);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(183, 22);
            this.txtedad.TabIndex = 18;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(213, 94);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(183, 22);
            this.txtnombre.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Especie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // comboespecie
            // 
            this.comboespecie.FormattingEnabled = true;
            this.comboespecie.Location = new System.Drawing.Point(213, 185);
            this.comboespecie.Name = "comboespecie";
            this.comboespecie.Size = new System.Drawing.Size(183, 24);
            this.comboespecie.TabIndex = 19;
            this.comboespecie.SelectedIndexChanged += new System.EventHandler(this.comboespecie_SelectedIndexChanged);
            // 
            // comboraza
            // 
            this.comboraza.FormattingEnabled = true;
            this.comboraza.Location = new System.Drawing.Point(213, 228);
            this.comboraza.Name = "comboraza";
            this.comboraza.Size = new System.Drawing.Size(183, 24);
            this.comboraza.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(96, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = " Propietario";
            // 
            // btnespecie
            // 
            this.btnespecie.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnespecie.Location = new System.Drawing.Point(425, 187);
            this.btnespecie.Name = "btnespecie";
            this.btnespecie.Size = new System.Drawing.Size(24, 23);
            this.btnespecie.TabIndex = 22;
            this.btnespecie.Text = "+";
            this.btnespecie.UseVisualStyleBackColor = true;
            this.btnespecie.Click += new System.EventHandler(this.btnespecie_Click);
            // 
            // btnraza
            // 
            this.btnraza.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraza.Location = new System.Drawing.Point(425, 229);
            this.btnraza.Name = "btnraza";
            this.btnraza.Size = new System.Drawing.Size(24, 23);
            this.btnraza.TabIndex = 23;
            this.btnraza.Text = "+";
            this.btnraza.UseVisualStyleBackColor = true;
            this.btnraza.Click += new System.EventHandler(this.btnraza_Click);
            // 
            // txtprop
            // 
            this.txtprop.Location = new System.Drawing.Point(248, 269);
            this.txtprop.Name = "txtprop";
            this.txtprop.Size = new System.Drawing.Size(183, 22);
            this.txtprop.TabIndex = 24;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(101, 369);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(131, 34);
            this.btnguardar.TabIndex = 25;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(622, 369);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(131, 34);
            this.btnsalir.TabIndex = 26;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtprop);
            this.Controls.Add(this.btnraza);
            this.Controls.Add(this.btnespecie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboraza);
            this.Controls.Add(this.comboespecie);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboespecie;
        private System.Windows.Forms.ComboBox comboraza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnespecie;
        private System.Windows.Forms.Button btnraza;
        private System.Windows.Forms.TextBox txtprop;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnsalir;
    }
}