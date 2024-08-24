namespace TP_1
{
    public partial class MiPrimerForms : Form
    {
        public MiPrimerForms()
        {
            InitializeComponent();
            // Configurar el evento KeyDown  
            this.KeyDown += new KeyEventHandler(Form1_KeyDown_1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            textBox3.Text = TxtApellido.Text + " " + TxtNombre.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown_1(object? sender, KeyEventArgs e)
        {
            // Verifica si se presionó Ctrl + S  
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Cierra la aplicación  
                Application.Exit();
            }
        }

        private void MiPrimerForms_Load(object sender, EventArgs e)
        {

        }
    }
}
