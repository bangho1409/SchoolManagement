using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Student
    {
        private string stdName;
        private string stdId;
        private string stdAddress;
        private string stdEmail;
        private string stdDoB;
        private string stdBatch;

        public Student()
        {

        }
        
        public Student(string stdId, string stdName, string stdAddress, string stdEmail, string stdDoB, string stdBatch)
        {
            this.stdId = stdId;
            this.stdName = stdName;           
            this.stdAddress = stdAddress;
            this.stdEmail = stdEmail;
            this.stdDoB = stdDoB;
            this.stdBatch = stdBatch;
        }

         public string getId()
        {
            return this.stdId;
        }
        public void setId(string stdId)
        {
            this.stdId = stdId;
        }

        public string getName()
        {
            return this.stdName;
        }
        public void setName(string stdName)
        {
            this.stdName = stdName;
        }

        public string getAddress()
        {
            return this.stdAddress;
        }
        public void setAddress(string stdAddress)
        {
            this.stdAddress = stdAddress;
        }

        public string getEmail()
        {
            return this.stdEmail;
        }
        public void setEmail(string stdEmail)
        {
            this.stdEmail = stdEmail;
        }

        public string getDoB()
        {
            return this.stdDoB;
        }
        public void setDoB(string stdDoB)
        {
            this.stdDoB = stdDoB;
        }

        public string getBatch()
        {
            return this.stdBatch;
        }
        public void setBatch(string stdBatch)
        {
            this.stdBatch = stdBatch;
        }
    }
}
