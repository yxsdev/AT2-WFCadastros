using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
            dtpDataCadastro.Value = DateTime.Today;

            cmbStatus.Items.Add("Ativo");
            cmbStatus.Items.Add("Inativo");
            cmbStatus.SelectedIndex = 0;
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
            txtNomeCategoria.Clear();
            txtDescricao.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbCodigo.Text))
            {
                Erro("Campo Código não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtNomeCategoria.Text))
            {
                Erro("Campo Nome do Produto não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Erro("Campo Descrição não pode estar Vazio!");
                return;
            }
            else if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                Erro("Campo Status não pode estar Vazio!");
                return;
            }

            Categoria categoria = new Categoria();
            categoria.Codigo = Convert.ToInt32(mtbCodigo.Text);
            categoria.NomeCategoria = txtNomeCategoria.Text;
            categoria.Descricao = txtDescricao.Text;
            DateTime dataCadastro = dtpDataCadastro.Value;
            categoria.DataCadastro = dataCadastro;
            categoria.Status = cmbStatus.Text;


            Categoria.ListaProduto.Add(categoria);

            FormListar formListaProduto = new FormListar();
            formListaProduto.Show();

            Sucesso("Cadastrado com Sucesso!");

            LimparFormulario();
        }
    }
}
