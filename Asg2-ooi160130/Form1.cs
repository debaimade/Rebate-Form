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

namespace CS6326Asg2
{
    public partial class Form1 : Form
    {
        List<rebateRecord> records = new List<rebateRecord>(); // will hold records as they are read in from text file
        private TimeSpan startTime, endTime; // variables for logging form edit times
        public Form1()
        {
            // will create textfile if it doesn't already exist
            FileStream fs = new FileStream(@"CS6326Asg2.txt", FileMode.OpenOrCreate);
            fs.Close();
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Will populate form based on selected entry from list view
            foreach (ListViewItem record in recordList.Items)
            {
                if (record.Selected)
                {
                    // creating search string 
                    string selectedFirstName = record.SubItems[0].Text;
                    string selectedLastName = record.SubItems[1].Text;
                    string selectedMI = record.SubItems[2].Text;
                    
                    // scan each record entry and populate form fields
                    foreach(rebateRecord rebate in records)
                    {
                        if(selectedFirstName == rebate.firstName && 
                            selectedLastName == rebate.lastName && 
                            selectedMI == rebate.midInit)
                        {
                            firstNameText.Text = rebate.firstName;
                            lastNameText.Text = rebate.lastName;
                            midInitText.Text = rebate.midInit;
                            addrLine1Text.Text = rebate.addrLine1;
                            addrLine2Text.Text = rebate.addrLine2;
                            cityText.Text = rebate.city;
                            stateText.Text = rebate.state;
                            zipCodeText.Text = rebate.zipCode;
                            phoneNumberText.Text = rebate.phoneNumber;
                            emailText.Text = rebate.email;
                            receiptYes.Checked = rebate.purchaseProofYes;
                            receiptNo.Checked = rebate.purchaseProofNo;
                            dateTimePicker1.Value = Convert.ToDateTime(rebate.dateReceived);
                        }
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            endTime = System.DateTime.Now.TimeOfDay; // log end time of form edit
            bool saveFlag = true; // flag for saving the record to text file
            StreamReader SR = new StreamReader(@"CS6326Asg2.txt", true);
            
            // Will check the record file for previous instances of current entry
            while (!SR.EndOfStream)
            {
                var line = SR.ReadLine();
                if (String.IsNullOrEmpty(line)) continue;
                if (line.Contains(firstNameText.Text + "\t" + lastNameText.Text + "\t" + midInitText.Text))
                {
                    MessageBox.Show("A rebate exists with this first name, last name and middle initial", "Record Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    saveFlag = false;
                    break;
                }
                else saveFlag = true;
            }
            SR.Close();

            // If no previous version exists, save new

            bool hasReceipt = receiptYes.Checked;

            if (saveFlag)
            {
                StreamWriter SW = new StreamWriter(@"CS6326Asg2.txt", true);
                SW.Write(firstNameText.Text + "\t");
                SW.Write(lastNameText.Text + "\t");
                SW.Write(midInitText.Text + "\t");
                SW.Write(addrLine1Text.Text + "\t");
                SW.Write(addrLine2Text.Text + "\t");
                SW.Write(cityText.Text + "\t");
                SW.Write(stateText.Text + "\t");
                SW.Write(zipCodeText.Text + "\t");
                SW.Write(phoneNumberText.Text + "\t");
                SW.Write(emailText.Text + "\t");
                SW.Write(receiptYes.Checked + "\t");
                SW.Write(receiptNo.Checked + "\t");
                SW.Write(dateTimePicker1.Value.ToString(("yyyy-MM-dd")) + "\t");
                SW.Write(startTime + "\t");
                SW.Write(endTime + "\t");
                SW.WriteLine();
                SW.Close();
            }
            clearFields();
            refreshList();

            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            startTime = System.DateTime.Now.TimeOfDay; // log start time of form edit
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            refreshList(); 
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // Function to refresh entries of the list view
        private void refreshList()
        {
            recordList.Items.Clear();
            records.Clear();

            // will scan record file and repopulate list view
            StreamReader SR = new StreamReader(@"CS6326Asg2.txt", true);
            int counter = 0;
            while (!SR.EndOfStream)
            {
                var line = SR.ReadLine();
                string[] info = line.Split('\t');
                rebateRecord temp = new rebateRecord();

                if (!(line == null))
                {
                    temp.firstName = info[0];
                    temp.lastName = info[1];
                    temp.midInit = info[2];
                    temp.addrLine1 = info[3];
                    temp.addrLine2 = info[4];
                    temp.city = info[5];
                    temp.state = info[6];
                    temp.zipCode = info[7];
                    temp.phoneNumber = info[8];
                    temp.email = info[9];
                    temp.purchaseProofYes = Convert.ToBoolean(info[10]);
                    temp.purchaseProofNo = Convert.ToBoolean(info[11]);
                    temp.dateReceived = info[12];
                    temp.startTime = TimeSpan.Parse(info[13]);
                    temp.endTime = TimeSpan.Parse(info[14]);

                }

                // avoid duplicate entries in the records list
                if (!records.Contains(temp))
                {
                    records.Add(temp);
                    counter++;
                }

            }

            // formatting entries for presentation in the list view
            for (int i = 0; i < records.Count; i++)
            {
                recordList.Items.Add(
                    new ListViewItem(new[]
                    {
                        records[i].firstName,
                        records[i].lastName,
                        records[i].midInit,
                        records[i].phoneNumber,
                    }
                    ));
            }
            SR.Close();
        }

        // function to clear all the fields in the form
        private void clearFields()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            midInitText.Text = "";
            addrLine1Text.Text = "";
            addrLine2Text.Text = "";
            cityText.Text = "";
            stateText.Text = "";
            zipCodeText.Text = "";
            phoneNumberText.Text = "";
            emailText.Text = "";
            receiptNo.Checked = false;
            receiptYes.Checked = false;
            dateTimePicker1.Value = System.DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void receiptNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // to delete record entry we build a string using the entries in the form fields
            string toDelete = "";
            toDelete += (firstNameText.Text + "\t");
            toDelete += (lastNameText.Text + "\t");
            toDelete += (midInitText.Text + "\t");
            toDelete += (addrLine1Text.Text + "\t");
            toDelete += (addrLine2Text.Text + "\t");
            toDelete += (cityText.Text + "\t");
            toDelete += (stateText.Text + "\t");
            toDelete += (zipCodeText.Text + "\t");
            toDelete += (phoneNumberText.Text + "\t");
            toDelete += (emailText.Text + "\t");
            toDelete += (receiptYes.Checked + "\t");
            toDelete += (receiptNo.Checked + "\t");
            toDelete += (dateTimePicker1.Value.ToString(("yyyy-MM-dd")) + "\t");

            // will scan the entries and rewrite the ones that do not match the entry we want to delete
            var lines = File.ReadAllLines(@"CS6326Asg2.txt").Where(line => !line.Contains(toDelete)).ToArray();

            File.WriteAllLines(@"CS6326Asg2.txt", lines);

            refreshList();
            clearFields();
            
        }
    }
}
