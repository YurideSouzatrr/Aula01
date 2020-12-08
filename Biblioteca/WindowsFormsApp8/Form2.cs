using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        List<Pessoa> pessoas;
        public Form2()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();


            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    }

        private void button6_Click(object sender, EventArgs e)
        {
            string Livrodedoacoes;
            string EfetuarCompra;
            string EmprestimosdeLivros;
            string QuantidadedeLivros;
            string QuantidadedeExemplares;

           Livrodedoacoes = label1.Text;
           EfetuarCompra = textBox1.Text;
           EmprestimosdeLivros = textBox2.Text;
           QuantidadedeLivros = textBox3.Text;
           QuantidadedeExemplares = textBox4.Text;


            MessageBox.Show("Nome:" + Livrodedoacoes);
            MessageBox.Show("Compra:" + EfetuarCompra);
            MessageBox.Show("Emprestimo:" + EmprestimosdeLivros);
            MessageBox.Show("Quantidade:" + QuantidadedeLivros);
            MessageBox.Show("Quantidade:" + QuantidadedeExemplares);


            Form3 OutroForm = new Form3();
            OutroForm.ShowDialog();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
