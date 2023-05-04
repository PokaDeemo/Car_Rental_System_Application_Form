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

namespace Assignment_01
{
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JRVHAIR;Initial Catalog=ASSIGNMENT01;Integrated Security=True");

        public Signup()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the Application", "Exit Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            try
            { 
                if (UsernameTextBox.Text != "" & PasswordTextBox.Text != "" & EmailTextBox.Text != "")
                { 
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert Into Account Values (@AccountUsername, @AccountPassword, @AccountEmail, @AccountRole)", con);

                        cmd.Parameters.AddWithValue("@AccountUsername", UsernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@AccountPassword", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@AccountEmail", EmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@AccountRole", comboBoxRole.SelectedItem);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Account has successfully been register!. You may login to your account now!.");
                        con.Close();
                }
                else
                {
                    MessageBox.Show("Error. Forms cannot be empty!.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Database Error!!!.");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu LoginForm = new MainMenu();
            LoginForm.Show();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            comboBoxRole.SelectedIndex = 0;
        }
    }
}
