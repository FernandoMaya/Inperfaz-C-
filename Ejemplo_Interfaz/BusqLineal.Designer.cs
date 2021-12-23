namespace Ejemplo_Interfaz
{
    partial class BusqLineal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.TextBox();
            this.uno = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Máximo";
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(621, 195);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(100, 26);
            this.Max.TabIndex = 3;
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(621, 134);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(100, 26);
            this.uno.TabIndex = 4;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(621, 258);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 26);
            this.valor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor";
            // 
            // BusqLineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 687);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "BusqLineal";
            this.Text = "BusqLineal";
            this.Load += new System.EventHandler(this.BusqLineal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox uno;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label3;
    }
}