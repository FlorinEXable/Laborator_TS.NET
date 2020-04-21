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
    public partial class FormVerificareStergere : Form
    {
        InterfacePhotoClient ip = new InterfacePhotoClient();
        string calepoza;
        public FormVerificareStergere(string cale)
        {
            InitializeComponent();
            richTextBox1.Text = "Fisierul " + cale + " nu a mai fost gasit. Fisierul este mutat sau sters?";
            calepoza = cale;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ip.SchimbareCale(calepoza, openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ip.DeletePhoto(calepoza);
        }
    }
}
