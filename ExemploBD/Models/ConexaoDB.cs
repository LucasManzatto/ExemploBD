using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploBD.Models
{
    public class ConexaoDB
    {
        public SqlConnection Conexao { get; set; }
        public SqlCommand Comando { get; set; }
        //public MySqlConnection Conexao { get; set; }
        //public MySqlCommand Comando { get; set; }

        public ConexaoDB()
        {
            //string con = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True";
            //string con = "Server=localhost;Database=ExercicioDB;Uid=root;Pwd=venus";
            //Conexao = new MySqlConnection(con);
            //Conexao = new SqlConnection(con);
            //Comando = Conexao.CreateCommand();
            //Conexao.Open();
        }
    }
}