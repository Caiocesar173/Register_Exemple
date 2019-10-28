using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registo_Usuario.Model;
using Registo_Usuario.Dao;
using MySql.Data.MySqlClient;

namespace Registo_Usuario
{
    public partial class Registro_Tela : Form
    {
        private Usuario Usuario = new Usuario();
        private Inserir Inserir = new Inserir();


        public Registro_Tela()
        {
            InitializeComponent();
        }
        private void Repoisicionamento_ErrorLabel(string Texto_Da_Label)
        {
            Label_Error.Text = Texto_Da_Label;
            Label_Error.Visible = true;
            int PanelImg_Center = (this.Size.Width - Label_Error.Size.Width) / 2;
            Label_Error.Location = new Point(PanelImg_Center, Label_Registro.Location.Y + Label_Registro.Height);
        }

        private bool VerificaCPF()
        {
            if(TxTBox_CPF.Text.Length >= 11 && TxTBox_CPF.Text.Length <= 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Limpar_Btn_Click(object sender, EventArgs e)
        {
            TxTBox_Nome.Text = "";
            TxTBox_CPF.Text = "";
            TxTBox_Enderço.Text = "";

        }

        private void Cadastrar_Btn_Click(object sender, EventArgs e)
        {
            if (TxTBox_Nome.Text != "" && TxTBox_CPF.Text != "" && TxTBox_Enderço.Text != "")
            {
                Label_Error.Visible = false;
                if (Usuario.ValidaCPF(TxTBox_CPF.Text))
                {
                    if (TxTBox_CPF.Text.Contains(".") || TxTBox_CPF.Text.Contains("-"))
                    {
                        TxTBox_CPF.Text = TxTBox_CPF.Text.Trim();
                        if (TxTBox_CPF.Text.Contains("."))
                        {
                            TxTBox_CPF.Text = TxTBox_CPF.Text.Replace(".", "");
                        }
                        if (TxTBox_CPF.Text.Contains("-"))
                        {
                            TxTBox_CPF.Text = TxTBox_CPF.Text.Replace("-", "");
                        }
                    }

                    Usuario.Nome = TxTBox_Nome.Text;
                    Usuario.CPF = TxTBox_CPF.Text;
                    Usuario.Enderço = TxTBox_Enderço.Text;

                    if (Inserir.Usuario(Usuario))
                    {
                        int PanelImg_Center = (this.Size.Width - Label_Error.Size.Width) / 2;
                        Label_UsuarioCadastrado.Location = new Point(PanelImg_Center, Label_Registro.Location.Y + Label_Registro.Height);
                        Label_UsuarioCadastrado.Visible = true;

                    }
                    else
                    {
                        Repoisicionamento_ErrorLabel("Usuário Não Cadastrado");
                    }
                }
                else
                {
                    Repoisicionamento_ErrorLabel("Digite um CPF Valido");
                }
            }
            else
            {
                Repoisicionamento_ErrorLabel("Todos os Campos devem ser Preenchidos");
            }
        }

        private void TxTBox_CPF_Leave(object sender, EventArgs e)
        {
            if (VerificaCPF())
            {
                if (TxTBox_CPF.Text.Length == 11)
                {
                    //xxx.xxx.xxx - xx
                    long CPF = Convert.ToInt64(TxTBox_CPF.Text);
                    string CPF_Formatado = String.Format(@"{0:\000\.000\.000\-00}", CPF);
                    TxTBox_CPF.Text = CPF_Formatado;
                }
            }
            else
            {
                Repoisicionamento_ErrorLabel("Digite um CPF Valido");
            }
        }

        private void TxTBox_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxTBox_Nome_OnValueChanged(object sender, EventArgs e)
        {
            if (TxTBox_Nome.Text != "" )
            {
                Label_Error.Visible = false;
            }
        }

        private void TxTBox_CPF_OnValueChanged(object sender, EventArgs e)
        {
            if (TxTBox_CPF.Text != "" )
            {
                Label_Error.Visible = false;
            }
        }

        private void TxTBox_Enderço_OnValueChanged(object sender, EventArgs e)
        {
            if (TxTBox_Enderço.Text != "" )
            {
                Label_Error.Visible = false;
            }
        }

        private void TestaConexao_btn_Click(object sender, EventArgs e)
        {
            Conexao Conexao = new Conexao();
            try
            {
                Conexao.Conectar();
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            if (Conexao.Checkconection())
            {
                MessageBox.Show("Conectado com o Banco de Dados","Estado da Conexão");
            }
            else
            {
                MessageBox.Show("Não Conectado com o Banco de Dados","Estado da Conexão");
            }
        }
    }
}
