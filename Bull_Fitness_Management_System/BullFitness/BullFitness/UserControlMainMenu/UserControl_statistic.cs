using insertInto;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BullFitness
{
    public partial class UserControl_statistic : UserControl
    {
        public UserControl_statistic()
        {
            InitializeComponent();
        }

        connection c = new connection();

        bool MenuSwitch = true;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\BullFitness\BullFitness\BullFitness.mdf;Integrated Security=True");
        SqlDataAdapter adp = new SqlDataAdapter();

        #region display
        private void displayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_pay;", con);
            adp.Fill(dt);
            dataGridView_Outsanding.DataSource = dt;
            con.Close();

            //c.select("select * from table_pay;");
        }

        private void displayFilteredData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_pay where memberID = '" + txtMemberID.Text + "' or name = '" + txtName.Text + "';", con);
            adp.Fill(dt);
            dataGridView_Outsanding.DataSource = dt;
            con.Close();
        }

        private void displayPendingData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_outsanding ;", con);
            adp.Fill(dt);
            dataGridViewPendingPayments.DataSource = dt;
            con.Close();
        }

        private void displayFilteredPendingData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_outsanding where nextPaymentDate = datediff(day , 0 , '" + datePickerPendingDate1.Value + "');", con);
            adp.Fill(dt);
            dataGridViewPendingPayments.DataSource = dt;
            con.Close();
        }

        #endregion
        #region Switch
        private void btnOutsanding_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {

                    pnlOutsanding.Show();
                    pnlPendingPayment.Hide();
                    MenuSwitch = false;

                }
                else if (MenuSwitch == false)
                {

                    pnlOutsanding.Hide();
                    pnlPendingPayment.Hide();
                    MenuSwitch = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnPendingPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {
                    pnlPendingPayment.Show();
                    pnlOutsanding.Hide();
                    MenuSwitch = false;
                }
                else if (MenuSwitch == false)
                {
                    pnlOutsanding.Hide();
                    pnlPendingPayment.Hide();
                    MenuSwitch = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Filter Outsanding

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adp = new SqlDataAdapter("select * from table_pay where name like '%" + txtName.Text + "%'", con);
                adp.Fill(dt);
                dataGridView_Outsanding.DataSource = dt;

                //Calculate sum & Deficit
                double sumAmount = 0, sumBalance = 0; ;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sumAmount += int.Parse(dataGridView_Outsanding.Rows[i].Cells["amount"].Value.ToString());
                    sumBalance += int.Parse(dataGridView_Outsanding.Rows[i].Cells["balance"].Value.ToString());
                }
                con.Close();
                labelIncomeValue.Text = Convert.ToString(sumAmount);
                labelDeficitValue.Text = Convert.ToString(sumBalance);

                labelIncome.Visible = true;
                labelIncomeValue.Visible = true;
                labelDeficit.Visible = true;
                labelDeficitValue.Visible = true;

                if (sumAmount > sumBalance)
                {
                    labelIndicator.Visible = true;
                    labelIndicator.Text = "+";
                }
                else if (sumAmount == sumBalance)
                {
                    labelIndicator.Visible = false;
                }
                else
                {
                    labelIndicator.Visible = true;
                    labelIndicator.Text = "-";
                }
                // end

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMemberID_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adp = new SqlDataAdapter("select * from table_pay where memberID like '%" + txtMemberID.Text + "%'", con);
                adp.Fill(dt);
                dataGridView_Outsanding.DataSource = dt;

                //Calculate sum & Deficit
                double sumAmount = 0, sumBalance = 0; ;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sumAmount += int.Parse(dataGridView_Outsanding.Rows[i].Cells["amount"].Value.ToString());
                    sumBalance += int.Parse(dataGridView_Outsanding.Rows[i].Cells["balance"].Value.ToString());
                }
                con.Close();
                labelIncomeValue.Text = Convert.ToString(sumAmount);
                labelDeficitValue.Text = Convert.ToString(sumBalance);

                labelIncome.Visible = true;
                labelIncomeValue.Visible = true;
                labelDeficit.Visible = true;
                labelDeficitValue.Visible = true;

                if (sumAmount > sumBalance)
                {
                    labelIndicator.Visible = true;
                    labelIndicator.Text = "+";
                }
                else if (sumAmount == sumBalance)
                {
                    labelIndicator.Visible = false;
                }
                else
                {
                    labelIndicator.Visible = true;
                    labelIndicator.Text = "-";
                }
                // end

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Filter Pending
        private void btnSearchPendingPayment_Click(object sender, EventArgs e)
        {
            if (datePickerPendingDate1.Value != null && datePickerPendingDate2.Value != null)
            {
                displayFilteredPendingData();
            }
            else
            {
                MessageBox.Show("Dates are empty..!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dropDownDate_onItemSelected(object sender, EventArgs e)
        {
            if (dropDownDate.selectedValue == "Today")
            {
                con.Open();
                DataTable dt = new DataTable();
                adp = new SqlDataAdapter("select * from table_outsanding where nextPaymentDate = datediff(day , 0 , getDate());", con);
                adp.Fill(dt);
                dataGridViewPendingPayments.DataSource = dt;
                con.Close();
            }
            else if (dropDownDate.selectedValue == "Tommorow")
            {
                con.Open();
                DataTable dt = new DataTable();
                adp = new SqlDataAdapter("select * from table_outsanding where nextPaymentDate = datediff(day , -1 , getDate());", con);
                adp.Fill(dt);
                dataGridViewPendingPayments.DataSource = dt;
                con.Close();
            }
            else if (dropDownDate.selectedValue == "Yesterday")
            {
                con.Open();
                DataTable dt = new DataTable();
                adp = new SqlDataAdapter("select * from table_outsanding where nextPaymentDate = datediff(day , 1 , getDate());", con);
                adp.Fill(dt);
                dataGridViewPendingPayments.DataSource = dt;
                con.Close();
            }
            else
            {
                displayPendingData();
            }
        }

        private void btnSearchDateBetween_Click(object sender, EventArgs e)
        {
            try
            {
                if (datePickerPendingDate1.Value < datePickerPendingDate2.Value)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adp = new SqlDataAdapter("select * from table_outsanding where nextPaymentDate between '" + datePickerPendingDate1.Value + "' and '" + datePickerPendingDate2.Value + "';", con);
                    adp.Fill(dt);
                    dataGridViewPendingPayments.DataSource = dt;
                    con.Close();
                }
                else
                {
                    if (datePickerPendingDate1.Value == datePickerPendingDate2.Value)
                    {
                        MessageBox.Show("Please select different dates..!", "Check Again !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Please select correct date format defference..!", "Check Again !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void UserControl_statistic_Load(object sender, EventArgs e)
        {
            MenuSwitch = true;
            pnlOutsanding.Hide();
            pnlPendingPayment.Hide();

            displayData();
            displayPendingData();

            dropDownDate.AddItem("All");
            dropDownDate.AddItem("Yesterday");
            dropDownDate.AddItem("Today");
            dropDownDate.AddItem("Tommorow");

        }

        private void datePicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchPayments_Click(object sender, EventArgs e)
        {
            try
            {
                txtMemberID.Text = "";
                txtName.Text = "";

                if (datePicker1.Value < datePicker2.Value)
                {

                    con.Open();
                    DataTable dt = new DataTable();
                    adp = new SqlDataAdapter("select * from table_pay where paymentDate between '" + datePicker1.Value + "' and '" + datePicker2.Value + "';", con);
                    adp.Fill(dt);
                    dataGridView_Outsanding.DataSource = dt;

                    //Calculate sum & Deficit
                    double sumAmount = 0, sumBalance = 0; ;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sumAmount += int.Parse(dataGridView_Outsanding.Rows[i].Cells["amount"].Value.ToString());
                        sumBalance += int.Parse(dataGridView_Outsanding.Rows[i].Cells["balance"].Value.ToString());
                    }
                    con.Close();
                    labelIncomeValue.Text = Convert.ToString(sumAmount);
                    labelDeficitValue.Text = Convert.ToString(sumBalance);

                    labelIncome.Visible = true;
                    labelIncomeValue.Visible = true;
                    labelDeficit.Visible = true;
                    labelDeficitValue.Visible = true;

                    if (sumAmount > sumBalance)
                    {
                        labelIndicator.Visible = true;
                        labelIndicator.Text = "+";
                    }
                    else if (sumAmount == sumBalance)
                    {
                        labelIndicator.Visible = false;
                    }
                    else
                    {
                        labelIndicator.Visible = true;
                        labelIndicator.Text = "-";
                    }
                    // end
                }
                else
                {
                    if (datePicker1.Value == datePicker2.Value)
                    {
                        MessageBox.Show("Please select different dates..!", "Check Again !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Please select correct date format defference..!", "Check Again !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            displayData();
            txtMemberID.Text = "";
            txtName.Text = "";
        }
    }
}
