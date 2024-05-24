using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUniversityManagement
{
    internal class University
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private List<Department> Departments { get; set; }

        public University()
        {
            Departments = new List<Department>();
        }

        public string AddDepartment(Department department)
        {
            Department existDepartment = Departments.FirstOrDefault(x => x.DeptNo == department.DeptNo);
            if (department.DeptNo == null || department.DeptNo =="")
            {
                return "Departments Add Faild! Because DeptNo is empty";
            }
            if (existDepartment == null)
            {
                Departments.Add(department);
                return "Departments Add Successfull";
            }
            else
            {
                return "Departments Add Faild! Because RegNo already exist";
            }
        }
        public string UpdateDepartment(Department department)
        {
            Department existDepartment = Departments.FirstOrDefault(x => x.DeptNo == department.DeptNo);
            if (existDepartment != null)
            {
                existDepartment.Name = existDepartment.Name;
                existDepartment.Description = existDepartment.Description;
                return "Department Update Successfull";
            }
            else
            {
                return "Department Update Faild! Because Department do not find";
            }
        }
        public string RemoveDepartment(string deptNo)
        {
            Department department = Departments.FirstOrDefault(x => x.DeptNo == deptNo);
            if (department != null)
            {
                Departments.Remove(department);
                return "department Remove Successfull";
            }
            else
            {
                return "department Remove Faild! Because RegNo donot find";
            }
        }
        public string GetDepartmentInfo()
        {
            var deptInfo = "";
            List<Department> departments = Departments.ToList();
            foreach (Department department in departments)
            {
                var dept= department.GetDepartmentInfo();
                deptInfo += dept;
                var studentInfo = department.GetStudentInfo();
                deptInfo += studentInfo;
            }
            return deptInfo;           

        }
    }
}
