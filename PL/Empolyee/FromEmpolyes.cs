using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsAppManager.PL.Empolyee
{
    public partial class F_Employee : Form
    {
        Data.db_connection db = new Data.db_connection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adp;
        DataTable dt = new DataTable();
        public void checkConnection()
        {
            if (db.connect.State == ConnectionState.Closed)
            {
                db.connect.Open();
            }
        }
        public F_Employee()
        {
            InitializeComponent();
        }

        public void refreshing()
        {
            adp = new MySqlDataAdapter("select * from EMP ; ", db.connect);
            dt.Rows.Clear();
            adp.Fill(dt);
            Affiche_EMP.DataSource = dt;
            Affiche_EMP.Columns[0].Visible = false;
            Affiche_EMP.Columns[1].HeaderText = "Name Empolyee";
            Affiche_EMP.Columns[2].HeaderText = "Number Phone ";
            Affiche_EMP.Columns[3].HeaderText = "Hire Date ";

        }

        private void F_Employee_Load(object sender, EventArgs e)
        {
            refreshing();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtn.Text))
            {
                MessageBox.Show("Please choose the employee you wont and double click on it  !!!");
            }
            else
            {
                checkConnection();
                string sql = "DELETE FROM `emp` WHERE  emp_name='" + txtn.Text + "'and emp_num_phone='" + txtnum.Text + "'and HireDate='" + date.Text + "'and ID ='" + Affiche_EMP.CurrentRow.Cells[0].Value.ToString() + "'";
                cmd = new MySqlCommand(sql, db.connect);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Employee deleted successfully!");
                }
            }
            refreshing();
            ClearFields();


        }

        private void ad_Click(object sender, EventArgs e)
        {
            txtn.Clear();
            txtnum.Clear();
            date.Text = DateTime.Now.ToString();
            txtn.Select();
        }

        private void ClearFields()
        {
            txtn.Text = "";
            txtnum.Text = "";
            date.Value = DateTime.Now;
        }

        private void sav_Click(object sender, EventArgs e)

        {
            checkConnection();
            string query = "INSERT INTO `emp`(`emp_name`, `emp_num_phone`, `HireDate`) VALUES ('" + txtn.Text + "','" + txtnum.Text + "','" + date.Text + "')";
            if (string.IsNullOrEmpty(txtn.Text))
            {
                MessageBox.Show("Please Enter an employee name !");
            }
            else if (string.IsNullOrEmpty(txtnum.Text))
            {
                MessageBox.Show("Please Enter an employee Number Phone !");
            }

            else
            {
                cmd = new MySqlCommand(query, db.connect);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Employee added successfully!");
                }
            }
           
            refreshing();
            ClearFields();

        }

        private void Affiche_EMP_DoubleClick(object sender, EventArgs e)
        {
            txtn.Text = Affiche_EMP.CurrentRow.Cells[1].Value.ToString();
            txtnum.Text = Affiche_EMP.CurrentRow.Cells[2].Value.ToString();
            date.Text = Affiche_EMP.CurrentRow.Cells[3].Value.ToString();
        }

        private void ed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtn.Text))
            {
                MessageBox.Show("Please choose the employee you wont and double click on it  !!!");
            }
            else
            {
                checkConnection();
                string sql = "update emp set emp_name='" + txtn.Text + "', emp_num_phone='" + txtnum.Text + "', HireDate='" + date.Text + "'where ID ='" + Affiche_EMP.CurrentRow.Cells[0].Value.ToString() + "'";
                cmd = new MySqlCommand(sql, db.connect);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Employee Updated successfully!");
                }
            }
            refreshing();
            ClearFields();

        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
