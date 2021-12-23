namespace Ejemplo_Interfaz
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
            this.LMax = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.tMax = new System.Windows.Forms.TextBox();
            this.tCantidad = new System.Windows.Forms.TextBox();
            this.BGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LMax
            // 
            this.LMax.AutoSize = true;
            this.LMax.Location = new System.Drawing.Point(400, 148);
            this.LMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMax.Name = "LMax";
            this.LMax.Size = new System.Drawing.Size(38, 20);
            this.LMax.TabIndex = 0;
            this.LMax.Text = "Max";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(400, 231);
            this.LCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(73, 20);
            this.LCantidad.TabIndex = 1;
            this.LCantidad.Text = "Cantidad";
            // 
            // tMax
            // 
            this.tMax.Location = new System.Drawing.Point(531, 148);
            this.tMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tMax.Name = "tMax";
            this.tMax.Size = new System.Drawing.Size(148, 26);
            this.tMax.TabIndex = 2;
            // 
            // tCantidad
            // 
            this.tCantidad.Location = new System.Drawing.Point(531, 231);
            this.tCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Size = new System.Drawing.Size(148, 26);
            this.tCantidad.TabIndex = 3;
            // 
            // BGenerar
            // 
            this.BGenerar.Location = new System.Drawing.Point(591, 332);
            this.BGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(112, 35);
            this.BGenerar.TabIndex = 4;
            this.BGenerar.Text = "Generar";
            this.BGenerar.UseVisualStyleBackColor = true;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BGenerar);
            this.Controls.Add(this.tCantidad);
            this.Controls.Add(this.tMax);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LMax);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LMax;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox tMax;
        private System.Windows.Forms.TextBox tCantidad;
        private System.Windows.Forms.Button BGenerar;
    }
}