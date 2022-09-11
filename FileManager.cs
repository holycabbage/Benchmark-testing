using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_testing
{
    public class FileManager
    {
        //A method to store content to the file MyClass.txt
        public bool StoreStaff(MyClass s)
        {
            if (s == null)
                return false;
            try
            {

                //Store the content which is in type of "StaffID,Name,DateOfBirt,Email,AnnualSalary\n"
                string content = string.Format("{0},{1},{2},{3},{4}\n", s.StaffID, s.Name, s.DateOfBirth, s.Email, s.AnnualSalary);

                //Determine whether the "MyClass.txt" file exists or not
                if (File.Exists("MyClass.txt"))
                {
                    //Create a new object named sb which is the type of StringBuilder class
                    StringBuilder sb = new StringBuilder();

                    //Specify the follow statement in sr which is a new object from StreamReader
                    //and it reads from MyClass.txt
                    using (StreamReader sr = new StreamReader("MyClass.txt"))
                    {
                        //Append a new line to the end of the file contents and place the cursor there
                        sb.Append(sr.ReadToEnd());
                    }

                    //Append the content
                    sb.Append(content);
                    //Specify the follow statement in sr which is a new object from StreamWeader
                    //and it writes into MyClass.txt
                    using (StreamWriter sw = new StreamWriter("MyClass.txt"))
                    {
                        //Convert content to string and write content down
                        sw.Write(sb.ToString());
                    }
                }
                else
                {
                    //Open of Create "MyClass.txt" text file which data can be written
                    using (FileStream fs = new FileStream("MyClass.txt", FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        //Specify the follow statement in sw which is a new object from StreamWeader
                        //and it writes into fs
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            //Write the content down
                            sw.Write(content);
                        }
                    }
                }

                //Return as true
                return true;
            }
            catch (Exception)
            {
                //Retuen as false
                return false;
            }

        }

        //A method to delete selected staff from the file MyClass.txt
        public bool DeleteStaff(IEnumerable<MyClass> staffs)
        {
            //Initialize the file path
            string path = "MyClass.txt";
            //Determine the file exists or not
            if (File.Exists(path))
                // remove old file
                File.Delete(path);

            //Create a new object named sb which is the type of StringBuilder class
            StringBuilder sb = new StringBuilder();
            foreach(var s in staffs)
            {
                //Store the content which is in type of "StaffID,Name,DateOfBirt,Email,AnnualSalary\n"
                string content = string.Format("{0},{1},{2},{3},{4}\n", s.StaffID, s.Name, s.DateOfBirth, s.Email, s.AnnualSalary);
                //Append the content
                sb.Append(content);
            }

            //Resotre staffs' data
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(sb.ToString());
            }

            //return as true
            return true;
        }

        //A method to load staff which tpye is List and it is the list of MyClass
        public List<MyClass> LoadStaff()
        {
            //try and catch is to control errors
            try
            {
                //Initialize the staffList
                List<MyClass> staffList = new List<MyClass>();

                //Create an object from StreamReader and it is reading from MyClass.txt
                StreamReader sr = new StreamReader("MyClass.txt");

                //When i don't read the endOfStream
                while (!sr.EndOfStream)
                {
                    //read each line and store it in temp
                    string temp = sr.ReadLine();
                    //use "," to split those five value
                    string[] values = temp.Split(',');

                    //creat a new object s which is MyClass type
                    MyClass s = new MyClass();

                    //store these five into each property of the class
                    s.StaffID = int.Parse(values[0]);
                    s.Name = values[1];
                    s.DateOfBirth = values[2];
                    s.Email = values[3];
                    s.AnnualSalary = int.Parse(values[4]);

                    //Add a list which is the type of MyClass
                    staffList.Add(s);

                }
                //dispose the file
                sr.Dispose();
                //return as staffList
                return staffList;
            }
            catch (Exception)
            {
                //return as null
                return null;
            }

        }

        //A method to save staff which type is bool
        public bool SaveStaff(MyClass s, string fileName)
        {
            try
            {

                //Create a object from StreanWrite and give a filename
                StreamWriter sw = new StreamWriter(fileName);

                //Print "STAFF DETIALS"
                sw.WriteLine("STAFF DETIALS");
                //Print "Staff ID" and its saved variable
                sw.WriteLine("Staff ID: " + s.StaffID);
                //Print "Staff Name" and its saved variable
                sw.WriteLine("Staff Name: " + s.Name);
                //Print "Staff Date of Birth" and its saved variable
                sw.WriteLine("Staff Date of Birth: " + s.DateOfBirth);
                //Print "Staff Email" and its saved variable
                sw.WriteLine("Staff Email: " + s.Email);
                //Print "Staff Annual Salary" and its saved variable
                sw.WriteLine("Staff Annual Salary: " + s.AnnualSalary);

                //dispose the file
                sw.Dispose();
                //return as true
                return true;

            }
            catch (Exception)
            {
                //return as false
                return false;
            }
        }
    }
}
