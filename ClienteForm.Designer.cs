namespace ControlDeTareas
{
    partial class ClienteForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregarCliente = new MetroFramework.Controls.MetroButton();
            this.btnEditarCliente = new MetroFramework.Controls.MetroButton();
            this.btnEliminarCliente = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.txtNombreCliente = new MetroFramework.Controls.MetroTextBox();
            this.txtCorreoCliente = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefonoCliente = new MetroFramework.Controls.MetroTextBox();
            this.txtDireccionCliente = new MetroFramework.Controls.MetroTextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionFisicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaTareasDataSet = new ControlDeTareas.SistemaTareasDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new ControlDeTareas.SistemaTareasDataSetTableAdapters.ClientesTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTareasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(62, 530);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(136, 43);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseSelectable = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(227, 530);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(136, 43);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseSelectable = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(528, 530);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(136, 43);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseSelectable = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(708, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombreCliente
            // 
            // 
            // 
            // 
            this.txtNombreCliente.CustomButton.Image = null;
            this.txtNombreCliente.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.txtNombreCliente.CustomButton.Name = "";
            this.txtNombreCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreCliente.CustomButton.TabIndex = 1;
            this.txtNombreCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreCliente.CustomButton.UseSelectable = true;
            this.txtNombreCliente.CustomButton.Visible = false;
            this.txtNombreCliente.Lines = new string[0];
            this.txtNombreCliente.Location = new System.Drawing.Point(62, 144);
            this.txtNombreCliente.MaxLength = 32767;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.SelectionLength = 0;
            this.txtNombreCliente.SelectionStart = 0;
            this.txtNombreCliente.ShortcutsEnabled = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(286, 23);
            this.txtNombreCliente.TabIndex = 4;
            this.txtNombreCliente.UseSelectable = true;
            this.txtNombreCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCorreoCliente
            // 
            // 
            // 
            // 
            this.txtCorreoCliente.CustomButton.Image = null;
            this.txtCorreoCliente.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.txtCorreoCliente.CustomButton.Name = "";
            this.txtCorreoCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCorreoCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorreoCliente.CustomButton.TabIndex = 1;
            this.txtCorreoCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorreoCliente.CustomButton.UseSelectable = true;
            this.txtCorreoCliente.CustomButton.Visible = false;
            this.txtCorreoCliente.Lines = new string[0];
            this.txtCorreoCliente.Location = new System.Drawing.Point(62, 209);
            this.txtCorreoCliente.MaxLength = 32767;
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.PasswordChar = '\0';
            this.txtCorreoCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreoCliente.SelectedText = "";
            this.txtCorreoCliente.SelectionLength = 0;
            this.txtCorreoCliente.SelectionStart = 0;
            this.txtCorreoCliente.ShortcutsEnabled = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(286, 23);
            this.txtCorreoCliente.TabIndex = 5;
            this.txtCorreoCliente.UseSelectable = true;
            this.txtCorreoCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorreoCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefonoCliente
            // 
            // 
            // 
            // 
            this.txtTelefonoCliente.CustomButton.Image = null;
            this.txtTelefonoCliente.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtTelefonoCliente.CustomButton.Name = "";
            this.txtTelefonoCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefonoCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefonoCliente.CustomButton.TabIndex = 1;
            this.txtTelefonoCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefonoCliente.CustomButton.UseSelectable = true;
            this.txtTelefonoCliente.CustomButton.Visible = false;
            this.txtTelefonoCliente.Lines = new string[0];
            this.txtTelefonoCliente.Location = new System.Drawing.Point(528, 144);
            this.txtTelefonoCliente.MaxLength = 32767;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.PasswordChar = '\0';
            this.txtTelefonoCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefonoCliente.SelectedText = "";
            this.txtTelefonoCliente.SelectionLength = 0;
            this.txtTelefonoCliente.SelectionStart = 0;
            this.txtTelefonoCliente.ShortcutsEnabled = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(163, 23);
            this.txtTelefonoCliente.TabIndex = 6;
            this.txtTelefonoCliente.UseSelectable = true;
            this.txtTelefonoCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefonoCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDireccionCliente
            // 
            // 
            // 
            // 
            this.txtDireccionCliente.CustomButton.Image = null;
            this.txtDireccionCliente.CustomButton.Location = new System.Drawing.Point(221, 2);
            this.txtDireccionCliente.CustomButton.Name = "";
            this.txtDireccionCliente.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txtDireccionCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccionCliente.CustomButton.TabIndex = 1;
            this.txtDireccionCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccionCliente.CustomButton.UseSelectable = true;
            this.txtDireccionCliente.CustomButton.Visible = false;
            this.txtDireccionCliente.Lines = new string[0];
            this.txtDireccionCliente.Location = new System.Drawing.Point(528, 209);
            this.txtDireccionCliente.MaxLength = 32767;
            this.txtDireccionCliente.Multiline = true;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.PasswordChar = '\0';
            this.txtDireccionCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccionCliente.SelectedText = "";
            this.txtDireccionCliente.SelectionLength = 0;
            this.txtDireccionCliente.SelectionStart = 0;
            this.txtDireccionCliente.ShortcutsEnabled = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(281, 62);
            this.txtDireccionCliente.TabIndex = 7;
            this.txtDireccionCliente.UseSelectable = true;
            this.txtDireccionCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccionCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.direccionFisicaDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(62, 297);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(747, 206);
            this.dgvClientes.TabIndex = 8;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 180;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionFisicaDataGridViewTextBoxColumn
            // 
            this.direccionFisicaDataGridViewTextBoxColumn.DataPropertyName = "DireccionFisica";
            this.direccionFisicaDataGridViewTextBoxColumn.HeaderText = "Direccion Fisica";
            this.direccionFisicaDataGridViewTextBoxColumn.Name = "direccionFisicaDataGridViewTextBoxColumn";
            this.direccionFisicaDataGridViewTextBoxColumn.Width = 220;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.sistemaTareasDataSet;
            // 
            // sistemaTareasDataSet
            // 
            this.sistemaTareasDataSet.DataSetName = "SistemaTareasDataSet";
            this.sistemaTareasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 58);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bitácora de Clientes de Proyectos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Ingrese el Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 187);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(179, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Ingrese el Correo Electronico";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(528, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Ingrese el Telefono";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(528, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(123, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Ingrese la Dirección";
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 587);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ClienteForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Control de Tareas - Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaTareasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAgregarCliente;
        private MetroFramework.Controls.MetroButton btnEditarCliente;
        private MetroFramework.Controls.MetroButton btnEliminarCliente;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroTextBox txtNombreCliente;
        private MetroFramework.Controls.MetroTextBox txtCorreoCliente;
        private MetroFramework.Controls.MetroTextBox txtTelefonoCliente;
        private MetroFramework.Controls.MetroTextBox txtDireccionCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private SistemaTareasDataSet sistemaTareasDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SistemaTareasDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionFisicaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}