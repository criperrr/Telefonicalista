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
    public partial class FrmPrincipal : Form
    {
        private ContatoPresenter presenter = new ContatoPresenter();
        Contato edicao;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /* =>
        * <=>
        * <=
        * ==>
        * ===
        * !=
        * !==
        * <==
        * >=
        * 
        */

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmNovoContato frmNovoContato = new FrmNovoContato();
            frmNovoContato.ShowDialog();
            Atualizar();
        }

        private void Atualizar()
        {
            List<Contato> contatos = presenter.ObterContatos("");

            dataGridView1.DataSource = presenter.ObterContatos(txtBusca.Text.Trim());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox.Text == "none")
            {
                txtBusca.Text = "";
                return;
            }
            txtBusca.Text = cmbBox.Text + "=";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditar frm = new FrmEditar(presenter, edicao);
            frm.ShowDialog();
            Atualizar();
            Limpar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dataGridView1.SelectedCells[0].RowIndex;
            int id = (int)dataGridView1.Rows[linha].Cells[0].Value;
            edicao = presenter.SelecionarContato(id);

            btnEditar.Enabled = true;
            btnRemover.Enabled = true;
            dataGridView1.Enabled = true;

        }
        private void Limpar()
        {
            edicao = null;
            btnEditar.Enabled = false;
            btnRemover.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
               $"Deseja realmente remover o contato {edicao.Nome}?",
               "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                presenter.ExcluirContato(edicao.Id);
                Atualizar();
                Limpar();
            }
        }
    }
}
