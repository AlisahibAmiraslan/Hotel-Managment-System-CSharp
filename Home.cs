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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void findTotalResAmount()
        {
            string reservText = "reserv";
            Con.Open();
            string query = "SELECT SUM (RoomPrice) FROM RegistrationTbl where CheckIn='" + dateTodayTime + "' and RoomAvailability='" + reservText + "'";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                object result = cmd.ExecuteScalar();
                totalAmountResPrice.Text = Convert.ToString(result) + " $";
            }
            Con.Close();
        }

        private void findTotalCheckInAmount()
        {
            string reservText = "check-in";
            Con.Open();
            string query = "SELECT SUM (RoomPrice) FROM RegistrationTbl where CheckIn='" + dateTodayTime + "' and RoomAvailability='" + reservText + "'";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                object result = cmd.ExecuteScalar();
                totalAmountCheckPrice.Text = Convert.ToString(result) + " $";
            }
            Con.Close();
        }
        private void findTotalAmount()
        {
            Con.Open();
            string query = "SELECT SUM (RoomPrice) FROM RegistrationTbl where CheckIn='" + dateTodayTime + "'";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                object result = cmd.ExecuteScalar();
                totalAmountPricelbl.Text = Convert.ToString(result) + " $";
            }
            Con.Close();
        }
        private void dashbaordExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string dateTodayTime = DateTime.Now.ToString("MM/dd/yyyy 00:00:00");
        public void ListAllTodaysRoom()
        {
            Con.Open();
            string query = "select * from RegistrationTbl where CheckIn='" + dateTodayTime + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            homedgw.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            ListAllTodaysRoom();
            findTotalAmount();
            findTotalCheckInAmount();
            findTotalResAmount();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (filtercbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select availability");
            }
            else
            {
                string filter = filtercbx.SelectedItem.ToString();

                Con.Open();
                string query = "select * from RegistrationTbl where RoomAvailability='" + filter + "' and CheckIn='" + dateTodayTime + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
                var ds = new DataSet();
                adapter.Fill(ds);
                homedgw.DataSource = ds.Tables[0];
                Con.Close();
            }

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            ListAllTodaysRoom();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

    }
}
