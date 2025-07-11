
namespace C44_G01_OOP2_Demo.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        public int empName;
        private string? Name;
        #endregion


        // Setters and Getters
        public void SetName(string name)
        {
            Name = name.Length > 10 ? Name?.Substring(0,10) : name;
        }

        public string? GetName()
        {
            return Name;
        }

        // Properties
        // 1] Automatic Property , 2] Full Property , 3] Indexer

        private decimal salary;

        //Full Property 
        public decimal Salary 
        {
            get { return salary; }
            set { salary = value < 1000 ? 1000 : value; }  // if not validation == Automatic Property
        }


        //Automatic Property

        public int age { get; set; } = 18; // default value

        // private decimal deduction;       // Not used 
        public decimal Deduction    // Derived Attribute
        {
            get { return 0.1m * salary ; }
        }









        #region Constructor

        public Employee(int id, string name, decimal salary)
        {
            empName = id;
            Name = name;
            Salary = salary;
        }
        #endregion


        #region Methods
        public override string ToString()
        {
            return $"Id: {empName}, Name: {Name}, Salary: {Salary}" ;
        }

        #endregion














    }
}
