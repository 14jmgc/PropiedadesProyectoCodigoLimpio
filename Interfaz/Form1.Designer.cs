namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnPropiedades = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Bernard MT Condensed", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPrincipal.Location = new System.Drawing.Point(152, 85);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(473, 99);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "INMOBILIARIA";
            // 
            // btnPropiedades
            // 
            this.btnPropiedades.Location = new System.Drawing.Point(286, 219);
            this.btnPropiedades.Name = "btnPropiedades";
            this.btnPropiedades.Size = new System.Drawing.Size(213, 29);
            this.btnPropiedades.TabIndex = 1;
            this.btnPropiedades.Text = "Propiedades";
            this.btnPropiedades.UseVisualStyleBackColor = true;
            this.btnPropiedades.Click += new System.EventHandler(this.btnPropiedades_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(344, 297);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPropiedades);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Name = "Form1";
            this.Text = "Inmobiliaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTituloPrincipal;
        private Button btnPropiedades;
        private Button btnSalir;
    }
}