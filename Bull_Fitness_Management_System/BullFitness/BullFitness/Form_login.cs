using System;
using System.Drawing;
using System.Windows.Forms;

namespace BullFitness
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        private string userName = "user";
        private string password = "1";

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "" && txtPassword.Text != "")
                {
                    if (txtUserName.Text == userName && txtPassword.Text == password)
                    {
                        this.Hide();
                        Form_mainMenu mainmenu = new Form_mainMenu();
                        mainmenu.Show();

                    }
                    else
                    {
                        labelMessage.Text = "Invalid user name or password!";
                        txtUserName.Text = "";
                        txtPassword.Text = "";

                    }
                }
                else
                {
                    if (txtUserName.Text == "")
                    {
                        labelMessage.Text = "Enter user name..!";
                    }
                    if (txtPassword.Text == "")
                    {
                        labelMessage.Text = "Enter a password..!";
                    }
                    if (txtPassword.Text == "" && txtUserName.Text == "")
                    {
                        labelMessage.Text = "Enter user name and password..!";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        #region Drag Controll 

        private bool mouseDown;
        private Point lastLocation;

        private void Form_login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion
    }
}
