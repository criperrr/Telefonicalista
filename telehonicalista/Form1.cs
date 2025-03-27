namespace telehonicalista
{
    public partial class telefonica : Form
    {
        string[,] lista;
        readonly int tamanho = 100;
        int itens = 0;
        public telefonica()
        {
            InitializeComponent();
            lista = new string[tamanho, 2];
        }
        void Atualizar()
        {
            gridData.Rows.Clear();
            for (int i = 0; i < itens; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridData);
                for (int j = 0; j < 2; j++)
                {
                    row.Cells[j].Value = lista[i, j];
                }
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
            lista[itens, 0] = nome.Text;
            lista[itens, 1] = numero.Text;
            itens++;
            nome.Text = "";
            numero.Text = "";
            Atualizar();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (gridData.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }
            var confirmResult = MessageBox.Show("Tem certeza que deseja remover este item?", "Confirmação", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.No)
            {
                return;
            }

            DataGridViewCell cell = gridData.SelectedCells[0];
            int index = cell.RowIndex;

            for (int i = index; i < itens - 1; i++)
            {
                lista[i, 0] = lista[i + 1, 0];
                lista[i, 1] = lista[i + 1, 1];
            }

            lista[itens - 1, 0] = null;
            lista[itens - 1, 1] = null;
            itens--;

            Atualizar();
        }
    }
}
