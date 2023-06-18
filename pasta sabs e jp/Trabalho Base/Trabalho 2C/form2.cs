using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2C
{
    public partial class form2 : Form
    {
        string diretorioAtual;
        public form2()
        {
            InitializeComponent();
            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioAtual += @"\..\..\..\Questões\";
            string[] diretorios = Directory.GetDirectories(diretorioAtual);
            for (int i = 0; i < diretorios.Length; i++)
            {
                string nomeDaDisciplina = diretorios[i].Remove(0, diretorioAtual.Length);
                cmbDisciplinas.Items.Add(nomeDaDisciplina);
            }
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = diretorioAtual + cmbDisciplinas.Text + @"\exercicio 1";
            if (cmbDisciplinas.Text != "")
            {
                int num = 1;
                if (!(txten.Text == "" || txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "" || txt5.Text == "" || ex.Text == "" || certo.Text == "")
                    && (certo.Text == "A" || certo.Text == "B" || certo.Text == "C" || certo.Text == "D" || certo.Text == "E"))
                {


                    for (int i = 0; true; i++)
                    {
                        if (File.Exists(path + ".txt"))
                        {
                            path = diretorioAtual + cmbDisciplinas.Text + @"\exercicio ";
                            num += 1;
                            path = path + num;
                        }
                        else
                        {
                            StreamWriter escritor = new StreamWriter(path + ".txt");
                            escritor.WriteLine(txten.Text);
                            escritor.WriteLine(txt1.Text);
                            escritor.WriteLine(txt2.Text);
                            escritor.WriteLine(txt3.Text);
                            escritor.WriteLine(txt4.Text);
                            escritor.WriteLine(txt5.Text);
                            escritor.WriteLine(ex.Text);
                            escritor.WriteLine();
                            escritor.WriteLine();
                            escritor.WriteLine(certo.Text);
                            escritor.Close();
                            break;
                        }
                    }
                    MessageBox.Show("enviado com sucesso");
                }
                else
                {
                    MessageBox.Show("INVALIDO, tente novamente");
                }
            }
            else
                MessageBox.Show("materia não encontrada");
        }

        private void certo_TextChanged(object sender, EventArgs e)
        {
            certo.Text = certo.Text.ToUpper();
        }
    }
}
