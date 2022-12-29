using Contatos1._1.Model;
using Contatos1._1.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Contatos1._1.DAO
{
    public class UsuarioDAO
    {        
        #region CadastroDeUsuario

        public void CadastrarUsuario(Usuario usuario)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    string sql = "insert into Usuario (id_usuario, nome, senha) values (@id_usuario, @nome, @senha)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_usuario", usuario.Id_Usuario);
                    executaCmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    executaCmd.Parameters.AddWithValue("@senha", usuario.Senha);
                    
                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário Cadastrado com Sucesso !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao Cadastrar Usuário {ex}");
                }
            }
        }

        #endregion

        #region EfetuacaoDeLogin

        public bool EfetuacaoDeLogin(string nome, string senha)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    string sql = "select * from Usuario where nome = @nome and senha = @senha";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@nome", nome);
                    executaCmd.Parameters.AddWithValue("@senha", senha);

                    conexao.Open();                    

                    //MySqlDataReader == Leitor de Dados:
                    var dr = executaCmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Acesso efetuado com Sucesso !", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var frm = new frmContatos();
                        frm.Show();

                        return true;
                    }
                    else if (nome == string.Empty && senha == string.Empty)
                    {
                        MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    else if (nome == string.Empty || senha == string.Empty)
                    {
                        MessageBox.Show("Atenção aos campos", "Preencha corretamente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Nome ou Senha incorretos", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao efetuar Login: {ex}");
                    return false;
                } 
            }
        }

        #endregion
    }
}
