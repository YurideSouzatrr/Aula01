using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection objcon = new MySqlConnection("server=Root;3301; User Id=Root database=livraria;");

                // Iniciando o Banco 

                objcon.Open();
                MessageBox.Show("Conectado");
                //Fechando 
                objcon.Close();
            }
            catch
            {

            }

            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();

        
               
            }
        }
    }
}
}