using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_CadastroPessoa
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparFormulario()
        {
            mtbCodigo.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            mtbCpf.Clear();
            mtbCelular.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string semMaskTelefone = mtbCelular.Text
               .Replace("(", "")
               .Replace(")", "")
               .Replace(" ", "")
               .Replace("-", "");

            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                Erro("Campo Nome não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(semMaskTelefone))
            {
                Erro("Campo Telefone não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo Email não pode estar Vazio!");
                return;
            }
            else if (!mtbCpf.MaskCompleted)
            {
                Erro("CPF não está preenchido corretamente!");
                return;
            }

            ETipoTelefone tipoTelefone;
            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção de Tipo de Telefone!");
                return;
            }
            else
            {
                if (rdbComercial.Checked)
                    tipoTelefone = ETipoTelefone.Comercial;
                else if (rdbPessoal.Checked)
                    tipoTelefone = ETipoTelefone.Pessoal;
                else
                    tipoTelefone = ETipoTelefone.Recado;
            }

            bool possuiFilhos = chkPossuiFilhos.Checked;


            Pessoa c1 = new Pessoa();
            c1.Codigo = 0;
            c1.Cpf = mtbCpf.Text;
            c1.NomeCompleto = txtNomeCompleto.Text;
            c1.Email = txtEmail.Text;
            c1.TipoTelefone = tipoTelefone;
            c1.Ddd = semMaskTelefone.Substring(0, 2);
            c1.Celular = semMaskTelefone.Substring(2);
            c1.PossuiFilhos = chkPossuiFilhos.Checked;

            Pessoa.ListaPessoa.Add(c1);

            FormListar formListar = new FormListar();
            formListar.Show();

            Sucesso("Cadastrado com Sucesso!");

            LimparFormulario();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
