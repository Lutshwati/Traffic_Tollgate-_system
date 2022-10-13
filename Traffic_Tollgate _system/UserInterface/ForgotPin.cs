using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traffic_Tollgate__system.Data_Logic;
using System.Windows.Forms;

namespace Traffic_Tollgate__system.UserInterface
{
    public partial class ForgotPin : Form
    {
        public static string id, username, pin, id_Number;

        DBAccess objDBAccess = new DBAccess();
        DataTable UserInfo = new DataTable();
        public ForgotPin()
        {
            InitializeComponent();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                int RecPin = Convert.ToInt32(txtRecorver.Text);

                String query2 = "Select * from DBSignUp Where ID_Number ='" + RecPin + "'";
                objDBAccess.readDatathroughAdapter(query2, UserInfo);

                if (UserInfo.Rows.Count == 1)
                {

                    id = UserInfo.Rows[0]["ID"].ToString();
                    username = UserInfo.Rows[0]["Username"].ToString();
                    pin = UserInfo.Rows[0]["Pin"].ToString();
                    id_Number = UserInfo.Rows[0]["ID_Number"].ToString();

                    objDBAccess.closeConn();

                    MessageBox.Show("Here are your LogIn details..." +
                        "Your Username is :  " + username
                        + "  ," + "Your Pin is :  " + pin);

                    this.Hide();
                    Main A = new Main();
                    A.ShowDialog();
                }
            }
            catch (Exception)
            {
                 MessageBox.Show("Error!!!, Please Enter Valid details... ");
            }
        }
    }
}
