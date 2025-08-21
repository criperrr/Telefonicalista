namespace telehonicalista.Views
{
    partial class FrmEditar
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
            txtTel = new MaskedTextBox();
            btnSave = new Button();
            label2 = new Label();
            Nome = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // txtTel
            // 
            txtTel.Location = new Point(76, 55);
            txtTel.Mask = "(999) 0000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(224, 23);
            txtTel.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(76, 102);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(224, 56);
            btnSave.TabIndex = 9;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 55);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Telefone: ";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(27, 15);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 7;
            Nome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 6;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 180);
            Controls.Add(txtTel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(txtNome);
            Name = "FrmEditar";
            Text = "FrmEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtTel;
        private Button btnSave;
        private Label label2;
        private Label Nome;
        private TextBox txtNome;
    }
}