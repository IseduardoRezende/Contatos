using Contatos1._1.DAO;
using Contatos1._1.Model;
using Contatos1._1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos1._1
{
    public partial class frmLogin : Form
    {
        private UsuarioDAO dao = new UsuarioDAO();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblCadUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmCadastroUsuario();
            frm.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            if (dao.EfetuacaoDeLogin(nome, senha))
            {
                this.Hide();
            }
        }
    }
}