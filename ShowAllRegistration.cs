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
    public partial class ShowAllRegistration : Form
    {
        public ShowAllRegistration()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        private void dashbaordExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ListAllRoom()
        {
            Con.Open();
            string query = "select * from RegistrationTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            showAllRegdgw.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ShowAllRegistration_Load(object sender, EventArgs e)
        {
            ListAllRoom();
        }

        private void btnbackRegAll_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();  
            dashboard.Show();
            this.Hide();
        }

        private void btnshowOnlyReg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(); 
            registration.Show();
            this.Hide();
        }

        private void btnRegDelete_Click(object sender, EventArgs e)
        {

        }

        private void showAllRegdgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
