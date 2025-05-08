namespace telehonicalista
{
    partial class telefonica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridData = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            lbl1 = new Label();
            label1 = new Label();
            nome = new TextBox();
            cadastra = new Button();
            numero = new MaskedTextBox();
            remove = new Button();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            SuspendLayout();
            // 
            // gridData
            // 
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToDeleteRows = false;
            gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridData.Columns.AddRange(new DataGridViewColumn[] { ID, name, telefone });
            gridData.Location = new Point(14, 16);
            gridData.Margin = new Padding(3, 4, 3, 4);
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.RowHeadersWidth = 51;
            gridData.Size = new Size(357, 568);
            gridData.TabIndex = 0;
            gridData.Click += gridData_Click;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 53;
            // 
            // name
            // 
            name.HeaderText = "Nome";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.MinimumWidth = 6;
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 125;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(427, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(80, 37);
            lbl1.TabIndex = 1;
            lbl1.Text = "Nome: ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 61);
            label1.Name = "label1";
            label1.Size = new Size(109, 35);
            label1.TabIndex = 2;
            label1.Text = "Número: ";
            // 
            // nome
            // 
            nome.Location = new Point(514, 31);
            nome.Margin = new Padding(3, 4, 3, 4);
            nome.Name = "nome";
            nome.Size = new Size(114, 27);
            nome.TabIndex = 3;
            // 
            // cadastra
            // 
            cadastra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastra.Location = new Point(409, 107);
            cadastra.Margin = new Padding(3, 4, 3, 4);
            cadastra.Name = "cadastra";
            cadastra.Size = new Size(219, 68);
            cadastra.TabIndex = 5;
            cadastra.Text = "Cadastrar";
            cadastra.UseVisualStyleBackColor = true;
            cadastra.Click += cadastra_Click;
            // 
            // numero
            // 
            numero.Location = new Point(514, 69);
            numero.Margin = new Padding(3, 4, 3, 4);
            numero.Mask = "(00) 00000-0000";
            numero.Name = "numero";
            numero.Size = new Size(114, 27);
            numero.TabIndex = 6;
            // 
            // remove
            // 
            remove.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remove.Location = new Point(427, 183);
            remove.Margin = new Padding(3, 4, 3, 4);
            remove.Name = "remove";
            remove.Size = new Size(171, 55);
            remove.TabIndex = 10;
            remove.Text = "Remover";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // telefonica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 600);
            Controls.Add(remove);
            Controls.Add(numero);
            Controls.Add(cadastra);
            Controls.Add(nome);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(gridData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "telefonica";
            Text = "Form1";
            Click += telefonica_Click;
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridData;
        private Label lbl1;
        private Label label1;
        private TextBox nome;
        private Button cadastra;
        private MaskedTextBox numero;
        private Button remove;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn telefone;
    }
}
