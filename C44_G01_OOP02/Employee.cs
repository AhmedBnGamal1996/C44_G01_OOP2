using System.Globalization; 

namespace C44_G01_OOP02
{


    // Employee is identified by an ID, Name, security level, salary, hire date and Gender.

    internal class Employee : HiringDate
    {


        private int id;
        private string? name;
        private SecurityPrivileges securitylevel;
        private int salary;
        private Gender gender ;




        #region  Full Prop
        
        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0  )

                    id = value ;
            }
        }
      

        public string? Name
        {

            get { return name; }
            set 
            { 
                if (value != null && value.Length> 4 && value is not null)
                {
                    name = value;
                }


            }
        }

        public SecurityPrivileges SecurityLevel
        {
            get { return securitylevel; }
            set
            {
                if (value > 0 )

                    securitylevel = value;
            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if ( value > 0  )
                {
                    salary = value;
                }
            }
        }



        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (value >= 0 )
                {
                    gender = value;
                }
            }
        }







        #endregion

        #region Constructors 

        public Employee(int Id, string? Name, SecurityPrivileges SecurityLevel, int Salary, Gender Gender , int day , int month , int year ) : base(day, month , year )
        {
            id = Id;
            name = Name;
            securitylevel = SecurityLevel;
            salary = Salary;
        

        }






        #endregion








        #region Methods


        // We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), 
        // display employee salary in a currency format. [ use String.Format Function]


        public override string ToString()
        {
            string? salaryFormat = salary.ToString("C", new CultureInfo("en-US"));

            return $"ID : {id} , Name : {name} , SecurityLevel : {securitylevel} , Salary : {salaryFormat} , HireDate : {base.ToString()} , Gender : {gender} "; 
        }




        #endregion


    }
}
