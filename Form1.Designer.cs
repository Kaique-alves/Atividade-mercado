namespace _211469
{
    partial class frm_Avaliacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvPainel = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSelecionado = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda:";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(96, 13);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(30, 31);
            this.lblVenda.TabIndex = 999;
            this.lblVenda.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor Unitário:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(102, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(309, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(102, 99);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(102, 139);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(246, 109);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 50);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(336, 109);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 50);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvPainel
            // 
            this.dgvPainel.AllowUserToAddRows = false;
            this.dgvPainel.AllowUserToDeleteRows = false;
            this.dgvPainel.AllowUserToOrderColumns = true;
            this.dgvPainel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPainel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPainel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.qntd,
            this.Valor_Unitario});
            this.dgvPainel.Location = new System.Drawing.Point(25, 196);
            this.dgvPainel.Name = "dgvPainel";
            this.dgvPainel.ReadOnly = true;
            this.dgvPainel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPainel.Size = new System.Drawing.Size(386, 150);
            this.dgvPainel.TabIndex = 9;
            this.dgvPainel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPainel_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade de Item Selecionado:";
            // 
            // txtSelecionado
            // 
            this.txtSelecionado.Location = new System.Drawing.Point(196, 376);
            this.txtSelecionado.Name = "txtSelecionado";
            this.txtSelecionado.Size = new System.Drawing.Size(85, 20);
            this.txtSelecionado.TabIndex = 9999;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(320, 373);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(320, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(320, 431);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(91, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar Venda";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(320, 460);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(91, 23);
            this.Fechar.TabIndex = 8;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(196, 431);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 25);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // Descricao
            // 
            this.Descricao.Frozen = true;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 80;
            // 
            // qntd
            // 
            this.qntd.Frozen = true;
            this.qntd.HeaderText = "Quantidade";
            this.qntd.Name = "qntd";
            this.qntd.ReadOnly = true;
            this.qntd.Width = 87;
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.Frozen = true;
            this.Valor_Unitario.HeaderText = "V.Unitário";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.ReadOnly = true;
            this.Valor_Unitario.Width = 78;
            // 
            // frm_Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 533);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtSelecionado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPainel);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.label1);
            this.Name = "frm_Avaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecnoMarket";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvPainel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSelecionado;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
    }
}

