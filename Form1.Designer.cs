
namespace Desafio1
{
    partial class Form1
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
            this.grpCadastro = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txbNomeCurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.TxbCidade = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbTodos = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grbAlunos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbTodos.SuspendLayout();
            this.grbAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.button2);
            this.grpCadastro.Controls.Add(this.btnRefresh);
            this.grpCadastro.Controls.Add(this.txbNomeCurso);
            this.grpCadastro.Controls.Add(this.label7);
            this.grpCadastro.Controls.Add(this.checkBox1);
            this.grpCadastro.Controls.Add(this.label6);
            this.grpCadastro.Controls.Add(this.txbCpf);
            this.grpCadastro.Controls.Add(this.txbRg);
            this.grpCadastro.Controls.Add(this.TxbCidade);
            this.grpCadastro.Controls.Add(this.txbTelefone);
            this.grpCadastro.Controls.Add(this.txbNome);
            this.grpCadastro.Controls.Add(this.label5);
            this.grpCadastro.Controls.Add(this.label4);
            this.grpCadastro.Controls.Add(this.label3);
            this.grpCadastro.Controls.Add(this.label2);
            this.grpCadastro.Controls.Add(this.label1);
            this.grpCadastro.Controls.Add(this.btnCadastrar);
            this.grpCadastro.Location = new System.Drawing.Point(23, 12);
            this.grpCadastro.Name = "grpCadastro";
            this.grpCadastro.Size = new System.Drawing.Size(333, 397);
            this.grpCadastro.TabIndex = 0;
            this.grpCadastro.TabStop = false;
            this.grpCadastro.Text = "Cadastro de Pessoas";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh.Location = new System.Drawing.Point(88, 330);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 27);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txbNomeCurso
            // 
            this.txbNomeCurso.Enabled = false;
            this.txbNomeCurso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbNomeCurso.Location = new System.Drawing.Point(104, 237);
            this.txbNomeCurso.Name = "txbNomeCurso";
            this.txbNomeCurso.Size = new System.Drawing.Size(171, 23);
            this.txbNomeCurso.TabIndex = 14;
            this.txbNomeCurso.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Curso: ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(192, 205);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Sim";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Está fazendo algum curso?";
            // 
            // txbCpf
            // 
            this.txbCpf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbCpf.Location = new System.Drawing.Point(104, 163);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(171, 23);
            this.txbCpf.TabIndex = 10;
            this.txbCpf.UseWaitCursor = true;
            // 
            // txbRg
            // 
            this.txbRg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbRg.Location = new System.Drawing.Point(104, 133);
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(171, 23);
            this.txbRg.TabIndex = 9;
            // 
            // TxbCidade
            // 
            this.TxbCidade.Location = new System.Drawing.Point(104, 100);
            this.TxbCidade.Name = "TxbCidade";
            this.TxbCidade.Size = new System.Drawing.Size(171, 23);
            this.TxbCidade.TabIndex = 8;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(104, 67);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(171, 23);
            this.txbTelefone.TabIndex = 7;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(104, 38);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(171, 23);
            this.txbNome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cpf: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rg: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(88, 291);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(134, 31);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(393, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // grbTodos
            // 
            this.grbTodos.Controls.Add(this.btnConsultar);
            this.grbTodos.Location = new System.Drawing.Point(384, 303);
            this.grbTodos.Name = "grbTodos";
            this.grbTodos.Size = new System.Drawing.Size(182, 104);
            this.grbTodos.TabIndex = 2;
            this.grbTodos.TabStop = false;
            this.grbTodos.Text = "Consultar todas as Pessoas";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(25, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 31);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grbAlunos
            // 
            this.grbAlunos.Controls.Add(this.button1);
            this.grbAlunos.Location = new System.Drawing.Point(595, 305);
            this.grbAlunos.Name = "grbAlunos";
            this.grbAlunos.Size = new System.Drawing.Size(182, 104);
            this.grbAlunos.TabIndex = 3;
            this.grbAlunos.TabStop = false;
            this.grbAlunos.Text = "Consultar Alunos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar Alunos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(88, 367);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
     
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbAlunos);
            this.Controls.Add(this.grbTodos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCadastro.ResumeLayout(false);
            this.grpCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbTodos.ResumeLayout(false);
            this.grbAlunos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.TextBox TxbCidade;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNomeCurso;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grbAlunos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

