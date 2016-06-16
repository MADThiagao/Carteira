using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using CaronteCore.Models;
using CaronteCore.Models.DTO;
using CaronteCore.Utils;

namespace Carteira
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private bool Valida()
        {

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Informe corretamente o usuário!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Informe corretamente a senha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }

            return true;
        }

        private void lcbtnentrar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
              Logar();
               // Main k = new Main();
              //  k.ShowDialog();
            }
        }

        private void Logar()
        {

            try
            {
                var usuario = RequestHelper.Post<Usuario>("Usuario", new LoginDTO() { Login = txtUsuario.Text, Senha = txtSenha.Text });

                if (usuario == null)
                    MessageBox.Show("Usuário ou senha não encontrados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema encontrado: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
