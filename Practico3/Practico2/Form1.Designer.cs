namespace Practico2
{
    partial class PequeñoFormulario
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
            LNyA = new Label();
            Ldni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            BEliminar = new Button();
            BGuardar = new Button();
            panel1 = new Panel();
            checkBoxMastercard = new CheckBox();
            checkBoxVisa = new CheckBox();
            checkBoxNaranja = new CheckBox();
            LTarjetaCredito = new Label();
            LTelefono = new Label();
            TTelefono = new TextBox();
            LNuevoCliente = new Label();
            radioButtonVaron = new RadioButton();
            radioButtonMujer = new RadioButton();
            pictureBox = new PictureBox();
            BSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(3, 25);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            LNyA.Click += label1_Click;
            // 
            // Ldni
            // 
            Ldni.AutoSize = true;
            Ldni.Location = new Point(23, 61);
            Ldni.Name = "Ldni";
            Ldni.Size = new Size(30, 15);
            Ldni.TabIndex = 0;
            Ldni.Text = "DNI:";
            Ldni.Click += label2_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(23, 105);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 0;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(23, 152);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            LNombre.Click += label4_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(156, 25);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 0;
            LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(113, 58);
            TDni.Name = "TDni";
            TDni.Size = new Size(136, 23);
            TDni.TabIndex = 1;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(113, 149);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(136, 23);
            TNombre.TabIndex = 1;
            TNombre.TextChanged += textBox2_TextChanged;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(113, 102);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(136, 23);
            TApellido.TabIndex = 1;
            TApellido.TextChanged += textBox2_TextChanged;
            // 
            // BEliminar
            // 
            BEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BEliminar.Image = Pequeño_Formulario.Properties.Resources.icons8_eliminar_64;
            BEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BEliminar.Location = new Point(183, 422);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(122, 61);
            BEliminar.TabIndex = 2;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = SystemColors.Control;
            BGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardar.Image = Pequeño_Formulario.Properties.Resources.icons8_guardar_64;
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(34, 423);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(122, 62);
            BGuardar.TabIndex = 2;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(checkBoxMastercard);
            panel1.Controls.Add(checkBoxVisa);
            panel1.Controls.Add(checkBoxNaranja);
            panel1.Controls.Add(LTarjetaCredito);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LNyA);
            panel1.Controls.Add(Ldni);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(TDni);
            panel1.Location = new Point(34, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 320);
            panel1.TabIndex = 3;
            // 
            // checkBoxMastercard
            // 
            checkBoxMastercard.AutoSize = true;
            checkBoxMastercard.Location = new Point(143, 294);
            checkBoxMastercard.Name = "checkBoxMastercard";
            checkBoxMastercard.Size = new Size(85, 19);
            checkBoxMastercard.TabIndex = 4;
            checkBoxMastercard.Text = "Mastercard";
            checkBoxMastercard.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisa
            // 
            checkBoxVisa.AutoSize = true;
            checkBoxVisa.Location = new Point(143, 269);
            checkBoxVisa.Name = "checkBoxVisa";
            checkBoxVisa.Size = new Size(47, 19);
            checkBoxVisa.TabIndex = 4;
            checkBoxVisa.Text = "Visa";
            checkBoxVisa.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaranja
            // 
            checkBoxNaranja.AutoSize = true;
            checkBoxNaranja.Location = new Point(143, 244);
            checkBoxNaranja.Name = "checkBoxNaranja";
            checkBoxNaranja.Size = new Size(67, 19);
            checkBoxNaranja.TabIndex = 4;
            checkBoxNaranja.Text = "Naranja";
            checkBoxNaranja.UseVisualStyleBackColor = true;
            checkBoxNaranja.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LTarjetaCredito
            // 
            LTarjetaCredito.AutoSize = true;
            LTarjetaCredito.Location = new Point(23, 244);
            LTarjetaCredito.Name = "LTarjetaCredito";
            LTarjetaCredito.Size = new Size(99, 15);
            LTarjetaCredito.TabIndex = 3;
            LTarjetaCredito.Text = "Tarjeta de Credito";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(23, 200);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(52, 15);
            LTelefono.TabIndex = 2;
            LTelefono.Text = "Telefono";
            LTelefono.Click += label1_Click_2;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(113, 197);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(136, 23);
            TTelefono.TabIndex = 1;
            TTelefono.TextChanged += Form1_Load;
            // 
            // LNuevoCliente
            // 
            LNuevoCliente.AutoSize = true;
            LNuevoCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoCliente.ForeColor = SystemColors.MenuHighlight;
            LNuevoCliente.Location = new Point(190, 9);
            LNuevoCliente.Name = "LNuevoCliente";
            LNuevoCliente.Size = new Size(152, 30);
            LNuevoCliente.TabIndex = 4;
            LNuevoCliente.Text = "Nuevo Cliente";
            LNuevoCliente.Click += label1_Click_1;
            // 
            // radioButtonVaron
            // 
            radioButtonVaron.AutoSize = true;
            radioButtonVaron.Checked = true;
            radioButtonVaron.Location = new Point(366, 171);
            radioButtonVaron.Name = "radioButtonVaron";
            radioButtonVaron.Size = new Size(55, 19);
            radioButtonVaron.TabIndex = 5;
            radioButtonVaron.TabStop = true;
            radioButtonVaron.Text = "Varon";
            radioButtonVaron.UseVisualStyleBackColor = true;
            radioButtonVaron.CheckedChanged += radioButtonVaron_CheckedChanged;
            // 
            // radioButtonMujer
            // 
            radioButtonMujer.AutoSize = true;
            radioButtonMujer.Location = new Point(447, 171);
            radioButtonMujer.Name = "radioButtonMujer";
            radioButtonMujer.Size = new Size(56, 19);
            radioButtonMujer.TabIndex = 5;
            radioButtonMujer.Text = "Mujer";
            radioButtonMujer.UseVisualStyleBackColor = true;
            radioButtonMujer.CheckedChanged += radioButtonMujer_CheckedChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(384, 54);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(96, 102);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // BSalir
            // 
            BSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSalir.Image = Pequeño_Formulario.Properties.Resources.icons8_salida_40;
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(350, 422);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(103, 61);
            BSalir.TabIndex = 2;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // PequeñoFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 536);
            Controls.Add(pictureBox);
            Controls.Add(radioButtonMujer);
            Controls.Add(radioButtonVaron);
            Controls.Add(LNuevoCliente);
            Controls.Add(panel1);
            Controls.Add(BSalir);
            Controls.Add(BGuardar);
            Controls.Add(BEliminar);
            Name = "PequeñoFormulario";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNyA;
        private Label Ldni;
        private Label LApellido;
        private Label LNombre;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TNombre;
        private TextBox TApellido;
        private Button BEliminar;
        private Button BGuardar;
        private Panel panel1;
        private Label LNuevoCliente;
        private TextBox TTelefono;
        private Label LTelefono;
        private CheckBox checkBoxNaranja;
        private Label LTarjetaCredito;
        private CheckBox checkBoxMastercard;
        private CheckBox checkBoxVisa;
        private RadioButton radioButtonVaron;
        private RadioButton radioButtonMujer;
        private PictureBox pictureBox;
        private Button BSalir;
    }
}
