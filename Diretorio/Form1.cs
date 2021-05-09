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

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EXISTS
            string path = @"D:\ProjetosC#\";
            //bool res = Directory.Exists(path + "teste");
            //lista.Items.Add(res);

            //if (res == false)
            //{
            //    Directory.CreateDirectory(path + "flavito");
            //}

            //Delete
            //if (res)
            //{
            //    Directory.Delete(path + "flavito");
            //}

            //Move
            //if (res)
            //{
            //    //movendo a pasta movida para dentro da pasta teste
            //    Directory.Move(path + "teste", path + @"destino\testeMovido");

            //}

            //GetDirectory busca todos os diretorios da pasta raiz
            //string[] dirs = Directory.GetDirectories(path);
            //foreach (var item in dirs)
            //{
            //    lista.Items.Add(item);
            //}

            //GetDirectory busca todos os ARQUIVOS da pasta raiz
            //string[] dirs = Directory.GetFiles(path);
            //foreach (var item in dirs)
            //{
            //    lista.Items.Add(item);
            //}

            //GetDirectoryRoot a raiz da pasta
            //string root = Directory.GetDirectoryRoot(path);
            //lista.Items.Add(root);


            //GetLogicalDrivers retornas todas as unidades logicas da maquina
            //string[] drivers = Directory.GetLogicalDrives();
            //lista.Items.AddRange(drivers);

            //GetParent retorna o diretoria pai do path especificado.
            //DirectoryInfo info = Directory.GetParent(path);
            //lista.Items.Add(info.FullName);

            //getCurrentDirectory retorna o diretorio atual, não passar parametro
            //string dirAtual = Directory.GetCurrentDirectory();
            //lista.Items.Add(dirAtual);

        }
    }
}
