

namespace C44_G01_OOP2_Demo.Inhiretance
{
    internal class Child : Parent
    {

        public int z { get; set; }

        // By default child will make constructor chaining for the parameterless 
        // constructor of the parent class
        public Child(int X , int Y , int Z): base(X, Y)  //Paremeterless Parent don't thing when delete :Base (x,y)
        {
            z = Z;
        }


        #region Methods 

        public override string ToString()
        {
            return $"{base.ToString()} , Z: { z }";

        }

        public override int Product() 
        {
            return base.Product() * z; // base.Product() will call the parent Product method
        }

        public override void MyFun()
        {
            Console.WriteLine("Hello I am child ...");
        }





        #endregion







        //public Child(int x, int y, int z)
        //{
        //    X = x;
        //    Y = y;
        //    Z = z;
        //}
        //public int Product ()
        //{
        //    return X * Y * Z;
        //}


        //public override string ToString()
        //{
        //    return $"X : {X} , Y : {Y}  , Z : {Z}";
        //}

    }

}

