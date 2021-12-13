using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Desafio1.Classes;

namespace Desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();

            pessoa.Nome = txbNome.Text;
            pessoa.Telefone = txbTelefone.Text;
            pessoa.Cidade = TxbCidade.Text;
            pessoa.Rg = txbRg.Text;
            pessoa.Cpf = txbCpf.Text;
            pessoa.NomeCurso = txbNomeCurso.Text;

            
                bool retorno = pessoa.gravarPessoa();

                if (retorno)
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Falha ao gravar!");
            }

           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txbNomeCurso.Enabled = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            txbNome.Text = null;
            txbTelefone.Text = null;
            TxbCidade.Text = null;
            txbRg.Text = null;
            txbCpf.Text = null;
            txbNomeCurso.Text = null;
            checkBox1.Checked = false;
            txbNomeCurso.Enabled = false;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            banco Banco = new banco();

            string sql = "select * from Pessoas";

            DataTable dt = new DataTable();

            dt = Banco.executarConsulta(sql);

            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            banco bd = new banco();

            string sql = "select * from Pessoas where NomeCurso != ''";

            DataTable dt = new DataTable();

            dt = bd.executarConsulta(sql);

            dataGridView1.DataSource = dt;

        }

       
    }
}
