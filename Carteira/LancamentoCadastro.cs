﻿using CaronteCore.Models;
using CaronteCore.Models.Enum;
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
    public partial class LancamentoCadastro : Form
    {

        Usuario _usuario;
        Lancamento _lancamento;

        public LancamentoCadastro(Usuario usuario, Lancamento lancamento)
        {
            InitializeComponent();

            _usuario = usuario;
            _lancamento = lancamento;

            CarregaCategoria();
            dtData.EditValue = DateTime.Today;

            if (lancamento == null)
            {
                Text = "Cadastrar Lançamento";
            }
            else
            {
                Text = "Editar Lançamento";
                CarregaDados(lancamento);
            }

        }

        private void CarregaCategoria()
        {
            try
            {
                var listaCategoria = RequestHelper.Get<List<Categoria>>("Categoria", "BuscarTodos", _usuario.Id);

                if (listaCategoria?.Any() == true)
                    cboCategoria.Properties.DataSource = listaCategoria.Where(x => x.Descricao != "Sem Categoria").ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Método CarregaCategoria: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void CarregaDados(Lancamento lancamento)
        {
            txtDescricao.Text = lancamento.Descricao;
            txtValor.Text = lancamento.Valor.ToString();
            dtData.EditValue = lancamento.Data;

            var categoria = ((List<Categoria>)cboCategoria.Properties.DataSource).Where(x => x.Id == (int)lancamento.IdCategoria).SingleOrDefault();
            cboCategoria.EditValue = categoria == null ? null : (int?)categoria.Id;

            rdTipo.EditValue = lancamento.Tipo == "D" ? "D" : "R";
        }

        private bool Valida()
        {

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe corretamente a descrição!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Informe corretamente o valor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
                return false;
            }

            return true;
        }

        private void Salvar()
        {
            try
            {

                if(_lancamento != null)
                    RequestHelper.Post<Lancamento>("Lancamento", "Atualizar", GerarLancamento());
                else
                    RequestHelper.Post<Lancamento>("Lancamento", "Adicionar", GerarLancamento());

                MessageBox.Show("Lancamento salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Método Salvar: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Lancamento GerarLancamento()
        {
            int? idCategoria;

            if (cboCategoria.EditValue == null)
                idCategoria = null;
            else
                idCategoria = ((Categoria)(cboCategoria.GetSelectedDataRow())).Id;

            return new Lancamento()
            {
                Id = _lancamento != null ? _lancamento.Id : 0,
                IdCategoria = idCategoria,
                IdUsuario = _usuario.Id,
                Descricao = txtDescricao.Text,
                Valor = Convert.ToDecimal(txtValor.Text),
                Data = Convert.ToDateTime(dtData.EditValue),
                Tipo = rdTipo.EditValue.ToString()
            };
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Salvar();
                DialogResult = DialogResult.OK;
            }
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
