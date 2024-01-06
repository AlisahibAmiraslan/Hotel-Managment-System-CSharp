using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagmentSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void dashbaordExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        
       DateTime today;
        private void Registration_Load(object sender, EventArgs e)
        {
            GetAllRooms();
            today = checkIndatedp.Value;
        }

        //checked in time comparison
        private void checkIndatedp_ValueChanged(object sender, EventArgs e)
        {
            if (checkIndatedp.Value.AddDays(1) < DateTime.Now)
            {
                MessageBox.Show("Wrong Date For Reservation");
                checkIndatedp.Value = DateTime.Now;
            }
        }

        //checked out time comparison
        private void checkOutdp_ValueChanged(object sender, EventArgs e)
        {
            if (checkOutdp.Value < checkIndatedp.Value)
            {
                MessageBox.Show("Wrong Date For Reservation");
                checkOutdp.Value = checkIndatedp.Value.AddDays(1);
            }
        }

        // get all rooms from Roomstbl (SQL DATA)
        public void GetAllRooms()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select RoomNumber from RoomsTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNumber", typeof(string));
            dt.Load(rdr);
            roomNumbercbx.ValueMember = "RoomNumber";
            roomNumbercbx.DataSource = dt;
            Con.Close();
        }

        List<string> daysData = new List<string>();
        string checkIn, checkOut;

        // find rezervation time for specific rooms
        private void findRoomNum()
        {
            Con.Open();
            string query = "select * from RegistrationTbl where RoomNumber=" + roomNumbercbx.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                checkIn = dr["CheckIn"].ToString();
                checkOut = dr["CheckOut"].ToString();

                for (DateTime counter = DateTime.Parse(checkIn).AddDays(1); counter <= DateTime.Parse(checkOut); counter = counter.AddDays(1))
                {
                    daysData.Add(counter.ToString("dd/MM/yyyy 00:00:00"));
                }

            }

            Con.Close();
        }
        
        private void roomNumbercbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            findRoomNum();
        }

        // reset all
        private void reset()
        {
            firstNametbx.Text = "";
            lastNametbx.Text = "";
            passprttbx.Text = "";
            phonetbx.Text = "";
            countrycbx.SelectedIndex = -1;
            roomNumbercbx.SelectedIndex = -1;
            roomAvacbx.SelectedIndex = -1;
            roomPricetbx.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void btnshowRezerv_Click(object sender, EventArgs e)
        {
            ShowAllRegistration showAllRegistration = new ShowAllRegistration();    
            showAllRegistration.Show(); 
            this.Hide();
        }

        private void modifyReg_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.Show();
            this.Hide();
        }

        // register Add Button customer
        private void btnRegRoom_Click(object sender, EventArgs e)
        {

            if (daysData != null && checkIn != null && checkOut != null)
            {
                var startDate = checkIndatedp.Value;
                var endDate = checkOutdp.Value;

                List<string> workingDays = new List<string>();

                for (DateTime counter = startDate; counter <= endDate; counter = counter.AddDays(1))
                {
                    workingDays.Add(counter.ToString("dd/MM/yyyy 00:00:00"));
                }

                bool existsDatas = workingDays.Intersect(daysData).Any();

                if (existsDatas)
                {
                    MessageBox.Show("These Dates are full! Please check dates");
                    reset();
                    //daysdata'nı sil
                    daysData.Clear();
                }
                else
                {
                    int parsedValue;
                    if (!int.TryParse(roomPricetbx.Text, out parsedValue))
                    {
                        MessageBox.Show("Please write only number to Room Price");
                        return;
                    }
                    var date1 = checkIndatedp.Value.ToString("MM/dd/yyyy");
                    var date2 = checkOutdp.Value.ToString("MM/dd/yyyy");

                    Con.Open();
                    string query = "insert into RegistrationTbl values('" + firstNametbx.Text + "','" + lastNametbx.Text + "','" + phonetbx.Text + "','" + countrycbx.SelectedItem.ToString() + "','" + passprttbx.Text + "','" + roomNumbercbx.SelectedValue.ToString() + "','" + roomAvacbx.SelectedItem.ToString() + "','" + date1 + "','" + date2 + "','" + Convert.ToInt32(roomPricetbx.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Registration successfull added !");
                    reset();
                    //daysdata'nı sil
                    daysData.Clear();
                }
            }
            else
            {

                if (firstNametbx.Text != "" && lastNametbx.Text != "" && passprttbx.Text != "" && phonetbx.Text != "" && 
                countrycbx.SelectedIndex != -1 && roomNumbercbx.SelectedIndex != -1 && roomAvacbx.SelectedIndex != -1 && roomPricetbx.Text != "")
                {
                    int parsedValue;
                    if (!int.TryParse(roomPricetbx.Text, out parsedValue))
                    {
                        MessageBox.Show("Please write only number to Room Price");
                        return;
                    }

                    var date1 = checkIndatedp.Value.ToString("MM/dd/yyyy");
                    var date2 = checkOutdp.Value.ToString("MM/dd/yyyy");

                    Con.Open();
                    string query = "insert into RegistrationTbl values('" + firstNametbx.Text + "','" + lastNametbx.Text + "','" + phonetbx.Text + "','" + countrycbx.SelectedItem.ToString() + "','" + passprttbx.Text + "','" + roomNumbercbx.SelectedValue.ToString() + "','" + roomAvacbx.SelectedItem.ToString() + "','" + date1 + "','" + date2 + "','" + Convert.ToInt32(roomPricetbx.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Registration successfull added !");
                    reset();
                    //daysdata'nı sil
                    daysData.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill all the boxes");
                }


                
            }
        }

    }
}
