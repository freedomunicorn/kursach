using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1.Формы
{
    public partial class FormTicket : Form
    {
        public FormTicket()
        {
            InitializeComponent();
        }
        private void FormTicket_Load(object sender, EventArgs e)
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
            panel1.BackColor = ThemeColor.PrimaryColor;
        }     
        private void Deserialize()
        {
            string name;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "xml files(*.xml|*.xml|All files(*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK);
                {
                    name = openFileDialog.FileName;
                }
            }
            XmlSerializer formatter = new XmlSerializer(typeof(Ticket));
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {

                Ticket newTicket = (Ticket)formatter.Deserialize(fs);
                label9.Text = newTicket.Nameoffilms;
                label11.Text = newTicket.Numbplace;
                label12.Text = newTicket.Fio;
                label10.Text = newTicket.Time;
                label13.Text = newTicket.Price;
                label8.Text = newTicket.Date;
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Deserialize();
        }
    }
}
