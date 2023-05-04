using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class ControlPanel : Form
    {
       SqlConnection con = new SqlConnection("Data Source=DESKTOP-JRVHAIR;Initial Catalog=ASSIGNMENT01;Integrated Security=True");

        public ControlPanel()
        {
            InitializeComponent();
        }

        private void UpdateRateButton_Click(object sender, EventArgs e)
        {
            if(UpdateTariffTextBox.Text != "" || UpdateTotalCostTextBox.Text != "" || UpdateDiscountRateTextBox.Text != "")
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.TariffRate = UpdateTariffTextBox.Text;
                f1.Total = UpdateTotalCostTextBox.Text;
                f1.DiscountRate = UpdateDiscountRateTextBox.Text;

                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error. Forms cannot be empty!.");
            }
       
        }

        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Select * From RentalCarData";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                AddRentalCarView.DataSource = dt;

                string query2 = "Select * From ReturnCarDetails";
                SqlDataAdapter adapter2 = new SqlDataAdapter(query2, con);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                ReturnCarDataView.DataSource = dt2;

                con.Close();
                MessageBox.Show("Rental Car Data has been shown.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection to Database Error!!!.");
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            f1 = null;
            this.Show();
        }

        private void LogOutButton02_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenuScreen = new MainMenu();
            MainMenuScreen.Show();
            MessageBox.Show("User Has Log Out.");
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete RentalCarData Where CustomerID=@CustomerID", con);

            cmd.Parameters.AddWithValue("@CustomerID", int.Parse(CustomerIDTextBox.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rental Car Data Has Been Deleted!.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete ReturnCarDetails Where BookingNo=@BookingNo", con);

            cmd.Parameters.AddWithValue("@BookingNo", ReturnBookingNoTextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Return Car Data Has Been Deleted!.");
        }
    }
}
