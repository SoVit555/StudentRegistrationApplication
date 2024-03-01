using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
            
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DayBox.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                MonthBox.Items.Add(i.ToString());
            }
            for (int i = 1900; i <= 2024; i++)
            {
                YearBox.Items.Add(i.ToString());
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (MaleButton.Checked) 
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string messageText =
                "Student name: " + FName.Text + " " + MName.Text + " " +LName.Text +
                "\nGender: " + gender +
                "\nDate of Birth: " + DayBox.Text + "/" + MonthBox.Text + "/" + YearBox.Text;
            MessageBox.Show(messageText);
        }
    }
}
