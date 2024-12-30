using Projetoloja.backend.database;
using Projetoloja.backend.models;
using Projetoloja.backend.respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetoloja.desktopApp.views
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.Items.Add("Admin");
            cmbTipoUsuario.Items.Add("Gerente");
            cmbTipoUsuario.Items.Add("Caixa");
            cmbTipoUsuario.Items.Add("Vendedor");

            cmbTipoUsuario.SelectedIndex = 0; // Seleciona o primeiro item por padrão
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var repository = new UsuarioRepository(context);
                var usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text,
                    TipoUsuario = cmbTipoUsuario.SelectedItem.ToString()
                };

                repository.AddUsuarioAsync(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!");
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            cmbTipoUsuario.SelectedIndex = 0; // Reseta para o primeiro item
        
        }
    }
}
