using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Drawing;
using System.Web;

namespace TBPserver
{
    [DataContract]
    public class Employee
    {

        [DataMember]
        public List<Task1> contacts = new List<Task1>();
        private string employeeName;
        [DataMember]
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        private string employeePassword;
        [DataMember]
        public string EmployeePassword
        {
            get { return employeePassword; }
            set { employeePassword = value; }
        }

        //private Image userImage;
        //[DataMember]
        //public Image UserImage
        //{
        //    get { return userImage; }
        //    set { userImage = value; }
        //}
        private string employeeID;
        [DataMember]
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        private string employeeDesignation;
        [DataMember]
        public string EmployeeDesignation
        {
            get { return employeeDesignation; }
            set { employeeDesignation = value; }
        }

    }

}