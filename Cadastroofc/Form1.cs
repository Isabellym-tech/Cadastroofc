using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Cadastroofc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;

            int tamanhoMinino = 3;
            if (usuario.Length < tamanhoMinino)
            {
                MessageBox.Show("O nome de usuário deve ter pelo menos 3 caracteres.");
            }
            else
            {
                MessageBox.Show("Nome de usuário válido.");
                listBox1.Items.Add($"Usuario cadastrado com sucesso: {usuario}");

            }





        }

        private void button2_Click(object sender, EventArgs e)

        {


            string novoUsuario = txtusuario.Text;
            int tamanhoMinino = 3;



            if (novoUsuario.Length < tamanhoMinino)
            {
                MessageBox.Show("O nome de usuário deve ter pelo menos 3 caracteres.");
                return;
            }


            if (listBox1.SelectedIndex != -1)
            {

                listBox1.Items[listBox1.SelectedIndex] = novoUsuario;
                MessageBox.Show("Nome de usuário editado com sucesso.");
                txtusuario.Clear();

            }


            else
                //{
                //    MessageBox.Show("Nome de usuário inválido.");
                //    txtusuario.Clear();
                listBox1.Items.Add($"Usuario editado com sucesso: {novoUsuario}");
            MessageBox.Show("Novo usuário adicionado com sucesso.");
            txtusuario.Clear();

        }
           
       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) 

            {
                
                string itemSelecionado = listBox1.SelectedItem.ToString();
                txtusuario.Text = itemSelecionado;
            }
        }
    }
}
