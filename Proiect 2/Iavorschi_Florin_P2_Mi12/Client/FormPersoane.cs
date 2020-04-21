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
    public partial class FormPersoane : Form
    {
        public string person { get; set; }
        public FormPersoane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person = textBox1.Text;
        }
    }
}
