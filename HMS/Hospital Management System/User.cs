using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    class User
    {
        public static User u;
        public User() { u = this; }
        Database d1 = new Database();
        public string adminFirstName;
        public string adminLastName;
        public string adminUserName;
        public string adminAge;
        public string adminCellno;
        public string adminBloodGroup;
        public string adminGender;
        public string adminEmergencyContact;
        public string adminPost;

        public string docID;
        public string docFirstName;
        public string docLastName;
        public string docUserName;
        public string docGender;
        public string docBloodGroup;
        public string docPost;
        public string docEducation;
        public string docCellno;
        public string docAge;
        public string docEmergencyContact;
        public string docPassword;

        public string staffFirstName;
        public string staffLastName;
        public string staffUserName;
        public string staffGender;
        public string staffAge;
        public string staffCellno;
        public string staffEmergencyContact;
        public string staffBloodGroup;
        public string staffPost;
        public string staffID;
        public string staffPassword;
        public int type;

        public string patientno;
        public string patientFirstName;
        public string patientLastName;
        public string patientAge;
        public string patientGender;
        public string patientBloodGroup;
        public string patientAddress;
        public string patientCellno;
        public string patientDoctor;
        public string patientroomNo;
        public string patientDoctorId;




        //>>>>>>>>>>>>>>>ADMIN PROPERTIES>>>>>>>>>>>>

        public string AdminFirstName
        {
            set { this.adminFirstName = value; }
            get { return this.adminFirstName; }
        }

        public string AdminLastName
        {
            set { this.adminLastName = value; }
            get { return this.adminLastName; }
        }

        public string AdminUserName
        {
            set { this.adminUserName = value; }
            get { return this.adminUserName; }
        }
        public string AdminAge
        {
            set { this.adminAge = value; }
            get { return this.adminAge; }
        }
        public string AdminBloodGroup
        {
            set { this.adminBloodGroup = value; }
            get { return this.adminBloodGroup; }
        }
        public string AdminEmergencyContact
        {
            set { this.adminEmergencyContact = value; }
            get { return this.adminEmergencyContact; }
        }
        public string AdminPost
        {
            set { this.adminPost = value; }
            get { return this.adminPost; }
        }
        public string AdminCellno
        {
            set { this.adminCellno = value; }
            get { return this.adminCellno; }
        }
        public string AdminGender
        {
            set { this.adminGender = value; }
            get { return this.adminGender; }
        }

        //>>>>>>>>>>>>>>>DOCTOR PROPERTIES>>>>>>>>>>>>


         public string DocID
        {
            set { this.docID = value; }
            get { return this.docID; }
        }
        public string DocFirstName
        {
            set { this.docFirstName = value; }
            get { return this.docFirstName; }
        }

        public string DocLastName
        {
            set { this.docLastName = value; }
            get { return this.docLastName; }
        }

        public string DocUserName
        {
            set { this.docUserName = value; }
            get { return this.docUserName; }
        }
        public string DocAge
        {
            set { this.docAge = value; }
            get { return this.docAge; }
        }
        public string DocBloodGroup
        {
            set { this.docBloodGroup = value; }
            get { return this.docBloodGroup; }
        }
        public string DocEmergencyContact
        {
            set { this.docEmergencyContact = value; }
            get { return this.docEmergencyContact; }
        }
        public string DocEducation
        {
            set { this.docEducation = value; }
            get { return this.docEducation; }
        }
        public string DocCellno
        {
            set { this.docCellno = value; }
            get { return this.docCellno; }
        }
        public string DocGender
        {
            set { this.docGender = value; }
            get { return this.docGender; }
        }
        public string DocPost
        {
            set { this.docPost = value; }
            get { return this.docPost; }
        }
         public string DocPassword
        {
            set { this.docPassword = value; }
            get { return this.docPassword; }
        }

         //>>>>>>>>>>>>>>>STAFF PROPERTIES>>>>>>>>>>>>

        public string StaffFirstName
        {
            set { this.staffFirstName = value; }
            get { return this.staffFirstName; }
        }

        public string StaffLastName
        {
            set { this.staffLastName = value; }
            get { return this.staffLastName; }
        }

        public string StaffUserName
        {
            set { this.staffUserName = value; }
            get { return this.staffUserName; }
        }
        public string StaffGender
        {
            set { this.staffGender = value; }
            get { return this.staffGender; }
        }
        public string StaffCellno
        {
            set { this.staffCellno = value; }
            get { return this.staffCellno; }
        }
        public string StaffEmergencyContact
        {
            set { this.staffEmergencyContact = value; }
            get { return this.staffEmergencyContact; }
        }
        public string StaffBloodGroup
        {
            set { this.staffBloodGroup = value; }
            get { return this.staffBloodGroup; }
        }
        public string StaffPost
        {
            set { this.staffPost = value; }
            get { return this.staffPost; }
        }
        public string StaffAge
        {
            set { this.staffAge = value; }
            get { return this.staffAge; }
        }

        public string StaffID
        {
            set { this.staffID = value; }
            get { return this.staffID; }
        }

        public string StaffPassword
        {
            set { this.staffPassword = value; }
            get { return this.staffPassword; }
        }

         public int Type
        {
            set { this.type = value; }
            get { return this.type; }
        }

         //>>>>>>>>>>>>>>>PATIENT PROPERTIES>>>>>>>>>>>>

         public string PatientNo
         {
             set { this.patientno = value; }
             get { return this.patientno; }
         }
         public string PatientFirstName
         {
             set { this.patientFirstName = value; }
             get { return this.patientFirstName; }
         }

         public string PatientLastName
         {
             set { this.patientLastName = value; }
             get { return this.patientLastName; }
         }

         public string PatientAge
         {
             set { this.patientAge = value; }
             get { return this.patientAge; }
         }

         public string PatientGender
         {
             set { this.patientGender = value; }
             get { return this.patientGender; }
         }

         public string PatientBloodGroup
         {
             set { this.patientBloodGroup = value; }
             get { return this.patientBloodGroup; }
         }
         public string PatientAddress
         {
             set { this.patientAddress = value; }
             get { return this.patientAddress; }
         }
     
         public string PatientCellNo
         {
             set { this.patientCellno = value; }
             get { return this.patientCellno; }
         }
         public string PatientDoctor
         {
             set { this.patientDoctor = value; }
             get { return this.patientDoctor; }
         }
         public string PatientRoomNo
         {
             set { this.patientroomNo = value; }
             get { return this.patientroomNo; }
         }
         public string PatientDoctorID
         {
             set { this.patientDoctorId = value; }
             get { return this.patientDoctorId; }
         }
       




        public int logIn(string un, string pw)
        {
           

            type = d1.getType(un, pw);
            return type;


            //>>>>>>>>>>>>>>>>>>>>>>>>USER METHODS<<<<<<<<<<<<<<<<<<<<<<<<
           

        }

        public string getFirstName(string un)
        {
            try
            {
                DocFirstName = d1.getFname(un);
                return DocFirstName;
            }
            catch
            {
                throw;
            }
        }

        public string getLastName(string un)
        {
            try
            {
                DocLastName = d1.getLname(un);
                return DocLastName;
            }
            catch
            {
                throw;
            }
        }

        public string getGender(string un)
        {
            try
            {

                return d1.getGndr(un);
            }
            catch
            {
                throw;
            }
        }

        public string getAge(string un)
        {
            try
            {

                return d1.getAg(un);
            }
            catch
            {
                throw;
            }
        }

        public string getCellPhone(string un)
        {
            try
            {

                return d1.getCell(un);
            }
            catch
            {
                throw;
            }
        }

        public string getPost(string un)
        {
            try
            {

                return d1.getPost(un);
            }
            catch
            {
                throw;
            }
        }

        public string getBloodgroup(string un)
        {
            try
            {

                return d1.getBG(un);
            }
            catch
            {
                throw;
            }
        }

        public string getEducation(string un)
        {
            try
            {

                return d1.getDocedu(un);
            }
            catch
            {
                throw;
            }
        }
        public string getEmergencyContact(string un)
        {
            try
            {

                return d1.getEC(un);
            }
            catch
            {
                throw;
            }
        }
        

        public string getID(string un)
        {
            try
            {

                return d1.getId(un);
            }
            catch
            {
                throw;
            }
        }

        public string getPassword(string un)
        {
            try
            {

                return d1.getPW(un);
            }
            catch
            {
                throw;
            }
        }

        public string getType(string un)
        {
            try
            {

                return d1.gettype(un);
            }
            catch
            {
                throw;
            }
        }

        //>>>>>>>>>>>>>>>>>LIST METHODS<<<<<<<<<<<<<<<<<<<<<

        public DataTable getRoomList()
        {

            try
            {
                return d1.getRmlist();
            }
            catch
            {
                throw;
            }

        }

        public DataTable getPatientList()
        {

            try
            {
                return d1.getPlist();
            }
            catch
            {
                throw;
            }

        }

        public DataTable getDoctorList()
        {
            try
            {
                return d1.getDoclist();
            }
            catch
            {
                throw;
            }
        }

        public DataTable getAvailableRooms()
        {
            try
            {
                return d1.getAvailableRms();
            }
            catch
            {
                throw;
            }
        }

        public DataTable getStaffList()
        {
            try
            {
                return d1.getstafflist();
            }
            catch
            {
                throw;
            }
        }

        public DataTable getDoctorPatientList(string id)
        {

            try
            {
                return d1.getDoctorpatientList(id);
            }
            catch
            {
                throw;
            }

        }




        //>>>>>>>>>>>>PATIENT METHODS<<<<<<<<<<<<<<<<<<<<


        public string getPatientFirstName(string pn)
        {
            try
            {
                PatientFirstName = d1.getPFname(pn);
                return PatientFirstName;
            }
            catch
            {
                throw;
            }
        }

        public string getPatientLastName(string pn)
        {
            try
            {
                PatientLastName = d1.getPLname(pn);
                return PatientLastName;
            }
            catch
            {
                throw;
            }
        }

        public string getPatientAge(string pn)
        {
            try
            {
                PatientAge = d1.getPAge(pn);
                return PatientAge;
            }
            catch
            {
                throw;
            }
        }

        public string getPatientGender(string pn)
        {
            try
            {
                PatientGender = d1.getPGender(pn);
                return PatientGender;
            }
            catch
            {
                throw;
            }
        }

        public string getPatientBloodGroup(string pn)
        {
            try
            {
                PatientBloodGroup = d1.getPBGroup(pn);
                return PatientBloodGroup;
            }
            catch
            {
                throw;
            }
        }

        public string getPatientAddress(string pn)
        {
            try
            {
                PatientAddress = d1.getPAddress(pn);
                return PatientAddress;
            }
            catch
            {
                throw;
            }
        }

        public string getPatientCell(string pn)
        {
            try
            {
                PatientCellNo = d1.getPCell(pn);
                return PatientCellNo;
            }
            catch
            {
                throw;
            }
        }
        
        public string getPatientDoctor(string pn)
        {
            try
            {
                PatientDoctor = d1.getPDoc(pn);
                return PatientDoctor;
            }
            catch
            {
                throw;
            }
        }


        public string getPatientRoomNo(string pn)
        {
            try
            {
                PatientRoomNo = d1.getPRoom(pn);
                return PatientRoomNo;
            }
            catch
            {
                throw;
            }
        }

        public string getPatientDoctorID(string pn)
        {
            try
            {
                PatientRoomNo = d1.getPDocID(pn);
                return PatientRoomNo;
            }
            catch
            {
                throw;
            }
        }


        

        //>>>>>>>>>>>>>>>DOC ADD REMOVE UPDATE<<<<<<<<<<<<<<<<<<<<

        public void addDoctor(string id, string fn, string ln, string un, string ag, string gen, string bg, string cell, string docedu, string post, string pass, string ec, int type)
        {

            d1.addDoc(id,fn,ln, un,ag,gen,bg, cell,docedu,post,pass,ec,type);
        
        }

        public void removeDoctor(string Id) { d1.removeDoc(Id); }

        public void updateDoctor(string id, string fn, string ln, string un, string ag, string gen, string bg, string cell, string docedu, string post, string pass, string ec, string type)
        {

            d1.updateDoc(id, fn, ln, un, ag, gen, bg, cell, docedu, post, pass, ec, type);

        }
       


        //>>>>>>>>>>>>>>>>>>STAFF ADD REMOVE UPDATE<<<<<<<<<<<<<<<<<<<<<<

        public void addStaff(string id, string fn, string ln, string un, string ag, string gen, string bg, string cell, string post, string pass, string ec, int type)
        {

            d1.addStf(id,fn,ln,un,ag,gen,bg,cell,post,pass,ec,type);
        
        
        }
        public void removeStaff(string Id) { d1.removeStf(Id); }

        public void updateStaff(string id, string fn, string ln, string un, string gen, string ag, string cell, string bg, string ec, string post, string pass, string type)
        {
            d1.updateStaff(id, fn, ln, un, gen, ag, cell, bg, ec, post, pass, type);
        }


        //>>>>>>>>>>>>>>>>>>>PATIENT ADD REMOVE UPDATE<<<<<<<<<<<<<<<<<<<


        public void addPatient(string pn, string fn, string ln, string ag, string gen, string bg, string ad, string cell, string dc, string rn,string docid)
        {
            d1.addpatnt(pn, fn, ln, ag, gen, bg, ad, cell, dc, rn,docid);
        }

        public void removePatient(string Pn) { d1.removepatnt(Pn); }
        

        public void updatePatient(string pn, string fn, string ln, string ag, string gen, string bg, string ad, string cell, string doc, string rn,string docid)
        {
            d1.updatePatnt(pn, fn, ln, ag, gen, bg, ad, cell, doc, rn,docid);
        }

        //>>>>>>>>>>>>>>>>>>>SEARCH METHODS<<<<<<<<<<<<<<<<<<<

        public DataTable searchUser(string fname)
        {
            try
            {
                return d1.searchuser(fname);
            }
            catch
            {
                throw;
            }
        }

        public DataTable searchPatient(string fname)
        {
            try
            {
                return d1.searchpatient(fname);
            }
            catch
            {
                throw;
            }
        }
        //>>>>>>>>>>>>>>>>>DISCHARGE METHOD<<<<<<<<<<<<<<<<<<<<<

        public void PatientDischarge(string pn)
        {
            d1.Patientdischarge(pn);
        }

        public DataTable dischargedPatientList()
        {
            try
            {
                return d1.dischargedpatientlist();
            }
            catch
            {
                throw;
            }
        }

        //>>>>>>>>>>>>>>>>>>>COUNT METHODS<<<<<<<<<<<<<<<<<<<

        public int getDoctorCount()
        {
            try
            {
                DataTable dt = new DataTable();
                dt= d1.getDoclist();
                int count = dt.Rows.Count;
                return count;
            }
            catch
            {
                throw;
            }
        }

        public int getPatientCount()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = d1.getPlist();
                int count = dt.Rows.Count;
                return count;
            }
            catch
            {
                throw;
            }
        }

        public int getStaffCount()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = d1.getstafflist();
                int count = dt.Rows.Count;
                return count;
            }
            catch
            {
                throw;
            }
        }

    }
}
   



