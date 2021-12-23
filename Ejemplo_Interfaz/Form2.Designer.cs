namespace Ejemplo_Interfaz
{
    partial class Form2
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
            this.BGenerador = new System.Windows.Forms.Button();
            this.BOrdenamiento = new System.Windows.Forms.Button();
            this.Bbusqueda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGenerador
            // 
            this.BGenerador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BGenerador.Location = new System.Drawing.Point(483, 205);
            this.BGenerador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BGenerador.Name = "BGenerador";
            this.BGenerador.Size = new System.Drawing.Size(238, 35);
            this.BGenerador.TabIndex = 0;
            this.BGenerador.Text = "Generador Numerico";
            this.BGenerador.UseVisualStyleBackColor = false;
            this.BGenerador.Click += new System.EventHandler(this.BGenerador_Click);
            // 
            // BOrdenamiento
            // 
            this.BOrdenamiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BOrdenamiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BOrdenamiento.Location = new System.Drawing.Point(483, 294);
            this.BOrdenamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BOrdenamiento.Name = "BOrdenamiento";
            this.BOrdenamiento.Size = new System.Drawing.Size(238, 35);
            this.BOrdenamiento.TabIndex = 1;
            this.BOrdenamiento.Text = "Ordenamiento";
            this.BOrdenamiento.UseVisualStyleBackColor = false;
            this.BOrdenamiento.Click += new System.EventHandler(this.BOrdenamiento_Click);
            // 
            // Bbusqueda
            // 
            this.Bbusqueda.Location = new System.Drawing.Point(483, 386);
            this.Bbusqueda.Name = "Bbusqueda";
            this.Bbusqueda.Size = new System.Drawing.Size(238, 35);
            this.Bbusqueda.TabIndex = 2;
            this.Bbusqueda.Text = "Búsqueda";
            this.Bbusqueda.UseVisualStyleBackColor = true;
            this.Bbusqueda.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clasificación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1242, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bbusqueda);
            this.Controls.Add(this.BOrdenamiento);
            this.Controls.Add(this.BGenerador);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BGenerador;
        private System.Windows.Forms.Button BOrdenamiento;
        private System.Windows.Forms.Button Bbusqueda;
        private System.Windows.Forms.Button button1;
    }
}