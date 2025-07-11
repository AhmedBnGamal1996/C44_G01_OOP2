
using Common;

namespace C44_G01_OOP2_Demo
{
    internal class TypeD : TypeA
    {
        /*
            private int A;
            internal int B;
            public  int C;

            private protected int x;
            protected int y;
            protected internal int z; 
        */

        public TypeD() 
        {
            // A = 10;         // Invalid  No Inherited

            // B = 20;         // Invalid  No Inherited

            C = 30;         // inherite to Public 

            // x = 40;         // No inherite because private protected 

            y = 50  ;         // inherite from protected to Private

            z = 60 ;         // inherite protected internal to Private 


        }








    }
}
