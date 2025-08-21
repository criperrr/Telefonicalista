namespace telehonicalista.Views
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contatoBindingSource1 = new BindingSource(components);
            contatoBindingSource = new BindingSource(components);
            txtBusca = new TextBox();
            btnBuscar = new Button();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnEditar = new Button();
            cmbBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn });
            dataGridView1.DataSource = contatoBindingSource1;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 365);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // contatoBindingSource1
            // 
            contatoBindingSource1.DataSource = typeof(Models.Contato);
            // 
            // contatoBindingSource
            // 
            contatoBindingSource.DataSource = typeof(Models.Contato);
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(140, 11);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(567, 23);
            txtBusca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(713, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(713, 415);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(551, 415);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(632, 415);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // cmbBox
            // 
            cmbBox.FormattingEnabled = true;
            cmbBox.Items.AddRange(new object[] { "none", "Id", "Nome", "Telefone" });
            cmbBox.Location = new Point(13, 12);
            cmbBox.Name = "cmbBox";
            cmbBox.Size = new Size(121, 23);
            cmbBox.TabIndex = 6;
            cmbBox.Text = "select one";
            cmbBox.SelectedIndexChanged += cmbBox_SelectedIndexChanged;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBox);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusca);
            Controls.Add(dataGridView1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contatoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBusca;
        private Button btnBuscar;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnEditar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private BindingSource contatoBindingSource;
        private BindingSource contatoBindingSource1;
        private ComboBox cmbBox;
    }
}