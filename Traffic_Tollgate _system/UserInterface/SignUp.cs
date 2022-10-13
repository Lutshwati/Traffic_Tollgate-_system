using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traffic_Tollgate__system.UserInterface;
using Traffic_Tollgate__system.Data_Logic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Traffic_Tollgate__system.UserInterface
{
    public partial class SignUp : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public SignUp()
        {
            InitializeComponent();
        }
        String username;
        int PIN;
        int ID_Numbers;
        private void button2_Click(object sender, EventArgs e)
        {
                if(txtPaswd.Text.Length < 4)
                {
                    MessageBox.Show("Pin too short, please enter a Pin with 4 or more digits.");
                }else

                if(txtID.Text.Length < 8 || txtID.Text.Length > 8)
                {
                    MessageBox.Show("Please Enter any 8 digits of your choice.");
                }
                else
            if (username == "" && PIN == Convert.ToInt32(""))
            {
                MessageBox.Show(" Error! Please enter valid Details...");
            }
            else
            try
            {

                Sign_up Get = new Sign_up();
                Get.SetVal(Convert.ToInt32(txtPaswd.Text), txtUser.Text, Convert.ToInt32(txtID.Text));
                username = Get.Username;
                PIN = Get.Pin;
                ID_Numbers = Get.ID;


                    SqlCommand insertCommand = new SqlCommand("insert into DBSignUp(Username, Pin, ID_Number) values(@username,@PIN,@ID_Numbers)");

                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@PIN", PIN);
                    insertCommand.Parameters.AddWithValue("@ID_Numbers", ID_Numbers);
                    objDBAccess.executeQuery(insertCommand);

                    MessageBox.Show("SignUp Successful! press Ok.");

                    this.Hide();
                    frmLogIn Go = new frmLogIn();
                    Go.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error occured, please press ok to try again");

                this.Hide();
                SignUp Show = new SignUp();
                Show.ShowDialog();
                    
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn AlreadyExist = new frmLogIn();
            AlreadyExist.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogIn AlreadyExist = new frmLogIn();
            AlreadyExist.Close();
            Main A = new Main();
            A.Close();
            ForgotPin ReturnTo = new ForgotPin();
            ReturnTo.Close();
            this.Close();
        }
    }
}
