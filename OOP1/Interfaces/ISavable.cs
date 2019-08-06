using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public interface ISavable
    {
        int Changes
        {
            get;
            set;
        }

        void Save();
        void NewMethod();
    }
}