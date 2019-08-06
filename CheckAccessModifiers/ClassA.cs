using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAccessModifiers
{
    class ClassA
    {
        //by default fields are private in C# ; A private member cannot be accessed from
        //outside of the class.
        int defaultA;

        //Can only be accessible from same project or assembly
        internal int internalX;
        
        //can only be accessible if derived
        protected int protectedY;
        
        //means protected or internal
        protected internal int protectedInternalZ;

        //No restrictions at all
        public int TestPublic;

        //Only accessible within this class
        private int TestPrivate;

        //Can be accessible from abstract representation of the class.
        //Or can be accessible without creating the class
        public static int StaticATest;
    }
}
