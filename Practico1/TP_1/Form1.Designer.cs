namespace TP_1
{
    partial class MiPrimerForms
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
            LNombre = new Label();
            LApellido = new Label();
            BGuardar = new Button();
            BEliminar = new Button();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            textBox3 = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(21, 97);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            LNombre.Click += label1_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(21, 56);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido";
            LApellido.Click += label2_Click;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(21, 150);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 2;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(123, 150);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 3;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(89, 53);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(109, 23);
            TxtApellido.TabIndex = 4;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(89, 94);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(109, 23);
            TxtNombre.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(256, 53);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 147);
            textBox3.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(368, 24);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            BSalir.KeyDown += Form1_KeyDown_1;
            // 
            // MiPrimerForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BSalir);
            Controls.Add(textBox3);
            Controls.Add(TxtNombre);
            Controls.Add(TxtApellido);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Name = "MiPrimerForms";
            Text = "Mi primer froms";
            Load += MiPrimerForms_Load;
            KeyDown += Form1_KeyDown_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombre;
        private Label LApellido;
        private Button BGuardar;
        private Button BEliminar;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private TextBox textBox3;
        private Button BSalir;
    }
}
