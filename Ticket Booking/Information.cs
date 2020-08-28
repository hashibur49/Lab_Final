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
    public partial class Information: Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            fisrtnamLbl.Text = Booking.FirstName;
            lastnamLbl.Text = Booking.LastName;
            fullNamlbl.Text = Booking.FirstName + " " + Booking.LastName;

            toLbl.Text = Booking.To;
            fromLbl.Text = Booking.From;

            startTripdatelbl.Text = Booking.StartTripDate;
            endTripLbl.Text = Booking.EndTripDate;

            tripLbl.Text = Booking.StartTripDate + " To " + Booking.EndTripDate;

            docNlbl.Text = Booking.DocumentNo;
            docissulbl.Text = Booking.IssueDate;
            docexpLbl.Text = Booking.ExpareDate;
            bagLbl.Text = Booking.Baggage;

            if (Booking.passport)
            {
                idocNolbl.Text = "Passport No:";
                idocIssueLbl.Text = "Passport Issue Date: ";
                idocExpirelbl.Text = "Passport Expire Date: ";
            }
            if (Booking.nid)
            {
                idocNolbl.Text = "NID Card No:";
                idocIssueLbl.Text = "NID Card Issue Date: ";
                idocExpirelbl.Text = "NID Card Expire Date: ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Confirmation con = new Confirmation();
            con.Show();
            this.Hide();
        }
    }
}
