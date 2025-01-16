using Projetoloja.backend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using MySql.Data.MySqlClient;


namespace Projetoloja.backend.database
{
    public class DatabaseContext : DbContext
    {
        public void DBConnect()
        {
            string strConnection = "server=127.0.0.1;User Id=root";
            //string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db";

            MySqlConnection conexao = new MySqlConnection(strConnection);
            //conexao.ConnectionString = strConnection;

            try
            {
                conexao.Open(); // abre conexao com base de dados

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {

                conexao.Close();
            }
        }
    }
        
}
