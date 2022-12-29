namespace Contatos1._1.View
{
    partial class frmContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContatos));
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblContatoSelecionado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.gbInformacao = new System.Windows.Forms.GroupBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.pnlContatos = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpcoes.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbInformacao.SuspendLayout();
            this.pnlContatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToDeleteRows = false;
            this.dgvContatos.BackgroundColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContatos.GridColor = System.Drawing.Color.Purple;
            this.dgvContatos.Location = new System.Drawing.Point(0, 0);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContatos.RowTemplate.Height = 25;
            this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatos.Size = new System.Drawing.Size(579, 469);
            this.dgvContatos.TabIndex = 0;
            this.dgvContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellClick);
            this.dgvContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellDoubleClick);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.AutoSize = true;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitulo.Controls.Add(this.lblContatoSelecionado);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, -1);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(945, 83);
            this.pnlTitulo.TabIndex = 8;
            // 
            // lblContatoSelecionado
            // 
            this.lblContatoSelecionado.AutoSize = true;
            this.lblContatoSelecionado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContatoSelecionado.ForeColor = System.Drawing.Color.White;
            this.lblContatoSelecionado.Location = new System.Drawing.Point(11, 39);
            this.lblContatoSelecionado.Name = "lblContatoSelecionado";
            this.lblContatoSelecionado.Size = new System.Drawing.Size(0, 25);
            this.lblContatoSelecionado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(464, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Contatos";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Purple;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemover.Location = new System.Drawing.Point(62, 53);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(167, 57);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Purple;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.Location = new System.Drawing.Point(78, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(167, 57);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.AutoSize = true;
            this.pnlOpcoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOpcoes.Controls.Add(this.gbOpcao);
            this.pnlOpcoes.Controls.Add(this.btnLixeira);
            this.pnlOpcoes.Controls.Add(this.gbInformacao);
            this.pnlOpcoes.Controls.Add(this.btnAdicionar);
            this.pnlOpcoes.Location = new System.Drawing.Point(13, 149);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(314, 469);
            this.pnlOpcoes.TabIndex = 15;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.btnRemover);
            this.gbOpcao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbOpcao.ForeColor = System.Drawing.Color.White;
            this.gbOpcao.Location = new System.Drawing.Point(16, 89);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(278, 129);
            this.gbOpcao.TabIndex = 17;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Selecione a célula do contato e clique em Remover";
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackColor = System.Drawing.Color.Purple;
            this.btnLixeira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLixeira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLixeira.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLixeira.Location = new System.Drawing.Point(78, 388);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(167, 57);
            this.btnLixeira.TabIndex = 16;
            this.btnLixeira.Text = "Lixeira";
            this.btnLixeira.UseVisualStyleBackColor = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // gbInformacao
            // 
            this.gbInformacao.Controls.Add(this.lblInformacao);
            this.gbInformacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbInformacao.ForeColor = System.Drawing.Color.White;
            this.gbInformacao.Location = new System.Drawing.Point(16, 234);
            this.gbInformacao.Name = "gbInformacao";
            this.gbInformacao.Size = new System.Drawing.Size(278, 131);
            this.gbInformacao.TabIndex = 15;
            this.gbInformacao.TabStop = false;
            this.gbInformacao.Text = "Aviso";
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacao.ForeColor = System.Drawing.Color.White;
            this.lblInformacao.Location = new System.Drawing.Point(12, 29);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(244, 84);
            this.lblInformacao.TabIndex = 2;
            this.lblInformacao.Text = "Para alterar um contato específico\r\nclique duas vezes\r\nsobre qualquer célula\r\ncom" +
    " as informações do indivíduo.";
            // 
            // pnlContatos
            // 
            this.pnlContatos.Controls.Add(this.dgvContatos);
            this.pnlContatos.Location = new System.Drawing.Point(353, 149);
            this.pnlContatos.Name = "pnlContatos";
            this.pnlContatos.Size = new System.Drawing.Size(579, 469);
            this.pnlContatos.TabIndex = 16;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisa.Location = new System.Drawing.Point(353, 104);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(284, 29);
            this.txtPesquisa.TabIndex = 17;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Purple;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(663, 95);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 41);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(944, 632);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.pnlContatos);
            this.Controls.Add(this.pnlOpcoes);
            this.Controls.Add(this.pnlTitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmContatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpcoes.ResumeLayout(false);
            this.gbOpcao.ResumeLayout(false);
            this.gbInformacao.ResumeLayout(false);
            this.gbInformacao.PerformLayout();
            this.pnlContatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel pnlOpcoes;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.GroupBox gbInformacao;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.Panel pnlContatos;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblContatoSelecionado;
    }
}