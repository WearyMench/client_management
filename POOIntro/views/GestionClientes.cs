using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using POOIntro.dao;
using POOIntro.entities;

namespace POOIntro
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            ClienteDao clienteDao = new ClienteDao();
            List<Cliente> listaDb = clienteDao.obtenerListadoDeClientes();
            listClients.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClients.Items.Add(cliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtLastName.Text;
            cliente.Telefono = txtNumTel.Text;
            cliente.TarjetaDeCredito = txttarjeta.Text;

            if (lblId.Text != "")
            {
                cliente.Id = lblId.Text;
            }

            ClienteDao clienteDao = new ClienteDao();
            clienteDao.Guardar(cliente);
            actualizarLista();
            limpiarListado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClients.SelectedItem;

            ClienteDao clienteDao = new ClienteDao();
            clienteDao.Eliminar(cliente);
            actualizarLista();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClients.SelectedItem;

            txtNombre.Text = cliente.Nombre;
            txtLastName.Text = cliente.Apellido;
            txtNumTel.Text = cliente.Telefono;
            txttarjeta.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.Id;

            actualizarLista();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            limpiarListado();
        }

        private void limpiarListado()
        {
            txtNombre.Text = "";
            txtLastName.Text = "";
            txtNumTel.Text = "";
            txttarjeta.Text = "";
            lblId.Text = "";
        }
    }
}
