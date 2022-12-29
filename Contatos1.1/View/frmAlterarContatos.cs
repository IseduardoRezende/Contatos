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
    public partial class frmAlterarContatos : Form
    {
        private DataGridView view;

        private Label label;

        private Panel panel;

        private Contato contato = new Contato();

        private ContatosDAO dao = new ContatosDAO();

        private readonly int  id_Contato;

        private Utils utils = new Utils();  

        public frmAlterarContatos(Contato contato, DataGridView view, Panel panel, Label label)
        {
            InitializeComponent();

            this.contato = contato;

            id_Contato = int.Parse(contato.Id_Contato.ToString());
            txtNome.Text = contato.Nome;
            txtCelular.Text = contato.Celular;
            txtDescricao.Text = contato.Descricao;

            this.view = view;
            this.panel = panel;
            this.label = label;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                contato.Nome = txtNome.Text;
                contato.Celular = txtCelular.Text;
                contato.Descricao = txtDescricao.Text;

                dao.AlterarContatos(contato);

                this.Close();

                utils.RefreshIntoContatos(view, panel, label);
         
                panel.Controls.Clear();

                var frm = new frmContatos();
                frm.TopLevel = false;

                panel.Controls.Add(view);
                label.Text = string.Empty;
                
                frm.Show();                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar Contato", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
