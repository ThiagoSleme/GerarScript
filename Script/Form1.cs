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
using System.Diagnostics;

namespace Script
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scriptButton_Click(object sender, EventArgs e)
        {
            string _sigla = siglaTextBox.Text;           
            string _estado = estadoTextBox.Text;                       

            if (string.IsNullOrEmpty(_estado))
            {
                errorProvider1.SetError(this.estadoTextBox, "Preemcher o campo");
            }
            else if (!File.Exists($"{_estado}.bat"))
            {
                MessageBox.Show("Arquivo não existe");
            }
            else
            {
                Process.Start($"{_estado}.bat");
                exibeListBox.Items.Add("Comando efetuado com sucesso");
            }
        }
        private void criarServiceButton_Click(object sender, EventArgs e)
        {
            IDictionary<string, int> linha = new Dictionary<string, int>();

            string [] linhas = File.ReadAllLines("dados.txt", Encoding.GetEncoding(1252));

            foreach (string teste in linhas)
            {
                if (string.IsNullOrEmpty(teste))
                {

                }
                else
                {
                    string sigla = siglaTextBox.Text;
                    
                    exibeListBox.Items.Add(linha);
                }
            }
        }
    }
}
