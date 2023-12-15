using CsvHelper.Configuration.Attributes;
using System;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Security.Policy;
using OO_programming;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OO_programming
{

    static class Program
    {





        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());









                }
            }

    /// <summary>
    /// Class a capture details accociated with an employee's pay slip record
    /// </summary>




    public class PaySlip
    {


        public string EmployeeID { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string HourlyRate { get; set; }

        public string TaxThreshold { get; set; }

        public int HoursWorked { get; set; }

        public string GrossPay { get; set; }

        public string Tax { get; set; }
        public string NetPay { get; set; }

        public string SupperAnnuation { get; set; }





      

       

         



                }





            }


        
    
        

                 









/// <summary>
/// Base class to hold all Pay calculation functions
/// Default class behaviour is tax calculated with tax threshold applied
/// </summary>
public class PayCalculator
        {

            public string HourlyRate { get; set; }

            public string TaxThreshold { get; set; }

            public int HoursWorked { get; set; }

            public string GrossPay { get; set; }

            public string Tax { get; set; }
            public string NetPay { get; set; }

            public string SupperAnnuation { get; set; }


        }





        /// <summary>
        /// Extends PayCalculator class handling No tax threshold
        /// </summary>
        public class PayCalculatorNoThreshold : PayCalculator
        {

        

            public PayCalculatorNoThreshold()
            {
               
                

            }




        }

        /// <summary>
        /// Extends PayCalculator class handling With tax threshold
        /// </summary>
        public class PayCalculatorWithThreshold : PayCalculator
        {

            public PayCalculatorWithThreshold()
            {


            }


        }

    


    
