using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    class Database
    {


      
        SqlConnection con = new SqlConnection(Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString);
       
        //>>>>>>>>>>>>>>>>>>>>GET COLUMNS<<<<<<<<<<<<<<<<<<

        public int getType(string un,string pw)
        {

            string query = "select Type from UserTable where Username ='" + un + "' AND Password ='" + pw  + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
           
            try
            {
                
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();

                return Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                

            }
            catch{
            Login.l.Error();
            throw;
            }
            
            
            
        }

          public  string getFname(string un) 
        {
            string query = "select FirstName from UserTable where Username='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();

            }

            catch { throw; }
          }

         public  string getLname(string un) 
        {
            string query = "select LastName from UserTable where Username ='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();
            
       }
            catch{throw;}
          }

         public string getGndr(string un) 
        {
          
            string query = "select Gender from UserTable where UserName ='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();
       }
            catch{throw;}
          }

         public string getAg(string un) 
        {
            string query = "select Age from UserTable where Username ='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();
       }
            catch{throw;}
          }

         public string getCell(string un) 
        {
            string query = "select CellPhone from UserTable where Username ='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();
       }
            catch{throw;}
          }

         public string getPost(string un) 
        {
            string query = "select Post from UserTable where Username ='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();
       }
            catch{throw;}
          }

         public string getBG(string un) 
        {
            string query = "select BloodGroup from UserTable where Username ='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt.Rows[0].ItemArray[0].ToString();
       }
            catch{throw;}
          }

         public string getDocedu(string un) 
        {
            string query = "select Education from UserTable where Username='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();
       }
            catch{throw;}
          }

         public string getEC(string un) 
        {
            string query = "select EmergencyContact from UserTable where Username ='" + un + "'";

            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            try{
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();
       }
            catch{throw;}
          }

         public string getId(string un)
         {
             string query = "select Id from UserTable where Username='" + un + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 SqlDataReader dr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 con.Close();
                 return dt.Rows[0].ItemArray[0].ToString();

             }
             catch { throw; }
         }

         public string getPW(string un)
         {
             string query = "select Password from UserTable where Username='" + un + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 SqlDataReader dr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 con.Close();
                 return dt.Rows[0].ItemArray[0].ToString();

             }

             catch { throw; }
         }

         public string gettype(string un)
         {
             string query = "select Type from UserTable where Username='" + un + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 SqlDataReader dr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 con.Close();
                 return dt.Rows[0].ItemArray[0].ToString();

             }

             catch { throw; }
         }



        //>>>>>>>>>>>>>>>>>>>PATIENT METHODS<<<<<<<<<<<<<<<<<<<<

         
          public string getPFname(string pn)
         {
             string query = "select FirstName from PatientsTable where PatientNo='" + pn + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 SqlDataReader dr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 con.Close();
                 return dt.Rows[0].ItemArray[0].ToString();

             }

             catch { throw; }
         }

        public string getPLname(string pn)
        {
            string query = "select LastName from PatientsTable where PatientNo='" + pn + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();

            }

            catch { throw; }
        }

        public string getPAge(string pn)
        {
            string query = "select Age from PatientsTable where PatientNo='" + pn + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();

            }

            catch { throw; }
        }


        public string getPGender(string pn)
        {
            string query = "select Gender from PatientsTable where PatientNo='" + pn + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();

            }

            catch { throw; }
        }

        public string getPBGroup(string pn)
        {
            string query = "select BloodGroup from PatientsTable where PatientNo='" + pn + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();

            }

            catch { throw; }
        }

        public string getPAddress(string pn)
        {
            string query = "select Address from PatientsTable where PatientNo='" + pn + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();

            }

            catch { throw; }
        }

        public string getPCell(string pn)
        {
            string query = "select CellPhone from PatientsTable where PatientNo='" + pn + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                return dt.Rows[0].ItemArray[0].ToString();

            }

            catch { throw; }
        }

         public string getPDoc(string pn)
         {
             string query = "select Doctor from PatientsTable where PatientNo='" + pn + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 SqlDataReader dr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 con.Close();
                 return dt.Rows[0].ItemArray[0].ToString();

             }
             catch { throw; }
         }


         public string getPRoom(string pn)
         {
             string query = "select RoomNo from PatientsTable where PatientNo='" + pn + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 SqlDataReader dr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 con.Close();
                 return dt.Rows[0].ItemArray[0].ToString();

             }
             catch { throw; }
         }

         public string getPDocID(string pn)
         {
             string query = "select DoctorID from PatientsTable where PatientNo='" + pn + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);

             try
             {
                 SqlDataReader dr = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(dr);
                 con.Close();
                 return dt.Rows[0].ItemArray[0].ToString();

             }
             catch { throw; }
         }


     //>>>>>>>>>>>>>>>>>>>LIST METHODS<<<<<<<<<<<<<<<<<<<<

         public DataTable getPlist()
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             SqlCommand cmd = new SqlCommand("select * from PatientsTable", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }

         public DataTable getDoclist()
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             string tp = "1";
             SqlCommand cmd = new SqlCommand("select * from UserTable where Type='" + tp + "'",con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }

         public DataTable getstafflist()
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             string tp = "2";
             SqlCommand cmd = new SqlCommand("select * from UserTable where Type='" + tp + "'", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }

         public DataTable getRmlist()
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             SqlCommand cmd = new SqlCommand("select * from RoomTable", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }

         public DataTable getAvailableRms()
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             
             SqlCommand cmd = new SqlCommand("select * from RoomTable where PatientName is null", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }

         public DataTable getDoctorpatientList(string id)
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             SqlCommand cmd = new SqlCommand("select * from PatientsTable where DoctorID='" + id + "'", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }



        //>>>>>>>>>>>>DOCTOR ADD REMOVE UPDATE<<<<<<<<<<<<<<<<

         public void addDoc(string id, string fn, string ln, string un, string ag, string gen, string bg, string cell, string docedu, string post, string pass, string ec,int type)
         {
             string query = "insert into UserTable(Id,FirstName,LastName,Username,Gender,Age,CellPhone,BloodGroup,EmergencyContact,Post,Education,Password,Type) values('" + id + "','" + fn + "','" + ln + "','" + un + "','" + gen + "','" + ag + "','" + cell + "','" + bg + "','" + ec + "','" + post + "','" + docedu + "','" + pass + "','" + type + "')";
             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }

         public void removeDoc(string ID) {

             string query = "delete from UserTable where Id='" + ID + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         
         }

         public void updateDoc(string id, string fn, string ln, string un, string ag, string gen, string bg, string cell, string docedu, string post, string pass, string ec, string type)
         {
             string query = "update UserTable set FirstName ='" + fn + "',LastName='" + ln + "',Username='" + un + "',Gender='" + gen + "',Age='" + ag + "',CellPhone='" + cell + "',BloodGroup='" + bg + "',EmergencyContact='" + ec + "',Post='" + post + "',Education='" + docedu + "',Password='" + pass + "' ,Type='" + type + "' where Id='" + id + "' ";
             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }

        //>>>>>>>>>>>>STAFF ADD REMOVE UPDATE<<<<<<<<<<<<<<

         public void addStf(string id, string fn, string ln, string un, string ag, string gen, string bg, string cell, string post, string pass, string ec, int type)
         {

             string query = "insert into UserTable(Id,FirstName,LastName,Username,Gender,Age,CellPhone,BloodGroup,EmergencyContact,Post,Password,Type) values('" + id + "','" + fn + "','" + ln + "','" + un + "','" + gen + "','" + ag + "','" + cell + "','" + bg + "','" + ec + "','" + post + "','" + pass + "','" + type + "')";
             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }

         public void removeStf(string ID)
         { 
         
             string query = "delete from UserTable where Id='" + ID + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         
         }


         public void updateStaff(string id, string fn, string ln, string un, string gen, string ag, string cell, string bg, string ec, string post, string pass, string type)
         {
             string query = "update UserTable set FirstName ='" + fn + "',LastName='" + ln + "',Username='" + un + "',Gender='" + gen + "',Age='" + ag + "',CellPhone='" + cell + "',BloodGroup='" + bg + "',EmergencyContact='" + ec + "',Post='" + post + "',Password='" + pass + "' ,Type='" + type + "' where Id='" + id + "' ";
             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }

        //>>>>>>>>>>>>>PATIENT ADD REMOVE UPDATE<<<<<<<<<<<<<<<<

         public void addpatnt(string pn, string fn, string ln, string ag, string gen, string bg, string ad, string cell, string dc, string rn,string docid)
         {
             string query = "insert into PatientsTable(PatientNo,FirstName,LastName,Age,Gender,BloodGroup,Address,CellPhone,Doctor,RoomNo,DoctorID) values('" + pn + "','" + fn + "','" + ln + "','" + ag + "','" + gen + "','" + bg + "','" + ad + "','" + cell + "','" + dc + "','" + rn + "','" + docid + "')";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }

         public void removepatnt(string PatientNo)
         {
             string query = "delete from PatientsTable where PatientNo='" + PatientNo + "'";

             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }
        

         public void updatePatnt(string pn, string fn, string ln, string ag, string gen, string bg, string ad, string cell, string doc, string rn,string docid)
         {
             string query = "update PatientsTable set FirstName='" + fn + "',LastName='" + ln + "',Age='" + ag + "',Gender='" + gen + "',BloodGroup='" + bg + "',Address='" + ad + "',CellPhone='" + cell + "',Doctor='" + doc + "',RoomNo='" + rn + "',DoctorID='" + docid + "' where PatientNo='" + pn + "' ";
             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }

        //>>>>>>>>>>>>>>>>>>>SEARCH METHODS<<<<<<<<<<<<<<<<<<<<

         public DataTable searchuser(string fname)
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             SqlCommand cmd = new SqlCommand("select * from UserTable where FirstName='" + fname + "'", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }

         public DataTable searchpatient(string fname)
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             SqlCommand cmd = new SqlCommand("select * from PatientsTable where FirstName='" + fname + "'", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }

        //>>>>>>>>>>>>>>>>>>>DISCHARGE METHODS<<<<<<<<<<<<<<<<<<<<


         public void Patientdischarge(string pn)
         {
             string d = "Discharged";
             string query = "update PatientsTable set DoctorID='" + d + "' where PatientNo='" + pn + "' ";
             con.Open();

             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();

             con.Close();
         }

         public DataTable dischargedpatientlist()
         {

             con.ConnectionString = Hospital_Management_System.Properties.Settings.Default.HospitalDatabaseConnectionString; ;
             if (ConnectionState.Closed == con.State)
                 con.Open();
             string s = "Discharged";
             SqlCommand cmd = new SqlCommand("select * from PatientsTable where DoctorID='" + s + "'", con);
             try
             {
                 SqlDataReader rd = cmd.ExecuteReader();
                 DataTable dt = new DataTable();
                 dt.Load(rd);
                 con.Close();
                 return dt;


             }

             catch { throw; }
         }
         
        
        }
}
