using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class menu_cadastro_ciente : Form
    {
        public menu_cadastro_ciente()
        {
            InitializeComponent();
        }

        private void menu_consulta_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro_pacotes fm3 = new menu_cadastro_pacotes();
            fm3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que quê Cancelar?", "???",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(result == System.Windows.Forms.DialogResult.Yes){
                this.Hide();
                menu_cadastro mncadastro = new menu_cadastro();
                mncadastro.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta fm4 = new consulta();
            fm4.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Nome Completo")
            {
                textBox1.Text = "";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "CPF(Só numéros)")
            {
                textBox5.Text = "";
            }

        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Sexo( M ou F)")
            {
                textBox11.Text = "";
            }

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "CEP")
            {
                textBox4.Text = "";
            }

        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Pais de Origem")
            {
                textBox8.Text = "";
            }

        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Data de Nascimento")
            {
                textBox9.Text = "";
            }

        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "DDD")
            {
                textBox10.Text = "";
            }

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "nº Telefone")
            {
                textBox7.Text = "";
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Nome Completo";
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Sexo( M ou F)";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "CPF(Só numéros)";
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "CEP";
            }

        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Pais de Origem";
            }

        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Data de Nascimento";
            }

        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "DDD";
            }

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "nº Telefone";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nome Completo";
            textBox4.Text = "CEP";
            textBox5.Text = "CPF(Só numéros)";
            textBox7.Text = "nº Telefone";
            textBox8.Text = "Pais de Origem";
            textBox9.Text = "Data de Nascimento";
            textBox10.Text = "DDD";
            textBox11.Text = "Sexo( M ou F)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendamento fm5 = new agendamento();
            fm5.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro mncada = new menu_cadastro();
            mncada.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento mnpaga = new pagamento();
            mnpaga.Show();

        }
    }
}
