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

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        //Escrever
        private void btnEscrever_Click(object sender, EventArgs e)
        {
            string path = @"D:\ProjetosC#\teste.txt";
            StreamWriter write = new StreamWriter(path, true, Encoding.UTF8);//treu aceita adicionar conteudo caso exista
            string linha = textBox1.Text;
            write.WriteLine(linha);

            //write.Flush();
            //write.Dispose();
            write.Close();
        }

        //Ler
        private void btnLerTxt_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string path = @"D:\ProjetosC#\teste.txt";

            StreamReader reader = new StreamReader(path);
            //string txt = reader.ReadToEnd();// lê todo o conteudo

            //Linha por linha
            //string linha = reader.ReadLine();
            //linha += reader.ReadLine();
            //linha += reader.ReadLine();
            //textBox1.Text = linha;

            //Enquanto houver linha
            //string linha = reader.ReadLine();
            //while (linha != null)
            //{
            //    textBox1.Text += linha + "\n";
            //    linha = reader.ReadLine();
            //}

            //ler caracter por caracter
            while (!reader.EndOfStream)
            {
                textBox1.Text += (char)reader.Read();
            }

            reader.Close();
        }

        //Ler Binario
        private void btnLerBinario_Click(object sender, EventArgs e)
        {
            string path = @"D:\ProjetosC#\teste.txt";
            FileStream file = File.OpenRead(path);
            BinaryReader reader = new BinaryReader(file);

            //metodo 1
            //while (reader.BaseStream.Position != reader.BaseStream.Length)
            //{
            //    byte b = reader.ReadByte();
            //    textBox1.Text += (char)b;
            //}

            //metodo 2
            //buffer = reader.ReadBytes((int)reader.BaseStream.Length);
            //foreach  (byte b in buffer)
            //{
            //    textBox1.Text += (char)b;
            //}

            //Metodo 3
            buffer = File.ReadAllBytes(path);


            reader.Close();
        }

        private void btnEscreverBinario_Click(object sender, EventArgs e)
        {
            string path = @"D:\ProjetosC#\testeNovo.txt";
            FileStream file = File.OpenWrite(path);
            BinaryWriter writer = new BinaryWriter(file);
            

            writer.Write(buffer);

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }
    }
}
