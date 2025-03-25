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
            gbxTipoStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            gbxTipoStatus.SuspendLayout();
            SuspendLayout();
            // 
            // mtbCodigo
            // 
            mtbCodigo.Enabled = false;
            mtbCodigo.Location = new Point(47, 84);
            mtbCodigo.Mask = "0000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(113, 23);
            mtbCodigo.TabIndex = 0;
            mtbCodigo.ValidatingType = typeof(int);
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(47, 66);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.Location = new Point(47, 137);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(113, 15);
            lblNomeCategoria.TabIndex = 2;
            lblNomeCategoria.Text = "Nome da Categoria:";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(47, 155);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(374, 23);
            txtNomeCategoria.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(47, 195);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(47, 213);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(374, 119);
            txtDescricao.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(273, 66);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(0, 15);
            lblCategoria.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(324, 370);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(97, 31);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // gbxTipoStatus
            // 
            gbxTipoStatus.Controls.Add(rdbInativo);
            gbxTipoStatus.Controls.Add(rdbAtivo);
            gbxTipoStatus.Location = new Point(179, 66);
            gbxTipoStatus.Name = "gbxTipoStatus";
            gbxTipoStatus.Size = new Size(242, 57);
            gbxTipoStatus.TabIndex = 12;
            gbxTipoStatus.TabStop = false;
            gbxTipoStatus.Text = "Status:";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(126, 22);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(55, 22);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 429);
            Controls.Add(gbxTipoStatus);
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
            Load += FormCadastrar_Load;
            gbxTipoStatus.ResumeLayout(false);
            gbxTipoStatus.PerformLayout();
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
        private GroupBox gbxTipoStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
    }
}