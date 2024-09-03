namespace ConexionBBDD
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
            txtId = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            lblId = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(157, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(176, 23);
            txtId.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(157, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(176, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(424, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(424, 143);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(176, 23);
            txtTelefono.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(73, 44);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(73, 99);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(73, 146);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(369, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(369, 146);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 150);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(157, 405);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(316, 405);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(495, 405);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblId);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label lblId;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblTelefono;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}
