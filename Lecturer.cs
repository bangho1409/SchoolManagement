using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Lecturer
    {
        private string lecId;
        private string lecName;
        private string lecAddress;
        private string lecEmail;
        private string lecDoB;
        private string lecDept;

        public Lecturer()
        {

        }

        public Lecturer(string lecId, string lecName, string lecAddress, string lecEmail, string lecDoB, string lecDept)
        {
            this.lecId = lecId;
            this.lecName = lecName;
            this.lecAddress = lecAddress;
            this.lecEmail = lecEmail;
            this.lecDoB = lecDoB;
            this.lecDept = lecDept;

        }

        public string getId()
        {
            return this.lecId;
        }
        public void setId(string lecId)
        {
            this.lecId = lecId;
        }

        public string getName()
        {
            return this.lecName;
        }
        public void setName(string lecName)
        {
            this.lecName = lecName;
        }

        public string getAddress()
        {
            return this.lecAddress;
        }
        public void setAddress(string lecAddress)
        {
            this.lecAddress = lecAddress;
        }

        public string getEmail()
        {
            return this.lecEmail;
        }
        public void setEmail(string lecEmail)
        {
            this.lecEmail = lecEmail;
        }

        public string getDoB()
        {
            return this.lecDoB;
        }
        public void setDoB(string lecDoB)
        {
            this.lecDoB = lecDoB;
        }

        public string getDept()
        {
            return this.lecDept;
        }
        public void setDept(string lecDept)
        {
            this.lecDept = lecDept;
        }
    }
}
