namespace Ejemplo_Interfaz
{
    partial class Form5
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
            this.BVectores = new System.Windows.Forms.Button();
            this.BArreglos = new System.Windows.Forms.Button();
            this.BArreglosIrregulares = new System.Windows.Forms.Button();
            this.BStructs = new System.Windows.Forms.Button();
            this.BListas = new System.Windows.Forms.Button();
            this.BPilas = new System.Windows.Forms.Button();
            this.BColas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BVectores
            // 
            this.BVectores.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BVectores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BVectores.Location = new System.Drawing.Point(363, 194);
            this.BVectores.Name = "BVectores";
            this.BVectores.Size = new System.Drawing.Size(75, 23);
            this.BVectores.TabIndex = 0;
            this.BVectores.Text = "Vectores";
            this.BVectores.UseVisualStyleBackColor = false;
            this.BVectores.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BArreglos
            // 
            this.BArreglos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BArreglos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BArreglos.Location = new System.Drawing.Point(272, 173);
            this.BArreglos.Name = "BArreglos";
            this.BArreglos.Size = new System.Drawing.Size(75, 23);
            this.BArreglos.TabIndex = 1;
            this.BArreglos.Text = "Arreglos";
            this.BArreglos.UseVisualStyleBackColor = false;
            // 
            // BArreglosIrregulares
            // 
            this.BArreglosIrregulares.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BArreglosIrregulares.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BArreglosIrregulares.Location = new System.Drawing.Point(272, 214);
            this.BArreglosIrregulares.Name = "BArreglosIrregulares";
            this.BArreglosIrregulares.Size = new System.Drawing.Size(75, 23);
            this.BArreglosIrregulares.TabIndex = 2;
            this.BArreglosIrregulares.Text = "Arreglos Irregulares";
            this.BArreglosIrregulares.UseVisualStyleBackColor = false;
            // 
            // BStructs
            // 
            this.BStructs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BStructs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BStructs.Location = new System.Drawing.Point(272, 255);
            this.BStructs.Name = "BStructs";
            this.BStructs.Size = new System.Drawing.Size(75, 23);
            this.BStructs.TabIndex = 3;
            this.BStructs.Text = "Structs";
            this.BStructs.UseVisualStyleBackColor = false;
            // 
            // BListas
            // 
            this.BListas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BListas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BListas.Location = new System.Drawing.Point(454, 173);
            this.BListas.Name = "BListas";
            this.BListas.Size = new System.Drawing.Size(75, 23);
            this.BListas.TabIndex = 4;
            this.BListas.Text = "Listas";
            this.BListas.UseVisualStyleBackColor = false;
            // 
            // BPilas
            // 
            this.BPilas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BPilas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BPilas.Location = new System.Drawing.Point(454, 214);
            this.BPilas.Name = "BPilas";
            this.BPilas.Size = new System.Drawing.Size(75, 23);
            this.BPilas.TabIndex = 5;
            this.BPilas.Text = "Pilas";
            this.BPilas.UseVisualStyleBackColor = false;
            // 
            // BColas
            // 
            this.BColas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BColas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BColas.Location = new System.Drawing.Point(454, 255);
            this.BColas.Name = "BColas";
            this.BColas.Size = new System.Drawing.Size(75, 23);
            this.BColas.TabIndex = 6;
            this.BColas.Text = "Colas";
            this.BColas.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BColas);
            this.Controls.Add(this.BPilas);
            this.Controls.Add(this.BListas);
            this.Controls.Add(this.BStructs);
            this.Controls.Add(this.BArreglosIrregulares);
            this.Controls.Add(this.BArreglos);
            this.Controls.Add(this.BVectores);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BVectores;
        private System.Windows.Forms.Button BArreglos;
        private System.Windows.Forms.Button BArreglosIrregulares;
        private System.Windows.Forms.Button BStructs;
        private System.Windows.Forms.Button BListas;
        private System.Windows.Forms.Button BPilas;
        private System.Windows.Forms.Button BColas;
    }
}