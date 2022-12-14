using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNonIndexedFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vaultPath = txtVault.Text;
            if (Directory.Exists(vaultPath))
            {
                txtStatus.Text = "Begin" + Environment.NewLine;
                ValidateDirectoryAttrib(vaultPath);
                txtStatus.AppendText("End");
            }
            else
            {
                txtStatus.Text = vaultPath + " does not exist.";
            }
        }


        public void ValidateDirectoryAttrib(string directory)
        {
            ValidateDirectoryAttrib(new DirectoryInfo(directory));
        }

        private void ValidateDirectoryAttrib(DirectoryInfo directory)
        {
            if ((directory.Attributes & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed)
            {
                txtStatus.AppendText(directory.FullName + Environment.NewLine);
            }
            try
            {
                DirectoryInfo[] directories = directory.GetDirectories();
                DirectoryInfo[] array = directories;
                foreach (DirectoryInfo dirs in array)
                {
                    ValidateDirectoryAttrib(dirs);
                }
            }
            catch (Exception)
            {

                txtStatus.AppendText("ERR:" + directory.FullName + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtVault.Text = Properties.Settings.Default.vault;
            //GetDefaultQuery();
        }

        private void GetDefaultQuery()
        {
            string empty = string.Empty;
            string text = "D:\\MyVault\\00000002_A.par";
            string text2 = "SystemIndex";
            string text3 = "System.ItemUrl";
            string empty2 = string.Empty;
            empty = "SELECT";
            empty += " ";
            empty += "SolidEdge.DocumentNumber";
            empty += " ";
            empty += "FROM ";
            Uri uri = new Uri(text);
            empty2 = ((!uri.IsUnc) ? (empty2 + text2) : (empty2 + uri.Host + "." + text2));
            empty += empty2;
            empty += " ";
            empty += "WHERE";
            empty += " ";
            empty += text3;
            empty += "=";
            empty = empty + "'" + text + "'";
            txtQry.Text = "SELECT System.ItemUrl FROM SystemIndex WHERE SolidEdge.DocumentNumber='MM-00177-001'";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.vault = txtVault.Text;
            Properties.Settings.Default.Save();
        }

        private void btnTestQRY_Click(object sender, EventArgs e)
        {
            OleDbDataReader oleDbDataReader = null;
            OleDbConnection oleDbConnection = null;
            OleDbCommand oleDbCommand = null;

            try
            {
                txtResults.Clear();
                string qry = txtQry.Text;
                if (string.IsNullOrEmpty(qry))
                {
                    return;
                }
                if (qry.Contains("System.ItemUrl="))
                {
                    string text2 = qry.Substring(qry.IndexOf("System.ItemUrl=") + 15);
                    char[] separator = new char[1] { '\'' };
                    text2 = text2.Split(separator)[1];
                    if (!File.Exists(text2))
                    {
                        txtResults.Text += Environment.NewLine + "File does not exists!";
                        return;
                    }
                }
                oleDbConnection = new OleDbConnection("Provider=Search.CollatorDSO;Extended Properties=\"Application=Windows\"");
                oleDbCommand = new OleDbCommand(qry, oleDbConnection);
                oleDbConnection.Open();
                oleDbDataReader = oleDbCommand.ExecuteReader();
                if (!oleDbDataReader.HasRows)
                {
                    txtResults.Text += Environment.NewLine + "Indexing is not working";
                }
                else
                {
                    while (oleDbDataReader.Read())
                    {
                        txtResults.Text = txtResults.Text + Environment.NewLine + "HasRows= " + oleDbDataReader.HasRows + Environment.NewLine;
                        for (int i = 0; i < oleDbDataReader.FieldCount; i++)
                        {
                            string name = oleDbDataReader.GetName(i);
                            string propVal = oleDbDataReader.GetValue(i).ToString();
                            txtResults.AppendText("Property Name: " + name + " = " + propVal + Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtResults.Text += "\nException occured:\n";
                txtResults.Text += ex.Message;
            }
            finally
            {
                if (oleDbDataReader != null)
                {
                    oleDbDataReader.Close();
                    oleDbDataReader.Dispose();
                }
                if (oleDbConnection!=null && oleDbConnection.State == ConnectionState.Open)
                {
                    oleDbConnection.Close();
                }
            }
        }
    }
}
