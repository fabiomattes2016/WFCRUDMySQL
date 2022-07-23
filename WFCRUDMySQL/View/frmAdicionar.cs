using MaterialSkin;
using WFCRUDMySQL.Model;
using WFCRUDMySQL.Model.DAO;
using WFCRUDMySQL.Model.DAO.Enum;
using WFCRUDMySQL.Model.Enum;
using WFCRUDMySQL.Services;

namespace WFCRUDMySQL.View
{
    public partial class FrmAdicionar : MaterialSkin.Controls.MaterialForm
    {
        ContatoDAO contatoDAO = new();
        ContatoService contatoService = new();

        TipoOperacao tipoOperacao;
        string IdSelecionado;

        public FrmAdicionar()
        {
            InitializeComponent();

            // Criando o theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Definindo um esquema de cor para o formulário
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple900, 
                Primary.Purple700, 
                Primary.Purple700, 
                Accent.Purple200, 
                TextShade.WHITE);

            txtBusca.Focus();
            lstDados.Font = new Font("Roboto", 10, System.Drawing.FontStyle.Regular);
            CarregarGrid(TipoBusca.Listagem);

            LimparCampos();

            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnExcluir.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid(TipoBusca.Pesquisa);
        }

        private async void btnGravar_Click(object sender, EventArgs e)
        {
            Contato contato = new()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text
            };

            if (tipoOperacao == TipoOperacao.Inclusao)
            {
                await contatoService.PostContatoService(contato);
                MessageBox.Show("Contato Inserido");
            }   
            else
            {
                contato.Id = Convert.ToInt32(IdSelecionado);
                await contatoService.PutContatoService(contato.Id, contato);
                MessageBox.Show("Contato Atualizado");
            }

            LimparCampos();

            CarregarGrid(TipoBusca.Listagem);

            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnExcluir.Enabled = true;

            txtBusca.Focus();
        }

        private async void CarregarGrid(TipoBusca tipoBusca)
        {
            List<ContatoResponse> lista;

            if (tipoBusca == TipoBusca.Listagem)
                lista = await contatoService.GetContatosService();
            else
            {
                if(txtBusca.Text == "")
                    lista = await contatoService.GetContatosService();
                else
                    lista = await contatoService.GetContatoByParametroService(txtBusca.Text);
            }

            lstDados.Items.Clear();

            foreach(var contato in lista)
            {
                ListViewItem item = new ListViewItem(contato.Id.ToString());
                item.SubItems.Add(contato.Nome);
                item.SubItems.Add(contato.Email);
                item.SubItems.Add(contato.Telefone);

                lstDados.Items.Add(item);
            }

            LimparCampos();
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

            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNome.Focus();
            tipoOperacao = TipoOperacao.Inclusao;

            btnNovo.Enabled = false;
            btnGravar.Enabled = true;
            btnExcluir.Enabled = false;
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente excluir o contato?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
                await contatoService.DeleteContatoService(Convert.ToInt32(IdSelecionado));

            CarregarGrid(TipoBusca.Listagem);
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }
    }
}