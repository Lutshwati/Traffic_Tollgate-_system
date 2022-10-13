using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traffic_Tollgate__system.UserInterface;
using System.Data.SqlClient;
using Traffic_Tollgate__system.Data_Logic;
using System.Windows.Forms;

namespace Traffic_Tollgate__system.UserInterface
{
    public partial class frmLogIn : Form
    {
        public static string id, username, pin, id_Number;

        DBAccess objDBAccess = new DBAccess();
        DataTable UserInfo = new DataTable();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp Show = new SignUp();
            Show.ShowDialog();
        }

        public frmLogIn()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String userName = txtUserS.Text;
                int Userpin = Convert.ToInt32(txtPin.Text);



                if (txtPin.Text == "" && txtUserS.Text == "")
                {
                    MessageBox.Show("Error! Please enter Something");
                }
                else
                {
                    String query = "Select * from DBSignUp Where Username ='" + userName + "' AND Pin = '" + Userpin + "'";

                    objDBAccess.readDatathroughAdapter(query, UserInfo);
                    if (UserInfo.Rows.Count == 1)
                    {

                        id = UserInfo.Rows[0]["ID"].ToString();
                        username = UserInfo.Rows[0]["Username"].ToString();
                        pin = UserInfo.Rows[0]["Pin"].ToString();
                        id_Number = UserInfo.Rows[0]["ID_Number"].ToString();

                        objDBAccess.closeConn();

                        this.Hide();
                        Main A = new Main();
                        A.ShowDialog();
                    }
                }
            }
            catch
            { 
                    {
                        MessageBox.Show("Error! You've entered incorrect details");
                        this.Hide();
                        frmLogIn Show = new frmLogIn();
                        Show.ShowDialog();
                    }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPin ReturnTo = new ForgotPin();
            ReturnTo.ShowDialog();

        }
    }
}
