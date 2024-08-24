namespace Practico2
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
            SuspendLayout();
            // 
            // LNyA
            // 
            LNyA.AutoSize = true;
            LNyA.Location = new Point(31, 25);
            LNyA.Name = "LNyA";
            LNyA.Size = new Size(110, 15);
            LNyA.TabIndex = 0;
            LNyA.Text = "Nombre y Apellido:";
            LNyA.Click += label1_Click;
            // 
            // Ldni
            // 
            Ldni.AutoSize = true;
            Ldni.Location = new Point(51, 61);
            Ldni.Name = "Ldni";
            Ldni.Size = new Size(30, 15);
            Ldni.TabIndex = 0;
            Ldni.Text = "DNI:";
            Ldni.Click += label2_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(51, 105);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 0;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(51, 152);
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
            LModificar.Location = new Point(184, 25);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 0;
            LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(141, 58);
            TDni.Name = "TDni";
            TDni.Size = new Size(136, 23);
            TDni.TabIndex = 1;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(141, 149);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(136, 23);
            TNombre.TabIndex = 1;
            TNombre.TextChanged += textBox2_TextChanged;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(141, 102);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(136, 23);
            TApellido.TabIndex = 1;
            TApellido.TextChanged += textBox2_TextChanged;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(167, 258);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 2;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(66, 258);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 2;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 341);
            Controls.Add(BGuardar);
            Controls.Add(BEliminar);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(TDni);
            Controls.Add(LModificar);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(Ldni);
            Controls.Add(LNyA);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
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
    }
}
