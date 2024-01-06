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
    public partial class AllCheckOuts : Form
    {
        public AllCheckOuts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public void ListAllRoom()
        {
            Con.Open();
            string query = "select * from CheckOutTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            showAllCheckOutdgw.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void findTotalAmount()
        {
            Con.Open();
            string query = "SELECT SUM (RoomPrice) FROM CheckOutTbl";
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                object result = cmd.ExecuteScalar();
                totalAmountPricelbl.Text = Convert.ToString(result) + " $";
            }
            Con.Close();
        }
        private void AllCheckOuts_Load(object sender, EventArgs e)
        {
            ListAllRoom();
            findTotalAmount();
        }

        private void btnShowcheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut(); 
            checkOut.Show();
            this.Hide();
        }

        private void btnbackRegAll_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void dashbaordExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
