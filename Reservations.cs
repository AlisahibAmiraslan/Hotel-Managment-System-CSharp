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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void dashbaordExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        public void ListAll()
        {
            string filter = "reserv";
            Con.Open();
            string query = "select * from RegistrationTbl where RoomAvailability='"+ filter + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            reservationdgw.DataSource = ds.Tables[0];
            Con.Close();
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
            roomNumberRescbx.ValueMember = "RoomNumber";
            roomNumberRescbx.DataSource = dt;
            Con.Close();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            ListAll();
            GetAllRooms();
        }


        private void reset()
        {
            firstNameRestbx.Text = "";
            lastNameRestbx.Text = "";
            passprtRestbx.Text = "";
            phoneRestbx.Text = "";
            countryRescbx.SelectedIndex = -1;
            roomNumberRescbx.SelectedIndex = -1;
            roomAvaRescbx.SelectedIndex = -1;
            roomPriceRestbx.Text = "";
        }

        private void updateResbtn_Click(object sender, EventArgs e)
        {
          

            try
            {
                if (firstNameRestbx.Text == "" && lastNameRestbx.Text == "" && passprtRestbx.Text == "" && phoneRestbx.Text == ""
               && countryRescbx.SelectedIndex == -1 && roomNumberRescbx.SelectedIndex == -1 && roomAvaRescbx.SelectedIndex == -1
               && roomPriceRestbx.Text == "")
                {
                    MessageBox.Show("These Dates are full!");
                }
                else
                {
                    int parsedValue;
                    if (!int.TryParse(roomPriceRestbx.Text, out parsedValue) && countryRescbx.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please write only number to Room Price");
                        return;
                    }

                    var date1 = checkIndateResdp.Value.ToString("MM/dd/yyyy");
                    var date2 = checkOutResdp.Value.ToString("MM/dd/yyyy");

                    Con.Open();
                    string query = "update RegistrationTbl set FirstName='" + firstNameRestbx.Text + "',LastName ='" + lastNameRestbx.Text + "',Phone='" + phoneRestbx.Text + "',Country='" + countryRescbx.SelectedItem.ToString() + "',PassportId='" + passprtRestbx.Text + "',RoomNumber='" + roomNumberRescbx.SelectedValue.ToString() + "',RoomAvailability='" + roomAvaRescbx.SelectedItem.ToString() + "',CheckIn='" + date1 + "',CheckOut='" + date2 + "',RoomPrice='" + Convert.ToInt32(roomPriceRestbx.Text) + "' where Id=" + reservationdgw.CurrentRow.Cells[0].Value.ToString() + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Registration successfull updated !");
                    ListAll();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reservationdgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            firstNameRestbx.Text = reservationdgw.CurrentRow.Cells[1].Value.ToString();
            lastNameRestbx.Text = reservationdgw.CurrentRow.Cells[2].Value.ToString();
            phoneRestbx.Text = reservationdgw.CurrentRow.Cells[3].Value.ToString();
            countryRescbx.SelectedItem = reservationdgw.CurrentRow.Cells[4].Value.ToString();
            passprtRestbx.Text = reservationdgw.CurrentRow.Cells[5].Value.ToString();
            roomNumberRescbx.SelectedValue = reservationdgw.CurrentRow.Cells[6].Value.ToString();
            roomAvaRescbx.SelectedItem = reservationdgw.CurrentRow.Cells[7].Value.ToString();
            checkIndateResdp.Text = reservationdgw.CurrentRow.Cells[8].Value.ToString();
            checkOutResdp.Text = reservationdgw.CurrentRow.Cells[9].Value.ToString();
            roomPriceRestbx.Text = reservationdgw.CurrentRow.Cells[10].Value.ToString();
        }

        private void deleteResbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "delete from RegistrationTbl where Id='" + reservationdgw.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Reservation Deleted Successfully");
                ListAll();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void backDash_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
