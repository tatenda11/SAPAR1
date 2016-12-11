using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageEmployees:databaseUtilies
    {
        public string employeeId;
        public string nationalId;
        public string Fname;
        public string address;
        public string Sname;
        public string DOB;
        public string Status;     //address gender department
        public string Dpt;
        public string supervisorId;
        public string department;
        public string EmpDate;
        public string Mobile;
        public string Email;
        public string gender;
        public string iceName;
        public string iceContact;
        public string iceRelationship;
        public Boolean dacFound;

        public Boolean SetEmpDetails()
        {
            try
            {
                string sql = "INSERT INTO wizemployes (employeeId,nationalId,Fname,Sname,DOB,Dpt,supervisorId,EmpDate,Mobile,Email,iceName,iceContact,iceRelationship, address,gender)";
                sql += "VALUES ('"+ this.employeeId +"','"+ this.nationalId +"','"+ this.Fname +"','"+ this.Sname +"', '"+ this.DOB + "','" + this.Dpt + "', '" + this.supervisorId + "','"+ this.EmpDate + "','" + this.Mobile + "','" + this.Email + "','" + this.iceName +"', '"+ this.iceContact +"','"+ this.iceRelationship +"','"+ this.address +"','"+ this.gender  +"')";
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in SetEmpDetails()" + ex);
                return false;
            }
        }

        public void getEmpDetails(string empId )
        {
            try
            {
                string sql = "SELECT * FROM wizemployes WHERE employeeId = '"+ empId +"' ";
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.dacFound = true;
                    while (dataReader.Read())
                    {
                        
                        this.DOB = dataReader["DOB"].ToString();
                        this.Dpt = dataReader["Dpt"].ToString();
                        this.Email = dataReader["Email"].ToString();
                        this.EmpDate = dataReader["EmpDate"].ToString();
                        this.Fname =  dataReader["Fname"].ToString();
                        this.iceContact =  dataReader["iceContact"].ToString();
                        this.iceName = dataReader["iceName"].ToString();
                        this.iceRelationship = dataReader["iceRelationship"].ToString();
                        this.Mobile = dataReader["Mobile"].ToString();
                        this.nationalId = dataReader["nationalId"].ToString();
                        this.Sname = dataReader["Sname"].ToString();
                        this.Status = dataReader["Status"].ToString();
                        this.supervisorId = dataReader["supervisorId"].ToString();
                        this.address = dataReader["address"].ToString();
                        this.gender = dataReader["gender"].ToString();
                    }
                }
                else
                {
                    this.dacFound = false;
                }

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getEmpDetails()" + ex.Message);
            }
            finally
            {
                connection.Close();
            } 
        }

        public Boolean updateEmplyee(string empId)
        {
            try
            {
                string sql = "UPDATE wizemployes SET DOB = '"+ this.DOB + "',Dpt = '"+ this.Dpt + "',Email = '"+ this.Email + "',EmpDate = '"+ this.EmpDate + "',Fname = '"+ this.Fname + "',iceContact = '"+ this.iceContact + "', iceName = '"+ this.iceName + "', iceRelationship = '"+ this.iceRelationship +"', ";
                sql += " Mobile = '"+ Mobile + "', nationalId = '"+ this.nationalId + "', Sname = '" + this.Sname + "',supervisorId = '"+ this.supervisorId + "', gender = '"+ this.gender +"', address = '"+ this.address + "' WHERE employeeId = '" + empId + "' LIMIT 1 ";
                System.Windows.Forms.MessageBox.Show(sql);
                return executeQuery(sql);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getEmpDetails()" + ex);
                return false;
            }
        }
    }
}
