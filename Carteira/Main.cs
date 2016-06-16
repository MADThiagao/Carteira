using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;
using CaronteCore.Utils;
using CaronteCore.Models;

namespace Carteira
{
    public partial class Main : Form
    {

        Usuario _usuario;

        public Main(Usuario usuario)
        {
            InitializeComponent();

            _usuario = usuario;
           
            CarregaLancamento();
        }

        private void IcoMenu_Click(object sender, EventArgs e)
        {
            lcGroupMenu.Visibility = lcGroupMenu.Visibility == LayoutVisibility.Always ? LayoutVisibility.Never : LayoutVisibility.Always;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void CarregaLancamento()
        {
            try
            {
                var lancamentos = RequestHelper.Get<List<Lancamento>>("Lancamento", _usuario.Id, "BuscarTodos");

                if (lancamentos?.Any() == true)
                {
                    gcLancamento.DataSource = lancamentos;
                    gvLancamento.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Método CarregaLancamento: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLancamento_Click(object sender, EventArgs e)
        {
            LancamentoCadastro cadastro = new LancamentoCadastro(_usuario, null);
            cadastro.ShowDialog();
        }
    }
}
