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

namespace Project3
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            tabs.TabPages.Remove(selectionTab);
            tabs.TabPages.Remove(newResTab);
            tabs.TabPages.Remove(resSearchTab);
            tabs.TabPages.Remove(scholarshipTab);
            tabs.TabPages.Remove(athleteTab);
            tabs.TabPages.Remove(workerTab);


        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
        }



        /// <summary>
        /// called when the button is clicked
        /// this is coming from main screen to the selection tab
        /// </summary>
        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "home" && password.Text == "1234")
            {
                tabs.TabPages.Add(selectionTab);
                tabs.SelectedIndex = 1;
                welcome.Visible = true;
                logoutButton.Visible = true;
                username.Clear();
                password.Clear();
            }
            else
            {
                MessageBox.Show("Please enter the correct credentials");
            }


        }
        /// <summary>
        /// return button goes to the selection tab from new resident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            tabs.TabPages.RemoveAt(tabs.SelectedIndex);
            tabs.SelectedIndex = 1;
        }

        //Clicking new Resident button or Find Resident button
        private void newRes_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(newResTab);
            tabs.SelectedIndex = 2;
        }
        
        private void findRes_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(resSearchTab);
            tabs.SelectedIndex = 2;
        }
        // Options for when choosing the kind of student being added to the residence
        private void go_Click(object sender, EventArgs e)
        {
            if (scholarship.Checked == true)
            {
                tabs.TabPages.Add(scholarshipTab);
                
            }
            else if (athlete.Checked == true)
            {
                tabs.TabPages.Add(athleteTab);      
            }
            else if (worker.Checked == true)
            {
                tabs.TabPages.Add(workerTab);     
            }
            tabs.SelectedIndex = 3;
        }

        private void return2_Click(object sender, EventArgs e)
        {
            tabs.TabPages.RemoveAt(tabs.SelectedIndex);
            tabs.SelectedIndex = 1;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            tabs.SelectedIndex = 0;
            tabs.TabPages.Remove(selectionTab);
            tabs.TabPages.Remove(newResTab);
            tabs.TabPages.Remove(resSearchTab);
            tabs.TabPages.Remove(scholarshipTab);
            tabs.TabPages.Remove(athleteTab);
            tabs.TabPages.Remove(workerTab);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            goScholarship.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            goScholarship.Enabled = true;
        }

        //Return buttons for new resident adds
        private void resReturn1_Click(object sender, EventArgs e)
        {
            tabs.TabPages.RemoveAt(tabs.SelectedIndex);
            tabs.SelectedIndex = 2;
        }

        private void resReturn2_Click(object sender, EventArgs e)
        {
            tabs.TabPages.RemoveAt(tabs.SelectedIndex);
            tabs.SelectedIndex = 2;
        }

        private void resReturn3_Click(object sender, EventArgs e)
        {
            tabs.TabPages.RemoveAt(tabs.SelectedIndex);
            tabs.SelectedIndex = 2;
        }

        //End of return boxes

        //Go button events
        private void goAthlete_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            
            if (radioButton4.Checked == true)
            {
                int x = num.Next(400, 441);
                MessageBox.Show($"Student ID:{idAthlete.Text} \nFloor 7 Rm: {x} \n Monthly Fee: $1200 \n");
            }
            else if (radioButton2.Checked == true)
            {
                int x = num.Next(500, 541);
                MessageBox.Show($"Student ID: {idAthlete.Text} \n Floor 8 Rm:{x} \n Monthly Fee: $1200 \n");
            }
            else if (radioButton5.Checked == true)
            {
                int x = num.Next(600, 641);
                MessageBox.Show($"Student ID: {idAthlete.Text} \n Floor 8 Rm:{x} \n Monthly Fee: $1200 \n");
            }
        }

        private void goScholarship_Click(object sender, EventArgs e)
        {
            Random num = new Random();

            if (radioButton1.Checked == true)
            {
                int x = num.Next(700, 741);
                MessageBox.Show($"Student ID:{idScholarship.Text} \nFloor 7 Rm: {x} \n Monthly Fee: $100 \n");
            }
            else if (radioButton3.Checked == true)
            {
                int x = num.Next(800, 841);
                MessageBox.Show($"Student ID: {idScholarship.Text} \n Floor 8 Rm: {x} \n Monthly Fee: $100 \n");
            }
        }

        private void goWorker_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int monthlyFee = 1245 - (14 * Convert.ToInt32(workedHrs.Text));

            if (radioButton8.Checked == true)
            {
                int x = num.Next(100, 141);
                
                MessageBox.Show($"Student ID:{idWorker.Text} \nFloor 7 Rm: {x} \n Monthly Fee: ${monthlyFee} \n");
            }
            else if (radioButton7.Checked == true)
            {
                int x = num.Next(200, 241);
                MessageBox.Show($"Student ID: {idWorker.Text} \n Floor 8 Rm:{x} \n Monthly Fee: ${monthlyFee} \n");
            }
            else if (radioButton6.Checked == true)
            {
                int x = num.Next(300, 341);
                MessageBox.Show($"Student ID: {idWorker.Text} \n Floor 8 Rm:{x} \n Monthly Fee: ${monthlyFee} \n");
            }

            
        }
        //End of Go click on all three new residences.

        private void idSearchGo_Click(object sender, EventArgs e)
        {
            string IDNum = idText.Text;

            var ResList = File.ReadLines("ResList.csv");

            foreach(var line in ResList)
                if (IDNum.Trim() == line.ToString())
                {
                    MessageBox.Show(line.ToString());
                }
                else
                {
                    MessageBox.Show("No matches found!");
                }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
