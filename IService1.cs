﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TBPserver
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void registration(string username, string userpassword, string ques, string ans);
        [OperationContract]
        bool isvalid(string username, string userpassword);
       // [OperationContract]
       // void showalluser(Employee em);
        
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        void resetPassword(string username, string password,string ques, string ans);

        [OperationContract]
        void add(string name, string password, string id, string des);

        [OperationContract]
        void addemployee(Employee emp);

        [OperationContract]
        List<Employee> getEmployeeList();


        [OperationContract]
        void addTask(Task1 tsk);

        [OperationContract]
        List<Task1> getTaskList();

        [OperationContract]
        void DeleteEmp(string name, string id);

        [OperationContract]
        void ShowMyTasks(string name);

        [OperationContract]
        void calculateSalary();

        [OperationContract]
        bool valid(string username, string userpassword);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
