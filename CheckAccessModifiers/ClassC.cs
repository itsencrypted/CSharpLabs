using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAccessModifiers
{
    class ClassC
    {
        public ClassC()
        {
            var A = new ClassA();
           
        }

        class classD : ClassA
        {
            public classD()
            {
            }
            
        }
    }
}
