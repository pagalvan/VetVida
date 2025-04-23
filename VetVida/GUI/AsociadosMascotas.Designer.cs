namespace GUI
{
    partial class AsociadosMascotas
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
            this.Gridasociado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Gridasociado)).BeginInit();
            this.SuspendLayout();
            // 
            // Gridasociado
            // 
            this.Gridasociado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridasociado.Location = new System.Drawing.Point(98, 62);
            this.Gridasociado.Name = "Gridasociado";
            this.Gridasociado.RowHeadersWidth = 51;
            this.Gridasociado.RowTemplate.Height = 24;
            this.Gridasociado.Size = new System.Drawing.Size(515, 454);
            this.Gridasociado.TabIndex = 0;
            this.Gridasociado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridasociado_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 37);
            this.panel1.TabIndex = 12;
            // 
            // AsociadosMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gridasociado);
            this.Name = "AsociadosMascotas";
            this.Text = "AsociadosMascotas";
            this.Load += new System.EventHandler(this.AsociadosMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridasociado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Gridasociado;
        private System.Windows.Forms.Panel panel1;
    }
}