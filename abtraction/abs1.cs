using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public int EmployeeId;
    public string EmployeeName;
    public double GrossPay;
    double TaxDeduction = 0.1;
    double netSalary;

    public Employee(int Eid, String Ename, double EGrossPay)
    {
        this.EmployeeId = Eid;
        this.EmployeeName = Ename;
        this.GrossPay = EGrossPay;
    }

    void CalculateSalary()
    {
        if(GrossPay >= 30000)
        {
            netSalary = GrossPay - (TaxDeduction * GrossPay);
            Console.WriteLine("Your Salary is {netSalary}");
        }
        else
        {
            Console.WriteLine("Your Salary is}", GrossPay);
        }
    }
    public void ShowEmployeeDetails()
    {
        Console.WriteLine("Employee Id is {0}: ", this.Eid);

        this.CalculateSalary();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee Ali = new Employee(333,"Ali Khan",40000);
        Ali.ShowEmployeeDetails();
        Console.ReadLine();
    }
}