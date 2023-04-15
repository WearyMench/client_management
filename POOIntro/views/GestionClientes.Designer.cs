namespace POOIntro
{
    partial class GestionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listClients = new ListBox();
            btnGuardar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            txtApellido = new Label();
            txtTelefono = new Label();
            txtNumTel = new TextBox();
            txtCreditcard = new Label();
            txttarjeta = new TextBox();
            txtLastName = new TextBox();
            BtnEditar = new Button();
            lblId = new Label();
            label3 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // listClients
            // 
            listClients.FormattingEnabled = true;
            listClients.ItemHeight = 20;
            listClients.Location = new Point(34, 28);
            listClients.Name = "listClients";
            listClients.Size = new Size(257, 364);
            listClients.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(546, 249);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 86);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(458, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 27);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(233, 398);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 119);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Location = new Point(393, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(66, 20);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.Location = new Point(393, 155);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(67, 20);
            txtTelefono.TabIndex = 2;
            txtTelefono.Text = "Telefono";
            // 
            // txtNumTel
            // 
            txtNumTel.Location = new Point(458, 152);
            txtNumTel.Name = "txtNumTel";
            txtNumTel.Size = new Size(182, 27);
            txtNumTel.TabIndex = 3;
            // 
            // txtCreditcard
            // 
            txtCreditcard.AutoSize = true;
            txtCreditcard.Location = new Point(393, 193);
            txtCreditcard.Name = "txtCreditcard";
            txtCreditcard.Size = new Size(125, 20);
            txtCreditcard.TabIndex = 2;
            txtCreditcard.Text = "Tarjeta de credito";
            // 
            // txttarjeta
            // 
            txttarjeta.Location = new Point(393, 216);
            txttarjeta.Name = "txttarjeta";
            txttarjeta.Size = new Size(247, 27);
            txttarjeta.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(458, 116);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(182, 27);
            txtLastName.TabIndex = 3;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(133, 398);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(94, 29);
            BtnEditar.TabIndex = 5;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(458, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 58);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 8;
            label3.Text = "Id:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(lblId);
            Controls.Add(BtnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txttarjeta);
            Controls.Add(txtCreditcard);
            Controls.Add(txtNumTel);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(listClients);
            Name = "GestionClientes";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClients;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Label label2;
        private Label txtApellido;
        private Label txtTelefono;
        private TextBox txtNumTel;
        private Label txtCreditcard;
        private TextBox txttarjeta;
        private TextBox txtLastName;
        private Button BtnEditar;
        private Label lblId;
        private Label label3;
        private Button btnAdd;
    }
}