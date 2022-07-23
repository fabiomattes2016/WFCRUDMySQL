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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
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
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGravar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
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
            this.txtBusca.Location = new System.Drawing.Point(12, 208);
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
            this.btnPesquisar.Location = new System.Drawing.Point(468, 208);
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
            this.lstDados.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.lstDados.FullRowSelect = true;
            this.lstDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDados.Location = new System.Drawing.Point(12, 250);
            this.lstDados.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstDados.MouseState = MaterialSkin.MouseState.OUT;
            this.lstDados.Name = "lstDados";
            this.lstDados.OwnerDraw = true;
            this.lstDados.Size = new System.Drawing.Size(641, 296);
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
            this.clhEmail.Width = 225;
            // 
            // clhTelefone
            // 
            this.clhTelefone.Text = "Telefone";
            this.clhTelefone.Width = 150;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.Depth = 0;
            this.btnNovo.Icon = null;
            this.btnNovo.Location = new System.Drawing.Point(435, 73);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(59, 36);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.AutoSize = true;
            this.btnGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGravar.Depth = 0;
            this.btnGravar.Icon = null;
            this.btnGravar.Location = new System.Drawing.Point(500, 73);
            this.btnGravar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Primary = true;
            this.btnGravar.Size = new System.Drawing.Size(72, 36);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(578, 73);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(75, 36);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 558);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstDados);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.Name = "FrmAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ImageList imageList1;
        private ImageList imageList2;
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
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialRaisedButton btnGravar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
    }
}