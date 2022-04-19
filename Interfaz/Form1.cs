namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnPropiedades_Click(object sender, EventArgs e)
        {
            Propiedades nuevaPropiedad = new Propiedades();
            nuevaPropiedad.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}