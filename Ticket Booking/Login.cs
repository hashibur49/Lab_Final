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
    public partial class Login : Form
    {
        public static string UserName, Password;
        public Login()
        {
            InitializeComponent();
        }

        public void Log ()
        {
            if (UserName == Signup.userid && Password == Signup.pass)
            {
                Booking bk = new Booking();
                bk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Your Information!!");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            UserName = userName.Text;
            Password = passWord.Text;

            Log();
           
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signup up = new Signup();
            up.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Booking_Ticket bt = new Booking_Ticket();
            bt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userName.Text = "";
            passWord.Text="";
        }
    }
}
