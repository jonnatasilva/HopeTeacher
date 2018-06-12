using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeProfessor
{
    public partial class ExibeRelatorio : Form
    {
        private PictureBox pb_novoAluno;
        private TextBox txt_relatorio;
        private PictureBox pictureBox1;
    
        public ExibeRelatorio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibeRelatorio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_novoAluno = new System.Windows.Forms.PictureBox();
            this.txt_relatorio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pb_novoAluno
            // 
            this.pb_novoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_novoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.pb_novoAluno.Image = ((System.Drawing.Image)(resources.GetObject("pb_novoAluno.Image")));
            this.pb_novoAluno.Location = new System.Drawing.Point(828, 522);
            this.pb_novoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.pb_novoAluno.Name = "pb_novoAluno";
            this.pb_novoAluno.Size = new System.Drawing.Size(45, 34);
            this.pb_novoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_novoAluno.TabIndex = 16;
            this.pb_novoAluno.TabStop = false;
            this.pb_novoAluno.Click += new System.EventHandler(this.pb_novoAluno_Click);
            // 
            // txt_relatorio
            // 
            this.txt_relatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_relatorio.Location = new System.Drawing.Point(295, 171);
            this.txt_relatorio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_relatorio.Multiline = true;
            this.txt_relatorio.Name = "txt_relatorio";
            this.txt_relatorio.Size = new System.Drawing.Size(296, 227);
            this.txt_relatorio.TabIndex = 17;
            // 
            // ExibeRelatorio
            // 
            this.ClientSize = new System.Drawing.Size(886, 569);
            this.Controls.Add(this.txt_relatorio);
            this.Controls.Add(this.pb_novoAluno);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExibeRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novoAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txt_relatorio_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void pb_novoAluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
