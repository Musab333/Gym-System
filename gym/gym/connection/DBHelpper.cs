using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gym.connction
{
    public class DBHelpper
    {
      
        public static string conString
        {
            get
            {
                //DESKTOP-MT1F29A\SQLEXPRESS
                return " Server =.\\SQLEXPRESS; database = Gym_System; Integrated Security = true;";
            }
        }
    }
}
