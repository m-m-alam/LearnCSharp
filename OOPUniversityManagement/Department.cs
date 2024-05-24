using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUniversityManagement
{
    internal class Department
    {
        public string DeptNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private List<Student> Students { get; set; }

        public Department() { Students = new List<Student>(); }
       
        public string AddStudent(Student student)
        {
            Student isExist = Students.FirstOrDefault(x => x.RegNo == student.RegNo);
            if (isExist == null)
            {
                Students.Add(student);
                return "Student Add Successfull";
            }
            else
            {
                return "Student Add Faild! Because RegNo already exist";
            }
        }
        public string UpdateStudent(Student student)
        {
            Student existStudent = Students.FirstOrDefault(x => x.RegNo == student.RegNo);
            if (existStudent != null)
            {
                existStudent.Name = student.Name;
                return "Student Update Successfull";
            }
            else
            {
                return "Student Update Faild! Because Sudent do not find";
            }
        }
        public string RemoveStudent(string regNo)
        {
            Student student = Students.FirstOrDefault(x => x.RegNo == regNo);
            if (student != null)
            {
                Students.Remove(student);
                return "Student Remove Successfull";
            }
            else
            {
                return "Student Remove Faild! Because RegNo donot find";
            }
        }
        public void GetStudentInfo()
        {
            List<Student> students = Students.ToList();
            int sl = 1;
            foreach (Student student in students)
            {
                Console.WriteLine($"Sl No : {sl} Reg No : {student.RegNo} Name : {student.Name}");
                sl++;
            }

        }
        public List<Student> GetStudentByDept(string deptNo)
        {
            List<Student> students = Students.Where(x=>x.DeptNo==deptNo).ToList();
            return students;
           

        }
    }
}
