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

            else if (listBox1.Items.Contains(usuario)) //ele vai verificar se o usuario ja esta na list box 
            {
                MessageBox.Show("O nome de usuário já existe.");
            }

            else
            {
                MessageBox.Show("Nome de usuário válido.");
                listBox1.Items.Add(usuario);

            }

            txtusuario.Clear();



        }

        private void button2_Click(object sender, EventArgs e)

        {

            string usuario = txtusuario.Text;

            if (listBox1.SelectedIndex != -1)
            {

                int tamanhoMinino = 3;
                if (usuario.Length < tamanhoMinino)
                {
                    MessageBox.Show("O nome de usuário deve ter pelo menos 3 caracteres.");
                }

                else
                {
                   
                    MessageBox.Show("Nome de usuário válido.");
                    listBox1.Items[listBox1.SelectedIndex] = usuario;

                }


            }
            else 
            {
                MessageBox.Show("Selecione um item para editar.");
            }

            txtusuario.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;

            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }

            txtusuario.Clear();
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
