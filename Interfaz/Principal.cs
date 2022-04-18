namespace Interfaz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funciona ese prbo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Suerte Gonorrea");
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}