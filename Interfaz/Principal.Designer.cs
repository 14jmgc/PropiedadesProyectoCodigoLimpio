namespace Interfaz
{
    partial class Principal
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
            this.btnPropiedades = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblInmobiliaria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPropiedades
            // 
            this.btnPropiedades.Location = new System.Drawing.Point(200, 128);
            this.btnPropiedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropiedades.Name = "btnPropiedades";
            this.btnPropiedades.Size = new System.Drawing.Size(310, 22);
            this.btnPropiedades.TabIndex = 0;
            this.btnPropiedades.Text = "Propiedades";
            this.btnPropiedades.UseVisualStyleBackColor = true;
            this.btnPropiedades.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(309, 190);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 22);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblInmobiliaria
            // 
            this.lblInmobiliaria.AutoSize = true;
            this.lblInmobiliaria.Font = new System.Drawing.Font("Broadway", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInmobiliaria.Location = new System.Drawing.Point(80, 27);
            this.lblInmobiliaria.Name = "lblInmobiliaria";
            this.lblInmobiliaria.Size = new System.Drawing.Size(556, 76);
            this.lblInmobiliaria.TabIndex = 2;
            this.lblInmobiliaria.Text = "INMOBILIARIA";
            this.lblInmobiliaria.Click += new System.EventHandler(this.label1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.lblInmobiliaria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPropiedades);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPropiedades;
        private Button btnSalir;
        private Label lblInmobiliaria;
    }
}