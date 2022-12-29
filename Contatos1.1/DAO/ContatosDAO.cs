using Contatos1._1.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Contatos1._1.DAO
{
    public class ContatosDAO
    {
        #region CadastroDeContato

        public void CadastrarContato(Contato contato)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    string sql = @"insert into Contatos_Usuario (id_contato, nome, celular, descricao, status_usuario)
                                   values (@id_contato, @nome, @celular, @descricao, @status_usuario)";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_contato", contato.Id_Contato);
                    executaCmd.Parameters.AddWithValue("@nome", contato.Nome);
                    executaCmd.Parameters.AddWithValue("@celular", contato.Celular);
                    executaCmd.Parameters.AddWithValue("@descricao", contato.Descricao);
                    executaCmd.Parameters.AddWithValue("@status_usuario", contato.Status_Usuario);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Contato inserido com Sucesso !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar contato: {ex}");
                }
            }
        }

        #endregion

        #region ListarContatos

        public DataTable ListarContatos()
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    var tabelaContatos = new DataTable();

                    string sql = "select * from vContatos_Usuario";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    //MySqlDataAdapter == Leva os dados para o DataTable;
                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaContatos);

                    return tabelaContatos;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao Listar Contatos: {ex}");
                    return null;
                }
            }
        }

        #endregion

        #region AlterarContatos

        public void AlterarContatos(Contato contatos)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    string sql = @"update Contatos_Usuario set nome = @nome, celular = @celular,
                                   descricao = @descricao where id_contato = @id_contato";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@nome", contatos.Nome);
                    executaCmd.Parameters.AddWithValue("@celular", contatos.Celular);
                    executaCmd.Parameters.AddWithValue("@descricao", contatos.Descricao);
                    executaCmd.Parameters.AddWithValue("@id_contato", contatos.Id_Contato);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Contato alterado com Sucesso !", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao alterar contato: {ex}");
                }
            }
        }

        #endregion

        #region AlterarStatusContato

        //Status significa a aparição do Contato no DataGridView, sempre que cadastramos um contato
        //o status é igual a true e todo status == true aparece na view do Banco De Dados assim aparecendo
        //no menu principal e todo status == false aparece na view da lixeira;

        public void AlterarStatusContato(int id_Contato, bool status_Contato)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    string sql = @"update Contatos_Usuario set status_usuario = @status_usuario 
                                   where id_contato = @id_contato";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_contato", id_Contato);
                    executaCmd.Parameters.AddWithValue("@status_usuario", status_Contato);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    if (status_Contato == true)
                    {
                        MessageBox.Show("Contato reativado com Sucesso !", "Reativação efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Contato removido com Sucesso !", "Remoção efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao efetuar remoção do Contato: {ex}");
                }
            }
        }

        #endregion

        #region PesquisarPorNomeDeContato

        //Este método utiliza do operador 'like';

        public DataTable PesquisarPorNomeDeContato(string nome)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    var tabelaContatos = new DataTable();

                    string sql = "select * from vContatos_Usuario where Nome like @Nome";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Nome", nome);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaContatos);

                    return tabelaContatos;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar Contato por nome: {ex}");
                    return null;
                }
            }
        }

        #endregion

        #region BuscarContato

        public DataTable BuscarContato(string nome)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    var tabelaContato = new DataTable();

                    string sql = "select * from vContatos_Usuario where Nome = @Nome";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Nome", nome);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaContato);

                    return tabelaContato;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar por Contato: {ex}");
                    return null;
                }
            }
        }

        #endregion
    }
}
