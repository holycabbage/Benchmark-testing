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

namespace Benchmark_testing
{
    public partial class Form1 : Form
    {
        //Initializing variable staffs which is a list of MyClass
        List<MyClass> staffs = new List<MyClass>();
        public Form1()
        {
            InitializeComponent();
        }


        private void lblAnnualSalary_Click(object sender, EventArgs e)
        {
            
        }



        private void btnStore_Click(object sender, EventArgs e)
        {
            //Create a new object of FileManager class named fm
            FileManager fm = new FileManager();
            try
            {

                //Create a new object s which is MyClass tpye
                MyClass s = new MyClass();

                // Determine the entered ID
                int id;
                //If the ID which is converted to an integer, in the range beyond the ID
                if(int.TryParse(tbxInputStaffID.Text, out id))
                {
                    //If the ID is less than 100000 or greater than 999999
                    if(id < 100000 || id > 999999)
                    {
                        //A message box is displayed which is printed "Please enter 6 digit numbers in StaffID"
                        MessageBox.Show("Please enter 6 digit numbers in StaffID");
                        return;
                    }
                }
                else
                {
                    //A message box is displayed which is printed "Please enter integer in in StaffID"
                    MessageBox.Show("Please enter integer in StaffID");
                    return;
                }

                //Store these five into each property of the class
                s.StaffID = id;
                s.Name = tbxInputName.Text;
                s.DateOfBirth = dtpBirthday.Value.ToString("yyyy-MM-dd");
                s.Email = tbxInputEmail.Text;
                s.AnnualSalary = int.Parse(tbxInputAnnualSalary.Text);

                //Calling the SaveStaff() function method to result
                bool result = fm.StoreStaff(s);

                //Clear the entered data in these five text box after press the btnStore
                tbxInputStaffID.Clear();
                tbxInputName.Clear();
                //Renew to the date of today after press the btnStore
                dtpBirthday.Value = DateTime.Now;
                tbxInputEmail.Clear();
                tbxInputAnnualSalary.Clear();

                //If result is false
                if (result == false)
                {
                    //A message box is displayed which is printed "Error Store Staff, please
                    //enter in the correct format", and message box's name is "Flie IO Error"
                    MessageBox.Show("Error Store Staff, please enter in the correct format", "File IO Error");
                }
                else
                {
                    //A message box is displayed which is printed "Store Successful", and message box's name is "Success"
                    DialogResult dr = MessageBox.Show("Store Successful", "Success");    
                }

            }
            catch (Exception)
            {
                //A message box is displayed which is printed "Please enter a right staff data", and
                //message box's name is "Error"
                MessageBox.Show("Please enter a right staff data", "Error");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Create a new object of FileManager class named fm
            FileManager fm = new FileManager();

            //The list box get cleared
            staffs.Clear();

            //Calling the LoadStaff() function method to staffs
            staffs = fm.LoadStaff();

            //if it is not able to read the file
            if (staffs == null)
            {
                //A message box is displayed which is printed "Error Loading Staff, please
                //enter in the correct format", and message box's name is "Flie IO Error"
                MessageBox.Show("Error Loading Staffs", "Flie IO Error");
            }
            else
            {
                //List box get cleared
                lbxStaff.Items.Clear();
                //Print the list of staff 
                lbxStaff.Items.AddRange(staffs.ToArray());
            }
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {

            //Create a object of Fliter class named cFilter
            Filter cFilter = new Filter();

            //Calling the SortAZ() function method to staffs
            staffs = cFilter.SortAZ(staffs);

            //List box get cleared
            lbxStaff.Items.Clear();
            //Print the list of staff which is in ascending order
            lbxStaff.Items.AddRange(staffs.ToArray());
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            //Create a object of Fliter class named cFilter
            Filter cFilter = new Filter();

            //Calling the SortZA() function method to staffs
            staffs = cFilter.SortZA(staffs);

            //List box get cleared
            lbxStaff.Items.Clear();
            //Print the list of staff which is in dscending order
            lbxStaff.Items.AddRange(staffs.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Initializing variable results which is a list of MyClass
            List<MyClass> results = new List<MyClass>();

            //Create a object of Fliter class named cFilter
            Filter sFilter = new Filter();

            //Initializing variable term which is a string, it is the text in tbxSearch
            string term = tbxSearch.Text;

            //Calling the Search() function method to results
            results = sFilter.Search(staffs, term);

            //List box get cleared
            lbxSearchResults.Items.Clear();
            //Print the list of staff which contains the term
            lbxSearchResults.Items.AddRange(results.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create a new object of FileManager class named fm
            FileManager fm = new FileManager();
            try
            {

                //Create a object of MyClass class named s which is selected in lbxSearchResults
                MyClass s = (MyClass)lbxSearchResults.SelectedItem;

                string filename = s.StaffID + s.Name + s.DateOfBirth + s.Email + s.AnnualSalary + ".txt";
                //Calling the SaveStaff() function method to result
                bool result = fm.SaveStaff(s, filename);

                // if result is false
                if (result == false)
                {
                    //A message box is displayed which is printed "Error Saving Staff", and
                    //message box's name is "Flie IO Error"
                    MessageBox.Show("Error Saving Staff", "File IO Error");
                }
                else
                {
                    //A message box is displayed which is printed "View File?", message box name is "Save Successful,
                    //and there are two bottons which are yes and no
                    DialogResult dr = MessageBox.Show("View File?", "Save Successful", MessageBoxButtons.YesNo);

                    //If click the Yes botton
                    if (dr.Equals(DialogResult.Yes))
                    {
                        //A string filename which contains staff data will be showed
                        System.Diagnostics.Process.Start(filename);
                    }
                }
            }
            catch (Exception)
            {
                //A message box is displayed which is printed "Please select a staff", message box name is "Eror"
                MessageBox.Show("Please select a staff", "Error");
            }
        }

        private void lbxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Create a object of MyClass class named s which is selected in lbxSearchResults
                MyClass s = (MyClass)lbxSearchResults.SelectedItem;


                //tbxStaffID shows the text which is the StaffID whose is selected, converted to string
                tbxStaffID.Text = s.StaffID.ToString();
                //tbxName shows the text which is the Name whose is selected
                tbxName.Text = s.Name;
                //tbxDateOfBirth shows the text which is the DateOfBirth whose is selected
                tbxDateOfBirth.Text = s.DateOfBirth;
                //tbxEmail shows the text which is the Email whose is selected
                tbxEmail.Text = s.Email;
                //tbxAnnualSalary shows the text which is the AnnualSalary whose is selected, converted to string
                tbxAnnualSalary.Text = s.AnnualSalary.ToString();
            }
            catch (Exception)
            {
                //A message box is displayed which is printed "Error"
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Create a object of MyClass class named s which is selected in lbxStaff
            MyClass s = (MyClass)lbxStaff.SelectedItem;

            if (s == null)
                return;

            //LINQ 
            var index = staffs.FindIndex(x => x.StaffID == s.StaffID);
            staffs.RemoveAt(index);

            //Remove the item form Staff ListBox
            lbxStaff.Items.RemoveAt(lbxStaff.SelectedIndex);

            //Restore staffs
            FileManager fm = new FileManager();
            fm.DeleteStaff(staffs);
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
