using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyFirstWebApplication
{
    public class ClassSchedule
    {
        #region Declarations
        public string sectName { get; set; } //Section name
        public int credhrs { get; set; } //credit hours
        public string courseName { get; set; }
        public int totalSeats { get; set; }
        public string room { get; set; }
        public string days { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string teachFullName { get; set; }
        public string location { get; set; }
        #endregion

        #region Methods
        public static List<ClassSchedule> GetClassScheduleData()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spClassScheduleDisplay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<ClassSchedule> schedule = new List<ClassSchedule>();
            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ClassSchedule cs = new ClassSchedule();
                    cs.sectName = rdr["SectionName"].ToString();
                    cs.credhrs = Convert.ToInt32(rdr["CreditHrs"]);
                    cs.courseName = rdr["CourseName"].ToString();
                    cs.totalSeats = Convert.ToInt32(rdr["TotalSeats"]);
                    cs.room = rdr["Room"].ToString();
                    cs.days = rdr["Days"].ToString();
                    cs.startTime = rdr["StartTime"].ToString();
                    cs.endTime = rdr["EndTime"].ToString();
                    cs.teachFullName = rdr["TeachFullName"].ToString();
                    cs.location = rdr["Location"].ToString();
                    schedule.Add(cs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return schedule;
        }
        #endregion
    }
}