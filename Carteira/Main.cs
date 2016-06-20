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
using CaronteCore.Models.DTO;
using DevExpress.XtraCharts;

namespace Carteira
{
    public partial class Main : Form
    {

        Usuario _usuario;

        public Main(Usuario usuario)
        {
            InitializeComponent();

            _usuario = usuario;

            CarregaGraficoLinha();

            CarregaGraficoDonut();

            CarregaLancamento();
        }

        private void IcoMenu_Click(object sender, EventArgs e)
        {
            lcGroupMenu.Visibility = lcGroupMenu.Visibility == LayoutVisibility.Always ? LayoutVisibility.Never : LayoutVisibility.Always;
        }

        private void CarregaLancamento()
        {
            try
            {
                var lancamentos = RequestHelper.Get<List<Lancamento>>("Lancamento", "BuscarMensal", _usuario.Id);

                if (lancamentos?.Any() == true)
                {
                    gcLancamento.DataSource = lancamentos;
                    gcLancamento.RefreshDataSource();
                    gvLancamento.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Método CarregaLancamento: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaGraficoLinha()
        {
            try
            {
                var grafico = RequestHelper.Post<List<GraficoLinhaDTO>>("Lancamento", "RecuperarGraficoLinha", _usuario);

                if (grafico != null)
                {
                    ChartLinha.DataSource = grafico;
                    ChartLinha.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Método CarregaGraficoLinha: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregaGraficoDonut()
        {
            try
            {
                var grafico = RequestHelper.Post<List<GraficoDonutDTO>>("Lancamento", "RecuperarGraficoDonut", _usuario);

                if (grafico != null)
                {
                    gdCategoria.DataSource = grafico;
                    gdCategoria.RefreshDataSource();
                    gvCategoria.BestFitColumns();
                    chartDonut.DataSource = grafico;
                    chartDonut.RefreshData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Método CarregaGraficoDonut: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddLancamento_Click(object sender, EventArgs e)
        {
            using (LancamentoCadastro cadastro = new LancamentoCadastro(_usuario, null))
            {
                DialogResult resultado = cadastro.ShowDialog();
                if (resultado == DialogResult.OK)
                    DashReloader();
            }
        }

        private void gvLancamento_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            var k = e;
        }

        private void btnGridRemover_Click(object sender, EventArgs e)
        {
            var lancamento = (Lancamento)gvLancamento.GetFocusedRow();

            if (lancamento != null)
            {
                DialogResult = MessageBox.Show("Tem certeza que deseja remover o lancamento selecionado?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                    try
                    {
                        RequestHelper.Post<Lancamento>("Lancamento", "Remover", lancamento);
                        DashReloader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Método RemoverLancamento: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void DashReloader()
        {
            CarregaLancamento();
            CarregaGraficoLinha();
            CarregaGraficoDonut();
        }

        private void btnGridAdicionar_Click(object sender, EventArgs e)
        {
            using (LancamentoCadastro cadastro = new LancamentoCadastro(_usuario, null))
            {
                DialogResult resultado = cadastro.ShowDialog();
                if (resultado == DialogResult.OK)
                    DashReloader();
            }
        }

        private void btnGridEditar_Click(object sender, EventArgs e)
        {
            var lancamento = (Lancamento)gvLancamento.GetFocusedRow();

            using (LancamentoCadastro cadastro = new LancamentoCadastro(_usuario, lancamento))
            {
                DialogResult resultado = cadastro.ShowDialog();
                if (resultado == DialogResult.OK)
                    DashReloader();
            }
        }

        private void btnCategoriaAdicionar_Click(object sender, EventArgs e)
        {
            using (CategoriaCadastro cadastro = new CategoriaCadastro(_usuario, null))
            {
                cadastro.ShowDialog();
            }
        }

        private void btnCategoriaRemover_Click(object sender, EventArgs e)
        {
            var Selecionado = (GraficoDonutDTO)gvCategoria.GetFocusedRow();

            if (Selecionado != null)
                if (Selecionado.CategoriaDescricao == "Sem Categoria")
                    MessageBox.Show("A Categoria 'Sem Categoria' não pode ser removida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult = MessageBox.Show("Ao excluir a categoria " + Selecionado.CategoriaDescricao + " todos os lançamentos vínculados a ela ficarão sem categoria, tem certeza que deseja remover?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (DialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            var categoria = new Categoria()
                            {
                                Id = Selecionado.CategoriaId,
                                IdUsuario = _usuario.Id
                            };

                            RequestHelper.Post<Categoria>("Categoria", "Remover", categoria);
                            MessageBox.Show("A Categoria " + Selecionado.CategoriaDescricao + " foi removida com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DashReloader();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Método RemoverCategoria: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
        }

        private void btnCategoriaAtualizar_Click(object sender, EventArgs e)
        {
            var Selecionado = (GraficoDonutDTO)gvCategoria.GetFocusedRow();

            if (Selecionado.CategoriaDescricao == "Sem Categoria")
                MessageBox.Show("A Categoria 'Sem Categoria' não pode ser editada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var categoria = new Categoria()
                {
                    Id = Selecionado.CategoriaId,
                    Descricao = Selecionado.CategoriaDescricao,
                    IdUsuario = _usuario.Id
                };

                using (CategoriaCadastro cadastro = new CategoriaCadastro(_usuario, categoria))
                {
                    DialogResult resultado = cadastro.ShowDialog();
                    if (resultado == DialogResult.OK)
                        DashReloader();
                }

            }
        }

    }
}
