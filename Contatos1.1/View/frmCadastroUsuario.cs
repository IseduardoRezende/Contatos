using Contatos1._1.DAO;
using Contatos1._1.Model;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contatos1._1.View
{
    public partial class frmCadastroUsuario : Form
    {
        private Usuario usuario = new Usuario();
        
        private UsuarioDAO dao = new UsuarioDAO();

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty && txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível cadastrar usuário", "Atenção, preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtNome.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível cadastrar usuário", "Atenção, preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                try
                {
                    usuario.Nome = txtNome.Text;
                    usuario.Senha = txtSenha.Text;

                    dao.CadastrarUsuario(usuario);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível cadastrar usuário", MessageBoxIcon.Information.ToString());
                }
            }
        }
    }
}
