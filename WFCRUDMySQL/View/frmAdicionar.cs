using WFCRUDMySQL.Model;
using WFCRUDMySQL.Model.DAO;
using WFCRUDMySQL.Model.DAO.Enum;
using WFCRUDMySQL.Model.Enum;

namespace WFCRUDMySQL.View
{
    public partial class FrmAdicionar : MaterialSkin.Controls.MaterialForm
    {
        ContatoDAO contatoDAO = new();
        TipoOperacao tipoOperacao;
        string IdSelecionado;

        public FrmAdicionar()
        {
            InitializeComponent();
            lstDados.Font = new Font("Roboto", 10, System.Drawing.FontStyle.Regular);
            CarregarGrid(TipoBusca.Listagem);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid(TipoBusca.Pesquisa);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contato contato = new()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text
            };

            if (tipoOperacao == TipoOperacao.Inclusao)
            {
                contatoDAO.InserirContato(contato);
                MessageBox.Show("Contato Inserido");
            }   
            else
            {
                contato.Id = Convert.ToInt32(IdSelecionado);
                contatoDAO.AtualizarContato(contato);
                MessageBox.Show("Contato Atualizado");
            }

            txtEmail.Clear();
            txtNome.Clear();
            txtTelefone.Clear();

            CarregarGrid(TipoBusca.Listagem);
        }

        private void CarregarGrid(TipoBusca tipoBusca)
        {
            List<Contato> lista;

            if (tipoBusca == TipoBusca.Listagem)
                lista = contatoDAO.Listar();
            else
                lista = contatoDAO.Buscar(txtBusca.Text);

            lstDados.Items.Clear();

            foreach(var contato in lista)
            {
                ListViewItem item = new ListViewItem(contato.Id.ToString());
                item.SubItems.Add(contato.Nome);
                item.SubItems.Add(contato.Email);
                item.SubItems.Add(contato.Telefone);

                lstDados.Items.Add(item);
            }
        }

        private void lstDados_Click(object sender, EventArgs e)
        {
            tipoOperacao = TipoOperacao.Alteracao;

            foreach (ListViewItem item in lstDados.Items)
            {
                if (item.Selected)
                {
                    IdSelecionado = item.SubItems[0].Text;
                    txtNome.Text = item.SubItems[1].Text;
                    txtEmail.Text = item.SubItems[2].Text;
                    txtTelefone.Text = item.SubItems[3].Text;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tipoOperacao = TipoOperacao.Inclusao;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = new()
            {
                Id = Convert.ToInt32(IdSelecionado),
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text
            };

            DialogResult resp = MessageBox.Show("Deseja realmente excluir o contato?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
                contatoDAO.ExcluirContato(contato);

            CarregarGrid(TipoBusca.Listagem);
        }
    }
}