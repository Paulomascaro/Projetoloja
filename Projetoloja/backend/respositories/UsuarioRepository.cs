using Projetoloja.backend.database;
using Projetoloja.backend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace Projetoloja.backend.respositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public UsuarioRepository()
        {

        }

        public void insertUser(string nome, string email, string senha, string tipo)
        {
            #region MySQL

            string strConnection = "server=127.0.0.1;User Id=root;database=projetoloja_db";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                string sql = "INSERT INTO usuario (nome, email, senha, tipo) VALUES (@nome, @email, @senha, @tipo)";

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    // Define os parâmetros
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);
                    comando.Parameters.AddWithValue("@tipo", tipo);

                    // Executa o comando
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("deu certo");
                conexao.Close();
            }

            #endregion
        }
    }
}
