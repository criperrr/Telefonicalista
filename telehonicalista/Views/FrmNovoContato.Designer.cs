namespace telehonicalista.Views
{
    partial class FrmNovoContato
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
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            Nome = new Label();
            label2 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(81, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(81, 52);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(224, 23);
            txtTelefone.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(32, 15);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 2;
            Nome.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 55);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone: ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(81, 102);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(224, 56);
            btnSave.TabIndex = 4;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmNovoContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 179);
            ControlBox = false;
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Name = "FrmNovoContato";
            Text = "FrmNovoContato";
            Load += FrmNovoContato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label Nome;
        private Label label2;
        private Button btnSave;
    }
}