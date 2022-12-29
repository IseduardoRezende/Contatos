using Contatos1._1.DAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Contatos1._1.Model
{
    public class Utils
    {
        ContatosDAO dao = new ContatosDAO();
        
        public void RefreshIntoContatos(DataGridView view, Panel panel, Label label)
        {
            view.DataSource = dao.ListarContatos();
            panel.Controls.Clear();
            label.Text = string.Empty;
        }

        public void RefreshIntoLixeira(DataGridView view, Panel panel)
        {
            view.DataSource = dao.ListarContatos();
            panel.Controls.Clear();
        }        
    }
}
