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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CboVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //Declarando o objeto  tipo teste  form1

            Form1 teste = new Form1();

            // Chamar o from1 através do metodo show 
            teste.Show();

            //fechar o form2 atual 
            this.Visible = false;


        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            // Aula teste Switch2 
            // Jonas Valere Técnic em Informática

            // Declarando o codigo Switch case, break 

            switch (CboVeiculos.Text)
            {
                case "1 ou 2":
                    lblResultado.Text = "O dia do seu rodizio é Segunda-feira!";
                    break;

                case "3 ou 4":
                    lblResultado.Text = "O dia do seu rodizio é Terça-feira!";
                    break;

                case "5 ou 6":
                    lblResultado.Text = "O dia do seu rodizio é Quarta-feira!";
                    break;

                case "7 ou 8":
                    lblResultado.Text = "O dia do seu rodizio é Quinta-feira!";
                    break;

                case "9 ou 0":
                    lblResultado.Text = "O dia do seu rodizio é Sexta-feira!";
                    break;


            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando codigo limpar tela, combobox, label

            CboVeiculos.Text = " ";
            lblResultado.Text = " ";

        }
    }
}
