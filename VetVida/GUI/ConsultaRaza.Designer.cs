namespace GUI
{
    partial class ConsultaRaza
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
            this.grillaPrueba = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPrueba
            // 
            this.grillaPrueba.AllowUserToAddRows = false;
            this.grillaPrueba.AllowUserToDeleteRows = false;
            this.grillaPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPrueba.Location = new System.Drawing.Point(173, 68);
            this.grillaPrueba.Name = "grillaPrueba";
            this.grillaPrueba.ReadOnly = true;
            this.grillaPrueba.RowHeadersWidth = 62;
            this.grillaPrueba.RowTemplate.Height = 24;
            this.grillaPrueba.Size = new System.Drawing.Size(450, 436);
            this.grillaPrueba.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(233, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(338, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 37);
            this.panel1.TabIndex = 13;
            // 
            // ConsultaRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grillaPrueba);
            this.Controls.Add(this.btnSalir);
            this.Name = "ConsultaRaza";
            this.Text = "ConsultaRaza";
            this.Load += new System.EventHandler(this.ConsultaRaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPrueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grillaPrueba;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
    }
}