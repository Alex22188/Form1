using System;
using System.Windows.Forms;
using System.Collections.Generic;

using System.IO;
using System.Globalization;
using CsvHelper;


using System.Security.Cryptography.X509Certificates;
using System.Linq;

using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using ServiceStack;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;






namespace OO_programming
{
    public partial class Form1 : Form
    {









        public Form1()
        {
            InitializeComponent();

            // Add code below to complete the implementation to populate the listBox
            // by reading the employee.csv file into a List of PaySlip objects, then binding this to the ListBox.
            // CSV file format: <employee ID>, <first name>, <last name>, <hourly rate>,<taxthreshold>






            List<PaySlip> EmployeeDetailList = new List<PaySlip>();
            List<PayCalculator> payCalculators = new List<PayCalculator>();
            List<PayCalculatorNoThreshold> payCalculatorNoThresholds = new List<PayCalculatorNoThreshold>();
            List<PayCalculatorWithThreshold> payCalculatorWithThresholds = new List<PayCalculatorWithThreshold>();







            TextBox1_Load();





        }





        private void TextBox1_Load()
        {

            string Path = @"C:\Users\alex4\Downloads\employee.csv";
            StreamReader reader = null;

            string employeeID = "Employee ID";
            string firstname = "First Name";
            string lastname = "Last Name";
            string hourlyrate = "Hourly Rate";
            string taxthreshold = "Taxthreshold";

            PaySlip EmployeeDetailList = new PaySlip();
            EmployeeDetailList.EmployeeID = employeeID;
            EmployeeDetailList.FirstName = firstname;
            EmployeeDetailList.LastName = lastname;
            EmployeeDetailList.HourlyRate = hourlyrate;
            EmployeeDetailList.TaxThreshold = taxthreshold;



            if (File.Exists(Path))
            {
                reader = new StreamReader(Path);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var Values = line.Split(',');
                    listBox1.Items.Add(employeeID);
                    listBox1.Items.Add(Values[0]);
                    listBox1.Items.Add(firstname);
                    listBox1.Items.Add(Values[1]);
                    listBox1.Items.Add(lastname);
                    listBox1.Items.Add(Values[2]);
                    listBox1.Items.Add(hourlyrate);
                    listBox1.Items.Add(Values[3]);
                    listBox1.Items.Add(taxthreshold);
                    listBox1.Items.Add(Values[4]);





                }



            }



        }











        private void button1_Click(object sender, EventArgs e)
        {
            // Add code below to complete the implementation to populate the
            // payment summary (textBox2) using the PaySlip and PayCalculatorNoThreshold
            // and classes object and methods.


            PaySlip EmployeeDetailList = new PaySlip();
            EmployeeDetailList.EmployeeID = "Employee ID";
            PayCalculatorNoThreshold payCalculatorNoThresholds = new PayCalculatorNoThreshold();



          
            string Path1 = @"C:\Users\alex4\Downloads\taxrate-nothreshold.csv";
            StreamReader reader1 = null;

          






            if (File.Exists(Path1))
            {
                reader1 = new StreamReader(Path1);

                while (!reader1.EndOfStream)
                {
                    var line1 = reader1.ReadLine();
                    var Values1 = line1.Split(',');

                    listBox1.Items.Add(Values1[0]);



                }


            }
        }



                private void button2_Click(object sender, EventArgs e)
                {
                    // Add code below to complete the implementation for saving the
                    // calculated payment data into a csv file.

                    // File naming convention: Pay_<full name>_<datetimenow>.csv
                    // Data fields expected - EmployeeId, Full Name, Hours Worked, Hourly Rate, Tax Threshold, Gross Pay, Tax, Net Pay, Superannuation




                }


            }
        }

    





