namespace OOPUniversityManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University()
            {
                Name = "DIU",
                Description = "Daffodill International University",
            };

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

            Student mahabub = new Student()
            {
                RegNo = "2024cs01",
                Name = "Mahabub Alam",
                DeptNo = "CSE01",
                
            };
            Student bob = new Student()
            {
                RegNo = "2024cs02",
                Name = "Mr Bob",
                DeptNo = "CSE01",
            };
            Student elian = new Student()
            {
                RegNo = "2024ee01",
                Name = "Mr Elian",
                DeptNo = "EEE02",
            };
            Student mark = new Student()
            {
                RegNo = "2024ee02",
                Name = "Mark",
                DeptNo = "EEE02",
            };
            Console.WriteLine(cse.AddStudent(mahabub));
            Console.WriteLine(cse.AddStudent(bob));
            Console.WriteLine(eee.AddStudent(elian));
            Console.WriteLine(eee.AddStudent(mark));

            cse.GetStudentInfo();
            cse.RemoveStudent("2024s02");
            cse.GetStudentInfo();

            var departments = university.GetDepartmentInfo();
            int deptSl = 1;
            int stSl = 1;
            foreach (Department department in departments)
            {
                Console.WriteLine($"Sl No : {deptSl} Reg No : {department.DeptNo} Name : {department.Name}");
                deptSl++;
                var students = department.GetStudentByDept(department.DeptNo);
               
                foreach (Student student in students)
                {
                    Console.WriteLine($"Sl No : {stSl} Reg No : {student.RegNo} Name : {student.Name} Department : {student.DeptNo}");
                    stSl++;
                }

            }



            Console.WriteLine("Hello, World!");
        }
    }
}