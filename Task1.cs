using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections;
using System.Web;

namespace TBPserver
{
    [DataContract]
    public class Task1
    {
        private bool task_Done;
        [DataMember]
        public bool Task_Done
        {
            get { return task_Done; }
            set { task_Done = value; }
        }
        private string empName;
        [DataMember]
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private string task;
        [DataMember]
        public string Tasks
        {
            get { return task; }
            set { task = value; }
        }
        //private string designation;

        //public string Designation
        //{
        //    get { return designation; }
        //    set { designation = value; }
        //}
        private string taskDetails;
        [DataMember]
        public string TaskDetails
        {
            get { return taskDetails; }
            set { taskDetails = value; }
        }

    }

}
