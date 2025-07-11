
namespace C44_G01_OOP2_Demo.Class
{
    internal class Car
    {
        #region Properties 
        // Automatic Properties
        //public int Id { get; set; }
        //public string? Model { get; set; }
        //public string? Color { get; set; }


        private int id = default; 
        private string? model = default;
        private string? color = default;


        #endregion

        #region Constructors

        public Car ()
        {
            // Do Nothing
        }

        public Car (int id , string? model , string? color)
        {
            this.id = id;
            this.model = model;
            this.color = color;
            Console.WriteLine("Constructor One");
        }

        public Car (int id , string? model):this (id,model,"Red")
        {
            Console.WriteLine("Constructor Two");

        }
        public Car(int id) : this(id ,"Ford" , "Red")
        {
            Console.WriteLine("Constructor Three");

        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return $"Id = {id} , Model = {model} , Color = {color}";
        }
        #endregion


    }
}
