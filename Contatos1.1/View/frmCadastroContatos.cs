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
    public partial class frmCadastroContatos : Form
    {
        private Contato contato = new Contato();

        private ContatosDAO dao = new ContatosDAO();

        private DataGridView view;

        private Panel panel;

        private Label label;

        private Utils utils = new Utils();

        public frmCadastroContatos(DataGridView view, Panel panel, Label label)
        {
            InitializeComponent();

            this.view = view;
            this.panel = panel;
            this.label = label;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty && txtCelular.Text == "        -")
            {
                MessageBox.Show("Preencha os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtNome.Text == string.Empty || txtCelular.Text == "        -")
            {
                MessageBox.Show("Atenção aos campos", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    contato.Nome = txtNome.Text;
                    contato.Celular = txtCelular.Text;
                    contato.Descricao = txtDescricao.Text;
                    contato.Status_Usuario = true;

                    dao.CadastrarContato(contato);

                    txtNome.Text = string.Empty;
                    txtCelular.Text = string.Empty;
                    txtDescricao.Text = string.Empty;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível cadastrar contato", MessageBoxIcon.Information.ToString());
                }
            }
        }

        private void frmCadastroContatos_FormClosed(object sender, FormClosedEventArgs e)
        {            
            utils.RefreshIntoContatos(view, panel, label);
            panel.Controls.Clear();

            var frm = new frmContatos();
            frm.TopLevel = false;

            panel.Controls.Add(view);
            label.Text = string.Empty;

            frm.Show();
        }
    }
}