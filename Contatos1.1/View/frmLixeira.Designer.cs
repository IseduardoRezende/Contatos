namespace Contatos1._1.View
{
    partial class frmLixeira
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
            this.pnlTituloLixeira = new System.Windows.Forms.Panel();
            this.lblContatoSelecionado = new System.Windows.Forms.Label();
            this.lblTituloLixeira = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlOpcao = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.gbReativar = new System.Windows.Forms.GroupBox();
            this.btnReativar = new System.Windows.Forms.Button();
            this.pnlLixeira = new System.Windows.Forms.Panel();
            this.dgvContatosLixeira = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pnlTituloLixeira.SuspendLayout();
            this.pnlOpcao.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbReativar.SuspendLayout();
            this.pnlLixeira.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosLixeira)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloLixeira
            // 
            this.pnlTituloLixeira.AutoSize = true;
            this.pnlTituloLixeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTituloLixeira.Controls.Add(this.lblContatoSelecionado);
            this.pnlTituloLixeira.Controls.Add(this.lblTituloLixeira);
            this.pnlTituloLixeira.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloLixeira.Name = "pnlTituloLixeira";
            this.pnlTituloLixeira.Size = new System.Drawing.Size(980, 102);
            this.pnlTituloLixeira.TabIndex = 10;
            // 
            // lblContatoSelecionado
            // 
            this.lblContatoSelecionado.AutoSize = true;
            this.lblContatoSelecionado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContatoSelecionado.ForeColor = System.Drawing.Color.White;
            this.lblContatoSelecionado.Location = new System.Drawing.Point(15, 62);
            this.lblContatoSelecionado.Name = "lblContatoSelecionado";
            this.lblContatoSelecionado.Size = new System.Drawing.Size(0, 25);
            this.lblContatoSelecionado.TabIndex = 2;
            // 
            // lblTituloLixeira
            // 
            this.lblTituloLixeira.AutoSize = true;
            this.lblTituloLixeira.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloLixeira.ForeColor = System.Drawing.Color.White;
            this.lblTituloLixeira.Location = new System.Drawing.Point(453, 52);
            this.lblTituloLixeira.Name = "lblTituloLixeira";
            this.lblTituloLixeira.Size = new System.Drawing.Size(244, 37);
            this.lblTituloLixeira.TabIndex = 0;
            this.lblTituloLixeira.Text = "Lixeira de Contatos";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Purple;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(86, 47);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(167, 57);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnlOpcao
            // 
            this.pnlOpcao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOpcao.Controls.Add(this.btnVoltar);
            this.pnlOpcao.Location = new System.Drawing.Point(56, 482);
            this.pnlOpcao.Name = "pnlOpcao";
            this.pnlOpcao.Size = new System.Drawing.Size(263, 113);
            this.pnlOpcao.TabIndex = 16;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Purple;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(43, 27);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(167, 57);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.btnExcluir);
            this.gbOpcao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbOpcao.ForeColor = System.Drawing.Color.White;
            this.gbOpcao.Location = new System.Drawing.Point(17, 176);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(360, 133);
            this.gbOpcao.TabIndex = 17;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Selecione a célula do contato e clique em Excluir";
            // 
            // gbReativar
            // 
            this.gbReativar.Controls.Add(this.btnReativar);
            this.gbReativar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbReativar.ForeColor = System.Drawing.Color.White;
            this.gbReativar.Location = new System.Drawing.Point(17, 330);
            this.gbReativar.Name = "gbReativar";
            this.gbReativar.Size = new System.Drawing.Size(370, 133);
            this.gbReativar.TabIndex = 18;
            this.gbReativar.TabStop = false;
            this.gbReativar.Text = "Selecione a célula do contato e clique em Reativar";
            // 
            // btnReativar
            // 
            this.btnReativar.BackColor = System.Drawing.Color.Purple;
            this.btnReativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReativar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReativar.Location = new System.Drawing.Point(84, 50);
            this.btnReativar.Name = "btnReativar";
            this.btnReativar.Size = new System.Drawing.Size(167, 57);
            this.btnReativar.TabIndex = 14;
            this.btnReativar.Text = "Reativar";
            this.btnReativar.UseVisualStyleBackColor = false;
            this.btnReativar.Click += new System.EventHandler(this.btnReativar_Click);
            // 
            // pnlLixeira
            // 
            this.pnlLixeira.Controls.Add(this.dgvContatosLixeira);
            this.pnlLixeira.Location = new System.Drawing.Point(429, 176);
            this.pnlLixeira.Name = "pnlLixeira";
            this.pnlLixeira.Size = new System.Drawing.Size(539, 419);
            this.pnlLixeira.TabIndex = 19;
            // 
            // dgvContatosLixeira
            // 
            this.dgvContatosLixeira.AllowUserToAddRows = false;
            this.dgvContatosLixeira.AllowUserToDeleteRows = false;
            this.dgvContatosLixeira.BackgroundColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatosLixeira.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContatosLixeira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatosLixeira.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContatosLixeira.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContatosLixeira.GridColor = System.Drawing.Color.Purple;
            this.dgvContatosLixeira.Location = new System.Drawing.Point(0, 0);
            this.dgvContatosLixeira.Name = "dgvContatosLixeira";
            this.dgvContatosLixeira.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContatosLixeira.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContatosLixeira.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContatosLixeira.RowTemplate.Height = 25;
            this.dgvContatosLixeira.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatosLixeira.Size = new System.Drawing.Size(539, 419);
            this.dgvContatosLixeira.TabIndex = 22;
            this.dgvContatosLixeira.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatosLixeira_CellClick_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Purple;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(743, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 41);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisa.Location = new System.Drawing.Point(429, 129);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(284, 29);
            this.txtPesquisa.TabIndex = 21;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // frmLixeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(980, 611);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.pnlLixeira);
            this.Controls.Add(this.gbReativar);
            this.Controls.Add(this.gbOpcao);
            this.Controls.Add(this.pnlOpcao);
            this.Controls.Add(this.pnlTituloLixeira);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmLixeira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLixeira_Load);
            this.pnlTituloLixeira.ResumeLayout(false);
            this.pnlTituloLixeira.PerformLayout();
            this.pnlOpcao.ResumeLayout(false);
            this.gbOpcao.ResumeLayout(false);
            this.gbReativar.ResumeLayout(false);
            this.pnlLixeira.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosLixeira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloLixeira;
        private System.Windows.Forms.Label lblTituloLixeira;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlOpcao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.GroupBox gbReativar;
        private System.Windows.Forms.Button btnReativar;
        private System.Windows.Forms.Panel pnlLixeira;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblContatoSelecionado;
        private System.Windows.Forms.DataGridView dgvContatosLixeira;
    }
}