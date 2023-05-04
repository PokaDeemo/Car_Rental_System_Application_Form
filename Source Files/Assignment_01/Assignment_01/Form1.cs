using System.Data;
using System.Data.SqlClient;

namespace Assignment_01
{
    public partial class Form1 : Form
    {
        public string TariffRate { get; set; }
        public string Total { get; set; }
        public string DiscountRate { get; set; }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JRVHAIR;Initial Catalog=ASSIGNMENT01;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            CarSpecificCombo.SelectedIndex = 0;
            PersonalHireCB.SelectedIndex = 0;
            CharteredHireCB.SelectedIndex = 0;

            TariffTextBox.Text = TariffRate;
            TotalCostTextBox.Text = Total;
            DiscountRateTextBox.Text = DiscountRate;
        }

        private void PersonalHireCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonalHireCheckbox.Checked == false)
            {
                CharteredHireCheckbox.Checked = true;  
            }
            else
            {
                CharteredHireCheckbox.Checked = false;
            }
        }

        private void CharteredHireCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(CharteredHireCheckbox.Checked == false)
            {
                PersonalHireCheckbox.Checked = true;
            }
            else
            {
                PersonalHireCheckbox.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenuScreen = new MainMenu();
            MainMenuScreen.Show();
            MessageBox.Show("User Has Log Out.");
        }

        private void CharteredHireCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonalHireCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenuScreen = new MainMenu();
            MainMenuScreen.Show();
            MessageBox.Show("User Has Log Out.");
        }

        private void ControlPanelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlPanel AdminControlPanel = new ControlPanel();
            AdminControlPanel.Show();
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
                if (CustomerIDTextBox.Text != "" & SecurityNoTextBox.Text != "" & CustomerTitleTextBox.Text != "" & FirstNameTextBox.Text != "" & SurnameTextBox.Text != ""
                    & ContactNoTextBox.Text != "" & PostcodeTextBox.Text != "" & CityTextBox.Text != "" & CountryTextBox.Text != "" & VehicleIDTextBox.Text != ""
                    & CarEngineTextBox.Text != "" & CarYearTextBox.Text != "" & CarModelTextBox.Text != "" & CarColorTextBox.Text != ""
                    & MilesBeforeTextBox.Text != "" & MilesAfterTextBox.Text != "" & BookingNoTextBox.Text != "" & DaysRentTextBox.Text != ""
                    & RentalTimeTextBox.Text != "" & MeterSettingTextBox.Text != "" & DiscountRateTextBox.Text != "" & TariffTextBox.Text != ""
                    & DistanceTariffTextBox.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into RentalCarData Values (@CustomerID,@SocialSecurityNo,@Title,@FirstName, @Surname, @ContactNo, @PostalCode, @City, @Country, @VehicleID, @CarEngine, @CarRegistYear, @CarModel, @CarColor, @CarSpecification, @MilesBefore, @MilesAfter, @CarCategory, @PersonalHire, @CharteredHire, @BookingNo, @DaysRented, @RentalDate, @RentalTime, @MeterSetting, @DiscountRate, @DayOfTariff, @TotalCost)", con);

                    // Customer Textbox

                    cmd.Parameters.AddWithValue("@CustomerID", int.Parse(CustomerIDTextBox.Text));
                    cmd.Parameters.AddWithValue("@SocialSecurityNo", SecurityNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Title", CustomerTitleTextBox.Text);
                    cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", PostcodeTextBox.Text);
                    cmd.Parameters.AddWithValue("@City", CityTextBox.Text);
                    cmd.Parameters.AddWithValue("@Country", CountryTextBox.Text);

                    // Vehicle Textbox

                    cmd.Parameters.AddWithValue("@VehicleID", VehicleIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@CarEngine", CarEngineTextBox.Text);
                    cmd.Parameters.AddWithValue("@CarRegistYear", CarYearTextBox.Text);
                    cmd.Parameters.AddWithValue("@CarModel", CarModelTextBox.Text);
                    cmd.Parameters.AddWithValue("@CarColor", CarColorTextBox.Text);
                    cmd.Parameters.AddWithValue("@CarSpecification", CarSpecificCombo.SelectedItem);
                    cmd.Parameters.AddWithValue("@MilesBefore", MilesBeforeTextBox.Text);
                    cmd.Parameters.AddWithValue("@MilesAfter", MilesAfterTextBox.Text);

                    if (PersonalHireCheckbox.Checked)
                    {
                        cmd.Parameters.AddWithValue("@CarCategory", "Personal Hire");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CarCategory", "Chartered Hire");
                    }

                    cmd.Parameters.AddWithValue("@PersonalHire", PersonalHireCB.SelectedItem);
                    cmd.Parameters.AddWithValue("@CharteredHire", CharteredHireCB.SelectedItem);

                    // Booking/Renting Textbox

                    cmd.Parameters.AddWithValue("@BookingNo", BookingNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@DaysRented", DaysRentTextBox.Text);
                    cmd.Parameters.AddWithValue("@RentalDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@RentalTime", RentalTimeTextBox.Text);
                    cmd.Parameters.AddWithValue("@MeterSetting", MeterSettingTextBox.Text);
                    cmd.Parameters.AddWithValue("@DiscountRate", DiscountRateTextBox.Text);
                    cmd.Parameters.AddWithValue("@DayOfTariff", TariffTextBox.Text);
                    cmd.Parameters.AddWithValue("@TotalCost", TotalCostTextBox.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Rental Car Data Has Been Successfully Added to the system.");
               }
               else
                {
                    MessageBox.Show("Error. Forms cannot be empty!.");
                }
        }
            
        private void ResetButton_Click(object sender, EventArgs e)
        {    
            // Customer TextBox Clear
            CustomerIDTextBox.Clear();
            SecurityNoTextBox.Clear();
            CustomerTitleTextBox.Clear();
            FirstNameTextBox.Clear();
            SurnameTextBox.Clear();
            ContactNoTextBox.Clear();
            PostcodeTextBox.Clear();
            CityTextBox.Clear();
            CountryTextBox.Clear();

            // Vehicle Textbox Clear
            VehicleIDTextBox.Clear();
            CarEngineTextBox.Clear();
            CarYearTextBox.Clear();
            CarModelTextBox.Clear();
            CarColorTextBox.Clear();
            CarSpecificCombo.SelectedIndex = 0;
            MilesBeforeTextBox.Clear();
            MilesAfterTextBox.Clear();
            PersonalHireCheckbox.Checked = false;
            CharteredHireCheckbox.Checked = false;
            PersonalHireCB.SelectedIndex = 0;
            CharteredHireCB.SelectedIndex = 0;

            // Booking/Renting Textbox Clear
            BookingNoTextBox.Clear();
            DaysRentTextBox.Clear();
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            RentalTimeTextBox.Clear();
            MeterSettingTextBox.Clear();
            DiscountRateTextBox.Clear();
            TariffTextBox.Clear();
            CostPerKmTextBox.Clear();
            DistanceTariffTextBox.Clear();
            TotalCostTextBox.Clear();

            MessageBox.Show("Form Has Been Cleared/Reset!.");
        }

        private void ReturnDataButton_Click(object sender, EventArgs e)
        {
                if (ReturnBookingNoTextBox.Text != "" & ReturnTimeTextBox.Text != "" & ReturnMeterSettingTextBox.Text != "")
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Insert Into ReturnCarDetails Values(@BookingNo, @ReturnDate, @ReturnTime, @ReturnMeterSetting)", con);

                    cmd.Parameters.AddWithValue("@BookingNo", ReturnBookingNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@ReturnDate", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@ReturnTime", ReturnTimeTextBox.Text);
                    cmd.Parameters.AddWithValue("@ReturnMeterSetting", ReturnMeterSettingTextBox.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Return Car Data Has Been Successfully Added to the system.");
                }
                else
                {
                    MessageBox.Show("Form Cannot Be Empty!.");
                }
        }

        private void ViewDataButton_Click(object sender, EventArgs e)
        {
                con.Open();
                string query = "Select * From RentalCarData";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                RentalCarDataViewGrid.DataSource = dt;

                con.Close();
                MessageBox.Show("Rental Car Data has been shown.");
        }

        private void ViewReturnDataButton_Click(object sender, EventArgs e)
        {
                con.Open();
                string query = "Select * From ReturnCarDetails";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ReturnDataViewGrid.DataSource = dt;

                con.Close();
                MessageBox.Show("Return Rental Car Data has been shown.");

        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            // Variables
            int DayRent = int.Parse(DaysRentTextBox.Text);
            float DayTariff = float.Parse(TariffTextBox.Text);
            float MilesAfter = Convert.ToInt32(MilesAfterTextBox.Text);
            float MilesBefore = Convert.ToInt32(MilesBeforeTextBox.Text);
            float price, originalPrice, discountPrice;
            float DiscountRate = float.Parse(DiscountRateTextBox.Text);
            float CostPerKM = float.Parse(CostPerKmTextBox.Text);
            float DistanceTariff = float.Parse(DistanceTariffTextBox.Text);

            // Calculation 
            float ActualKmDriving = (float)((MilesAfter - MilesBefore) * 1.6);


           // Validation Check 
            if (PersonalHireCB.SelectedIndex > 0 & CharteredHireCB.SelectedIndex > 0)
            {
                MessageBox.Show("Error in calculating the totals. Please try again");
            }
            else
            {
                if (PersonalHireCB.SelectedIndex != 0 || CharteredHireCB.SelectedIndex != 0)
                {

                    // Personal Hire Price Calculation Formula
                    if (PersonalHireCB.SelectedIndex == 1)
                    {
                        if (DiscountRate > 0)
                        {
                            originalPrice = 20 * DayRent;
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = 20 * DayRent;
                            TotalCostTextBox.Text = price.ToString();
                        }
                    }

                    if (PersonalHireCB.SelectedIndex == 2)
                    {

                        if (DiscountRate > 0)
                        {
                            originalPrice = 40 * DayRent;
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = 40 * DayRent;
                            TotalCostTextBox.Text = price.ToString();
                        }
                    }

                    if (PersonalHireCB.SelectedIndex == 3)
                    {
                        if (DiscountRate > 0)
                        {
                            originalPrice = (70 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving);
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = (70 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving);
                            TotalCostTextBox.Text = price.ToString();
                        }
                    }

                    if (PersonalHireCB.SelectedIndex == 4)
                    {
                        if (DiscountRate > 0)
                        {
                            originalPrice = (20 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving * DistanceTariff);
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = (20 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving * DistanceTariff);
                            TotalCostTextBox.Text = price.ToString();
                        }
                    }

                    if (PersonalHireCB.SelectedIndex == 5)
                    {
                        if (DiscountRate > 0)
                        {
                            originalPrice = (70 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving * DistanceTariff);
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = (70 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving * DistanceTariff);
                            TotalCostTextBox.Text = price.ToString();
                        }
                    }

                    if (PersonalHireCB.SelectedIndex == 6)
                    {
                        if (DiscountRate > 0)
                        {
                            originalPrice = (150 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving * DistanceTariff);
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = (150 * DayRent * DayTariff) + (CostPerKM * ActualKmDriving * DistanceTariff);
                            TotalCostTextBox.Text = price.ToString();

                        }
                    }

                    // Chartered Hire Price Formula
                    if (CharteredHireCB.SelectedIndex == 1)
                    {
                        if (DiscountRate > 0)
                        {
                            originalPrice = 39 * DayRent;
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = 39 * DayRent;
                            TotalCostTextBox.Text = price.ToString();
                        }
                    }

                    if (CharteredHireCB.SelectedIndex == 2)
                    {
                        if (DiscountRate > 0)
                        {
                            originalPrice = 50 * DayRent;
                            price = originalPrice * (DiscountRate / 100);
                            discountPrice = originalPrice - price;
                            TotalCostTextBox.Text = discountPrice.ToString();
                        }
                        else
                        {
                            price = 50 * DayRent;
                            TotalCostTextBox.Text = price.ToString();
                        }
                    }

                    // Receipt Showing Script
                    ReceiptTextBox.Text = "";
                    ReceiptTextBox.AppendText("----------------------------------\r\n");
                    ReceiptTextBox.AppendText("--- Rental Receipt --------\r\n");
                    ReceiptTextBox.AppendText("----------------------------------\r\n");
                    ReceiptTextBox.AppendText("Rental Car Receipt" + "\r\n");
                    ReceiptTextBox.AppendText("First Name:" + FirstNameTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Surname:" + SurnameTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Booking Number:" + BookingNoTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Number Of Day Renting:" + DaysRentTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Rental Date:" + dateTimePicker1.Text + "\r\n");
                    ReceiptTextBox.AppendText("Rental Time:" + RentalTimeTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Number Of Day Renting:" + DaysRentTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Car Model:" + CarModelTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Discount Rate:" + DiscountRateTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("----------------------------------\r\n");
                    ReceiptTextBox.AppendText("TOTAL PRICE:" + TotalCostTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("----------------------------------\r\n");

                    MessageBox.Show("Total Price Has Been Shown!");
                }
                else
                {
                    price = 0;
                    TotalCostTextBox.Text = price.ToString();

                    ReceiptTextBox.Text = "";
                    ReceiptTextBox.AppendText("----------------------------------\r\n");
                    ReceiptTextBox.AppendText("--- Rental Receipt --------\r\n");
                    ReceiptTextBox.AppendText("----------------------------------\r\n");
                    ReceiptTextBox.AppendText("Rental Car Receipt" + "\r\n");
                    ReceiptTextBox.AppendText("First Name:" + FirstNameTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Surname:" + SurnameTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Booking Number:" + BookingNoTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Number Of Day Renting:" + DaysRentTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Rental Date:" + dateTimePicker1.Text + "\r\n");
                    ReceiptTextBox.AppendText("Rental Time:" + RentalTimeTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Number Of Day Renting:" + DaysRentTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Car Model:" + CarModelTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("Discount Rate:" + DiscountRateTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("----------------------------------\r\n");
                    ReceiptTextBox.AppendText("TOTAL PRICE:" + TotalCostTextBox.Text + "\r\n");
                    ReceiptTextBox.AppendText("----------------------------------\r\n");


                    MessageBox.Show("Price will be NULL");

                }
            }

        }
  
        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete RentalCarData Where BookingNo=@BookingNo", con);

            cmd.Parameters.AddWithValue("@BookingNo", ReturnBookingNoTextBox.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Rental Car Data Has Been Deleted!.");
        }

        private void ReturnResetButton_Click(object sender, EventArgs e)
        {
            ReturnBookingNoTextBox.Clear();
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            ReturnTimeTextBox.Clear();
            ReturnMeterSettingTextBox.Clear();

            MessageBox.Show("Form Has Been Reset!.");
        }
    }
}
    

