namespace AT2_CadastroPessoa
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblCodigo = new Label();
            mtbCodigo = new MaskedTextBox();
            mtbCpf = new MaskedTextBox();
            lblCpf = new Label();
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblCelular = new Label();
            mtbCelular = new MaskedTextBox();
            gbvTipoCelular = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            chkPossuiFilhos = new CheckBox();
            btnSalvar = new Button();
            btnVoltar = new Button();
            gbvTipoCelular.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(51, 52);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // mtbCodigo
            // 
            mtbCodigo.Location = new Point(51, 70);
            mtbCodigo.Mask = "0000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(129, 23);
            mtbCodigo.TabIndex = 1;
            mtbCodigo.ValidatingType = typeof(int);
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(204, 70);
            mtbCpf.Mask = "000-000-000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(200, 23);
            mtbCpf.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(204, 52);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(51, 110);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(99, 15);
            lblNomeCompleto.TabIndex = 4;
            lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(51, 128);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(353, 23);
            txtNomeCompleto.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(51, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(51, 233);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(76, 15);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "DDD/Celular:";
            // 
            // mtbCelular
            // 
            mtbCelular.Location = new Point(51, 251);
            mtbCelular.Mask = "(99) 00000-0000";
            mtbCelular.Name = "mtbCelular";
            mtbCelular.Size = new Size(129, 23);
            mtbCelular.TabIndex = 9;
            // 
            // gbvTipoCelular
            // 
            gbvTipoCelular.Controls.Add(rdbRecado);
            gbvTipoCelular.Controls.Add(rdbComercial);
            gbvTipoCelular.Controls.Add(rdbPessoal);
            gbvTipoCelular.Location = new Point(204, 233);
            gbvTipoCelular.Name = "gbvTipoCelular";
            gbvTipoCelular.Size = new Size(200, 128);
            gbvTipoCelular.TabIndex = 10;
            gbvTipoCelular.TabStop = false;
            gbvTipoCelular.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(19, 81);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 11;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(19, 56);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(19, 31);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // chkPossuiFilhos
            // 
            chkPossuiFilhos.AutoSize = true;
            chkPossuiFilhos.Location = new Point(51, 290);
            chkPossuiFilhos.Name = "chkPossuiFilhos";
            chkPossuiFilhos.Size = new Size(97, 19);
            chkPossuiFilhos.TabIndex = 11;
            chkPossuiFilhos.Text = "Possui filhos?";
            chkPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(312, 396);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(92, 39);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(210, 396);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(83, 39);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.MiddleRight;
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 463);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(chkPossuiFilhos);
            Controls.Add(gbvTipoCelular);
            Controls.Add(mtbCelular);
            Controls.Add(lblCelular);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Controls.Add(mtbCpf);
            Controls.Add(lblCpf);
            Controls.Add(mtbCodigo);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            gbvTipoCelular.ResumeLayout(false);
            gbvTipoCelular.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private MaskedTextBox mtbCodigo;
        private MaskedTextBox mtbCpf;
        private Label lblCpf;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblCelular;
        private MaskedTextBox mtbCelular;
        private GroupBox gbvTipoCelular;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private CheckBox chkPossuiFilhos;
        private Button btnSalvar;
        private Button btnVoltar;
    }
}