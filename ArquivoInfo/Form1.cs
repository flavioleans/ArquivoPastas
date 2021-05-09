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

namespace ArquivoInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //CLASSE FILEINFO
        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            FileInfo info = new FileInfo(@"D:\ProjetosC#\teste.txt");
            lista.Items.Add(info.FullName);
            lista.Items.Add(info.Name);
            lista.Items.Add(info.Extension);
            lista.Items.Add(info.Directory.FullName);
            lista.Items.Add(info.Directory.Name);
            lista.Items.Add(info.Exists);
            lista.Items.Add(info.LastAccessTime);
            lista.Items.Add(info.Length);
        } 
    }
}
