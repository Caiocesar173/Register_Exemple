using MySql.Data.MySqlClient;
using Registo_Usuario.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Registo_Usuario.Dao
{
    class Inserir
    {
        private Conexao Conexão = new Conexao();
        private bool Usuario_Incluido = false;


        public bool Usuario(Usuario Usuario)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE CPF = @CPF ", Conexão.Pega_Conexão());

                command.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = Usuario.CPF;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                // check if the user exists or not
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }
                    if (Conexão.Checkconection())
                    {
                        string InsertAbastecimento = "INSERT INTO USUARIO(NOME, ENDEREÇO, CPF) VALUES (@Nome, @Enderço, @CPF);";
                    
                        MySqlCommand commando = new MySqlCommand(InsertAbastecimento);
                        commando.Connection = Conexão.Pega_Conexão();
                        commando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = Usuario.Nome;
                        commando.Parameters.Add("@Enderço", MySqlDbType.VarChar).Value = Usuario.Enderço;
                        commando.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = Usuario.CPF;
                        int retorno = commando.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Usuario_Incluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Usuario_Incluido;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario já Existe","Problemas ao inserir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            
            return Usuario_Incluido;
        }
    }
}
