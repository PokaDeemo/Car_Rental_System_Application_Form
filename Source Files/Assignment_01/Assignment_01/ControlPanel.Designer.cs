namespace Assignment_01
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.CarRentalSystemLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton02 = new System.Windows.Forms.Button();
            this.ViewDataButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddRentalCarView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReturnCarDataView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReturnBookingNoTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.UpdateRateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateTariffTextBox = new System.Windows.Forms.TextBox();
            this.DiscountRateLabel = new System.Windows.Forms.Label();
            this.UpdateDiscountRateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddRentalCarView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnCarDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarRentalSystemLabel
            // 
            this.CarRentalSystemLabel.AutoSize = true;
            this.CarRentalSystemLabel.BackColor = System.Drawing.Color.Transparent;
            this.CarRentalSystemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarRentalSystemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CarRentalSystemLabel.Location = new System.Drawing.Point(402, 19);
            this.CarRentalSystemLabel.Name = "CarRentalSystemLabel";
            this.CarRentalSystemLabel.Size = new System.Drawing.Size(281, 32);
            this.CarRentalSystemLabel.TabIndex = 1;
            this.CarRentalSystemLabel.Text = "Admin Control Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DeleteDataButton);
            this.groupBox1.Controls.Add(this.BackButton);
            this.groupBox1.Controls.Add(this.LogOutButton02);
            this.groupBox1.Controls.Add(this.ViewDataButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CarRentalSystemLabel);
            this.groupBox1.Location = new System.Drawing.Point(59, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 676);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(378, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 57);
            this.button1.TabIndex = 68;
            this.button1.Text = "Delete Return Car Data ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteDataButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DeleteDataButton.Location = new System.Drawing.Point(233, 598);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(139, 57);
            this.DeleteDataButton.TabIndex = 67;
            this.DeleteDataButton.Text = "Delete Rental Car Data ";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackButton.Location = new System.Drawing.Point(37, 598);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(106, 57);
            this.BackButton.TabIndex = 67;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutButton02
            // 
            this.LogOutButton02.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogOutButton02.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton02.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LogOutButton02.Location = new System.Drawing.Point(937, 19);
            this.LogOutButton02.Name = "LogOutButton02";
            this.LogOutButton02.Size = new System.Drawing.Size(137, 66);
            this.LogOutButton02.TabIndex = 59;
            this.LogOutButton02.Text = "Log Out";
            this.LogOutButton02.UseVisualStyleBackColor = false;
            this.LogOutButton02.Click += new System.EventHandler(this.LogOutButton02_Click);
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewDataButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ViewDataButton.Location = new System.Drawing.Point(773, 598);
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.Size = new System.Drawing.Size(106, 57);
            this.ViewDataButton.TabIndex = 66;
            this.ViewDataButton.Text = "View Data";
            this.ViewDataButton.UseVisualStyleBackColor = true;
            this.ViewDataButton.Click += new System.EventHandler(this.ViewDataButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(572, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 513);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddRentalCarView);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Rental Car Datas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddRentalCarView
            // 
            this.AddRentalCarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddRentalCarView.Location = new System.Drawing.Point(-4, -2);
            this.AddRentalCarView.Name = "AddRentalCarView";
            this.AddRentalCarView.RowTemplate.Height = 25;
            this.AddRentalCarView.Size = new System.Drawing.Size(509, 484);
            this.AddRentalCarView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReturnCarDataView);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Return Rental Car Datas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReturnCarDataView
            // 
            this.ReturnCarDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnCarDataView.Location = new System.Drawing.Point(-4, -2);
            this.ReturnCarDataView.Name = "ReturnCarDataView";
            this.ReturnCarDataView.RowTemplate.Height = 25;
            this.ReturnCarDataView.Size = new System.Drawing.Size(509, 491);
            this.ReturnCarDataView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ReturnBookingNoTextBox);
            this.groupBox2.Controls.Add(this.CustomerIDLabel);
            this.groupBox2.Controls.Add(this.CustomerIDTextBox);
            this.groupBox2.Controls.Add(this.UpdateRateButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.UpdateTariffTextBox);
            this.groupBox2.Controls.Add(this.DiscountRateLabel);
            this.groupBox2.Controls.Add(this.UpdateDiscountRateTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.UpdateTotalCostTextBox);
            this.groupBox2.Location = new System.Drawing.Point(37, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 513);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(117, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Delete Datas/Records";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(102, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 69;
            this.label5.Text = " Booking No:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReturnBookingNoTextBox
            // 
            this.ReturnBookingNoTextBox.Location = new System.Drawing.Point(229, 436);
            this.ReturnBookingNoTextBox.Name = "ReturnBookingNoTextBox";
            this.ReturnBookingNoTextBox.Size = new System.Drawing.Size(177, 23);
            this.ReturnBookingNoTextBox.TabIndex = 70;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerIDLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerIDLabel.Location = new System.Drawing.Point(100, 397);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(123, 22);
            this.CustomerIDLabel.TabIndex = 67;
            this.CustomerIDLabel.Text = "Customer ID:";
            this.CustomerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(229, 396);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(177, 23);
            this.CustomerIDTextBox.TabIndex = 68;
            // 
            // UpdateRateButton
            // 
            this.UpdateRateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateRateButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateRateButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UpdateRateButton.Location = new System.Drawing.Point(162, 249);
            this.UpdateRateButton.Name = "UpdateRateButton";
            this.UpdateRateButton.Size = new System.Drawing.Size(139, 74);
            this.UpdateRateButton.TabIndex = 66;
            this.UpdateRateButton.Text = "Update Rates";
            this.UpdateRateButton.UseVisualStyleBackColor = false;
            this.UpdateRateButton.Click += new System.EventHandler(this.UpdateRateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(113, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Rate Update/Changes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(57, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 22);
            this.label8.TabIndex = 62;
            this.label8.Text = "Day of Tariff Rate:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateTariffTextBox
            // 
            this.UpdateTariffTextBox.Location = new System.Drawing.Point(229, 130);
            this.UpdateTariffTextBox.Name = "UpdateTariffTextBox";
            this.UpdateTariffTextBox.Size = new System.Drawing.Size(177, 23);
            this.UpdateTariffTextBox.TabIndex = 63;
            // 
            // DiscountRateLabel
            // 
            this.DiscountRateLabel.AutoSize = true;
            this.DiscountRateLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiscountRateLabel.ForeColor = System.Drawing.Color.Black;
            this.DiscountRateLabel.Location = new System.Drawing.Point(83, 209);
            this.DiscountRateLabel.Name = "DiscountRateLabel";
            this.DiscountRateLabel.Size = new System.Drawing.Size(134, 22);
            this.DiscountRateLabel.TabIndex = 60;
            this.DiscountRateLabel.Text = "Discount Rate:";
            this.DiscountRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateDiscountRateTextBox
            // 
            this.UpdateDiscountRateTextBox.Location = new System.Drawing.Point(229, 209);
            this.UpdateDiscountRateTextBox.Name = "UpdateDiscountRateTextBox";
            this.UpdateDiscountRateTextBox.Size = new System.Drawing.Size(177, 23);
            this.UpdateDiscountRateTextBox.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(117, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 58;
            this.label9.Text = "Total Cost:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateTotalCostTextBox
            // 
            this.UpdateTotalCostTextBox.Location = new System.Drawing.Point(229, 169);
            this.UpdateTotalCostTextBox.Name = "UpdateTotalCostTextBox";
            this.UpdateTotalCostTextBox.Size = new System.Drawing.Size(177, 23);
            this.UpdateTotalCostTextBox.TabIndex = 59;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1212, 715);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddRentalCarView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnCarDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label CarRentalSystemLabel;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox UpdateTotalCostTextBox;
        private Label DiscountRateLabel;
        private TextBox UpdateDiscountRateTextBox;
        private GroupBox groupBox2;
        private Label label1;
        private Label label8;
        private TextBox UpdateTariffTextBox;
        private Button UpdateRateButton;
        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView AddRentalCarView;
        private TabPage tabPage2;
        private DataGridView ReturnCarDataView;
        private Button ViewDataButton;
        private Button LogOutButton02;
        private Button BackButton;
        private Button DeleteDataButton;
        private Label CustomerIDLabel;
        private TextBox CustomerIDTextBox;
        private Button button1;
        private Label label5;
        private TextBox ReturnBookingNoTextBox;
        private Label label2;
    }
}