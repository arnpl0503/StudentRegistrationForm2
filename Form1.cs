using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentRegistrationForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         public void DisplayInfo(string Lastname, string FirstName, string MiddleName, string Gender, string month, string day, string year, string program)
        {
          MessageBox.Show("Student Name: " + Lastname + "," + FirstName + " " + MiddleName + "\nGeder: " + Gender +
        "\nDate of Birth: " + month + "/" + day + "/" + year + "\nProgram: " + program);
        }
         public void DisplayInfo(string Lastname, string FirstName, string MiddleName, string Gender, string program)
        {
          MessageBox.Show("Student Name" + Lastname + ", " + FirstName + MiddleName + "\nGender" + Gender + "\nProgram");
        }

         public void DisplayInfo(string Lastname, string FirstName, string MiddleName, string program)
       {
          MessageBox.Show("Student Name" + Lastname + ", " + FirstName + MiddleName + "\nProgram" + program);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList monthList = new ArrayList();

            monthList.Add("January");
            monthList.Add("February");
            monthList.Add("March");
            monthList.Add("April");
            monthList.Add("May");
            monthList.Add("June");
            monthList.Add("July");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("October");
            monthList.Add("November");
            monthList.Add("December");

            foreach(string month in monthList)
            {
                comboBox1.Items.Add(month);
            }
            for (int i = 1; i <= 31; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
             for (int i = 1900; i <= 2024; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            ArrayList ProgramList = new ArrayList();

            ProgramList.Add("Bachelor of Science in Information Technology");
            ProgramList.Add("Bachelor of Science in Tourism Management");
            ProgramList.Add("Bachelor of Science in Computer Engeneering");
            ProgramList.Add("Bachelor of Science in Bussiness Administration");

            foreach(string Program in ProgramList)
            {
                comboBox4.Items.Add(Program);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = comboBox1.GetItemText(comboBox1.SelectedItem);
            string day = comboBox3.GetItemText(comboBox3.SelectedItem);
            string year = comboBox2.GetItemText(comboBox2.SelectedItem);
            string gender = radioButton1.Checked == true ? "Male" : "Female";
            string program = comboBox4.GetItemText(comboBox4.SelectedItem);
            string Lastname = textBox1.Text;
            string Firstname = textBox3.Text;
            string Middlename = textBox2.Text;

           DisplayInfo(Lastname, FirstName, MiddleName, gender, month, day, year, program);
           DisplayInfo(Lastname,  FirstName,  MiddleName, gender, program);
           DisplayInfo(Lastname, FirstName,  MiddleName,  program);
        }
           openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
       }
    }
}
