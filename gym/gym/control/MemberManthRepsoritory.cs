using gym.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.control
{
    public static class MemberManthRepsoritory
    {
        public static void AddMemberManth(this MemberManth sub, ref SqlCommand cmd)
        {

            cmd.CommandText = "INSERT INTO [dbo].[Gym_Members]([Member_Name],[Member_Address],[Member_Phone],[Member_Age],[Member_height],[Member_weitgh],[chronic_disease],[Date_Subscription]) VALUES" + "(@Member_Name,@Member_Address,@Member_Phone,@Member_Age,@Member_height,@Member_weitgh,@chronic_disease,@Date_Subscription);";

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Teacherid", sub.Member_Name);
            cmd.Parameters.AddWithValue("@Teachername", sub.Member_Address);
            cmd.Parameters.AddWithValue("@Teacherdegree", sub.Member_Phone);
            cmd.Parameters.AddWithValue("@Teacherfunctional", sub.Member_Age);
            cmd.Parameters.AddWithValue("@Teachername", sub.Member_height);
            cmd.Parameters.AddWithValue("@Teacherdegree", sub.Member_weitgh);
            cmd.Parameters.AddWithValue("@Teacherfunctional", sub.chronic_disease);
            cmd.Parameters.AddWithValue("@Teacherfunctional", sub.Date_Subscription);
            
            // MessageBox.Show();
            cmd.ExecuteNonQuery();
        }
    }
}
