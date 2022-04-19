namespace Interfaz
{
    partial class MostrarTerreo
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
            this.labelDirec = new System.Windows.Forms.Label();
            this.labelEst = new System.Windows.Forms.Label();
            this.labelPre = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDue = new System.Windows.Forms.Label();
            this.labelMetr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDirec
            // 
            this.labelDirec.AutoSize = true;
            this.labelDirec.Location = new System.Drawing.Point(108, 45);
            this.labelDirec.Name = "labelDirec";
            this.labelDirec.Size = new System.Drawing.Size(60, 15);
            this.labelDirec.TabIndex = 0;
            this.labelDirec.Text = "Direccion ";
            this.labelDirec.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEst
            // 
            this.labelEst.AutoSize = true;
            this.labelEst.Location = new System.Drawing.Point(312, 178);
            this.labelEst.Name = "labelEst";
            this.labelEst.Size = new System.Drawing.Size(42, 15);
            this.labelEst.TabIndex = 1;
            this.labelEst.Text = "Estado";
            // 
            // labelPre
            // 
            this.labelPre.AutoSize = true;
            this.labelPre.Location = new System.Drawing.Point(108, 178);
            this.labelPre.Name = "labelPre";
            this.labelPre.Size = new System.Drawing.Size(40, 15);
            this.labelPre.TabIndex = 2;
            this.labelPre.Text = "Precio";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(472, 45);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(51, 15);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nombre";
            // 
            // labelDue
            // 
            this.labelDue.AutoSize = true;
            this.labelDue.Location = new System.Drawing.Point(312, 45);
            this.labelDue.Name = "labelDue";
            this.labelDue.Size = new System.Drawing.Size(42, 15);
            this.labelDue.TabIndex = 4;
            this.labelDue.Text = "Dueño";
            // 
            // labelMetr
            // 
            this.labelMetr.AutoSize = true;
            this.labelMetr.Location = new System.Drawing.Point(472, 178);
            this.labelMetr.Name = "labelMetr";
            this.labelMetr.Size = new System.Drawing.Size(47, 15);
            this.labelMetr.TabIndex = 5;
            this.labelMetr.Text = "Metraje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarTerreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMetr);
            this.Controls.Add(this.labelDue);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPre);
            this.Controls.Add(this.labelEst);
            this.Controls.Add(this.labelDirec);
            this.Name = "MostrarTerreo";
            this.Text = "MostrarTerreno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDirec;
        private Label labelEst;
        private Label labelPre;
        private Label labelNom;
        private Label labelDue;
        private Label labelMetr;
        private Button button1;
    }
}