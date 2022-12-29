using Contatos1._1.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Contatos1._1.DAO
{
    public class LixeiraDAO
    {
        #region ListarContatosNaLixeira

        public DataTable ListarContatosNaLixeira()
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    var tabelaLixeira = new DataTable();

                    string sql = "select * from vContatos_Usuario_Removido";

                    var executaCmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLixeira);

                    return tabelaLixeira;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao listar lixeira: {ex}");
                    return null;
                }
            }
        }

        #endregion

        #region ExcluirContatoDaLixeira

        public void ExcluirContatoDaLixeira(int id_Contato)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    string sql = @"delete from Contatos_Usuario where
                                   id_contato = @id_contato";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@id_contato", id_Contato);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    MessageBox.Show("Contato excluído com Sucesso !", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir contato: {ex}");
                }
            }
        }

        #endregion

        #region PesquisarContatoPorNomeNaLixeira

        public DataTable PesquisarContatoPorNomeNaLixeira(string nome)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    var tabelaLixeira = new DataTable();

                    string sql = @"select * from vContatos_Usuario_Removido where
                                   Nome like @Nome";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Nome", nome);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLixeira);

                    return tabelaLixeira;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao pesquisar por nome de contato: {ex}");
                    return null;
                }
            }
        }

        #endregion

        #region BuscarPorContatoNaLixeira

        public DataTable BuscarPorContatoNaLixeira(string nome)
        {
            using (var conexao = ConnectionFactory.GetConnection())
            {
                try
                {
                    var tabelaLixeira = new DataTable();

                    string sql = @"select * from vContatos_Usuario_Removido
                                   where Nome = @Nome";

                    var executaCmd = new MySqlCommand(sql, conexao);
                    executaCmd.Parameters.AddWithValue("@Nome", nome);

                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    var da = new MySqlDataAdapter(executaCmd);
                    da.Fill(tabelaLixeira);

                    return tabelaLixeira;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar por contato: {ex}");
                    return null;
                }
            }
        }

        #endregion
    }
}
