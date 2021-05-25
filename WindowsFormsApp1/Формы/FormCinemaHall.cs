using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1.Формы
{
    [Serializable]
    public partial class FormCinemaHall : Form
    {        
        public int kolPlace = 0;
        public int Cost = 5;
       Button[,] B = new Button[5, 5];
        
        public FormCinemaHall()
        {
            InitializeComponent();
            BtnPlace();           
            for(int i = 0; i < Film.a; i++) {
                cB1.Items.Add(Film.nameOfFilms[i]);
            }
        }
            

        private void BtnPlace()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {                  
                    B[i, j] = new Button();                                       
                    B[i, j].Top = j * 60+20; 
                    B[i, j].Left = i *60+40;
                    B[i, j].Size = new Size(60,60);                    
                    B[i, j].Click += new EventHandler(btn_Click);
                    B[i, j].Tag = j * 10 + i;                   
                    B[i, j].FlatAppearance.BorderSize=0;
                    B[i,j].BackColor=Color.Green;
                    this.Controls.Add(B[i, j]);
                }
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            int index = (int)(sender as Button).Tag;
            int i = index % 10;//строка
            int j = index / 10;//столбец
            B[i, j].Enabled = false;
            B[i, j].BackColor = Color.Red;
            B[i, j].Text = ("Ряд:"+( j + 1),"Место:"+( i + 1)).ToString();
            lblPlace.Text += B[i, j].Text ;          
            PlaceKol();
            Price();
        }            
        private void PlaceKol()
        {
            kolPlace++;
            lblKol.Text = "Занято мест: " + kolPlace.ToString();
            if (kolPlace > 25)
            {
                kolPlace--;
                MessageBox.Show("Все места заняты",
                    "Система бронировавания",
                    MessageBoxButtons.OKCancel);
            }
        }
        private void Price()
        {
            int g = Cost * kolPlace;
            lblPrice.Text=g.ToString();
        }
        private void BtnColor()
        {
            btnPrint.BackColor = ThemeColor.PrimaryColor;
            btnPrint.ForeColor = Color.White;
            btnPrint.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            cB1.BackColor = ThemeColor.PrimaryColor;
            cB1.ForeColor = Color.White;
            cB2.BackColor= ThemeColor.PrimaryColor;
            cB2.ForeColor = Color.White;
            textBox1.BackColor = ThemeColor.PrimaryColor;
            textBox1.ForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground=ThemeColor.PrimaryColor;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
        }      
        private void FormCinemaHall_Load(object sender, EventArgs e)
        {
            BtnColor();
        }
        private void Serialization()
        {
            Ticket ticket = new Ticket(cB1.Text, lblPlace.Text, cB2.Text, textBox1.Text, lblPrice.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));            
            Console.WriteLine("Объект создан");
            XmlSerializer formatter = new XmlSerializer(typeof(Ticket));
            using (FileStream fs = new FileStream("ticket.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ticket);
                MessageBox.Show("Успешно напечатан!");
                Console.WriteLine("Объект сериализован");
            }
        }       
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cB1.Text) || string.IsNullOrEmpty(cB2.Text)||string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(lblPlace.Text))
            {
                MessageBox.Show("Заполните все данные");
            }
            else
            {              
                Serialization();               
                
            }
        }
    }
}
