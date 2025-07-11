namespace Common
{
    public class TypeB
    {
        /*
        private int A;
        internal int B;
        public  int C;

        private protected int x;
        protected int y;
        protected internal int z; 
         
         */

        void MyFun()
        {
            TypeA  typeA = new TypeA();
            // typeA.A = 1;                // invalid because Private
            typeA.B = 2;            // Valid because internal 
            typeA.C = 3;            // Valid because Public 

            // typeA.x = 4;    // Invalid because transform from Protected Private to Private and not Inherite 
            // typeA.y = 5;    // Invalid because transform from Protected to Private
            typeA.z = 6;       // Valid because transform from Protected Internal to Internal
             

        }
    }
}
