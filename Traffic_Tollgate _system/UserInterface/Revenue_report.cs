using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Tollgate__system.UserInterface
{
    public partial class Revenue_report : Form
    {
        public Revenue_report()
        {
            InitializeComponent();
        }

        private void Revenue_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userInfoDataSet.DB_Main' table. You can move, or remove it, as needed.
            this.dB_MainTableAdapter.Fill(this.userInfoDataSet.DB_Main);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
