namespace HopeProfessor
{
    partial class Esqueci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Esqueci));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_Resp = new System.Windows.Forms.TextBox();
            this.cb_PergEsq = new System.Windows.Forms.ComboBox();
            this.pb_novoAluno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_enviar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Location = new System.Drawing.Point(275, 302);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(90, 23);
            this.btn_enviar.TabIndex = 3;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_Resp
            // 
            this.txt_Resp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Resp.Location = new System.Drawing.Point(210, 224);
            this.txt_Resp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Resp.Name = "txt_Resp";
            this.txt_Resp.Size = new System.Drawing.Size(236, 20);
            this.txt_Resp.TabIndex = 5;
            // 
            // cb_PergEsq
            // 
            this.cb_PergEsq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_PergEsq.FormattingEnabled = true;
            this.cb_PergEsq.Items.AddRange(new object[] {
            "Qual o nome da sua mãe?",
            "Qual sua cidade natal?"});
            this.cb_PergEsq.Location = new System.Drawing.Point(156, 152);
            this.cb_PergEsq.Margin = new System.Windows.Forms.Padding(2);
            this.cb_PergEsq.Name = "cb_PergEsq";
            this.cb_PergEsq.Size = new System.Drawing.Size(343, 21);
            this.cb_PergEsq.TabIndex = 6;
            // 
            // pb_novoAluno
            // 
            this.pb_novoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_novoAluno.BackColor = System.Drawing.Color.Transparent;
            this.pb_novoAluno.Image = ((System.Drawing.Image)(resources.GetObject("pb_novoAluno.Image")));
            this.pb_novoAluno.Location = new System.Drawing.Point(610, 394);
            this.pb_novoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.pb_novoAluno.Name = "pb_novoAluno";
            this.pb_novoAluno.Size = new System.Drawing.Size(45, 34);
            this.pb_novoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_novoAluno.TabIndex = 17;
            this.pb_novoAluno.TabStop = false;
            // 
            // Esqueci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 428);
            this.Controls.Add(this.pb_novoAluno);
            this.Controls.Add(this.cb_PergEsq);
            this.Controls.Add(this.txt_Resp);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Esqueci";
            this.Text = "HOPE Esqueci a senha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novoAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_Resp;
        private System.Windows.Forms.ComboBox cb_PergEsq;
        private System.Windows.Forms.PictureBox pb_novoAluno;
    }
}