using System;
using System.Data;
using System.Data.SqlClient;

namespace insertInto
{
    class connection
    {

        public string conString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\BullFitness\BullFitness\BullFitness.mdf;Integrated Security=True";
        }

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;

        public DataTable select(String querry)
        {
            con = new SqlConnection(conString());
            adp = new SqlDataAdapter();
            con.Open();
            dt = new DataTable();
            adp = new SqlDataAdapter(querry, con);
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        public void insertData(string querry)
        {
            con = new SqlConnection(conString());
            con.Open();
            cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateData(string querry)
        {
            con = new SqlConnection(conString());
            con.Open();
            cmd = new SqlCommand(querry , con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deleteData(string querry)
        {
            con = new SqlConnection(conString());
            cmd = new SqlCommand(querry , con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
//create obj in class
// -> connection c = new connection();

//call to querry with in obj object 
// -> c.insertData("insert into addNewPassword values('" + textBox_name.Text + "', '" + textBox_userName.Text + "', '" + textBox_eMail.Text + "', '" + textBox_password.Text + "', '" + textBox_date.Text + "')");
