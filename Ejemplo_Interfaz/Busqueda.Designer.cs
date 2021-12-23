namespace Ejemplo_Interfaz
{
    partial class Busqueda
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
            this.BBusquedaL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BBusquedaL
            // 
            this.BBusquedaL.Location = new System.Drawing.Point(499, 140);
            this.BBusquedaL.Name = "BBusquedaL";
            this.BBusquedaL.Size = new System.Drawing.Size(212, 38);
            this.BBusquedaL.TabIndex = 0;
            this.BBusquedaL.Text = "Busqueda Lineal";
            this.BBusquedaL.UseVisualStyleBackColor = true;
            this.BBusquedaL.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Busqueda Binaria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BBusquedaL);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BBusquedaL;
        private System.Windows.Forms.Button button1;
    }
}