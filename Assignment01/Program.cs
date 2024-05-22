namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department cseDpt = new Department()
            {
                DeptNo = "01",
                Name = "CSE",
                Description = "Computer Science & Engineering"
            };
            Student mahabub = new Student()
            {
                RegNo = "2024s01",
                Name = "Mahabub Alam"
            };
            Student bob = new Student()
            {
                RegNo = "2024s02",
                Name = "Mr Bob"
            };
            Student elian = new Student()
            {
                RegNo = "2024s03",
                Name = "Mr Elian"
            };
            Student updateSt = new Student()
            {
                RegNo = "2024s03",
                Name = "updateSt"
            };
            Console.WriteLine(cseDpt.AddStudent(mahabub));
            Console.WriteLine(cseDpt.AddStudent(bob));
            Console.WriteLine(cseDpt.AddStudent(elian));
            Console.WriteLine(cseDpt.AddStudent(elian));
            
            cseDpt.GetStudentInfo();
            cseDpt.RemoveStudent("2024s02");
            cseDpt.GetStudentInfo();


            Console.WriteLine(cseDpt.UpdateStudent(updateSt));
            cseDpt.GetStudentInfo();


        }
    }
}