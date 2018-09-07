using Sistema_Alunos.DAO;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text =="" || txtSenha.Text == "")
            {
                MessageBox.Show("Digite um usuario e senha!");
            }
            else
            {
                try
                {
                    LoginDAO loginBD = new LoginDAO();

                    if(loginBD.logar(login: txtUsuario.Text, senha: txtSenha.Text))
                    {
                        this.Close();
                        Form3 abre = new Form3();
                        abre.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha invalidos!");
                        Close();
                    }
                }

                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
