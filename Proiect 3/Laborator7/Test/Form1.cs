using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosV2
{
    public partial class Form1 : Form
    {
        PhotosAPI papi = new PhotosAPI();
        public Form1()
        {
            InitializeComponent();
            label7.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            List<string> lista = papi.GetNames();
            foreach (var s in lista)
            {
                if(!(File.Exists(s)))
                {
                    using (FormVerificareStergere form2 = new FormVerificareStergere(s))
                    {
                        if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            listBox1.Items.Clear();
                        }
                    }
                }
            }
            lista = papi.GetNames();
            foreach (var s in lista)
            {
                listBox1.Items.Add(s);
            }
        }

        private void buttonIncarcarePoza_Click(object sender, EventArgs e)
        {
            string cale = "";
            string[] persoane;
            string[] extensii_poze = { "png", "jpg", "jpeg", "bmp" };
            string[] extensii_video = { "mp4", "MOV", "mp3", "avi" };
            openFileDialog1.Title = "Alege fisierul dorit";
            openFileDialog1.Filter = "Visual files|*.jpg;*.jpeg;*.png;*.bmp;*.mp4;*.mp3;*.avi;*.MOV";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cale = openFileDialog1.FileName;
                if(extensii_poze.Contains(openFileDialog1.FileName.Split('.').Last()))
                {
                    axWindowsMediaPlayer1.Visible = false;
                    axWindowsMediaPlayer1.URL = null;
                    pictureBox1.Visible = true;
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                }
                else if(extensii_video.Contains(openFileDialog1.FileName.Split('.').Last()))
                {
                    pictureBox1.Visible = false;
                    pictureBox1.ImageLocation = null;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
            }
            if (papi.PhotoExist(cale) == 1)
            {
                textBox2.Text = papi.GetEveniment(cale);
                textBox3.Text = papi.GetLoc(cale);
                textBox1.Text = papi.GetNume(cale);
                dateTimePicker1.Value = papi.GetDataCrearii(cale);
                if (papi.GetPersoane(cale) is null)
                {
                    listBox2.Items.Clear();
                }
                else
                {
                    persoane = papi.GetPersoane(cale).Split(',');
                    for (int i = 0; i < persoane.Length; i++)
                    {
                        listBox2.Items.Add(persoane[i]);
                    }
                }
            }
            else
            {
                textBox2.Text = null;
                textBox3.Text = null;
                textBox1.Text = papi.GetNume(cale);
                dateTimePicker1.Value = DateTime.Today;
                listBox2.Items.Clear();
            }
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null)
            {
                string persoane = "";
                for(int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.SetSelected(i, true);
                    persoane = persoane + listBox2.SelectedItem.ToString() + ",";
                }
                papi.AddPhoto(pictureBox1.ImageLocation, dateTimePicker1.Value.Date, textBox2.Text, textBox3.Text, persoane);
                listBox1.Items.Clear();
                List<string> lista = papi.GetNames();
                foreach (var s in lista)
                {
                    listBox1.Items.Add(s);
                }
            }
            else if (axWindowsMediaPlayer1.URL != null)
            {
                string persoane = "";
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox2.SetSelected(i, true);
                    persoane = persoane + listBox2.SelectedItem.ToString() + ",";
                }
                papi.AddPhoto(axWindowsMediaPlayer1.URL, dateTimePicker1.Value.Date, textBox2.Text, textBox3.Text, persoane);
                listBox1.Items.Clear();
                List<string> lista = papi.GetNames();
                foreach (var s in lista)
                {
                    listBox1.Items.Add(s);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] extensii_poze = { "png", "jpg", "jpeg", "bmp" };
            string[] extensii_video = { "mp4", "MOV", "mp3", "avi" };
            string cale = "";
            cale = listBox1.SelectedItem.ToString();
            if (extensii_poze.Contains(cale.Split('.').Last()))
            {
                if (!(listBox1.SelectedItem is null))
                {
                    if(pictureBox1.ImageLocation is null)
                    {
                        axWindowsMediaPlayer1.Visible = false;
                        axWindowsMediaPlayer1.URL = null;
                        pictureBox1.Visible = true;
                        pictureBox1.ImageLocation = listBox1.SelectedItem.ToString();
                    }
                    string[] persoane;
                    pictureBox1.ImageLocation = listBox1.SelectedItem.ToString();
                    textBox2.Text = papi.GetEveniment(pictureBox1.ImageLocation);
                    textBox3.Text = papi.GetLoc(pictureBox1.ImageLocation);
                    textBox1.Text = papi.GetNume(pictureBox1.ImageLocation);
                    dateTimePicker1.Value = papi.GetDataCrearii(pictureBox1.ImageLocation);
                    if (papi.GetPersoane(pictureBox1.ImageLocation) is null)
                    {
                        listBox2.Items.Clear();
                    }
                    else
                    {
                        listBox2.Items.Clear();
                        persoane = papi.GetPersoane(pictureBox1.ImageLocation).Split(',');
                        for (int i = 0; i < persoane.Length; i++)
                        {
                            listBox2.Items.Add(persoane[i]);
                        }
                    }
                }
            }
            else if (extensii_video.Contains(cale.Split('.').Last()))
            {
                if (!(listBox1.SelectedItem is null))
                {
                    pictureBox1.Visible = false;
                    pictureBox1.ImageLocation = null;
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    string[] persoane;
                    axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();
                    textBox2.Text = papi.GetEveniment(axWindowsMediaPlayer1.URL);
                    textBox3.Text = papi.GetLoc(axWindowsMediaPlayer1.URL);
                    textBox1.Text = papi.GetNume(axWindowsMediaPlayer1.URL);
                    dateTimePicker1.Value = papi.GetDataCrearii(axWindowsMediaPlayer1.URL);
                    if (papi.GetPersoane(axWindowsMediaPlayer1.URL) is null)
                    {
                        listBox2.Items.Clear();
                    }
                    else
                    {
                        listBox2.Items.Clear();
                        persoane = papi.GetPersoane(axWindowsMediaPlayer1.URL).Split(',');
                        for (int i = 0; i < persoane.Length; i++)
                        {
                            listBox2.Items.Add(persoane[i]);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormPersoane form2 = new FormPersoane())
            {
                if(form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    listBox2.Items.Add(form2.person);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!(comboBox1.SelectedItem is null))
            {
                if (comboBox1.SelectedItem.ToString() == "Eveniment")
                {
                    listBox1.Items.Clear();
                    List<string> lista = papi.GetEvenimentList(textBox4.Text);
                    foreach (var s in lista)
                    {
                        listBox1.Items.Add(s);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Persoana")
                {
                    listBox1.Items.Clear();
                    List<string> lista = papi.GetPersoanaList(textBox4.Text);
                    foreach (var s in lista)
                    {
                        listBox1.Items.Add(s);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Loc")
                {
                    listBox1.Items.Clear();
                    List<string> lista = papi.GetLocList(textBox4.Text);
                    foreach (var s in lista)
                    {
                        listBox1.Items.Add(s);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Toate pozele")
                {
                    listBox1.Items.Clear();
                    List<string> lista = papi.GetNames();
                    foreach (var s in lista)
                    {
                        listBox1.Items.Add(s);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Data Crearii")
                {
                    listBox1.Items.Clear();
                    List<string> lista = papi.GetDataCreariiList(textBox4.Text);
                    foreach (var s in lista)
                    {
                        listBox1.Items.Add(s);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pictureBox1.ImageLocation != null && papi.PhotoExist(pictureBox1.ImageLocation) != 0)
            {
                papi.DeletePhoto(pictureBox1.ImageLocation);
                listBox1.Items.Clear();
                List<string> lista = papi.GetNames();
                foreach (var s in lista)
                {
                    listBox1.Items.Add(s);
                }
                listBox1.SetSelected(0, true);
            }
            else if(axWindowsMediaPlayer1.URL != null && papi.PhotoExist(axWindowsMediaPlayer1.URL) != 0)
            {
                papi.DeletePhoto(axWindowsMediaPlayer1.URL);
                listBox1.Items.Clear();
                List<string> lista = papi.GetNames();
                foreach (var s in lista)
                {
                    listBox1.Items.Add(s);
                }
                listBox1.SetSelected(0, true);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Data Crearii")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(!(pictureBox1.ImageLocation == null))
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument photo = new PrintDocument();
                photo.PrintPage += PhotoPrintPage;
                pd.Document = photo;
                if (pd.ShowDialog() == DialogResult.OK)
                    photo.Print();
            }
        }

        private void PhotoPrintPage(object sender, PrintPageEventArgs e)
        {
            Image imagine = Image.FromFile(pictureBox1.ImageLocation);
            Bitmap bm = new Bitmap(imagine.Width, imagine.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, imagine.Width, imagine.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            object[] listaPoze = new object[listBox1.Items.Count];
            string[] listaPoz;
            listBox1.Items.CopyTo(listaPoze, 0);
            using (FormEmail form2 = new FormEmail(listaPoze))
            {
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient();

                        mail.From = new MailAddress(form2.emailpersonal);
                        mail.To.Add(new MailAddress(form2.emaildestinatar));
                        mail.Subject = form2.subiect;
                        mail.Body = form2.mesaj;

                        System.Net.Mail.Attachment attachment;
                        listaPoz = form2.listaPoz.Split(',');
                        foreach (var poza in listaPoz)
                        {
                            attachment = new System.Net.Mail.Attachment(poza);
                            mail.Attachments.Add(attachment);
                        }

                        SmtpServer.EnableSsl = true;
                        //SmtpServer.UseDefaultCredentials = false;
                        SmtpServer.Credentials = new System.Net.NetworkCredential(form2.emailpersonal, form2.parola);
                        SmtpServer.Host = "smtp.gmail.com";
                        SmtpServer.Port = 587;

                        SmtpServer.Send(mail);
                        MessageBox.Show("mail Send");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
