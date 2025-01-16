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
using Projetoloja.backend.database;

namespace Projetoloja.desktopApp.views
{
    public partial class UsuarioForm : Form
    {
        DatabaseContext connect = new DatabaseContext();
        UsuarioRepository usuarioRepository = new UsuarioRepository();


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

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                cmbTipoUsuario.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            usuarioRepository.insertUser(txtNome.Text, txtEmail.Text, txtSenha.Text, cmbTipoUsuario.Text);

                //MessageBox.Show("Usuário cadastrado com sucesso!");
                LimparCampos();
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
