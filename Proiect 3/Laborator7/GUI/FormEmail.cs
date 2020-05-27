using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormEmail : Form
    {
        public string emailpersonal { get; set; }
        public string parola { get; set; }
        public string emaildestinatar { get; set; }
        public string subiect { get; set; }
        public string mesaj { get; set; }
        public string listaPoz { get; set; }
        public FormEmail(object [] listaPoze)
        {
            InitializeComponent();
            listBox1.Items.AddRange(listaPoze);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] lista = new object[listBox1.SelectedItems.Count];
            listaPoz = "";
            emailpersonal = textBox1.Text;
            parola = textBox2.Text;
            emaildestinatar = textBox4.Text;
            subiect = textBox3.Text;
            mesaj = richTextBox1.Text;
            listBox1.SelectedItems.CopyTo(lista, 0);
            foreach(var optiune in lista)
            {
                listaPoz = listaPoz + optiune.ToString() + ",";
            }
            listaPoz = listaPoz.Remove(listaPoz.Length - 1);

        }
    }
}
