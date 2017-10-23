using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;

namespace MutuERP_UnitTest
{
    [TestClass]
    public class GlobalEnvironment
    {
        private static void CreateDB()
        {
            string conString = "server=localhost;database=master;uid=sa;pwd=123456";
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("create database MutuERP_Test", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }

            ConfigurationManager.AppSettings["SqlConn"] = conString;
        }

        private static void DropDB()
        {
            string conString = "server=localhost;database=master;uid=sa;pwd=123456";
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("drop database MutuERP_Test", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void CreateTable()
        {
            string sqlFile = System.Environment.CurrentDirectory + "\\..\\..\\..\\..\\script\\sql\\MutuERP_Test.sql";
            Assert.IsTrue(File.Exists(sqlFile));
            Trace.WriteLine(">>>>>>>path:" + System.Environment.CurrentDirectory);

            try
            {
                System.Diagnostics.Process pr = new System.Diagnostics.Process();
                pr.StartInfo.FileName = "osql.exe ";
                //pr.StartInfo.Arguments = "-U sa -P 123456 -d MutuERP_Test -s 127.0.0.1 -i script.sql";
                pr.StartInfo.Arguments = "-U sa -P 123456 -d MutuERP_Test -s 127.0.0.1 -i " + sqlFile;
                pr.StartInfo.UseShellExecute = false;
                pr.StartInfo.RedirectStandardOutput = true; //重定向输出

                pr.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;//隐藏输出窗口
                pr.Start();

                System.IO.StreamReader sr = pr.StandardOutput;
                Console.WriteLine(sr.ReadToEnd());

                pr.WaitForExit();
                pr.Close();
            }
            catch (Exception err)
            {
                Trace.WriteLine(">>>>>>>>>>>Error: " + err.ToString());
            }
        }
        private static void DropTable()
        {
        }

        [AssemblyInitialize]
        public static void GlobalInitialize(TestContext context)
        {
            CreateDB();
            CreateTable();
        }



        [AssemblyCleanup]
        public static void GlobalCleanup()
        {
            DropDB();
        }
    }
}
