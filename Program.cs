using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Students 
    {
        //declaring public string variables
        public String FirstName;
        public String LastName;

        //declaration of constructor with parameters
        public Students(String FN, String LN) {
            //initialising variables
            FirstName = FN;
            LastName = LN;
        }

        //declaration of get method
        public String GetFirstName() {
            //returning the first name
            return FirstName;
        }

        public String GetLastName()
        {
            return LastName;
        }

        //setting student first name
        public void SetFirstName(String Name) {
            FirstName = Name;
        }

        public void SetLastName(String LName)
        {
            LastName = LName;
        }

    }

    class Groups
    {
        //declaring public string variable
        public String GroupName;
        public String LecFirstName;
        public String LecLastName;

        //constructor with string parameter
        public Groups(String GName) {
            //initialising group name
            GroupName = GName;
        }

        //setting and getting methods
        public String GetGroupName()
        {
            return GroupName;
        }

        public String GetLecFName()
        {
            return LecFirstName;
        }

        public String GetLecLName()
        {
            return LecLastName;
        }

        public void SetGroupName(String GrpName) 
        {
            GroupName = GrpName;
        }

        public void SetLecFName(String LFName)
        {
            LecFirstName = LFName;
        }

        public void SetLecLName(String LLName)
        {
            LecLastName = LLName;
        }

        public List<Students> Studs = new List<Students>();

        

    }

    class College 
    {
        //public string variabe
        public String CollegeName;

        //public constructor with string variable parameter
        public College(String ColName) 
        {
            CollegeName = ColName;
        }

        //setters and getters methods
        public String GetCollegeName() {
            return CollegeName;
        }

        public void SetCollegeName(String cName) 
        {
            CollegeName = cName;
        }

        //declaration of lists
        public List<Groups> Grps = new List<Groups>();
        public List<Lecturers> Lects = new List<Lecturers>();
        public List<Students> Studs = new List<Students>();

        //public print method
        public void print() {


            Console.WriteLine("School name: " + CollegeName);

            Console.WriteLine();

            Console.Write("Lecturers: ");
            //for each declaration
            foreach (var lecturer in Lects) {
                //if last lecturer in lists
                if (lecturer.Equals(Lects.Last())) {
                    //display lecturer first name and last name, without comma after
                    Console.Write(lecturer.LecturerFirstName + " " + lecturer.LecturerLastName);
                }
                else {
                    //display lecturer first name and last name, with comma after
                    Console.Write(lecturer.LecturerFirstName + " " + lecturer.LecturerLastName + ", "); 
                }
            }

            Console.WriteLine();

            Console.Write("Students: ");
            //declaration of foreach loop, for students
            foreach (var students in Studs) {
                //if last of students
                if (students.Equals(Studs.Last())) {
                    //display students first name and last name, without comma after
                    Console.Write(students.FirstName + " " + students.LastName);
                }
                else {
                    //display students first name and last name, with comma after
                    Console.Write(students.FirstName + " " + students.LastName + ", ");
                }
            }

            Console.WriteLine();

            Console.Write("Groups: ");
            //foreach declaration
            foreach (var groups in Grps)
            {
                //if last of groupds lists
                if (groups.Equals(Grps.Last())) {
                    //display group, without comma after
                    Console.Write(groups.GroupName);
                }
                else {
                    //display group, with comma after
                    Console.Write(groups.GroupName + ", ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine();

            //declaration of foreach loop, for lects list
            foreach (var LectName in Lects) {
                //displaying lecturer first name and last name
                Console.WriteLine("Lecturer name: " + LectName.LecturerFirstName + " " + LectName.LecturerLastName);
                Console.Write("Groups of this lecturer: ");

                //declaration of foreach loop, for groups
                foreach (var grps in LectName.Grps) {
                    //if last of lists
                    if (grps.Equals(LectName.Grps.Last())) {
                        ////display list, without comma after
                        Console.Write(grps.GroupName);
                    }
                    else 
                    {
                        //display list, with comma after
                        Console.Write(grps.GroupName + ", ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------");

            }

            Console.WriteLine();
            //foreach declaration for groups
            foreach (var allGroups in Grps) {

                Console.WriteLine("Group Name: " + allGroups.GroupName);

                Console.Write("Students in the group: ");
                //nested foreach to get lists related to lists
                foreach (var allStudents in allGroups.Studs) {
                    //if last of lists
                    if (allStudents.Equals(allGroups.Studs.Last())) {
                        //display lists, without comma after
                        Console.Write(allStudents.FirstName + " " + allStudents.LastName);
                    }
                    else {
                        //display lists, with comma after
                        Console.Write(allStudents.FirstName + " " + allStudents.LastName + ", ");
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Group Lecturer: " + allGroups.LecFirstName + " " + allGroups.LecLastName);

                Console.WriteLine("------------------------------------------------------------------------");
            }

        }

    }

    class Lecturers 
    {
        //public string variable
        public String LecturerFirstName;
        public String LecturerLastName;

        //constructors with string parameters
        public Lecturers(String LFName, String LLName)
        {
            //initialisation of variables
            LecturerFirstName = LFName;
            LecturerLastName = LLName;
        }

        //getter and setter methods
        public String GetLecFirstName()
        {
            return LecturerFirstName;
        }

        public String GetLecLastName()
        {
            return LecturerLastName;
        }

        public void SetLectFirstName(String LecFName) 
        {
            LecturerFirstName = LecFName;
        }

        public void SetLectLastName(String LecLName)
        {
            LecturerLastName = LecLName;
        }

        //lists declaration
        public List<Groups> Grps = new List<Groups>();


    }

    class Program
    {
        static void Main(string[] args)
        {
            //Initialising object
            //passing a string value arguement (College name) to the constructor
            College objCollege = new College("Richfield Graduate Institute of Technology");

            //initialising object
            //passing string value arguements (Student name and surname) to the constructor
            Students objStudOne = new Students("Mzotho", "Andile");
            Students objStudTwo = new Students("Ngcobo", "Mandy");
            Students objStudThree = new Students("Khumalo", "Itumeleng");
            Students objStudFour = new Students("Tambo", "David");

            //initialising object
            //passing a string value arguement (Group) to the constructor
            Groups objGroupOne = new Groups("Java Programming");
            Groups objGroupTwo = new Groups("Advanced Data Structures");
            Groups objGroupThree = new Groups("Python");

            //using object to set the name and surname of the lecturers
            objGroupOne.SetLecFName("Raymond");
            objGroupOne.SetLecLName("Shamba");

            objGroupTwo.SetLecFName("Raymond");
            objGroupTwo.SetLecLName("Shamba");

            objGroupThree.SetLecFName("Prominent");
            objGroupThree.SetLecLName("Mugariri");

            //adding students to the required groups
            objGroupOne.Studs.Add(objStudFour);
            objGroupOne.Studs.Add(objStudTwo);
            objGroupOne.Studs.Add(objStudThree);

            objGroupTwo.Studs.Add(objStudFour);
            objGroupTwo.Studs.Add(objStudTwo);

            objGroupThree.Studs.Add(objStudOne);
            objGroupThree.Studs.Add(objStudTwo);

            ////initialising object
            //passing string value arguements (lecturer name and surname) to the constructor
            Lecturers objLecturerOne = new Lecturers("Raymond", "Shamba");
            Lecturers objLecturerTwo = new Lecturers("Prominent", "Mugariri");

            objLecturerOne.Grps.Add(objGroupOne);
            objLecturerOne.Grps.Add(objGroupTwo);
            objLecturerTwo.Grps.Add(objGroupThree);

            //adding groups to the college object
            objCollege.Grps.Add(objGroupOne);
            objCollege.Grps.Add(objGroupTwo);
            objCollege.Grps.Add(objGroupThree);

            //adding lecturers to the college object
            objCollege.Lects.Add(objLecturerOne);
            objCollege.Lects.Add(objLecturerTwo);

            //adding students to the college object
            objCollege.Studs.Add(objStudOne);
            objCollege.Studs.Add(objStudTwo);
            objCollege.Studs.Add(objStudThree);
            objCollege.Studs.Add(objStudFour);

            //displaying options
            Console.WriteLine("Choose an option:");
            Console.Write("1. Print \n2. Add \n3. Edit \n4. Delete \n");

            Console.WriteLine("Your option: ");
            //getting input from user
            int OptOne = Int32.Parse(Console.ReadLine());

            //declaration of switch statement
            switch (OptOne) {
                case 1:
                    //clears the console
                    Console.Clear();
                    //calling the print method, using the college object
                    objCollege.print();
                    break;

                case 2:

                    Console.Clear();

                    //add options
                    Console.WriteLine("Choose an add option: ");
                    Console.Write("1. Lecturer \n2. Student \n3. Group \n");

                    Console.WriteLine("Your option: ");
                    int OptTwo = Int32.Parse(Console.ReadLine());

                    switch (OptTwo)
                    {
                        case 1:
                            Console.Clear();
                            //asking for lecturer first name
                            Console.Write("Enter Lecturer First Name: ");
                            //getting input from user (lecturer first name)
                            String LecFName = Console.ReadLine();
                            //asking for lecturer last name
                            Console.Write("Enter Lecturer Last Name: ");
                            //getting input from user (lecturer first name)
                            String LecLName = Console.ReadLine();

                            //adding new lecturer to the lecturer object
                            Lecturers objLecturers = new Lecturers(LecFName, LecLName);
                            //adding the lecturer object to the college object
                            objCollege.Lects.Add(objLecturers);

                            Console.Clear();

                            Console.WriteLine();
                            Console.Write("****************************************************Added lecturer****************************************************");
                            Console.WriteLine();

                            //calling print method using college object
                            objCollege.print();
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Enter Student First Name: ");
                            String StudFName = Console.ReadLine();
                            Console.Write("Enter Student Last Name: ");
                            String StudLName = Console.ReadLine();

                            Students objStudents = new Students(StudFName, StudLName);
                            objCollege.Studs.Add(objStudents);

                            Console.Clear();

                            Console.WriteLine();
                            Console.Write("****************************************************Added Student****************************************************");
                            Console.WriteLine();

                            objCollege.print();

                            break;

                        case 3:
                            Console.Clear();
                            Console.Write("Enter Group Name: ");
                            String newGroup = Console.ReadLine();

                            Groups objGroups = new Groups(newGroup);
                            objCollege.Grps.Add(objGroups);

                            Console.WriteLine();
                            Console.Write("****************************************************Added Group****************************************************");
                            Console.WriteLine();

                            Console.Clear();

                            objCollege.print();

                            break;

                        default:
                            Console.WriteLine("Non-existant option.");
                            break;
                    }

                    break;

                case 3:

                    Console.Clear();

                    Console.WriteLine("Choose an edit option: ");
                    Console.Write("1. Lecturer \n2. Student \n3. Group \n");

                    Console.WriteLine("Your option: ");
                    int OptThree = Int32.Parse(Console.ReadLine());

                    switch (OptThree) {
                        case 1:

                            Console.Clear();
                            //asking for new lecturer name
                            Console.Write("Enter Lecturer First Name: ");
                            //getting lecturer new name
                            String LecFName = Console.ReadLine();
                            //asking for new lecturer surname
                            Console.Write("Enter Lecturer Last Name: ");
                            //getting lecturer new surname
                            String LecLName = Console.ReadLine();

                            //setting new lecturer first name and last name
                            objLecturerOne.SetLectFirstName(LecFName);
                            objLecturerOne.SetLectLastName(LecLName);

                            objGroupOne.SetLecFName(LecFName);
                            objGroupOne.SetLecLName(LecLName);

                            objGroupTwo.SetLecFName(LecFName);
                            objGroupTwo.SetLecLName(LecLName);

                            //calling print method using college object
                            Console.Clear();
                            objCollege.print();
                            break;

                        case 2:

                            Console.Clear();
                            Console.Write("Enter Student First Name: ");
                            String StudFName = Console.ReadLine();
                            Console.Write("Enter Student Last Name: ");
                            String StudLName = Console.ReadLine();

                            //setting new student first name and last name
                            objStudOne.SetFirstName(StudFName);
                            objStudOne.SetLastName(StudLName);

                            Console.Clear();
                            objCollege.print();

                            break;

                        case 3:

                            Console.Clear();
                            Console.Write("Enter Group: ");
                            String editedGroup = Console.ReadLine();

                            //setting new group name
                            objGroupOne.SetGroupName(editedGroup);

                            Console.Clear();
                            objCollege.print();

                            break;

                        default:
                            Console.WriteLine("Non-existant option.");
                            break;
                    }

                    break;

                case 4:

                    Console.Clear();

                    Console.WriteLine("Choose a delete option: ");
                    Console.Write("1. Lecturer \n2. Student \n3. Group \n");

                    Console.WriteLine("Your option: ");
                    int OptFour = Int32.Parse(Console.ReadLine());

                    switch (OptFour)
                    {
                        case 1:
                            //deleting lecture first name and last name
                            objLecturerOne.SetLectFirstName(null);
                            objLecturerOne.SetLectLastName(null);

                            Console.Clear();
                            //calling print object
                            objCollege.print();
                            break;

                        case 2:
                            //deleting student first name and last name
                            objStudOne.SetFirstName(null);
                            objStudOne.SetLastName(null);

                            Console.Clear();
                            objCollege.print();
                            break;

                        case 3:
                            //deleting group
                            objGroupOne.SetGroupName(null);

                            Console.Clear();
                            objCollege.print();
                            break;

                        default:
                            Console.WriteLine("Non-existant option.");
                            break;
                    }

                    break;

                default:
                    //default display if choice isn't in given options
                    Console.WriteLine("Non-existant option.");
                    break;
            }



            Console.ReadLine();

        }
    }
}
