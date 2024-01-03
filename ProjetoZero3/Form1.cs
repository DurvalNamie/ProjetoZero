using ProjetoZero3.Repositorio;

namespace ProjetoZero3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(0, txtNome.Text, txtCpf.Text, txtEmail.Text);
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Insert(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }
        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtId.Text = string.Empty;
        }


        private void BuscarTodasAsPessoas(PessoaRepositorio pessoaRepositorio)
        {
            var pessoas = pessoaRepositorio.BuscarTodasPessoas();
            dgPessoa.DataSource = pessoas.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void dgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtId.Text = dgv.CurrentRow.Cells["Id"].Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"].Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["Cpf"].Value?.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value?.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(Convert.ToInt32(txtId.Text), txtNome.Text, txtCpf.Text, txtEmail.Text);
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Atualizar(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Deletar(Convert.ToInt32(txtId.Text));
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }
    }
}