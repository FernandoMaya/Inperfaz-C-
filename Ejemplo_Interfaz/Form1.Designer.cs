namespace Ejemplo_Interfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAlgoritmos = new System.Windows.Forms.Button();
            this.BEstructuras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAlgoritmos
            // 
            this.BAlgoritmos.BackColor = System.Drawing.SystemColors.Highlight;
            this.BAlgoritmos.Location = new System.Drawing.Point(360, 90);
            this.BAlgoritmos.Name = "BAlgoritmos";
            this.BAlgoritmos.Size = new System.Drawing.Size(116, 23);
            this.BAlgoritmos.TabIndex = 0;
            this.BAlgoritmos.Text = "Algoritmos";
            this.BAlgoritmos.UseVisualStyleBackColor = false;
            this.BAlgoritmos.Click += new System.EventHandler(this.Algoritmos_Click);
            // 
            // BEstructuras
            // 
            this.BEstructuras.BackColor = System.Drawing.SystemColors.Highlight;
            this.BEstructuras.Location = new System.Drawing.Point(360, 196);
            this.BEstructuras.Name = "BEstructuras";
            this.BEstructuras.Size = new System.Drawing.Size(116, 23);
            this.BEstructuras.TabIndex = 1;
            this.BEstructuras.Text = "Estructuras";
            this.BEstructuras.UseVisualStyleBackColor = false;
            this.BEstructuras.Click += new System.EventHandler(this.BEstructuras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BEstructuras);
            this.Controls.Add(this.BAlgoritmos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAlgoritmos;
        private System.Windows.Forms.Button BEstructuras;
    }
}

