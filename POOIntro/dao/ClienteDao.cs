using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using POOIntro.entities;

namespace POOIntro.dao
{
    internal class ClienteDao
    {
        private readonly string _connectionString;

        public ClienteDao()
        {
            // Construir la configuración a partir del archivo appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Obtener la cadena de conexión
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public MySqlConnection Conectar()
        {
            MySqlConnection conexionDb = new MySqlConnection(_connectionString);
            conexionDb.Open();
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
            }
            else
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
            string consulta = "UPDATE `clientes` SET `nombre` = '" + cliente.Nombre + "', `apellido` = '" + cliente.Apellido + "', `telefono` = '" + cliente.Telefono + "', `tarjeta_de_credito` = '" + cliente.TarjetaDeCredito + "' WHERE `clientes`.`id` = " + cliente.Id + ";";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Eliminar(Cliente cliente)
        {
            string consulta = "DELETE FROM clientes WHERE `clientes`.`id` = " + cliente.Id + ";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
