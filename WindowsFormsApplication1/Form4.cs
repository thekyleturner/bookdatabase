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
    public partial class Form4 : Form
    {
        string connStr = "server=73.50.6.99;user=books;database=bookCheckout;port=3306;password=books1234;";
        String thisDay = DateTime.Today.ToString("yyyy-MM-dd");
        String next = DateTime.Today.AddDays(14).ToString("yyyy-MM-dd");
        MySqlDataAdapter globalAdp;

        public Form4(string qs)
        {
            InitializeComponent();
            txt_UID.Text = qs;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            // TODO: This line of code loads data into the 'bookCheckoutDataSet1.checkout' table. You can move, or remove it, as needed.
            this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet1.checkout);
            // TODO: This line of code loads data into the 'bookCheckoutDataSet.user' table. You can move, or remove it, as needed.
            this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
            // TODO: This line of code loads data into the 'bookCheckoutDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.bookCheckoutDataSet.user);
            // TODO: This line of code loads data into the 'bookCheckoutDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.bookCheckoutDataSet.book);
        }

        private int writeSQL(String cmd)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand sql = new MySqlCommand(cmd, conn);
            int output = -1;
            try
            {
                conn.Open();
                output = Convert.ToInt32(sql.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return output;
        }


        





        private void btn_showCheckedOut_Click(object sender, EventArgs e)
        {

            



        MySqlConnection conn = new MySqlConnection(connStr);
            this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
            this.userTableAdapter1.Fill(this.bookCheckoutDataSet.user);
            this.bookTableAdapter.Fill(this.bookCheckoutDataSet.book);

            String stm = $"SELECT checkout.userID, student.studentFirstName, student.studentLastName, book.bookId, book.bookTitle FROM checkout, student, book WHERE '{txt_UID.Text.ToString()}' = checkout.userID = student.userID AND checkout.bookID = book.BookID;";
            globalAdp = show(stm, conn);
        }
        private void btn_showAllBooks_Click(object sender, EventArgs e)
        {


            MySqlConnection conn = new MySqlConnection(connStr);
            this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
            this.userTableAdapter1.Fill(this.bookCheckoutDataSet.user);
            this.bookTableAdapter.Fill(this.bookCheckoutDataSet.book);

            String stm = "SELECT * FROM book;";
            globalAdp = show(stm, conn);
        }

        private void btn_showFines_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
            this.userTableAdapter1.Fill(this.bookCheckoutDataSet.user);
            this.bookTableAdapter.Fill(this.bookCheckoutDataSet.book);


            String stm = $"SELECT student.userID, student.studentFirstName, student.studentLastName, parent.parentFirstName, parent.parentLastName, parent.parentPhone, user.fines FROM student, parent, user WHERE '{txt_UID.Text.ToString()}' = student.userID AND student.userID = user.userID AND student.userID = parent.studentID;";
            globalAdp = show(stm, conn);


        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }








        // Checkout Button
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);

        //    var checkout = bookCheckoutDataSet.checkout;
        //    String bookTitle = comboBox1.Text;
        //    String bookID = comboBox2.Text;
        //    String UID = comboBox3.Text;
        //    String checkoutNum = $"SELECT COUNT(*) FROM checkout WHERE bookID = {bookID};";
        //    String classes = $"SELECT COUNT(*) FROM takes WHERE studentID = {UID};";
        //    String books = $"SELECT COUNT(*) FROM checkout WHERE userID = {UID};";
        //    String countOverdue = $"SELECT COUNT(*) FROM checkout WHERE userID = {UID} AND dueDate < '{thisDay}';";
        //    String finesAmt = $"SELECT fines FROM user WHERE userID = {UID};";

        //    try
        //    {
        //        // Setup SQL variables
        //        int checkedOut = writeSQL(checkoutNum);
        //        int numClasses = writeSQL(classes);
        //        int numBooks = writeSQL(books);
        //        int overdue = writeSQL(countOverdue);
        //        int fine = writeSQL(finesAmt);

        //        // Test if initialization of SQL variables was successful
        //        if (checkedOut == -1 || numClasses == -1 || numBooks == -1 || overdue == -1 || fine == -1)
        //        {
        //            MessageBox.Show("ERROR: Initialization of SQL variables failed!");
        //        }

        //        // If book is already checked out, throw error
        //        else if (checkedOut > 0)
        //        {
        //            MessageBox.Show("Requested book is already checked out.");
        //        }

        //        // If student already has max books, throw error
        //        else if (numClasses <= numBooks && numClasses > 0)
        //        {
        //            MessageBox.Show("Student has checked out the maximum number of books.");
        //        }

        //        // If user has a book that is overdue, throw error
        //        else if (overdue > 0)
        //        {
        //            MessageBox.Show("User has an overdue book, and cannot checkout another until it is returned.");
        //        }

        //        // If user has more than $5 in fines, throw error
        //        else if (fine > 5)
        //        {
        //            MessageBox.Show("User has more than $5 in fines, and cannot check out a book until they pay.");
        //        }

        //        // If no problems
        //        else
        //        {
        //            try
        //            {
        //                MySqlConnection conn = new MySqlConnection(connStr);
        //                conn.Open();

        //                string sql = $"INSERT INTO bookCheckout.checkout VALUES ( '{bookID}', '{UID}', '{thisDay}', '{next}' );";
        //                MySqlCommand cmd = new MySqlCommand(sql, conn);
        //                MySqlDataReader rdr = cmd.ExecuteReader();

        //                conn.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.ToString());
        //            }

        //            this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        //// Return Button
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MySqlConnection conn = new MySqlConnection(connStr);
        //    String bookID = comboBox4.Text.ToString();

        //    try
        //    {
        //        Console.WriteLine("Connecting to MySQL...");
        //        conn.Open();

        //        string sql = $"DELETE FROM bookCheckout.checkout WHERE bookID = {bookID}";
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);
        //        MySqlDataReader rdr = cmd.ExecuteReader();

        //        conn.Close();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }

        //    this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
        //}

        // Renew Button
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    MySqlConnection conn = new MySqlConnection(connStr);
        //    String bookID = comboBox6.Text.ToString();

        //    try
        //    {
        //        Console.WriteLine("Connecting to MySQL...");
        //        conn.Open();

        //        string sql = $"UPDATE bookCheckout.checkout SET dueDate = '{next}' WHERE bookID = {bookID};";
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);
        //        MySqlDataReader rdr = cmd.ExecuteReader();

        //        conn.Close();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }

        //    this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
        //}

        //// Update Button
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    MySqlConnection conn = new MySqlConnection(connStr);
        //    this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
        //    this.userTableAdapter1.Fill(this.bookCheckoutDataSet.user);
        //    this.bookTableAdapter.Fill(this.bookCheckoutDataSet.book);

        //    if (comboBox5.Text.ToString().Equals("Books Checked Out"))
        //    {
        //        String stm = "SELECT * FROM checkout;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox5.Text.ToString().Equals("Books Checked Out (Students)"))
        //    {
        //        String stm = "SELECT student.userID, studentFirstName, studentLastName, bookID, checkoutDate, dueDate FROM checkout, student WHERE student.userID = checkout.userID ORDER BY student.userID;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox5.Text.ToString().Equals("Books Checked Out (Class)"))
        //    {
        //        String stm = "SELECT takes.classID, class.className, class.classSection, checkout.bookID, book.bookTitle FROM takes, class, book, checkout WHERE checkout.userID = takes.studentID AND book.bookID = checkout.bookID AND takes.classID = class.classID ORDER BY takes.classID;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox5.Text.ToString().Equals("Overdue Books"))
        //    {
        //        String stm = $"SELECT * FROM checkout WHERE dueDate < '{thisDay}' ORDER BY userID;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox5.Text.ToString().Equals("All Books"))
        //    {
        //        String stm = "SELECT * FROM book;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox5.Text.ToString().Equals("Student Balances"))
        //    {

        //        String stm = "SELECT student.userID, student.studentFirstName, student.studentLastName, parent.parentFirstName, parent.parentLastName, parent.parentPhone, user.fines FROM student, parent, user WHERE student.userID = user.userID AND student.userID = parent.studentID ORDER BY student.userID;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox5.Text.ToString().Equals("Teacher Balances"))
        //    {

        //        String stm = "SELECT teacher.userID, teacher.teacherFirstName, teacher.teacherLastName, user.fines FROM teacher, user WHERE user.userID = teacher.userID ORDER BY teacher.userID;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox5.Text.ToString().Equals("User Access"))
        //    {
        //        String stm = "SELECT userID, username, accessLevel FROM user;";
        //        globalAdp = show(stm, conn);
        //    }
        //}

        // Save Button
        //private void button5_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataTable changes = dgv2dt(dataGridView1).GetChanges();
        //        if (changes != null)
        //        {
        //            MySqlCommandBuilder mcb = new MySqlCommandBuilder(globalAdp);
        //            globalAdp.UpdateCommand = mcb.GetUpdateCommand();
        //            globalAdp.Update(changes);
        //            DataTable data = dgv2dt(dataGridView1);
        //            data.AcceptChanges();

        //            MessageBox.Show("Cell Updated");
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        // Show SQL SELECT in dataGridView
        private MySqlDataAdapter show(String stm, MySqlConnection conn)
        {
            conn.Open();
            dataGridView1.DataSource = null;

            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = new MySqlCommand(stm, conn);
            DataTable table = new DataTable();
            adp.Fill(table);

            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            dataGridView1.DataSource = bs;

            conn.Close();
            return adp;

        }

        // Convert dataGridView source to dataTable
        private DataTable dgv2dt(DataGridView dgv)
        {
            var bs = (BindingSource)dgv.DataSource;
            var dt = ((DataTable)bs.DataSource).Copy();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (!column.Visible)
                {
                    dt.Columns.Remove(column.Name);
                }
            }
            return dt;
        }


        ///// ///////////////////////////////////////////////////////////
        //// USELESS

        //// Book ID for return
        //private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //// Book name to checkout
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //// Book ID to checkout
        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //// User ID for checkout
        //private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}

        //private void label5_Click(object sender, EventArgs e)
        //{

        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        //private void checkoutBindingSource_CurrentChanged(object sender, EventArgs e)
        //{

        //}


        //private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void button6_Click(object sender, EventArgs e)
        //{



        //    String UID = comboBox8.Text;


        //    MySqlConnection conn = new MySqlConnection(connStr);
        //    this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
        //    this.userTableAdapter1.Fill(this.bookCheckoutDataSet.user);
        //    this.bookTableAdapter.Fill(this.bookCheckoutDataSet.book);




        //    if (comboBox7.Text.ToString().Equals("Books Checked Out"))
        //    {
        //        String stm = $"SELECT checkout.userID, student.studentFirstName, student.studentLastName, book.bookId, book.bookTitle FROM checkout, student, book WHERE {UID} = checkout.userID = student.userID AND checkout.bookID = book.BookID;";
        //        globalAdp = show(stm, conn);
        //    }

        //    else if (comboBox7.Text.ToString().Equals("Overdue Books"))
        //    {
        //        String stm = $"SELECT checkout.userID, student.studentFirstName, student.studentLastName,book.bookId, book.bookTitle, user.fines FROM checkout, book, user, student WHERE checkout.dueDate < '{thisDay}' AND checkout.userID = '{UID}' AND checkout.bookID = book.bookID AND '{UID}' = user.userID AND '{UID}' = student.userID;";
        //        globalAdp = show(stm, conn);
        //    }

        //    else if (comboBox7.Text.ToString().Equals("Student Balances"))
        //    {

        //        String stm = $"SELECT student.userID, student.studentFirstName, student.studentLastName, parent.parentFirstName, parent.parentLastName, parent.parentPhone, user.fines FROM student, parent, user WHERE '{UID}' = student.userID AND student.userID = user.userID AND student.userID = parent.studentID;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox7.Text.ToString().Equals("Teacher Balances"))
        //    {

        //        String stm = $"SELECT teacher.userID, teacher.teacherFirstName, teacher.teacherLastName, user.fines FROM teacher, user WHERE '{UID}' = user.userID AND user.userID = teacher.userID ORDER BY teacher.userID;";
        //        globalAdp = show(stm, conn);
        //    }
        //    else if (comboBox7.Text.ToString().Equals("User Access"))
        //    {
        //        String stm = $"SELECT user.userID, user.username, user.accessLevel FROM user WHERE '{UID}' = user.userID;";
        //        globalAdp = show(stm, conn);
        //    }







        //}

        //private void button7_Click(object sender, EventArgs e)
        //{

        //    String fName = textBox1.Text;
        //    String lName = textBox2.Text;

        //    MySqlConnection conn = new MySqlConnection(connStr);
        //    this.checkoutTableAdapter1.Fill(this.bookCheckoutDataSet.checkout);
        //    this.userTableAdapter1.Fill(this.bookCheckoutDataSet.user);
        //    this.bookTableAdapter.Fill(this.bookCheckoutDataSet.book);


        //    String stm = $"SELECT student.userID FROM student WHERE student.studentFirstName = '{fName}' AND student.studentLastName = '{lName}';";
        //    globalAdp = show(stm, conn);







        //}


    }
}
