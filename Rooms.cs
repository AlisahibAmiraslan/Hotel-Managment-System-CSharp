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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagment;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
      
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ListAllRoom()
        {
            Con.Open();
            string query = "select * from RoomsTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            adapter.Fill(ds);
            roomdwg.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void reset()
        {
            roomNumbertbx.Text = "";
            roomAvacbx.SelectedIndex = -1;
            roomTypecbx.SelectedIndex = -1; 
        }
        private void btnRoomAdd_Click(object sender, EventArgs e)
        {


            if (roomNumbertbx.Text == "" && roomAvacbx.SelectedIndex == -1 && roomTypecbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the boxes");
            }
            else
            {
                Con.Open();
                string query = "insert into RoomsTbl values('" + roomNumbertbx.Text + "','" + roomAvacbx.SelectedItem.ToString() + "','" + roomTypecbx.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Room Successfully Added !");
                ListAllRoom();
                reset();
            }
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            ListAllRoom();
        }

        private void btnRoomUpdate_Click(object sender, EventArgs e)
        {
            if (roomNumbertbx.Text == "" || roomAvacbx.SelectedIndex == -1 || roomTypecbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the boxes");
            }
            else
            {
            Con.Open();
            string query = "Update RoomsTbl set RoomNumber= '" + Convert.ToInt32(roomNumbertbx.Text) + "',RoomAvailability='"+ roomAvacbx.SelectedItem.ToString() + "',RoomType='"+ roomTypecbx.SelectedItem.ToString() + "' where Id="+ Convert.ToInt32(roomdwg.CurrentRow.Cells[0].Value) + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Room Successfully Updated !");
            ListAllRoom();
            reset();
            }
        }

        private void roomdwg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomNumbertbx.Text = roomdwg.CurrentRow.Cells[1].Value.ToString();
            roomAvacbx.SelectedItem = roomdwg.CurrentRow.Cells[2].Value.ToString();
            roomTypecbx.SelectedItem = roomdwg.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from RoomsTbl where Id= "+ Convert.ToInt32(roomdwg.CurrentRow.Cells[0].Value) + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Room Successfully Deleted !");
            ListAllRoom();
            reset();
        }

        private void btnRoomBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.Show();
            this.Hide();
        }
    }
}
