using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictures3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            saveFileDialog1.Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var url = textURL.Text;
            picture.ImageLocation = url;
        }

        private void textURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textURL.Text = fileText;
            picture.Image = Image.FromFile(filename);
            MessageBox.Show("Файл открыт");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textURL.Text == "")
            {
                MessageBox.Show("Файл пуст");
                return;
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, textURL.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
