namespace OOPUniversityManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create University
            University university = new University()
            {
                Name = "DIU",
                Description = "Daffodill International University",
            };

            //add Departments
            Department cse = new Department()
            {
                DeptNo = "CSE01",
                Name = "Computer Science & Engineerning",
                Description = "Good Department",
            };

            Department eee = new Department()
            {
                DeptNo = "EEE02",
                Name = "Electrical & Electronics Engineerning",
                Description = "Good Department",
            };

            Console.WriteLine(university.AddDepartment(cse));
            Console.WriteLine(university.AddDepartment(eee));


            //add Students

            Student mahabub = new Student()
            {
                RegNo = "2024cs01",
                Name = "Mahabub Alam",
                
            };
            Student bob = new Student()
            {
                RegNo = "2024cs02",
                Name = "Mr Bob",
            };
            Student elian = new Student()
            {
                RegNo = "2024ee01",
                Name = "Mr Elian",
            };
            Student mark = new Student()
            {
                RegNo = "2024ee02",
                Name = "Mark",
            };
            Console.WriteLine(cse.AddStudent(mahabub));
            Console.WriteLine(cse.AddStudent(bob));
            Console.WriteLine(eee.AddStudent(elian));
            Console.WriteLine(eee.AddStudent(mark));

            //get Department info
            Console.WriteLine(university.GetDepartmentInfo());

        }
    }
}