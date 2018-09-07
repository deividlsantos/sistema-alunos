using Sistema_Alunos.DAO;
using Sistema_Alunos.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Alunos.view
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoDAO alunoBD = new AlunoDAO();
                Aluno alunoReg = new Aluno(txtNome.Text, txtEnd.Text, int.Parse(txtIdade.Text));

                alunoBD.IncluirAluno(alunoReg);
                txtNome.Text = "";
                txtEnd.Text = "";
                txtIdade.Text = "";
                MessageBox.Show("Registo salvo com sucesso.");
            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoDAO alunoBD = new AlunoDAO();
                Aluno alunoReg = new Aluno(int.Parse(txtCod.Text),txtNome.Text, txtEnd.Text, int.Parse(txtIdade.Text));

                alunoBD.Alterar(alunoReg);
                txtNome.Text = "";
                txtEnd.Text = "";
                txtIdade.Text = "";
                MessageBox.Show("Registro Alterado com Sucesso!");

            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }

            Form1 abre = new Form1();
            abre.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void carregaDados()
        {
            AlunoDAO alunoBD = new AlunoDAO();

            txtCod.Text = "";
            txtNome.Text = "";
            txtEnd.Text = "";
            txtIdade.Text = "";
            txtCod.Focus();

            dgvAlunos.DataSource = alunoBD.getAluno();
        }
    }
}
