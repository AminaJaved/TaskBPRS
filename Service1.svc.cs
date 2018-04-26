﻿using System;
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

        
    }
}
