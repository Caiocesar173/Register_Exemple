using MySql.Data.MySqlClient;
using System.Data;



namespace Registo_Usuario.Dao
{
    class Conexao
    {
        private MySqlConnection conexao = new MySqlConnection("server = 127.0.0.1; port = 3306; User Id = root; database = usuario; password = ");


        public void Conectar()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }
            catch (MySqlException Exception)
            {

            }
        }
        public void Desconectar()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (MySqlException Exception)
            {

            }
        }
        public bool Checkconection()
        {
            bool retorno = false;
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    retorno = true;
                }
            }
            catch (MySqlException Exception)
            {

            }

            return retorno;
        }
        public MySqlConnection Pega_Conexão()
        {
            return conexao;
        }
    }
}
