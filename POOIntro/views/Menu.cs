namespace POOIntro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientes ventana = new GestionClientes();
            ventana.ShowDialog();
        }
    }
}