using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using insertInto;

namespace BullFitness
{
    public partial class UserControl_viewMembers : UserControl
    {
        public UserControl_viewMembers()
        {
            InitializeComponent();
        }

        bool MenuSwitch = true;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\BullFitness\BullFitness\BullFitness.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adp;
        int ID = 0;

        #region Display&Open
        private void DisplayMember()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_MemberDetail;", con);
            adp.Fill(dt);
            dataGridView_ViewMember.DataSource = dt;
            con.Close();
        }
        private void DisplayActiveMember()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_MemberDetail where stauts='Active';", con);
            adp.Fill(dt);
            dataGridView_ViewMember.DataSource = dt;
            con.Close();
        }
        private void DisplayDeactiveMember()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_MemberDetail where stauts='Deactive';", con);
            adp.Fill(dt);
            dataGridView_ViewMember.DataSource = dt;
            con.Close();
        }
        private void DisplayFitness()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_fitnessDetail", con);
            adp.Fill(dt);
            dataGridView_FitnessDetail.DataSource = dt;
            con.Close();
        }
        private void DisplayPayment()
        {
            con.Open();
            DataTable dt = new DataTable();
            adp = new SqlDataAdapter("select * from table_paymentDetails;", con);
            adp.Fill(dt);
            dataGridView_Payment.DataSource = dt;
            con.Close();
        }
        #endregion
        #region clear
        private void checkBoxesFalse()
        {
            checkBoxActive.Checked = false;
            checkBoxDeactive.Checked = false;
        }
        private void clearPayment()
        {
            ID = 0;
            txtMemberFee.Text = "";
            txtMonthlyFee.Text = "";
            txtNextPayment.Text = "";
            txtJoinDate.Text = "";
            txtPackage.Text = "";
            txtPaymentDate.Text = "";
        }
        private void clearMember()
        {
            ID = 0;
            txtAddress.Text = "";
            txtAge.Text = "";
            txtDOB.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
            txtNIC.Text = "";
        }
        private void clearFitness()
        {
            ID = 0;
            txtChest.Text = "";
            txtHeight.Text = "";
            txtLowArm.Text = "";
            txtLowLeg.Text = "";
            txtUpperArm.Text = "";
            txtUpperLeg.Text = "";
            txtWeight.Text = "";

        }
        #endregion
        #region GridViewHedderClick
        private void dataGridView_ViewMember_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView_ViewMember.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = dataGridView_ViewMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNIC.Text = dataGridView_ViewMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDOB.Text = dataGridView_ViewMember.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAge.Text = dataGridView_ViewMember.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAddress.Text = dataGridView_ViewMember.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMobile.Text = dataGridView_ViewMember.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEmail.Text = dataGridView_ViewMember.Rows[e.RowIndex].Cells[7].Value.ToString();


                if (dataGridView_ViewMember.Rows[e.RowIndex].Cells[8].Value.ToString() == "Active")
                {
                    checkBoxActive.Checked = true;
                    checkBoxDeactive.Checked = false;
                }
                if (dataGridView_ViewMember.Rows[e.RowIndex].Cells[8].Value.ToString() == "Deactive")
                {
                    checkBoxActive.Checked = false;
                    checkBoxDeactive.Checked = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }

        }

        private void dataGridView_Payment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView_Payment.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMemberFee.Text = dataGridView_Payment.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMonthlyFee.Text = dataGridView_Payment.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPackage.Text = dataGridView_Payment.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtJoinDate.Text = dataGridView_Payment.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNextPayment.Text = dataGridView_Payment.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPaymentDate.Text = dataGridView_Payment.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void dataGridView_FitnessDetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtWeight.Text = dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHeight.Text = dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtChest.Text = dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtLowArm.Text = dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtUpperArm.Text = dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLowLeg.Text = dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtUpperLeg.Text = dataGridView_FitnessDetail.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
        #endregion
        #region Update&Delete

        connection c = new connection();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtAge.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtName.Text != "" && txtNIC.Text != "")
                {
                    if (checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        cmd = new SqlCommand("update table_MemberDetail set name = '" + txtName.Text + "' ,  NIC = '" + txtNIC.Text + "' , dob = '" + txtDOB.Text + "', age = '" + txtAge.Text + "' , address = '" + txtAddress.Text + "' , mobileNo = '" + txtMobile.Text + "' , email = '" + txtEmail.Text + "' , stauts = 'Active' where memberID = '" + ID + "';", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Details Updated..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        DisplayMember();
                        checkBoxesFalse();
                        clearMember();
                    }
                    else if (!checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        cmd = new SqlCommand("update table_MemberDetail set name = '" + txtName.Text + "' ,  NIC = '" + txtNIC.Text + "' , dob = '" + txtDOB.Text + "', age = '" + txtAge.Text + "' , address = '" + txtAddress.Text + "' , mobileNo = '" + txtMobile.Text + "' , email = '" + txtEmail.Text + "' , stauts = 'Deactive' where memberID = '" + ID + "';", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Details Updated..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        DisplayMember();
                        checkBoxesFalse();
                        clearMember();
                    }
                    else if (checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        MessageBox.Show("Enter Valid Status..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        MessageBox.Show("Enter Member Status..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Select Record To Update..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtJoinDate.Text != "" && txtMemberFee.Text != "" && txtMonthlyFee.Text != "" && txtNextPayment.Text != "" && txtPackage.Text != "")
                {

                    cmd = new SqlCommand("update table_paymentDetails set memberFee = '" + txtMemberFee.Text + "' ,  monthlyFee = '" + txtMonthlyFee.Text + "' , package = '" + txtPackage.Text + "', joinDate = '" + txtJoinDate.Text + "' , nextPaymentDate = '" + txtNextPayment.Text + "' , paymentDate = '" + txtPaymentDate.Text + "' where memberID = '" + ID + "';", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Updated..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DisplayPayment();
                    clearPayment();
                }
                else
                {
                    MessageBox.Show("Select Record To Update..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnFitnessUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWeight.Text != "" && txtUpperLeg.Text != "" && txtUpperArm.Text != "" && txtLowLeg.Text != "" && txtLowArm.Text != "" && txtHeight.Text != "" && txtChest.Text != "")
                {

                    cmd = new SqlCommand("update table_fitnessDetail set weight = '" + txtWeight.Text + "' ,  height = '" + txtHeight.Text + "' , chest = '" + txtChest.Text + "', lowArm = '" + txtLowArm.Text + "' , upperArm = '" + txtUpperArm.Text + "' , lowLeg = '" + txtLowLeg.Text + "' , upperLeg = '" + txtUpperLeg.Text + "' where memberID = '" + ID + "';", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Updated..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DisplayFitness();
                    clearFitness();
                }
                else
                {
                    MessageBox.Show("Select Record To Update..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0 && txtAddress.Text != "" && txtAge.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtName.Text != "" && txtNIC.Text != "")
                {
                    cmd = new SqlCommand("delete from table_MemberDetail where memberID = '" + ID + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Deleted..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    DisplayMember();
                    checkBoxesFalse();
                    clearMember();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
        #endregion
        #region Switch
        private void btnViewmember_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {

                    pnlViewMember.Show();
                    pnlViewFitness.Hide();
                    pnlViewPayment.Hide();
                    MenuSwitch = false;

                }
                else if (MenuSwitch == false)
                {

                    pnlViewFitness.Hide();
                    pnlViewMember.Hide();
                    pnlViewPayment.Hide();
                    MenuSwitch = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddFitnessDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {

                    pnlViewFitness.Show();
                    pnlViewMember.Hide();
                    pnlViewPayment.Hide();
                    MenuSwitch = false;

                }
                else if (MenuSwitch == false)
                {

                    pnlViewFitness.Hide();
                    pnlViewMember.Hide();
                    pnlViewPayment.Hide();
                    MenuSwitch = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {

                    pnlViewFitness.Hide();
                    pnlViewMember.Hide();
                    pnlViewPayment.Show();
                    MenuSwitch = false;

                }
                else if (MenuSwitch == false)
                {

                    pnlViewFitness.Hide();
                    pnlViewMember.Hide();
                    pnlViewPayment.Hide();
                    MenuSwitch = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region FilterMemberStatus
        private void checkBoxActive_OnChange(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtAge.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtName.Text != "" && txtNIC.Text != "")
                {
                    //fill position
                    if (checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        checkBoxDeactive.Checked = true;
                        checkBoxActive.Checked = false;
                    }
                    if (!checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        checkBoxDeactive.Checked = true;
                        checkBoxActive.Checked = false;
                    }
                    if (checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        checkBoxActive.Checked = true;
                        checkBoxDeactive.Checked = false;
                    }
                }
                else
                {

                    //empty position
                    if (checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        DisplayMember();
                        checkBoxesFalse();

                    }
                    if (checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        DisplayActiveMember();
                    }
                    if (!checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        DisplayDeactiveMember();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void checkBoxDeactive_OnChange(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtAge.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtName.Text != "" && txtNIC.Text != "")
                {
                    //filled position
                    if (checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        checkBoxDeactive.Checked = true;
                        checkBoxActive.Checked = false;
                    }
                    if (!checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        checkBoxDeactive.Checked = true;
                        checkBoxActive.Checked = false;
                    }
                    if (checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        checkBoxActive.Checked = false;
                        checkBoxDeactive.Checked = true;
                    }
                }
                else
                {

                    //empty position
                    if (checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        DisplayMember();
                        checkBoxesFalse();
                    }
                    if (checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        DisplayActiveMember();
                    }
                    if (!checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        DisplayDeactiveMember();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
        #endregion

        private void txtClear_Click(object sender, EventArgs e)
        {
            clearMember();
        }

        private void UserControl_viewMembers_Load(object sender, EventArgs e)
        {
            DisplayMember();
            DisplayFitness();
            DisplayPayment();

            MenuSwitch = true;

            pnlViewMember.Hide();
            pnlViewFitness.Hide();
            pnlViewPayment.Hide();
            checkBoxActive.Checked = true;
            checkBoxDeactive.Checked = false;

            if (MenuSwitch == true)
            {
                DisplayActiveMember();
                checkBoxActive.Checked = true;
                checkBoxDeactive.Checked = false;
            }
            if (MenuSwitch == false)
            {
                DisplayDeactiveMember();
                checkBoxActive.Checked = false;
                checkBoxDeactive.Checked = true;
            }


        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adp = new SqlDataAdapter("select * from table_MemberDetail where name like '%" + txtName.Text + "%'", con);
            //    adp.Fill(dt);
            //    dataGridView_ViewMember.DataSource = dt;
            //    con.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void txtNIC_OnValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adp = new SqlDataAdapter("select * from table_MemberDetail where NIC like '%" + txtNIC.Text + "%'", con);
            //    adp.Fill(dt);
            //    dataGridView_ViewMember.DataSource = dt;
            //    con.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtMobile_OnValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    DataTable dt = new DataTable();
            //    adp = new SqlDataAdapter("select * from table_MemberDetail where mobileNo like '%" + txtMobile.Text + "%'", con);
            //    adp.Fill(dt);
            //    dataGridView_ViewMember.DataSource = dt;
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnSearchDateBetween_Click(object sender, EventArgs e)
        {
            try
            {
                if (datePickerPendingDate1.Value < datePickerPendingDate2.Value)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adp = new SqlDataAdapter("select * from table_paymentDetails where nextPaymentDate between '" + datePickerPendingDate1.Value + "' and '" + datePickerPendingDate2.Value + "';", con);
                    adp.Fill(dt);
                    dataGridView_Payment.DataSource = dt;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayPayment();
            clearPayment();
        }
    }
}
