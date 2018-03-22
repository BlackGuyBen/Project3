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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (username.Text == "home")
            {
                password.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (password.Text == "1234")
            {
                login.Enabled = true;
            }
        }

        /// <summary>
        /// called when the button is clicked
        /// this is coming from main screen to the selection tab
        /// </summary>
        private void login_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(selectionTab);
            tabs.SelectedIndex = 1;
            welcome.Visible = true;
            logoutButton.Visible = true;
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
    }
}
