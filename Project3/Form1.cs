using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            selectionTab.Hide();
            newResTab.Hide();
            resSearchTab.Hide();
            scholarshipTab.Hide();
            athleteTab.Hide();
            workerTab.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "home")
            {
                textBox2.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        ///called when the button is clicked
        private void loginButton_Click(object sender, EventArgs e)
        {
            selectionTab.Show();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            selectionTab.Hide();
            newResTab.Hide();
            resSearchTab.Hide();
            scholarshipTab.Hide();
            athleteTab.Hide();
            workerTab.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resSearchTab.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "1234")
            {
                loginButton.Enabled = true;
            }
        }

        private void newRes_Click(object sender, EventArgs e)
        {
            newResTab.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (scholarship.Checked == true)
            {
                scholarshipTab.Show();
                //scholarshipTab();
            }
            if (athlete.Checked == true)
            {
                athleteTab.Show();
            }
            else if (worker.Checked == true)
            {
                workerTab.Show();
            }
        }
    }
}
