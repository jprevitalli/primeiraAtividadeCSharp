using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace primeiraAtividadeCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   //array das minhas imagens
            string[] nomeImagensDosItens = Directory.GetFiles (@"C:\Users\jonat\OneDrive\Área de Trabalho\ProdutosPP");

            //para cada imagem dentro do array
            foreach (string img in nomeImagensDosItens)
            {   
                // Colocar 2 barras para o separador na barra
                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[6].Split('.');
                
                // testando
                //MessageBox.Show(nomeSelecionado[0]);

                if(comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\jonat\OneDrive\Área de Trabalho\ProdutosPP\" + comboBox2.Text + ".jpeg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if(comboBox1.Text == "BOLEIRAS")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("BOLEIRA AMARELA");
                comboBox2.Items.Add("BOLEIRA VERMELHA");
            }
            else if(comboBox1.Text == "PORTA-DOCES")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("PORTA-DOCES MICKEY");
                comboBox2.Items.Add("PORTA-DOCES PRETA");
            }
            else if (comboBox1.Text == "ROCAMBOLEIRA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ROCAMBOLEIRA VERMELHA");
                comboBox2.Items.Add("ROCAMBOLEIRA AMARELA");

            }
            else if (comboBox1.Text == "BOLO-FAKE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("BOLO-FAKE BATIZADO");
                comboBox2.Items.Add("BOLO-FAKE AVENGERS");
            }
            else if (comboBox1.Text == "VASOS")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("VASO MADEIRA");
                comboBox2.Items.Add("VASO AMARELO");
            }
            else if (comboBox1.Text == "PAINEL")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("PAINEL MURO INGLES");
                comboBox2.Items.Add("PAINEL MADEIRA");
            }
            else if (comboBox1.Text == "MESA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("MESA CAVALETE");
                comboBox2.Items.Add("MESA ARABESCO");
            }
            else if (comboBox1.Text == "TAPETES")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TAPETE PERSA");
                comboBox2.Items.Add("TAPETE GRAMA SINTETICA");
            }

        }
    }
}
