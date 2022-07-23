namespace WFCRUDMySQL.View
{
    partial class FrmAdicionar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdicionar));
            this.btnGravar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBusca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lstDados = new MaterialSkin.Controls.MaterialListView();
            this.clhId = new System.Windows.Forms.ColumnHeader();
            this.clhNome = new System.Windows.Forms.ColumnHeader();
            this.clhEmail = new System.Windows.Forms.ColumnHeader();
            this.clhTelefone = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.ImageIndex = 0;
            this.btnGravar.ImageList = this.imageList1;
            this.btnGravar.Location = new System.Drawing.Point(158, 316);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnGravar.Size = new System.Drawing.Size(140, 95);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "salvar.png");
            this.imageList1.Images.SetKeyName(1, "excluir.png");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "novo.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "pesquisar.png");
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageIndex = 1;
            this.btnExcluir.ImageList = this.imageList1;
            this.btnExcluir.Location = new System.Drawing.Point(304, 316);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnExcluir.Size = new System.Drawing.Size(127, 95);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.ImageIndex = 3;
            this.btnNovo.ImageList = this.imageList1;
            this.btnNovo.Location = new System.Drawing.Point(12, 316);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnNovo.Size = new System.Drawing.Size(140, 95);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(12, 73);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(417, 23);
            this.txtNome.TabIndex = 14;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "E-mail";
            this.txtEmail.Location = new System.Drawing.Point(12, 102);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(417, 23);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Hint = "Telefone (DDD) 00000-0000";
            this.txtTelefone.Location = new System.Drawing.Point(12, 131);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.Size = new System.Drawing.Size(214, 23);
            this.txtTelefone.TabIndex = 19;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Depth = 0;
            this.txtBusca.Hint = "Nome ou E-mail";
            this.txtBusca.Location = new System.Drawing.Point(437, 73);
            this.txtBusca.MaxLength = 32767;
            this.txtBusca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.SelectedText = "";
            this.txtBusca.SelectionLength = 0;
            this.txtBusca.SelectionStart = 0;
            this.txtBusca.Size = new System.Drawing.Size(450, 23);
            this.txtBusca.TabIndex = 20;
            this.txtBusca.TabStop = false;
            this.txtBusca.UseSystemPasswordChar = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.Icon = null;
            this.btnPesquisar.Location = new System.Drawing.Point(893, 73);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Primary = true;
            this.btnPesquisar.Size = new System.Drawing.Size(94, 36);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lstDados
            // 
            this.lstDados.BackColor = System.Drawing.Color.White;
            this.lstDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhNome,
            this.clhEmail,
            this.clhTelefone});
            this.lstDados.Depth = 0;
            this.lstDados.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDados.FullRowSelect = true;
            this.lstDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDados.Location = new System.Drawing.Point(437, 115);
            this.lstDados.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstDados.MouseState = MaterialSkin.MouseState.OUT;
            this.lstDados.Name = "lstDados";
            this.lstDados.OwnerDraw = true;
            this.lstDados.Size = new System.Drawing.Size(550, 182);
            this.lstDados.TabIndex = 22;
            this.lstDados.UseCompatibleStateImageBehavior = false;
            this.lstDados.View = System.Windows.Forms.View.Details;
            this.lstDados.Click += new System.EventHandler(this.lstDados_Click);
            // 
            // clhId
            // 
            this.clhId.Text = "#";
            this.clhId.Width = 50;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 200;
            // 
            // clhEmail
            // 
            this.clhEmail.Text = "E-mail";
            this.clhEmail.Width = 200;
            // 
            // clhTelefone
            // 
            this.clhTelefone.Text = "Telefone";
            this.clhTelefone.Width = 70;
            // 
            // FrmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 467);
            this.Controls.Add(this.lstDados);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.Name = "FrmAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGravar;
        private ImageList imageList1;
        private ImageList imageList2;
        private Button btnExcluir;
        private Button btnNovo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusca;
        private MaterialSkin.Controls.MaterialRaisedButton btnPesquisar;
        private MaterialSkin.Controls.MaterialListView lstDados;
        private ColumnHeader clhId;
        private ColumnHeader clhNome;
        private ColumnHeader clhEmail;
        private ColumnHeader clhTelefone;
    }
}