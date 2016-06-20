using CaronteCore.Models;
using CaronteCore.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carteira
{
    public partial class CategoriaCadastro : Form
    {
        Usuario _usuario;
        Categoria _categoria;


        public CategoriaCadastro(Usuario usuario, Categoria categoria)
        {
            InitializeComponent();
            _usuario = usuario;
            _categoria = categoria;

            if (categoria != null)
            {
                txtDescricao.Text = categoria.Descricao;
            }

        }

        private bool Valida()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe corretamente a descrição!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Salvar();
                DialogResult = DialogResult.OK;
            }
        }

        private void Salvar()
        {
            try
            {
                if (_categoria != null)
                {
                    _categoria.Descricao = txtDescricao.Text;

                    RequestHelper.Post<Lancamento>("Categoria", "Atualizar", _categoria);
                }
                else
                    RequestHelper.Post<Lancamento>("Categoria", "Adicionar", new Categoria() { Descricao = txtDescricao.Text, IdUsuario = _usuario.Id });

                MessageBox.Show("Categoria salva com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Método Salvar: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
