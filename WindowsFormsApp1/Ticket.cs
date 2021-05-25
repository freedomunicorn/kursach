using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Ticket
    {           
        public string Nameoffilms { get; set; }
        public string Numbplace { get; set; }
        public string Time { get; set; }
        public string Fio { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
        public Ticket()
        {

        }
        public Ticket(string nameoffilms, string numbplace, string time, string fio,string price, string date)
        {
            Nameoffilms = nameoffilms;
           Numbplace = numbplace;
            Time = time;
            Fio = fio;
            Price = price;
            Date = date;
        }
    }
}
