using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dedeles_lab
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StudentNo = txtStudentNo.Text;
            string Lname = txtLname.Text;
            string Age = txtAge.Text;
            string Birthdate = dtpBirth.Text;
            string Program = cbProg.Text;
            string Fname = txtFname.Text;
            string MiddleInitial = txtMI.Text;
            string Gender = cbGender.Text;
            string Contact = txtContact.Text;





            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            StudentNo+".txt")))
            {
                outputFile.WriteLine("Student Number: " + StudentNo);
                outputFile.WriteLine("Full Name: " + Lname + Fname + MiddleInitial);
                outputFile.WriteLine("Program: " + Program);
                outputFile.WriteLine("Gender: " + Gender);
                outputFile.WriteLine("Age: " + Age);
                outputFile.WriteLine("Birthday: " + Birthdate);
                outputFile.WriteLine("Contact: " + Contact);



            }
        }
    }
}
