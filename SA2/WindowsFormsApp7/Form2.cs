using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Declarando variáveis
            string nomedareceita;


            nomedareceita = textBox1.Text;
            string tempodepreparacao;
             int graudepreparacao;
             int  numerodepessoas;
            string categorias;
            string descricao;
            string ingredientes;


            tempodepreparacao = textBox2.Text;
            graudepreparacao = Convert.ToInt32(comboBox2.Text);
            numerodepessoas = Convert.ToInt32(comboBox3.Text);
            categorias = comboBox1.Text;
            descricao = textBox3.Text;
            ingredientes = textBox4.Text;
             
            // Declarando valor a variável e botão
            MessageBox.Show(" Nome da Receita: Cadastrado " + nomedareceita);
            MessageBox.Show("Tempo de Preparacao: " + tempodepreparacao);
            MessageBox.Show(" Grau de Preparacao:  Médio " + graudepreparacao);
            MessageBox.Show(" Número de Pessoas: " + numerodepessoas);
            MessageBox.Show(" Categorias :" + categorias);
            MessageBox.Show("Descrição:" + descricao);
            MessageBox.Show("Ingredientes" + ingredientes);

            Form3 OutroForm = new Form3();
            OutroForm.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Médio");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("(Carne, Peixe, Marisco, Pastelaria, Sobremesas,");
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}