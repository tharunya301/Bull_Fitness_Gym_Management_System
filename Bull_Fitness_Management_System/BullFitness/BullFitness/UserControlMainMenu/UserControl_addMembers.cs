using insertInto;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BullFitness
{
    public partial class UserControl_addMembers : UserControl
    {
        public UserControl_addMembers()
        {
            InitializeComponent();
        }

        bool MenuSwitch = true;
        connection c = new connection();

        #region clear
        private void clearPayment()
        {
            txtPaymentMemberId.Text = "";
            txtMemberFee.Text = "";
            txtMonthlyFee.Text = "";
            dateTimePickerJoinDate.Text = "";
            dateTimePickerNextPayment.Text = "";
        }
        private void clearFitness()
        {
            txtAddMemberId.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtChest.Text = "";
            txtLowArm.Text = "";
            txtLowLeg.Text = "";
            txtUpperArm.Text = "";
            txtUpperLeg.Text = "";
        }
        private void clearMember()
        {
            txtMemberId.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
            txtNIC.Text = "";
            checkBoxActive.Checked = false;
            checkBoxDeactive.Checked = false;
            dateTimePickerDOB.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearPayment();
        }

        private void btnClearFitness_Click(object sender, EventArgs e)
        {
            clearFitness();
        }

        private void btnClearMember_Click(object sender, EventArgs e)
        {
            clearMember();
        }
        #endregion
        #region Switch
        private void btnAddmember_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {
                    pnlAddMemberDetail.Show();
                    pnlAddFitnessDetail.Hide();
                    pnlPaymentDetail.Hide();
                    MenuSwitch = false;
                }
                else if (MenuSwitch == false)
                {
                    pnlAddMemberDetail.Hide();
                    pnlAddFitnessDetail.Hide();
                    pnlPaymentDetail.Hide();
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
                    pnlAddMemberDetail.Hide();
                    pnlAddFitnessDetail.Show();
                    pnlPaymentDetail.Hide();
                    MenuSwitch = false;
                }
                else if (MenuSwitch == false)
                {
                    pnlAddMemberDetail.Hide();
                    pnlAddFitnessDetail.Hide();
                    pnlPaymentDetail.Hide();
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
                    pnlAddMemberDetail.Hide();
                    pnlAddFitnessDetail.Hide();
                    pnlPaymentDetail.Show();
                    MenuSwitch = false;
                }
                else if (MenuSwitch == false)
                {
                    pnlAddMemberDetail.Hide();
                    pnlAddFitnessDetail.Hide();
                    pnlPaymentDetail.Hide();
                    MenuSwitch = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion
        #region InsertData
        private void btnAddmemberDetail_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime DOB = Convert.ToDateTime(dateTimePickerDOB.Text);

                if (txtMemberId.Text != "" && txtAddress.Text != "" && txtAge.Text != "" && dateTimePickerDOB.Text != "" && txtMobile.Text != "" && txtName.Text != "" && txtNIC.Text != "")
                {
                    if (!checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        c.insertData("insert into table_MemberDetail values('" + txtMemberId.Text + "', '" + txtName.Text + "', '" + txtNIC.Text + "', '" + DOB + "','" + txtAge.Text + "' ,'" + txtAddress.Text + "' , '" + txtMobile.Text + "' , '" + txtEmail.Text + "' , 'Deactive')");
                        MessageBox.Show("Data Saved..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearMember();
                    }
                    else if (checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        c.insertData("insert into table_MemberDetail values('" + txtMemberId.Text + "', '" + txtName.Text + "', '" + txtNIC.Text + "', '" + DOB + "','" + txtAge.Text + "' ,'" + txtAddress.Text + "' , '" + txtMobile.Text + "' , '" + txtEmail.Text + "' , 'Active')");
                        MessageBox.Show("Data Saved..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearMember();
                    }
                    else if (!checkBoxActive.Checked && !checkBoxDeactive.Checked)
                    {
                        MessageBox.Show("Enter Member Status..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (checkBoxActive.Checked && checkBoxDeactive.Checked)
                    {
                        MessageBox.Show("Enter Valid Status..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Some Fields Are Empty..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnAddFitness_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddMemberId.Text != "")
                {
                    c.insertData("insert into table_fitnessDetail values('" + txtAddMemberId.Text + "', '" + txtWeight.Text + "', '" + txtHeight.Text + "', '" + txtChest.Text + "','" + txtLowArm.Text + "' ,'" + txtUpperArm.Text + "' , '" + txtLowLeg.Text + "' , '" + txtUpperLeg.Text + "')");
                    MessageBox.Show("Data Saved..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFitness();
                }
                else
                {
                    MessageBox.Show("Some Fields Are Empty..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            DateTime joinDate = Convert.ToDateTime(dateTimePickerJoinDate.Text);
            DateTime nextPayment = Convert.ToDateTime(dateTimePickerNextPayment.Text);

            try
            {

                if (txtPaymentMemberId.Text != "" && dateTimePickerNextPayment.Text != "" && txtMemberFee.Text != "" && txtMonthlyFee.Text != "" && dateTimePickerJoinDate.Text != "" && dropDownPackage.selectedValue != "")
                {
                    c.insertData("insert into table_paymentDetail values('" + txtPaymentMemberId.Text + "', '" + txtMemberFee.Text + "', '" + txtMonthlyFee.Text + "', '" + dropDownPackage.selectedValue + "','" + joinDate + "' ,'" + nextPayment + "' , '" + bunifuDropdownPaymentDate.selectedValue + "')");
                    MessageBox.Show("Data Saved..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearPayment();
                }
                else
                {
                    MessageBox.Show("Some Fields Are Empty..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Drag
        private bool mouseDown;
        private Point lastLocation;

        private void UserControl_addMembers_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void UserControl_addMembers_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void UserControl_addMembers_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion 
        #region Filter
        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Convert.ToString(DateTime.Today.Year - dateTimePickerDOB.Value.Year);
        }

        private void dateTimePickerJoinDate_ValueChanged(object sender, EventArgs e)
        {
            if (dropDownPackage.selectedValue != "")
            {
                if (dropDownPackage.selectedValue == "1 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(1);
                }
                else if (dropDownPackage.selectedValue == "3 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(3);
                }
                else if (dropDownPackage.selectedValue == "6 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(6);
                }
                else if (dropDownPackage.selectedValue == "12 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(12);
                }
            }

        }

        private void dropDownPackage_onItemSelected(object sender, EventArgs e)
        {
            if (dropDownPackage.selectedValue != "")
            {
                if (dropDownPackage.selectedValue == "1 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(1);
                }
                else if (dropDownPackage.selectedValue == "3 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(3);
                }
                else if (dropDownPackage.selectedValue == "6 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(6);
                }
                else if (dropDownPackage.selectedValue == "12 Month")
                {
                    dateTimePickerNextPayment.Value = dateTimePickerJoinDate.Value.AddMonths(12);
                }
            }
        }
        #endregion

        private void UserControl_addMembers_Load(object sender, EventArgs e)
        {
            try
            {
                pnlAddMemberDetail.Hide();
                pnlAddFitnessDetail.Hide();
                pnlPaymentDetail.Hide();
                MenuSwitch = true;

                dropDownPackage.AddItem("1 Month");
                dropDownPackage.AddItem("3 Month");
                dropDownPackage.AddItem("6 Month");
                dropDownPackage.AddItem("12 Month");


                for (int date = 1; date <= 31; date++)
                {
                    bunifuDropdownPaymentDate.AddItem(Convert.ToString(date));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
