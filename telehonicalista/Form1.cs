using System.Windows.Forms;

namespace telehonicalista
{
    public partial class telefonica : Form
    {
        string[][] lista;
        readonly int tamanho = 100;
        public telefonica()
        {
            InitializeComponent();
            lista = new string[tamanho][];
        }
        void Atualizar()
        {
            gridData.Rows.Clear();
            for (int i = 0; i < Length(lista); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridData);
                for (int j = 0; j < 3; j++)
                {
                    row.Cells[j].Value = lista[i][j];
                }
                gridData.Rows.Add(row);
            }
        }
        private void cadastra_Click(object sender, EventArgs e)
        {
            if (cadastra.Text == "Cadastrar")
            {
                if (String.IsNullOrEmpty(nome.Text) || String.IsNullOrEmpty(numero.Text))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");
                    return;
                }
                if (Length(lista) == tamanho)
                {
                    MessageBox.Show("Limite alcançado (100)");
                    return;
                }
                int id = Length(lista) > 0 ? (int.Parse(lista[Length(lista) - 1][0]) + 1) : 1;
                lista[Length(lista)] = new string[] { id.ToString(), nome.Text, numero.Text };
                Atualizar();
            }
            else if (cadastra.Text == "Editar")
            {
                if (String.IsNullOrEmpty(nome.Text) || String.IsNullOrEmpty(numero.Text))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");
                    return;
                }
                int row = gridData.SelectedCells[0].RowIndex;
                string id = gridData.Rows[row].Cells[0].Value.ToString();
                lista[row] = new string[] { id, nome.Text, numero.Text };
                Atualizar();
            }
        }

        int Length(string[][] e)
        {
            int itens = 0;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] != null)
                {
                    itens++;
                }
            }
            return itens;
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
            int indice = 0;
            for (indice = 0; indice < Length(lista) && lista[indice][0] != id; indice++) ;
            DialogResult confirmResult = MessageBox.Show($"Tem certeza que deseja remover {lista[indice][1]}?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No) return;
            for (int i = indice; i < Length(lista); i++)
            {
                lista[i] = lista[i + 1];
            }
            lista[Length(lista)] = null;
            
            Atualizar();
        }

        private void gridData_Click(object sender, EventArgs e)
        {
            cadastra.Text = "Editar";
        }

        private void telefonica_Click(object sender, EventArgs e)
        {
            cadastra.Text = "Cadastrar";
            gridData.ClearSelection();
        }
    }
}
