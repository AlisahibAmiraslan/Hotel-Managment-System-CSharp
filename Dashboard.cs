using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        string dateTodayTime = DateTime.Now.ToString("MM/dd/yyyy 00:00:00");
        private void ListCheckInCustomers()
        {
            string roomCond = "check-in";
            Con.Open();
            string query = "select Count(*) from RegistrationTbl where CheckIn='" + dateTodayTime + "' and RoomAvailability='"+ roomCond + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            checkInDashData.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void ListReservationsRooms()
        {
            string roomCond = "reserv";
            Con.Open();
            string query = "select Count(*) from RegistrationTbl where CheckIn='" + dateTodayTime + "' and RoomAvailability='" + roomCond + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            reservDashData.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void ListCheckOutCustomers()
        {
            Con.Open();
            string query = "select Count(*) from CheckOutTbl where CheckOutTime='" + dateTodayTime + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            checkOutDashData.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void dashbaordExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnDashLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
            this.Hide();
        }

        private void btnDashRoom_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();

            rooms.Show();
            this.Hide();
        }

        private void btnDashRegistration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();

            registration.Show();
            this.Hide();
        }

        private void btnDashAllRegistration_Click(object sender, EventArgs e)
        {
            ShowAllRegistration registration = new ShowAllRegistration();
            registration.Show();
            this.Hide();
        }

        private void btnDashHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void showCheckOutBtn_Click(object sender, EventArgs e)
        {
            AllCheckOuts allCheckOut = new AllCheckOuts();
            allCheckOut.Show();
            this.Hide();
        }

        private void btnDashCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ListCheckInCustomers();
            ListReservationsRooms();
            ListCheckOutCustomers();
        }
    }
}
