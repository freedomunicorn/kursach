using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Collections;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Http;
using AngleSharp.Dom;

namespace WindowsFormsApp1.Формы
{
    public partial class FormFilm : Form
    {
       //public List<string> nameOfFilms = new List<string>();
       // public List<string> description = new List<string>();
       // public List<string> image = new List<string>();
        int count = 0;
        //string[] nameOfFilms =
        //{
        //    "1+1","Волк с Уолл Стрит","Дело храбрых"
        //};
        //string[] description = {
        //    "Пострадав в результате несчастного случая, богатый \nаристократ Филипп нанимает в помощники человека,\nкоторый менее всего подходит для этой работы,– \nмолодого жителя предместья Дрисса, только что \nосвободившегося из тюрьмы.Несмотря на то, что \nФилипп прикован к инвалидному креслу,Дриссу удается \nпривнести в размеренную жизнь аристократа дух \nприключений.","1987 год.Джордан Белфорт становится брокером\nв успешном инвестиционном банке.Вскоре\nбанк закрывается после внезапного обвала\nиндекса Доу-Джонса.По совету жены\nТерезы Джордан устраивается в небольшое заведение,\nзанимающееся мелкими акциями.Его настойчивый\nстиль общения с клиентами и врождённая харизма\nбыстро даёт свои плоды.", "Действие разворачивается в небольшом провинциальном\nгородке Прескотт, расположенном в штате\nАризона.Группа лесных пожарных, работающих\nне один год, усиленно готовится\nк сертификации.Получение высшего разряда\nсделает отважных парней элитной командой,\nимеющей возможность работать на территории\nвсей страны."
        //};

        public FormFilm()
        {
            InitializeComponent();
        }

        private void FormFilm_Load(object sender, EventArgs e)
        {
            LoadTheme();
          

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count < Film.a-1)
            {
                count++;
            }
            pictureBox1.ImageLocation = Film.image[count];
            lblNameOfFilm.Text = Film.nameOfFilms[count];
            lblDescription.Text = Film.description[count];           
        } 
        
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            pictureBox1.ImageLocation = Film.image[count];
            lblNameOfFilm.Text = Film.nameOfFilms[count];
            lblDescription.Text = Film.description[count];
        } 
        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            FormAddFilm formAddFilm = new FormAddFilm();
            formAddFilm.Show();
        }
    }
}
