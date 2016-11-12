using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class managestudentdetails : databaseUtilies
    {
        public int detailId;
        public string enrolmentId;
        public string address;
        public string guardianFname;
        public string guardianSname;
        public string relationship;
        public string mobileNumber;
        public string email;
    

        public Boolean setStudentDetails(string add, string guardianFname, string guardianSname, string rel, string cell, string email)
        {
            try
            {
                string sql = "INSERT INTO wiz studentdetails (address,guardianFname,guardianSname,relationship,mobileNumber,email)";
                sql += "VALUES ('" + add + "','" + guardianFname + "','" + guardianSname + "','" + rel + "', '" + cell + "', '" + email + "')";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in setStudentDetails()  " + ex);
                return false;
            }
        }

        public Boolean updateStudentDetails(string enId)
        {
            try
            {
                string sql = "UPDATE studentdetails SET address = '" + this.address + "',guardianFname = '" + this.guardianFname + "', guardianSname = '"+ this.guardianSname +"', relationship = '" + this.relationship + "', ,mobileNumber = '" + this.mobileNumber + "', email = '" + this.email + "' WHERE enrolmentId = '" + enId +"' LIMIT 1";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in updateStudentDetails()  " + ex);
                return false;
            }
        }

        public void getStudentDetails(string enId)
        {
            try
            {
                checkConnection();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM studentdetails WHERE enrolmentId = '" + enId + "' ";
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.address = dataReader["address"].ToString();
                    this.email = dataReader["email"].ToString();
                    this.guardianFname = dataReader["guardianFname"].ToString();
                    this.guardianSname = dataReader["guardianSname"].ToString();
                    this.mobileNumber = dataReader["mobileNumber"].ToString();
                    this.relationship = dataReader["relationship"].ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in updateStudentDetails()  " + ex);
            }
        }

        public Boolean deleteStudent(string enId)
        {
            try
            {
                string sql = "DELETE FROM studentdetails WHERE enrolmentId = '" + enId + "' LIMIT 1";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in deleteStudent()  " + ex);
                return false;
            }
        }

    }
}
