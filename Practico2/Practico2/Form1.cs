using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string dni = TDni.Text;
            string apellido = TApellido.Text;
            string nombre = TNombre.Text;

            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el DNI solo contenga números  
            if (!long.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el apellido y nombre solo contengan letras  
            if (!apellido.All(char.IsLetter) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("El Apellido y el Nombre deben contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de consulta sobre la inserción  
            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // Verificar la respuesta del usuario  
            if (ask == DialogResult.Yes)
            {
                // Aquí iría la lógica para insertar el nuevo cliente  
                // Por ejemplo, llamar a una función para insertar en la base de datos

                // Mostrar mensaje de información confirmando la inserción correcta  
                MessageBox.Show($"El Cliente: {nombre} {apellido} se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = "Los datos han sido guardados.";
            }
            else
            {
                LModificar.Text = "Inserción cancelada.";
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string dni = TDni.Text;
            string apellido = TApellido.Text;
            string nombre = TNombre.Text;

            // Verificar que los campos no estén vacíos  
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de advertencia sobre la eliminación  
            DialogResult ask = MessageBox.Show($"Está a punto de eliminar el Cliente: {nombre} {apellido}", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            // Verificar la respuesta del usuario  
            if (ask == DialogResult.Yes)
            {
                // Aquí iría la lógica para eliminar el cliente  
                // Por ejemplo, llamar a una función para eliminar en la base de datos

                // Limpiar los campos de texto  
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();

                // Mostrar mensaje de confirmación de la eliminación  
                MessageBox.Show($"El Cliente: {nombre} {apellido} se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
