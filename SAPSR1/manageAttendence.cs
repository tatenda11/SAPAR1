﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAPSR1
{
    class manageAttendence : databaseUtilies
    {
        public string enrollmentId;
        public string termPeriod;
        public int totaldays;
        public int presentdays;
        public int absentdays;
        public int classId;
        public Boolean dacCrud;
        public Boolean dacFound;

        public Boolean setAttendence(string enId, string termP, int clsId)
        {
            try
            {
                string sql = "INSERT INTO wizattendence (enrollmentId,termPeriod,classId) VALUES '" + enId + "', '" + termP + "', '" + clsId + "'";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in setAttendence()  " + ex);
                return false;
            }
        }

        public void getAttendence(string term, string enId)
        {
            try
            {
                string sql = "SELECT * FROM wizattendence WHERE enrollmentId = '" + enId + "' AND termPeriod = '" + term + "' LIMIT 1";
                checkConnection();
                query.Connection = connection;
                query.CommandText = sql;
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    this.classId = Convert.ToInt32(dataReader["classId"]);
                    this.absentdays = Convert.ToInt32(dataReader["absentdays"]);
                    this.presentdays = Convert.ToInt32(dataReader["presentdays"]);
                    this.totaldays = Convert.ToInt32(dataReader["totaldays"]);
                    this.enrollmentId = dataReader["enrollmentId"].ToString();
                    this.termPeriod = dataReader["termPeriod"].ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getAttendence()  " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Boolean addPresent(string term, string enId)
        {
            try
            {
                /*increament total days by 1 and inceament present days by 1*/
                this.presentdays = this.presentdays + 1;
                this.totaldays = this.totaldays +1;
                string sql = "UPDATE wizattendence SET presentdays = '" + this.presentdays + "',totaldays = '" + this.totaldays + "' WHERE enrollmentId = '"+ enId +"' LIMIT 1";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getAttendence()  " + ex);
                return false;
            }
        }

        public Boolean addAbsent(string term, string enId)
        {
            try
            {
                /*increament total days by 1 and inceament absentdays days by 1*/
                this.absentdays += 1;
                this.totaldays += 1;
                string sql = "UPDATE wizattendence SET absentdays = '" + this.absentdays + "',totaldays = '" + this.totaldays + "'  WHERE enrollmentId = '" + enId + "' LIMIT 1";
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getAttendence()  " + ex);
                return false;
            }
        }

        public Boolean updateEntry(string term, string enId, string item)
        {
            try
            {
                if(item == "undo_present")
                {
                    this.presentdays = this.presentdays - 1;
                    this.absentdays = this.absentdays + 1;
                }
                else
                {
                    this.presentdays = this.presentdays + 1;
                    this.absentdays = this.absentdays - 1;
                }
                string sql = "UPDATE wizattendence SET presentdays = '" + this.presentdays + "',absentdays = '" + this.absentdays + "' WHERE enrollmentId = '" + enId + "' LIMIT 1";
                System.Windows.Forms.MessageBox.Show(sql);
                return executeQuery(sql);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed in getAttendence()  " + ex);
                return false;
            }
        }
    }
}
