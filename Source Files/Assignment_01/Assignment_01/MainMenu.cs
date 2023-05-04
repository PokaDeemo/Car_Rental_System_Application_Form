using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment_01
{
    public partial class MainMenu : Form
    {
       SqlConnection con = new SqlConnection("Data Source=DESKTOP-JRVHAIR;Initial Catalog=ASSIGNMENT01;Integrated Security=True");

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Select * From Account where AccountUsername = '" + LoginTextBox.Text.Trim() + "' and AccountPassword = '" + PasswordTextBox.Text.Trim() + "'and AccountRole = '" + comboBox1.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                   
                    string role = dt.Rows[0][4].ToString();

                    if (role == "Admin")
                    {
                        MessageBox.Show("[Admin] Login Successfully!!!");
                        Form1 ObjectMainForm = new Form1();
                        ObjectMainForm.Text = comboBox1.Text;
                        this.Hide();
                        ObjectMainForm.Show();
                        ObjectMainForm.ControlPanelButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("[User] Login Successfully!!!");
                        this.Hide();
                        Form1 ObjectMainForm = new Form1();
                        ObjectMainForm.Show();
                        ObjectMainForm.ControlPanelButton.Enabled = false;
                        ObjectMainForm.TariffTextBox.Text = "1.5";
                        ObjectMainForm.DiscountRateTextBox.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username, Password or Role!. Please try again Or it cannot be empty!");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Database Error!!!.");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the Application", "Exit Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}

