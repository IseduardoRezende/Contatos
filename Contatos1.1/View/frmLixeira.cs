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
    public partial class frmLixeira : Form
    {
        private Contato contato = new Contato();

        private LixeiraDAO dao = new LixeiraDAO();

        private Layout layout = new Layout();

        private Contato contatoSelecionado;

        private ContatosDAO dao_Contato = new ContatosDAO();

        private Utils utils = new Utils();

        private DataGridView view;

        private Panel panel;

        public frmLixeira(DataGridView view, Panel panel)
        {
            InitializeComponent();
            
            this.view = view;
            this.panel = panel;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            utils.RefreshIntoLixeira(view, panel);
            panel.Controls.Clear();

            var frm = new frmContatos();
            frm.TopLevel = false;

            panel.Controls.Add(view);
            frm.Show();
        }

        private void frmLixeira_Load(object sender, EventArgs e)
        {
            layout.DataGridViewLayout(dgvContatosLixeira);

            dgvContatosLixeira.DataSource = dao.ListarContatosNaLixeira();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (contatoSelecionado == null || lblContatoSelecionado.Text == string.Empty)
            {
                MessageBox.Show("Selecione o contato para remoção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (DialogResult.Yes == MessageBox.Show("Deseja excluir o contato ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dao.ExcluirContatoDaLixeira(contatoSelecionado.Id_Contato);

                dgvContatosLixeira.DataSource = dao.ListarContatosNaLixeira();

                lblContatoSelecionado.Text = string.Empty;
            }
        }

        private void btnReativar_Click(object sender, EventArgs e)
        {
            if (contatoSelecionado == null || lblContatoSelecionado.Text == string.Empty)
            {
                MessageBox.Show("Selecione o contato para reativação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (DialogResult.Yes == MessageBox.Show("Deseja reativar o contato ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dao_Contato.AlterarStatusContato(contatoSelecionado.Id_Contato, contatoSelecionado.Status_Usuario = true);

                dgvContatosLixeira.DataSource = dao.ListarContatosNaLixeira();
            
                lblContatoSelecionado.Text = string.Empty;
            }
        }

        private void dgvContatosLixeira_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            contato.Id_Contato = int.Parse(dgvContatosLixeira.CurrentRow.Cells[0].Value.ToString());
            contato.Nome = dgvContatosLixeira.CurrentRow.Cells[1].Value.ToString();

            this.contatoSelecionado = contato;
            lblContatoSelecionado.Text = $"Contato selecionado: {contatoSelecionado.Nome}";
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            dgvContatosLixeira.DataSource = dao.PesquisarContatoPorNomeNaLixeira(nome);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == string.Empty)
            {
                dao.ListarContatosNaLixeira();
                return;
            }
            else
            {
                string nome = txtPesquisa.Text;

                dgvContatosLixeira.DataSource = dao.BuscarPorContatoNaLixeira(nome);

                if (dgvContatosLixeira.Rows.Count == 0)
                {
                    MessageBox.Show("Contato não existente", "Atenção, contato não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvContatosLixeira.DataSource = dao.ListarContatosNaLixeira();
                    txtPesquisa.Text = string.Empty;
                }
            }
        }
    }
}
