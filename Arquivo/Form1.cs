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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Metodos File
        /*File.Existis();
        Existe.Delete():
        File.Create();
        File.Move();
        File.Copy();
        File.WriteAllText();
        File.ReadAllText();*/
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\Arquivos\";
            string arquivo = "teste.txt";

            //verificando se arquivo existe
            //bool res = File.Exists(pasta + arquivo);
            //label1.Text = res.ToString();

            //deletar
            //if (res == true)
            //{
            //    File.Delete(pasta + arquivo);
            //    label1.Text = "Arquivo deletado";
            //}


            //create e fechar arquivo
            //if (!File.Exists(pasta + arquivo))
            //{
            //    File.Create(pasta + arquivo).Close();
            //    label1.Text = "Criado";
            //}
            //else
            //{
            //    MessageBox.Show("Arquivo já existe");
            //}

            //Copy
            //if (File.Exists(pasta + arquivo))
            //{
            //    File.Copy(pasta + arquivo, pasta + "TesteCopia.txt", true); //permite sobre escrita
            //    label1.Text = "Arquivo copiado";
            //}
            //else
            //{
            //    MessageBox.Show("Arquivo não existe");
            //}


            //Move - semelhante ao Copy (recorta)
            //File.Move(pasta + arquivo, pasta + "Movido.txt");


            //WriteAllText
            //File.WriteAllText(pasta + arquivo, "teste de escrita de arquivo", Encoding.Default);

            //ReadAllText
            //label1.Text = File.ReadAllText(pasta + arquivo, Encoding.Default);

        }
    }
}
