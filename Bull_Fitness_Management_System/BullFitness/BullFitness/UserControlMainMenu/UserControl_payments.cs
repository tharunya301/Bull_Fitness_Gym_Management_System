using insertInto;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BullFitness
{
    public partial class UserControl_payments : UserControl
    {
        public UserControl_payments()
        {
            InitializeComponent();
        }

        int ID = 0;

        private void clearText()
        {
            txtAmt.Text = "";
            txtBalance.Text = "";
            txtMonthlyFee.Text = "";
            txtName.Text = "";
            txtPaymentDate.Text = "";
            txtPaymentMemberId.Text = "";
            txtUpdateNextPaymentDate.Text = "";

        }

        private void UserControl_payments_Load(object sender, EventArgs e)
        {
            dropDownPaymentType.AddItem("Membership");
            dropDownPaymentType.AddItem("Monthly Fee");
            dateTimePickerToday.Hide();
            label12.Text = dateTimePickerToday.Text;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\BullFitness\BullFitness\BullFitness.mdf;Integrated Security=True");
        #region getDetails
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                ID = Convert.ToInt32(txtPaymentMemberId.Text);
                SqlCommand cmdName = new SqlCommand("select name from table_MemberDetail where memberID = '" + txtPaymentMemberId.Text + "';", con);
                SqlDataReader drName = cmdName.ExecuteReader();

                SqlCommand cmdNextPaymentDate = new SqlCommand("select nextPaymentDate from table_paymentDetails where memberID = '" + txtPaymentMemberId.Text + "';", con);
                SqlDataReader drNextPaymentDate = cmdNextPaymentDate.ExecuteReader();

                SqlCommand cmdMonthlyFee = new SqlCommand("select monthlyFee from table_paymentDetails where memberID = '" + txtPaymentMemberId.Text + "';", con);
                SqlDataReader drMonthlyFee = cmdMonthlyFee.ExecuteReader();

                if (drMonthlyFee.HasRows)
                {
                    while (drMonthlyFee.Read())
                    {
                        txtMonthlyFee.Text = drMonthlyFee["monthlyFee"].ToString();
                    }
                    while (drName.Read())
                    {
                        txtName.Text = drName["name"].ToString();
                    }
                    while (drNextPaymentDate.Read())
                    {
                        txtPaymentDate.Text = drNextPaymentDate["nextPaymentDate"].ToString();
                        txtUpdateNextPaymentDate.Text = drNextPaymentDate["nextPaymentDate"].ToString();
                    }
                }

                else
                {
                    MessageBox.Show("Can't Find That User..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region MakePayment
        connection c = new connection();
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime NextPaymentDate, paymentDate, updatedNextPaymentDate;
                NextPaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
                paymentDate = Convert.ToDateTime(dateTimePickerToday.Value);
                SqlCommand cmdUpdate = new SqlCommand();


                if (txtPaymentMemberId.Text != "" && txtPaymentDate.Text != "" && txtName.Text != "" && txtMonthlyFee.Text != "" && txtBalance.Text != "" && txtAmt.Text != "")
                {
                    con.Open();
                    c.insertData("insert into table_pay values('" + txtPaymentMemberId.Text + "', '" + txtName.Text + "', '" + NextPaymentDate + "', '" + txtMonthlyFee.Text + "', '" + paymentDate + "' , '" + dropDownPaymentType.selectedValue + "' , '" + txtAmt.Text + "' , '" + txtBalance.Text + "')");
                    updatedNextPaymentDate = Convert.ToDateTime(txtUpdateNextPaymentDate.Text);

                    cmdUpdate = new SqlCommand("update table_paymentDetails set nextPaymentDate = '" + txtUpdateNextPaymentDate.Text + "' where memberID = '" + ID + "';", con);
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Payment Updated..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (Convert.ToDouble(txtBalance.Text) > 0)
                    {
                        c.insertData("insert into table_outsanding values('" + txtPaymentMemberId.Text + "', '" + txtName.Text + "', '" + txtUpdateNextPaymentDate.Text + "', '" + txtPaymentDate.Text + "', '" + txtBalance.Text + "')");
                        MessageBox.Show(txtName.Text + " have balance of Rs. " + Convert.ToDouble(txtBalance.Text), "Outsanding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    clearText();
                }
                else
                {
                    MessageBox.Show("Payments not updated..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion
    }
}
