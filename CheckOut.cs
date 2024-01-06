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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public void ListAll()
        {
            string filter = "check-in";
            Con.Open();
            string query = "select * from RegistrationTbl where RoomAvailability='" + filter + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            checkOutdgw.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void reset()
        {
            firstNameChecktbx.Text = "";
            lastNameChecktbx.Text = "";
            passprtChecktbx.Text = "";
            phoneChecktbx.Text = "";
            countryChecktbx.Text = "";
            roomNumberChecktbx.Text = "";
            roomPriceChecktbx.Text = "";
        }

        private void DeleteReservation()
        {
            try
            {
                Con.Open();
                string query = "delete from RegistrationTbl where Id='" + checkOutdgw.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                ListAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dashbaordExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            ListAll();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void showAllcheckOutbtn_Click(object sender, EventArgs e)
        {
            AllCheckOuts allCheckOut = new AllCheckOuts();
            allCheckOut.Show();
            this.Hide();
        }

        private void checkOutdgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            firstNameChecktbx.Text = checkOutdgw.CurrentRow.Cells[1].Value.ToString();
            lastNameChecktbx.Text = checkOutdgw.CurrentRow.Cells[2].Value.ToString();
            phoneChecktbx.Text = checkOutdgw.CurrentRow.Cells[3].Value.ToString();
            countryChecktbx.Text = checkOutdgw.CurrentRow.Cells[4].Value.ToString();
            passprtChecktbx.Text = checkOutdgw.CurrentRow.Cells[5].Value.ToString();
            roomNumberChecktbx.Text = checkOutdgw.CurrentRow.Cells[6].Value.ToString();
            checkIndp.Text = checkOutdgw.CurrentRow.Cells[8].Value.ToString();
            roomPriceChecktbx.Text = checkOutdgw.CurrentRow.Cells[10].Value.ToString();
        }

        private void checkOutbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNameChecktbx.Text != "" && lastNameChecktbx.Text != "" && phoneChecktbx.Text != "" && countryChecktbx.Text != "" 
                    && passprtChecktbx.Text != "" && roomNumberChecktbx.Text != "" && roomPriceChecktbx.Text != "")
                {
                    var checkOutDate = checkOutCheckdp.Value.ToString("MM/dd/yyyy");
                    var checkInDate = checkIndp.Value.ToString("MM/dd/yyyy");

                    Con.Open();
                    string query = "insert into CheckOutTbl values('" + firstNameChecktbx.Text + "','" + lastNameChecktbx.Text + "','" + phoneChecktbx.Text + "','" + countryChecktbx.Text + "','" + passprtChecktbx.Text + "','" + roomNumberChecktbx.Text + "','" + checkInDate + "','" + checkOutDate + "','" + Convert.ToInt32(roomPriceChecktbx.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Room successfully check Outed!");
                    DeleteReservation();
                    reset();
                }
                else
                {
                    MessageBox.Show("Please Select Rooms");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
