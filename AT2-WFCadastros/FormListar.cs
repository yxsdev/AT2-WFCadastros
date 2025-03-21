namespace AT2_WFCadastros
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            dgvListagem.DataSource = Categoria.ListaProduto;
        }
    }
}
