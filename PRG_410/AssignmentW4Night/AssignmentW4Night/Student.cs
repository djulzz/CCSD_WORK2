using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentW4Night
{
    public class Student
    {
        private String mName;
        private String mLastName;

        public Student()
        { }

        public Student( String name )
        {
            mName = name;
        }
        public String Name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }
    }
}
