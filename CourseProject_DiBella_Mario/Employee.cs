using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMEP
{
    abstract class Employee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAge;
        private string employeeBirth;
        private string employeePosition;
        private string employeeSalary;
        private static List<Employee> employees = new List<Employee>();
        public Employee(string employeeID, string employeeName, string employeeAge, string employeeBirth, string employeePosition, string employeeSalary)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeAge = employeeAge;
            EmployeeBirth = employeeBirth;
            EmployeePosition = employeePosition;
            EmployeeSalary = employeeSalary;
        }

        public static void getEmployees()
        {
            SqlConnection con;
            SqlCommand cmd;
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mario\source\repos\CourseProject_DiBella_Mario\CourseProject_DiBella_Mario\App_Data\EmployeeBasic.mdf;Integrated Security=True;Connect Timeout=30";
            using (con = new SqlConnection(constr))
            {
                using (cmd = new SqlCommand("Select * From EmployeeInfo"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        
                        while (sdr.Read())
                        {
                            string id = sdr["emp_id"].ToString();
                            string pic = sdr["emp_pic"].ToString();
                            string name = sdr["emp_name"].ToString();
                            string age = sdr["emp_age"].ToString();
                            string birth = sdr["emp_birth"].ToString();
                            string pos = sdr["emp_position"].ToString();
                            string sal = sdr["emp_salary"].ToString();
                            if (!pos.Contains("Manager")||!pos.Contains("CEO"))
                            {
                                Employees.Add(new Worker(id, name, pic, age, birth, sal));
                                Console.WriteLine(Employees.Count+" worker");
                            }
                            else
                            {
                                Employees.Add(new Manager(id, name, pic, age, birth, sal, true));
                                Console.WriteLine(Employees.Count+" manager");
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeAge { get => employeeAge; set => employeeAge = value; }
        public string EmployeeBirth { get => employeeBirth; set => employeeBirth = value; }
        public string EmployeePosition { get => employeePosition; set => employeePosition = value; }
        public string EmployeeSalary { get => employeeSalary; set => employeeSalary = value; }
        internal static List<Employee> Employees { get => employees; set => employees = value; }
    }
}
