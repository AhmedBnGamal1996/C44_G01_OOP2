

namespace C44_G01_OOP2_Demo.Inhiretance
{
    internal class Parent
    {
     

        public int x {  get; set; } 
        public int y { get; set; }


        #region Constructor

        public Parent(int X, int Y)
        {
            x = X;
            y = Y;
        }




        //public Parent()
        //{
            
        //}
        #endregion


        #region Methods

        public virtual void  MyFun()
        {
            Console.WriteLine("Hello I am Parent");
        }

        public virtual int Product()
        {

            return x * y ;


        }

        public override string ToString()
        {
            return $"X : {x} , Y : {y}";
        }
       #endregion

    }

}
