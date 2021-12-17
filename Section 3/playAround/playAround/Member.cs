using System;
using System.Collections.Generic;
using System.Text;

namespace playAround
{
    class Member
    {

        // member - private field
        private string memberName;
        private string jobTitle;
        private string firstName;
        private string lastName;
        private string age;

        // member - public field
        // public int age; 

        // member - property - exposes jobTitle safely - properties start with capital letter

        public string JobTitle 
        { 
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;   
            }
        }

        public string MemberName
        {
            get
            {
                return memberName;
            }
            set
            {
                memberName = value;
            }
        
        }
    }
}
