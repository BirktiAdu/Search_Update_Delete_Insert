using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Search_Update_Delete_Insert
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = " Data Source =DESKTOP-U75EESK\\SQLEXPRESS;Initial Catalog = c#;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            int Id = int.Parse(tb_id.Text);
            String FirstName = tb_firstname.Text;
            String LastName = tb_lastname.Text;
            String Email = tb_email.Text;
            String Address = tb_address.Text;
            String PhoneNo = tb_phoneno.Text;
           
          

            string Query = "  INSERT INTO MAIN_PAGE(ID, FIRSTNAME, LASTNAME, EMAIL, ADDRESS, PHONENO)VALUES("+Id+", '"+FirstName+"', '"+LastName+"', '"+Email+"', '"+Address+"', "+PhoneNo+")";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("DATA SAVED SUCCESSFULLY");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = " Data Source =DESKTOP-U75EESK\\SQLEXPRESS;Initial Catalog = c#;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            String NameId = tb_id.Text;
            String FirstName = tb_firstname.Text;
            String LastName = tb_lastname.Text;
            String Email = tb_email.Text;
            String Address = tb_address.Text;
            String PhoneNo = tb_phoneno.Text;



            string Query = " SELECT*FROM MAIN_PAGE";
            SqlCommand cmd = new SqlCommand(Query, conn);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;
            

            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConnectionString = " Data Source =DESKTOP-U75EESK\\SQLEXPRESS;Initial Catalog = c#;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            String NameId = tb_id.Text;
            String FirstName = tb_firstname.Text;
            String LastName = tb_lastname.Text;
            String Email = tb_email.Text;
            String Address = tb_address.Text;
            String PhoneNo = tb_phoneno.Text;



            string Query = " UPDATE MAIN_PAGE SET FIRSTNAME = '"+FirstName+ "', LASTNAME ='" + LastName + "', EMAIL = '" + Email + "', ADDRESS = '" + Address + "', PHONENO = " + PhoneNo + " WHERE ID = " + NameId;
            //
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("DATA SAVED UPDATED");

            tb_id.Text = "";
            tb_firstname.Text = " ";
            tb_lastname.Text= " ";
            tb_email.Text = "";
            tb_address.Text = "";
            tb_phoneno.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ConnectionString = " Data Source =DESKTOP-U75EESK\\SQLEXPRESS;Initial Catalog = c#;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            String NameId = tb_id.Text;
          



            string Query = "DELETE FROM MAIN_PAGE WHERE ID = "+NameId;
            SqlCommand cmd = new SqlCommand(Query, conn);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;


            conn.Close();
        }
    }
}
