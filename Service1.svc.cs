using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TBPserver
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public void registration(string username, string userpassword, string ques, string ans)
        {
            Admin ad = new Admin();
            ad.AdminName = username;
            ad.AdminPassword = userpassword;
            ad.Sec_question = ques;
            ad.Sec_answer = ans;
        }

        public bool isvalid(string username, string userpassword)
        {
            Boolean check=false;
            foreach(Admin a in AdminDL.adminName)
            {
                if (a.AdminName == username && a.AdminPassword == userpassword)
                {
                    check = true;
                }
                
            }
            return check;
        }

        public void resetPassword(string username, string userpassword, string ques, string ans)
        {
            bool reset = false;
            foreach (Admin a in AdminDL.adminName)
            {
                if (a.AdminName == username && a.Sec_question == ques && a.Sec_answer==ans)
                {
                    a.AdminPassword = userpassword;
                    reset = true;
                }
            }
            
        }

        public void add(string name, string password, string id, string des)
        {
            Employee ad = new Employee();
            ad.EmployeeName = name;
            ad.EmployeePassword = password;
            ad.EmployeeID = id;
            ad.EmployeeDesignation = des;
        }

        public void addemployee(Employee emp)
        {
            EmloyeeDL.employeeName.Add(emp);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Employee> getEmployeeList()
        {
            return EmloyeeDL.employeeName;
        }

        public void addTask(Task1 tsk)
        {
            TaskDL.tsk.Add(tsk);
        }

        public List<Task1> getTaskList()
        {
            return TaskDL.tsk;
        }

        public void DeleteEmp(string name, string id)
        {
            bool reset = false;
            foreach (Employee a in EmloyeeDL.employeeName)
            {
                if (a.EmployeeName == name && a.EmployeeID == id )
                {                    
                    reset = true;
                    a.EmployeeName = "";
                    a.EmployeePassword = "";
                    a.EmployeeID = "";
                    a.EmployeeDesignation="";

                }
            }
            
        }

        public void ShowMyTasks(string name)
        {
            //bool isFound = false;

            foreach (Task1 t in TaskDL.tsk)
            {
                if (t.EmpName == name)
                {
                    EmployeeTask.tsk.Add(t);                  
                    
                }
            }
        }
        int i = 0;
        public void calculateSalary()
        {
            foreach (Task1 a in TaskDL.tsk)
            {
                if (a.Task_Done == true)
                {
                    i = i + 10;
                    Salary.x=(i);
                }
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool valid(string username, string userpassword)
        {
            Boolean check = false;
            foreach (Employee a in EmloyeeDL.employeeName)
            {
                if (a.EmployeeName == username && a.EmployeePassword == userpassword)
                {
                    check = true;
                }

            }
            return check;
        }
    }
}
