using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using System.Drawing;

namespace TBPserver
{
    [DataContract]
    public class Admin
    {
        private string sec_question;
        private string sec_answer;
        [DataMember]
        public string Sec_question
        {
            get { return sec_question; }
            set { sec_question = value; }
        }

        [DataMember]
        public string Sec_answer
        {
            get { return sec_answer; }
            set { sec_answer = value; }
        }
        private string adminName;
        [DataMember]
        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        private string adminPassword;
        [DataMember]
        public string AdminPassword
        {
            get { return adminPassword; }
            set { adminPassword = value; }
        }
        private Image adminImage;
        [DataMember]
        public Image AdminImage
        {
            get { return adminImage; }
            set { adminImage = value; }
        }
    }
}