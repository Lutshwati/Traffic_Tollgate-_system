using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Traffic_Tollgate__system.Data_Logic;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Traffic_Tollgate__system.Data_Logic
{
    public class Sign_up
    {
        
        public String Username { get; set; }
        public int Pin { get; set; }
        public int ID { get; set; }
        public Sign_up()
        {
            Username = String.Empty;
            Pin = 0;
            ID = 0;
        }
        public void SetVal(int Pin, String User, int id)
        {
            Username = User;
            this.Pin = Pin;
            ID = id;
        }
        
    }
}
