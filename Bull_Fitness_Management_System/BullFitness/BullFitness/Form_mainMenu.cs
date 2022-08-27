using System;
using System.Drawing;
using System.Windows.Forms;

namespace BullFitness
{
    public partial class Form_mainMenu : Form
    {
        public Form_mainMenu()
        {
            InitializeComponent();
        }

        #region Switch
        bool MenuSwitch = true;
        private void btnAddmember_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {

                    userControl_addMembers.Show();
                    userControl_payments.Hide();
                    userControl_statistic.Hide();
                    userControl_viewMembers.Hide();
                    MenuSwitch = false;

                }
                else if (MenuSwitch == false)
                {

                    userControl_addMembers.Hide();
                    userControl_payments.Hide();
                    userControl_statistic.Hide();
                    userControl_viewMembers.Hide();
                    MenuSwitch = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {
                    userControl_viewMembers.Show();
                    userControl_addMembers.Hide();
                    userControl_payments.Hide();
                    userControl_statistic.Hide();
                    MenuSwitch = false;
                }
                else if (MenuSwitch == false)
                {
                    userControl_viewMembers.Hide();
                    userControl_addMembers.Hide();
                    userControl_payments.Hide();
                    userControl_statistic.Hide();
                    MenuSwitch = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form_mainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                userControl_viewMembers.Hide();
                userControl_addMembers.Hide();
                userControl_payments.Hide();
                userControl_statistic.Hide();

                CenterToScreen();
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
                    userControl_payments.Show();
                    userControl_viewMembers.Hide();
                    userControl_addMembers.Hide();
                    userControl_statistic.Hide();
                    MenuSwitch = false;
                }
                else if (MenuSwitch == false)
                {
                    userControl_payments.Hide();
                    userControl_viewMembers.Hide();
                    userControl_addMembers.Hide();
                    userControl_statistic.Hide();
                    MenuSwitch = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnStatistict_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuSwitch == true)
                {
                    userControl_statistic.Show();
                    userControl_payments.Hide();
                    userControl_viewMembers.Hide();
                    userControl_addMembers.Hide();
                    MenuSwitch = false;
                }
                else if (MenuSwitch == false)
                {
                    userControl_statistic.Hide();
                    userControl_payments.Hide();
                    userControl_viewMembers.Hide();
                    userControl_addMembers.Hide();
                    MenuSwitch = true;
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

        private void Form_mainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_mainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_mainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_headder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
