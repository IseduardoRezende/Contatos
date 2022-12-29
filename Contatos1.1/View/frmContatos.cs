using Contatos1._1.DAO;
using Contatos1._1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contatos1._1.View
{
    public partial class frmContatos : Form
    {
        private Contato contato = new Contato();

        private ContatosDAO dao = new ContatosDAO();

        private Layout layout = new Layout();

        private Contato contatoSelecionado;

        public frmContatos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastroContatos(dgvContatos, pnlContatos, lblContatoSelecionado);
            frm.ShowDialog();            
        }        

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            var frm = new frmLixeira(dgvContatos, pnlContatos);
            frm.ShowDialog();
        }

        private void frmContatos_Load(object sender, EventArgs e)
        {
            layout.DataGridViewLayout(dgvContatos);

            dgvContatos.DataSource = dao.ListarContatos();
        }

        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            contato.Id_Contato  = int.Parse(dgvContatos.CurrentRow.Cells[0].Value.ToString()); 
            contato.Nome        = dgvContatos.CurrentRow.Cells[1].Value.ToString();
            contato.Celular     = dgvContatos.CurrentRow.Cells[2].Value.ToString();
            contato.Descricao   = dgvContatos.CurrentRow.Cells[3].Value.ToString();            

            var frm = new frmAlterarContatos(contato, dgvContatos, pnlContatos, lblContatoSelecionado);
            frm.ShowDialog();            
        }

        private void dgvContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contato.Id_Contato  = int.Parse(dgvContatos.CurrentRow.Cells[0].Value.ToString());
            contato.Nome        = dgvContatos.CurrentRow.Cells[1].Value.ToString(); 
            
            this.contatoSelecionado     = contato;
            lblContatoSelecionado.Text  = $"Contato selecionado: {contatoSelecionado.Nome}";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (contatoSelecionado == null || lblContatoSelecionado.Text == string.Empty)
            {
                MessageBox.Show("Selecione o Contato que deseja remover", "Remoção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (DialogResult.Yes == MessageBox.Show($"Deseja remover: {contatoSelecionado.Nome} ?", "Remoção de Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                dao.AlterarStatusContato(contatoSelecionado.Id_Contato, contatoSelecionado.Status_Usuario = false);
                dgvContatos.DataSource = dao.ListarContatos();

                lblContatoSelecionado.Text = string.Empty;
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // "%" == operador que busca por cada letra;            
            string nome = "%" + txtPesquisa.Text + "%";

            dgvContatos.DataSource = dao.PesquisarPorNomeDeContato(nome);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == string.Empty)
            {
                dgvContatos.DataSource = dao.ListarContatos();
                return;
            }
            else
            {
                string nome = txtPesquisa.Text;

                dgvContatos.DataSource = dao.BuscarContato(nome);

                if (dgvContatos.Rows.Count == 0)
                {
                    MessageBox.Show("Contato não existente", "Nenhum contato encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvContatos.DataSource = dao.ListarContatos();
                    txtPesquisa.Text = string.Empty;
                }
            }            
        }
    }
}
