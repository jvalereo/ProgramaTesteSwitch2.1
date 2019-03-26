using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaTesteSwitch2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CboSemanas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aula teste como usar o comando Switch
            // Jonas Valereo Técnico em Informáica

            //Declarando o codigo e comando Switch

            switch (CboSemanas.Text)
            {
                case "Domingo":
                    MessageBox.Show("O dia da semana hoje é Domingo", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Segunda-feira":
                    MessageBox.Show("O dia da semana hoje é Segunda-feira", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Terça-feira":
                    MessageBox.Show("O dia da semana hoje é Terça-feira", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Quarta-feira":
                    MessageBox.Show("O dia da semana hoje é Quarta-feira", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Quinta-feira":
                    MessageBox.Show("O dia da semana hoje é Quinta-feira", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Sexta-feira":
                    MessageBox.Show("O dia da semana hoje é Sexta-feira", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Sábado":
                    MessageBox.Show("O dia da semnha hoje é Sábado", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                    //fim do programa 
            }

        }

        private void BtnAvanca_Click(object sender, EventArgs e)
        {
            //Declarando o objeto  tipo teste  form2

            Form2 teste = new Form2();

            // Chamar o from2 através do metodo show 
            teste.Show();

            //fechar o form atual 

            this.Visible = false;


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair

            Close();

        }

      
    }
}
