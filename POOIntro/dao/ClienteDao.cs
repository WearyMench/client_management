using MySql.Data.MySqlClient;
using POOIntro.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntro.dao
{
    internal class ClienteDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "clientes";
            string cadenaConexion = "Database=" + baseDeDatos + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();
            //conexionDb.Close();
            return conexionDb;
        }

        public List<Cliente> obtenerListadoDeClientes() 
        {
            List<Cliente> lista = new List<Cliente>();

            string consulta = "SELECT * FROM `clientes`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = lectura.GetString("id");
                cliente.Nombre = lectura.GetString("nombre");
                cliente.Apellido = lectura.GetString("apellido");
                cliente.Telefono = lectura.GetString("telefono");
                cliente.TarjetaDeCredito = lectura.GetString("tarjeta_de_credito");
                lista.Add(cliente);

            }
            comando.Connection.Close();
            return lista;
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente.Id == null)
            {
                Insert(cliente);
            } else
            {
                Update(cliente);
            }
        }

        private void Insert(Cliente cliente)
        {
            string consulta = "INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `telefono`, `tarjeta_de_credito`) VALUES (NULL, '"
                + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Telefono + "', '" + cliente.TarjetaDeCredito + "');";
            
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        private void Update(Cliente cliente)
        {
            string consulta = "UPDATE `clientes` SET `nombre` = '"+ cliente.Nombre + "', `apellido` = '"+ cliente.Apellido +"', `telefono` = '"+ cliente.Telefono +"', `tarjeta_de_credito` = '"+ cliente.TarjetaDeCredito +"' WHERE `clientes`.`id` = "+ cliente.Id +";";
            
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            
            comando.Connection.Close();
        }

        public void Eliminar(Cliente cliente)
        {
            string consulta = "DELETE FROM clientes WHERE `clientes`.`id` = "+ cliente.Id +";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
