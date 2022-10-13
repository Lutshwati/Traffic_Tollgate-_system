using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Traffic_Tollgate__system.Data_Logic;
using System.Windows.Forms;

namespace Traffic_Tollgate__system.UserInterface
{
    public partial class Main : Form
    {

        DBAccess objDBAccess = new DBAccess();
        public Main()
        {
            InitializeComponent();
        }
        String Vehicle_Type;
        Decimal price;
        String _Manufacture;
        String _Colour;
        String _regNum;
        String _Name;
        DateTime _DateTime;
        String _Province;

        private void button1_Click_1(object sender, EventArgs e)
        {

            Vehicles Motors = new Vehicles();
            Motors.Capture(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text);
            _Manufacture = Motors.manufacturer;
            _Colour = Motors.colour;
            _regNum = Motors.reg_number;
            _Name = Motors.name;
            _DateTime = DateTime.Now;
            _Province = cmProv.SelectedItem.ToString();


            if (rdLight.Checked)
            {
                Light__Vehicles Get = new Light__Vehicles();
                Get.Put("Light Vehicle", 34);
                Vehicle_Type = Get.VehicleType;
                price = Get.Price;

                lsb_Details.Items.Clear();
                lsb_Details.Items.Add(Vehicle_Type);
                lsb_Details.Items.Add("R" + price + ",00");
            }
            else
            if (rdMedium.Checked==true)
            {
                MediumVehicles Get = new MediumVehicles();
                Get.Put("Medium vehicle", 57);
                Vehicle_Type = Get.VehicleType;
                price = Get.Price;

                lsb_Details.Items.Clear();
                lsb_Details.Items.Add(Vehicle_Type);
                lsb_Details.Items.Add("R" + price + ",00");
            }
            else
            if (rdLarge.Checked==true)
            {
                LargeVehicles Get = new LargeVehicles();
                Get.Put("Large Vehicle", 61);
                Vehicle_Type = Get.VehicleType;
                price = Get.Price;

                lsb_Details.Items.Clear();
                lsb_Details.Items.Add(Vehicle_Type);
                lsb_Details.Items.Add("R" + price + ",00");

                
            }
            else
            if (rdExtraL.Checked==true)
            {
                ExtrLargeVehicles Get = new ExtrLargeVehicles();
                Get.Put("Extra-Large Vehicle", 115);
                Vehicle_Type = Get.VehicleType;
                price = Get.Price;

                lsb_Details.Items.Clear();
                lsb_Details.Items.Add(Vehicle_Type);
                lsb_Details.Items.Add("R" + price + ",00");
            }


            if (textBox1.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show(" Error! Please enter valid Details");
            }
            else
            {
                try
                {
                    lsb_Details.Items.Add(_Manufacture);
                    lsb_Details.Items.Add(_Colour);
                    lsb_Details.Items.Add(_regNum);
                    lsb_Details.Items.Add(_Name);
                    lsb_Details.Items.Add(_DateTime.ToString());
                    lsb_Details.Items.Add(_Province);
                
                SqlCommand sqlCommand1 = new SqlCommand("insert into DB_Main(Manufacturer,Colour,Reg_number,Name,Vehicle_Type,Province,Date_Time,Price) values(@_Manufacture,@_Colour,@_regNum,@_Name,@Vehicle_Type,@_Province,@_DateTime,@price)");

                    sqlCommand1.Parameters.AddWithValue("@_Manufacture", _Manufacture);
                    sqlCommand1.Parameters.AddWithValue("@_Colour", _Colour);
                    sqlCommand1.Parameters.AddWithValue("@_regNum", _regNum);
                    sqlCommand1.Parameters.AddWithValue("@_Name", _Name);
                sqlCommand1.Parameters.AddWithValue("@Vehicle_Type", Vehicle_Type);
                    sqlCommand1.Parameters.AddWithValue("@_Province", _Province);
                sqlCommand1.Parameters.AddWithValue("@_DateTime", _DateTime);
                sqlCommand1.Parameters.AddWithValue("@price", price);

                    int Row = objDBAccess.executeQuery(sqlCommand1);

                    if(Row == 1)
                    {
                        MessageBox.Show("Data successfully saved!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occured while savig data");
                }
            }
        }

        private void btnLog_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Are you sure ?");
            SignUp Back = new SignUp();
            Back.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
           printPreviewDialog1.Document = printDocument1;
           printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            try
            {

                e.Graphics.DrawString("Traffic Tolgate System", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(300, 20));
                e.Graphics.DrawString("Payment Details   :", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(10, 100));
                e.Graphics.DrawString("Driver Name :" + " " + _Name, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 130));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 150));
                e.Graphics.DrawString("\r\n" + "Manufacture Name :" + " " + _Manufacture, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 150));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 190));
                e.Graphics.DrawString("\r\n" + "vehicle Colour :" + " " + _Colour, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 190));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 230));
                e.Graphics.DrawString("\r\n" + "vehicle Registration Number :" + " " + _regNum, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 230));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 270));
                e.Graphics.DrawString("\r\n" + "vehicle Class :" + Vehicle_Type, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 270));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 310));
                e.Graphics.DrawString("\r\n" + "vehicle registration Province :" + " " + _Province, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 310));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 350));
                e.Graphics.DrawString("\r\n" + "Issued Date & Time :" + " " + _DateTime, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 350));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 390));
                e.Graphics.DrawString("\r\n" + "vehicle Colour :" + " " + _Colour, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 390));
                e.Graphics.DrawString("****************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 430));
                e.Graphics.DrawString("\r\n" + "Price paid  :" + " R" + price + ",00", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(700, 430));
                e.Graphics.DrawString("********************************************************************************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 470));
                e.Graphics.DrawString("********************************************************************************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 510));
                e.Graphics.DrawString("\r\n" + "Thank you for your cooperation ", new Font("Calibri", 12, FontStyle.Bold), Brushes.Black, new Point(10, 530));
                e.Graphics.DrawString("\r\n" + "Here is your Reciept", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(300, 590));
                e.Graphics.DrawString("********************************************************************************************************************", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 640));
                e.Graphics.DrawString("Email : customercare@ectransport.gov.za", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(10, 670));
                e.Graphics.DrawString("Tell : 0800-644-644", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, new Point(700, 670));

            }
            catch (Exception)
            {

                MessageBox.Show("Error occured pleases restart the application");
            }
        }
    }
}
