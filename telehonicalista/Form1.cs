using System.Windows.Forms;
using telehonicalista.Models;

namespace telehonicalista
{
    public partial class telefonica : Form
    {
        List<Contato> lista;
        string selectedId;
        public telefonica()
        {
            InitializeComponent();
            lista = new List<Contato>();
        }
        void Atualizar()
        {
            gridData.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridData);
                row.Cells[0].Value = lista[i].Id;
                row.Cells[1].Value = lista[i].Nome;
                row.Cells[2].Value = lista[i].Telefone;
                gridData.Rows.Add(row);
            }
        }
        private void cadastra_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nome.Text) || String.IsNullOrEmpty(numero.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }
            if (cadastra.Text == "C&adastrar")
            {
                int id = 1;
                if(lista.Count > 0)
                    id = lista.Max(c => c.Id) + 1;
                Contato contato = new Contato() { Id=id, Nome=nome.Text, Telefone=numero.Text };

                lista.Add(contato);
                Atualizar();
                nome.Text = null;
                numero.Text = null;
            }
            else if (cadastra.Text == "&Editar")
            {
                int row = gridData.SelectedCells[0].RowIndex;
                lista[row].Nome = nome.Text;
                lista[row].Telefone = numero.Text;

                Atualizar();
                nome.Text = null;
                numero.Text = null;
            }
        }
        private void remove_Click(object sender, EventArgs e)
        {
            if (gridData.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }
            DataGridViewCell cell = gridData.SelectedCells[0];
            int linha = cell.RowIndex;
            string id = gridData.Rows[linha].Cells[0].Value.ToString();
            int indice = lista.FindIndex(item => item.Id.ToString() == id);
            if (indice == -1) return;

            DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja remover {lista[indice].Nome}?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) return;

            lista.RemoveAt(indice);
            Atualizar();
            nome.Text = null;
            numero.Text = null;
            cadastra.Text = "C&adastrar";
        }

        private void telefonica_Click(object sender, EventArgs e)
        {
            cadastra.Text = "C&adastrar";
        }

        private void gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.SelectedCells.Count == 0)
                return;
            cadastra.Text = "&Editar";
            int row = gridData.SelectedCells[0].RowIndex;
            nome.Text = gridData.Rows[row].Cells[1].Value.ToString();
            numero.Text = gridData.Rows[row].Cells[2].Value.ToString();
        }
    }
}