using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Формы
{
    public partial class FormAddFilm : Form
    {
        public FormAddFilm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFilm();
            Film.a++;
        }
        private void AddFilm()
        {
            Film.nameOfFilms.Add(textBox1.Text);
            Film.description.Add(textBox2.Text);
            Film.image.Add(textBox3.Text);
            MessageBox.Show("Успешно добавлено!");           
        }
    }
}
