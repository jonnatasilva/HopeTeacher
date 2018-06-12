namespace HopeProfessor
{
    partial class MenuProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProf));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pb_pesquisar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb_fechar = new System.Windows.Forms.PictureBox();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.pb_novoAluno = new System.Windows.Forms.PictureBox();
            this.lbl_novoAluno = new System.Windows.Forms.Label();
            this.pb_meuPerfil = new System.Windows.Forms.PictureBox();
            this.lbl_meuPerfil = new System.Windows.Forms.Label();
            this.txtId_aluno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_meuPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(534, 399);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pb_pesquisar
            // 
            this.pb_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_pesquisar.BackColor = System.Drawing.Color.White;
            this.pb_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pb_pesquisar.Image")));
            this.pb_pesquisar.Location = new System.Drawing.Point(318, 32);
            this.pb_pesquisar.Name = "pb_pesquisar";
            this.pb_pesquisar.Size = new System.Drawing.Size(34, 28);
            this.pb_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pesquisar.TabIndex = 20;
            this.pb_pesquisar.TabStop = false;
            this.pb_pesquisar.Click += new System.EventHandler(this.pb_pesquisar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pesquisar Aluno:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(147, 32);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(166, 22);
            this.txtPesquisar.TabIndex = 18;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(106, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 314);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alunos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_aluno,
            this.nome,
            this.email,
            this.data_nasc,
            this.telefone_1,
            this.telefone_2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 277);
            this.dataGridView1.TabIndex = 27;
            // 
            // ID_aluno
            // 
            this.ID_aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_aluno.HeaderText = "Código do aluno";
            this.ID_aluno.Name = "ID_aluno";
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // data_nasc
            // 
            this.data_nasc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_nasc.HeaderText = "Data de nascimento";
            this.data_nasc.Name = "data_nasc";
            // 
            // telefone_1
            // 
            this.telefone_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefone_1.HeaderText = "Telefone 1";
            this.telefone_1.Name = "telefone_1";
            // 
            // telefone_2
            // 
            this.telefone_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefone_2.HeaderText = "Telefone 2";
            this.telefone_2.Name = "telefone_2";
            // 
            // pb_fechar
            // 
            this.pb_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_fechar.BackColor = System.Drawing.Color.White;
            this.pb_fechar.Image = ((System.Drawing.Image)(resources.GetObject("pb_fechar.Image")));
            this.pb_fechar.Location = new System.Drawing.Point(551, 12);
            this.pb_fechar.Name = "pb_fechar";
            this.pb_fechar.Size = new System.Drawing.Size(34, 28);
            this.pb_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fechar.TabIndex = 16;
            this.pb_fechar.TabStop = false;
            this.pb_fechar.Click += new System.EventHandler(this.pb_fechar_Click);
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fechar.AutoSize = true;
            this.lbl_fechar.BackColor = System.Drawing.Color.White;
            this.lbl_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechar.Location = new System.Drawing.Point(550, 43);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(38, 16);
            this.lbl_fechar.TabIndex = 15;
            this.lbl_fechar.Text = "  Sair";
            this.lbl_fechar.Click += new System.EventHandler(this.lbl_fechar_Click);
            // 
            // pb_novoAluno
            // 
            this.pb_novoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_novoAluno.BackColor = System.Drawing.Color.White;
            this.pb_novoAluno.Image = ((System.Drawing.Image)(resources.GetObject("pb_novoAluno.Image")));
            this.pb_novoAluno.Location = new System.Drawing.Point(481, 12);
            this.pb_novoAluno.Name = "pb_novoAluno";
            this.pb_novoAluno.Size = new System.Drawing.Size(34, 28);
            this.pb_novoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_novoAluno.TabIndex = 14;
            this.pb_novoAluno.TabStop = false;
            this.pb_novoAluno.Click += new System.EventHandler(this.pb_novoAluno_Click);
            // 
            // lbl_novoAluno
            // 
            this.lbl_novoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_novoAluno.AutoSize = true;
            this.lbl_novoAluno.BackColor = System.Drawing.Color.White;
            this.lbl_novoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novoAluno.Location = new System.Drawing.Point(464, 43);
            this.lbl_novoAluno.Name = "lbl_novoAluno";
            this.lbl_novoAluno.Size = new System.Drawing.Size(78, 16);
            this.lbl_novoAluno.TabIndex = 13;
            this.lbl_novoAluno.Text = "Novo Aluno";
            this.lbl_novoAluno.Click += new System.EventHandler(this.lbl_novoAluno_Click);
            // 
            // pb_meuPerfil
            // 
            this.pb_meuPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_meuPerfil.BackColor = System.Drawing.Color.White;
            this.pb_meuPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pb_meuPerfil.Image")));
            this.pb_meuPerfil.Location = new System.Drawing.Point(418, 12);
            this.pb_meuPerfil.Name = "pb_meuPerfil";
            this.pb_meuPerfil.Size = new System.Drawing.Size(34, 28);
            this.pb_meuPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_meuPerfil.TabIndex = 12;
            this.pb_meuPerfil.TabStop = false;
            this.pb_meuPerfil.Click += new System.EventHandler(this.pb_meuPerfil_Click_1);
            // 
            // lbl_meuPerfil
            // 
            this.lbl_meuPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_meuPerfil.AutoSize = true;
            this.lbl_meuPerfil.BackColor = System.Drawing.Color.White;
            this.lbl_meuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meuPerfil.Location = new System.Drawing.Point(394, 43);
            this.lbl_meuPerfil.Name = "lbl_meuPerfil";
            this.lbl_meuPerfil.Size = new System.Drawing.Size(70, 16);
            this.lbl_meuPerfil.TabIndex = 11;
            this.lbl_meuPerfil.Text = "Meu  Perfil";
            this.lbl_meuPerfil.Click += new System.EventHandler(this.lbl_meuPerfil_Click);
            // 
            // txtId_aluno
            // 
            this.txtId_aluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId_aluno.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId_aluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId_aluno.Location = new System.Drawing.Point(418, 402);
            this.txtId_aluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtId_aluno.Name = "txtId_aluno";
            this.txtId_aluno.Size = new System.Drawing.Size(112, 20);
            this.txtId_aluno.TabIndex = 22;
            // 
            // MenuProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 454);
            this.Controls.Add(this.txtId_aluno);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.pb_pesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_fechar);
            this.Controls.Add(this.lbl_fechar);
            this.Controls.Add(this.pb_novoAluno);
            this.Controls.Add(this.lbl_novoAluno);
            this.Controls.Add(this.pb_meuPerfil);
            this.Controls.Add(this.lbl_meuPerfil);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuProf";
            this.Text = "HOPE Menu Professor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_meuPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pb_pesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_fechar;
        private System.Windows.Forms.Label lbl_fechar;
        private System.Windows.Forms.PictureBox pb_novoAluno;
        private System.Windows.Forms.Label lbl_novoAluno;
        private System.Windows.Forms.PictureBox pb_meuPerfil;
        private System.Windows.Forms.Label lbl_meuPerfil;
        private System.Windows.Forms.TextBox txtId_aluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_2;

    }
}