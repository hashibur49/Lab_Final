using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Booking
{
    public partial class Booking : Form
    {
        public static string To, From, FirstName, LastName, 
        StartTripDate, EndTripDate, DocumentNo, IssueDate, ExpareDate, Baggage;
        public static Boolean passport;
        public static Boolean nid;
        public Booking()
        {
            InitializeComponent();
        }

        private void passportRdb_CheckedChanged(object sender, EventArgs e)
        {
            if(passportRdb.Checked)
            {
                docIssueLbl.Text = "Passport Issue Date:";
                docExpirelbl.Text = "Passport Expire Date:";
                docNolbl.Text = "Passport No:";
                passport = true;
            }
            else
            {
                passport = false;
            }
        }

        private void nidRdb_CheckedChanged(object sender, EventArgs e)
        {
            if (nidRdb.Checked)
            {
                docIssueLbl.Text = "NID Card Issue Date:";
                docExpirelbl.Text = "NID Card Expire Date:";
                docNolbl.Text = "NID Card No:";
                nid = true;
            }
            else
            {
                nid = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //monthCalendar.MaxSelectionCount = 100;
            //monthCalendar.ShowToday = true;

            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            To = toTextbox.Text;
            From = formTextbox.Text;

            StartTripDate = monthCalendar.SelectionStart.ToString("dd MMM yyyy");
            EndTripDate = monthCalendar1.SelectionEnd.ToString("dd MMM yyyy");

            FirstName = fnametextBox.Text;
            LastName = lnametextBox.Text;
            DocumentNo = docnotextBox.Text;

            IssueDate = dateTimePicker1.Value.ToString("dd MMM yyyy");
            ExpareDate = dateTimePicker2.Value.ToString("dd MMM yyyy");

            Baggage = numericUpDown1.Value.ToString();

            Information info = new Information();
            info.Show();
            this.Hide();
        }
    }
}
