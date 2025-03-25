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
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparFormulario()
        {
            int quantidadeLista = Categoria.ListaProduto.Count;
            int codigo = quantidadeLista + 1;
            mtbCodigo.Text = codigo.ToString("D4");
            txtNomeCategoria.Clear();
            txtDescricao.Clear();
            rdbInativo.Checked = false;
            rdbAtivo.Checked = false;
        }

        public bool CamposPreenchidos()
        {
            if (string.IsNullOrEmpty(mtbCodigo.Text))
            {
                Erro("Campo Código não pode estar Vazio!");
                return true;
            }
            else if (string.IsNullOrEmpty(txtNomeCategoria.Text))
            {
                Erro("Campo Nome da Categoria não pode estar Vazio!");
                return true;
            }
            else if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Erro("Campo Descrição não pode estar Vazio!");
                return true;
            }
            else if (rdbAtivo.Checked == false && rdbInativo.Checked == false)
            {
                Erro("Campo Status não pode estar Vazio!");
                return true;
            }

            return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.CamposPreenchidos() == false)
            {
                Categoria categoria = new Categoria();
                categoria.Codigo = int.Parse(mtbCodigo.Text);
                categoria.NomeCategoria = txtNomeCategoria.Text;
                categoria.Descricao = txtDescricao.Text;

                if (rdbAtivo.Checked)
                {
                    categoria.status = Status.Ativo;
                }
                else
                {
                    categoria.status = Status.Inativo;
                }

                categoria.DataCadastro = DateTime.Now;


                Categoria.ListaProduto.Add(categoria);


                Sucesso("Cadastrado com Sucesso!");


                LimparFormulario();
            }
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            int quantidadeLista = Categoria.ListaProduto.Count;
            int codigo = quantidadeLista + 1;
            mtbCodigo.Text = codigo.ToString("D4");
        }
    }
}
