using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telehonicalista.Models;
using telehonicalista.Presenters;

namespace telehonicalista.Views
{
    public partial class FrmNovoContato : Form
    {
        public FrmNovoContato()
        {
            InitializeComponent();
        }

        private void FrmNovoContato_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string tel = txtTelefone.Text;

            if (nome.Length == 0 || !txtTelefone.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos corretamente!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Contato novo = new Contato() { 
                Nome = nome, 
                Telefone = tel 
            };
            ContatoPresenter presenter = new ContatoPresenter();

            if (presenter.AdicionarContato(novo))
                this.Close();
            else
                MessageBox.Show("Erro ao adicionar contato!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
