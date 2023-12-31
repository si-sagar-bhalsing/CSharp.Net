﻿using System.Xml.Linq;

namespace CollectionDemo
{
    internal class EmployeeUtility
    {
        List<Employee> employeeList = new List<Employee>()
       {
            new Employee(){id=1, name="Sagar", department="Data and Video Tech",salary=70000 },
            new Employee(){id=2, name="Anchal", department="HR",salary=45000 },
            new Employee(){id=3, name="Anas", department="IT",salary=65000 },
            new Employee(){id=4, name="Jay", department="IT",salary=60000 },
            new Employee(){id=5, name="Sapna", department="Content",salary=40000 },
        };
    


    public Employee CreateEmployee(int id, string name, string department, double salary)
        {
            Employee emp = new Employee()
            { name = name, department = department, salary = salary,id =id };
            return emp;
        }



        public bool AddEmployee(Employee emp)
        {
            if (employeeList.Count == 0)
            {
                employeeList.Add(emp);
            }
            else
            {
                foreach (Employee employee in employeeList)
                {
                    if (employee.Equals(emp))
                    {
                        return false;
                    }
                    else
                    {
                        employeeList.Add(emp);
                        break;
                    }
                }
            }
            return true;

        }
        public void SearchByName(string name)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.name.Equals(name))
                {
                    Console.WriteLine($"ID:{emp.id}   Name:{emp.name}  Department:{emp.department}   Salary:{emp.salary}");
                }
            }
        }

        public void SearchById(int id)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.id.Equals(id))
                {
                    Console.WriteLine($"ID:{emp.id}   Name:{emp.name}  Department:{emp.department}   Salary:{emp.salary}");
                }
            }
        }

        public void SearchByDepartment(string department)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.department.Equals(department))
                {
                    Console.WriteLine($"ID:{emp.id}   Name:{emp.name}  Department:{emp.department}   Salary:{emp.salary}");

                }
            }
        }
        public List<Employee> CompareSalary()
        {
            employeeList.Sort(new EmployeeCompare());
            return employeeList;
        }
        public void DisplayEmployees()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("================================");
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
