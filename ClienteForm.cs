using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeTareas
{
    public partial class ClienteForm : MetroFramework.Forms.MetroForm
    {
        private GestorClientes gestorClientes; // Cambiado el nombre de la variable

        public ClienteForm()
        {
            InitializeComponent();
            gestorClientes = new GestorClientes(); // Asumiendo que tienes una clase GestorClientes en tu capa de negocios
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaTareasDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sistemaTareasDataSet.Clientes);
            CargarClientes();
        }

        private void CargarClientes()
        {
            // Lógica para cargar la lista de clientes en el DataGridView
            dgvClientes.DataSource = gestorClientes.ObtenerClientesDB();

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar la selección de una fila en el DataGridView de clientes
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Mostrar los detalles del cliente seleccionado en los TextBox
                txtNombreCliente.Text = row.Cells[1].Value.ToString();
                txtTelefonoCliente.Text = row.Cells[2].Value.ToString();
                txtCorreoCliente.Text = row.Cells[3].Value.ToString();
                txtDireccionCliente.Text = row.Cells[4].Value.ToString();
                    }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un nuevo cliente
            string nombre = txtNombreCliente.Text;
            string telefono = txtTelefonoCliente.Text;
            string correo = txtCorreoCliente.Text;
            string direccion = txtDireccionCliente.Text;

            gestorClientes.AgregarCliente(nombre, telefono, correo, direccion);

            CargarClientes(); // Actualizar la lista de clientes después de agregar uno nuevo
            LimpiarCamposCliente();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

            // Obtener el cliente seleccionado del DataGridView
            Cliente clienteSeleccionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

            // Lógica para editar el cliente seleccionado
            string nombre = txtNombreCliente.Text;
            string telefono = txtTelefonoCliente.Text;
            string correo = txtCorreoCliente.Text;
            string direccion = txtDireccionCliente.Text;

            gestorClientes.EditarCliente(clienteSeleccionado.ClienteId, nombre, telefono, correo, direccion);

            CargarClientes(); // Actualizar la lista de clientes después de editar
            LimpiarCamposCliente();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            // Obtener el cliente seleccionado del DataGridView
            Cliente clienteSeleccionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;

            // Lógica para eliminar el cliente seleccionado
            gestorClientes.EliminarCliente(clienteSeleccionado.ClienteId);

            CargarClientes(); // Actualizar la lista de clientes después de eliminar
            LimpiarCamposCliente();
        }

        private void LimpiarCamposCliente()
        {
            // Lógica para limpiar los campos del formulario de clientes
            txtNombreCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
            txtCorreoCliente.Text = string.Empty;
            txtDireccionCliente.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

            TareasForm tareasForm = new TareasForm();
            tareasForm.Show();
        }
    }
}