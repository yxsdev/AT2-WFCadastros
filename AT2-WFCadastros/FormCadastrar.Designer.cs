namespace AT2_WFCadastros
{
    partial class FormCadastrar
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
            mtbCodigo = new MaskedTextBox();
            lblCodigo = new Label();
            lblNomeCategoria = new Label();
            txtNomeCategoria = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblCategoria = new Label();
            btnCadastrar = new Button();
            dtpDataCadastro = new DateTimePicker();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            lblDataCadastro = new Label();
            SuspendLayout();
            // 
            // mtbCodigo
            // 
            mtbCodigo.Location = new Point(47, 75);
            mtbCodigo.Mask = "000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(113, 23);
            mtbCodigo.TabIndex = 0;
            mtbCodigo.ValidatingType = typeof(int);
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(47, 57);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.Location = new Point(47, 120);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(113, 15);
            lblNomeCategoria.TabIndex = 2;
            lblNomeCategoria.Text = "Nome da Categoria:";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(47, 138);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(374, 23);
            txtNomeCategoria.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(47, 178);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(47, 196);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(374, 119);
            txtDescricao.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(260, 57);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(0, 15);
            lblCategoria.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(346, 378);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Location = new Point(312, 75);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(109, 23);
            dtpDataCadastro.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(175, 75);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(175, 57);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status:";
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(312, 57);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(84, 15);
            lblDataCadastro.TabIndex = 12;
            lblDataCadastro.Text = "Data Cadastro:";
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 429);
            Controls.Add(lblDataCadastro);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDataCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNomeCategoria);
            Controls.Add(lblNomeCategoria);
            Controls.Add(lblCodigo);
            Controls.Add(mtbCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbCodigo;
        private Label lblCodigo;
        private Label lblNomeCategoria;
        private TextBox txtNomeCategoria;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblCategoria;
        private Button btnCadastrar;
        private DateTimePicker dtpDataCadastro;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Label lblDataCadastro;
    }
}