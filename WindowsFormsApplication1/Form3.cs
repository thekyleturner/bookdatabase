using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {

        MySqlConnection conn = new MySqlConnection("server=73.50.6.99;user=books;database=bookCheckout;port=3306;password=books1234;");     // login to server


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.Open();                                            // open connection to db on form load
        }

        private void login_submit_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlcmd = new MySqlCommand("select userid,password,accessLevel from user where username='" + login_userText.Text + "'and password='" + login_passText.Text + "'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(sqlcmd);             // pull data
            DataTable dt = new DataTable();                                 // new data table
            da.Fill(dt);                                                    // populate data table with data from db

            if (dt.Rows.Count == 1)                                         // it returned ONLY ONE hit
            {
                //login is correct
                this.Hide();
                Form1 thisNewForm1 = new Form1();                            // set up main form, this will need the other two access level forms
                Form2 thisNewForm2 = new Form2();
                Form4 thisNewForm4 = new Form4(dt.Rows[0][0].ToString());

                string accessLevel = dt.Rows[0][2].ToString();              // gets access level from data table pulled from db earlier
                string UID = dt.Rows[0][0].ToString();

                // If Student
                if (accessLevel == "1")
                {
                    Form4 form4 = new Form4(UID);
                    form4.FormClosed += (s, args) => this.Close();
                    form4.Show();
                }

                // If Teacher
                else if (accessLevel == "2")
                {
                    thisNewForm2.Show();
                }

                // If Admin
                else if (accessLevel == "3")
                {
                    thisNewForm1.Show();
                }

            }

            // Incorrect Login
            else
            {
                MessageBox.Show("Login Unsuccessful");
            }

            conn.Close();                                                   // close connection to db
        }

        private void login_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();                                             // user wants to cancel/exit
        }

        private void login_userText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
