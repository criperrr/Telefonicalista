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
            gridData.Location = new Point(12, 12);
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.RowHeadersWidth = 51;
            gridData.Size = new Size(312, 426);
            gridData.TabIndex = 0;
            gridData.TabStop = false;
            gridData.CellClick += gridData_CellClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 43;
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
            lbl1.Location = new Point(374, 18);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(70, 28);
            lbl1.TabIndex = 1;
            lbl1.Text = "Nome: ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 46);
            label1.Name = "label1";
            label1.Size = new Size(95, 26);
            label1.TabIndex = 2;
            label1.Text = "Número: ";
            // 
            // nome
            // 
            nome.Location = new Point(450, 23);
            nome.Name = "nome";
            nome.Size = new Size(100, 23);
            nome.TabIndex = 0;
            // 
            // cadastra
            // 
            cadastra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastra.Location = new Point(358, 80);
            cadastra.Name = "cadastra";
            cadastra.Size = new Size(192, 51);
            cadastra.TabIndex = 2;
            cadastra.Text = "C&adastrar";
            cadastra.UseVisualStyleBackColor = true;
            cadastra.Click += cadastra_Click;
            // 
            // numero
            // 
            numero.Location = new Point(450, 52);
            numero.Mask = "(00) 00000-0000";
            numero.Name = "numero";
            numero.Size = new Size(100, 23);
            numero.TabIndex = 1;
            // 
            // remove
            // 
            remove.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remove.Location = new Point(374, 137);
            remove.Name = "remove";
            remove.Size = new Size(150, 41);
            remove.TabIndex = 3;
            remove.Text = "&Remover";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // telefonica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(remove);
            Controls.Add(numero);
            Controls.Add(cadastra);
            Controls.Add(nome);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(gridData);
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
