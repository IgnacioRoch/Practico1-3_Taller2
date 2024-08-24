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

            // Validaci�n de que el DNI solo contenga n�meros  
            if (!long.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe contener solo n�meros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validaci�n de que el apellido y nombre solo contengan letras  
            if (!apellido.All(char.IsLetter) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("El Apellido y el Nombre deben contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de consulta sobre la inserci�n  
            DialogResult ask = MessageBox.Show("�Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // Verificar la respuesta del usuario  
            if (ask == DialogResult.Yes)
            {
                // Aqu� ir�a la l�gica para insertar el nuevo cliente  
                // Por ejemplo, llamar a una funci�n para insertar en la base de datos

                // Mostrar mensaje de informaci�n confirmando la inserci�n correcta  
                MessageBox.Show($"El Cliente: {nombre} {apellido} se insert� correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = "Los datos han sido guardados.";
            }
            else
            {
                LModificar.Text = "Inserci�n cancelada.";
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string dni = TDni.Text;
            string apellido = TApellido.Text;
            string nombre = TNombre.Text;

            // Verificar que los campos no est�n vac�os  
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de advertencia sobre la eliminaci�n  
            DialogResult ask = MessageBox.Show($"Est� a punto de eliminar el Cliente: {nombre} {apellido}", "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            // Verificar la respuesta del usuario  
            if (ask == DialogResult.Yes)
            {
                // Aqu� ir�a la l�gica para eliminar el cliente  
                // Por ejemplo, llamar a una funci�n para eliminar en la base de datos

                // Limpiar los campos de texto  
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();

                // Mostrar mensaje de confirmaci�n de la eliminaci�n  
                MessageBox.Show($"El Cliente: {nombre} {apellido} se elimin� correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eliminaci�n cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
