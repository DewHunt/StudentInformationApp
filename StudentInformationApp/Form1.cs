using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<StudentInfo> studentList=new List<StudentInfo>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo();

            if (studentList.Count < 3)
            {
                student.regNo = regNoTextBox.Text;
                student.firstName = firstNameTextBox.Text;
                student.lastName = lastNameTextBox.Text;

                studentList.Add(student);

                MessageBox.Show("Student Information saved Successfully");

                Clear();
            }
            else
            {
                Clear();
                MessageBox.Show("You can only save 3 Student...");
            }
        }

        private void Clear()
        {
            regNoTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string studentInfo = "Reg No:\tName:";

            foreach (StudentInfo info in studentList)
            {
                studentInfo = studentInfo + "\n" + info.regNo + "\t" + info.firstName + " " + info.lastName;
            }

            MessageBox.Show(studentInfo);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentList=new List<StudentInfo>();
        }
    }
}
