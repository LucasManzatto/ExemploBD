using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace ExemploBD.Models.DAO
{
    public static class ClienteDAO
    {
        static private readonly string con = "Server=localhost;Database=mydb;Uid=root;Pwd=admin";

        public static Cliente BuscarPorId(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                return connection.Get<Cliente>(id);
            }
        }
        public static Cliente Inserir(Cliente cliente) { 
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                long retorno = connection.Insert(cliente);
                return retorno > 0 ? cliente : null;
            }
        }
        public static bool Alterar(Cliente cliente)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                return connection.Update(cliente);
            }
        }
        public static bool Deletar(Cliente cliente)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                if (cliente != null)
                {
                    return connection.Delete(cliente);
                }
                return false;
            }
        }
    }
}