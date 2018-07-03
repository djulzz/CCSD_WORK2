using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Interfacing_01
{
    public class Student
    {
        protected int mID;
        protected String name_first;
        protected String name_last;

        public int ID { get { return mID;  } }
        public String FirstName {  get { return name_first; } }
        public String LastName {  get { return name_last;  } }
        // This constructor sucks because it is unsafe
        // allows first and last names to be swapped.
        // TODO: FIX THIS
        public Student(int _ID, String _first, String _last)
        {
            mID = _ID;
            name_first = _first;
            name_last = _last;
        }

        public String this[int i]
        {
            get
            {
                switch( i )
                {
                    case 0:
                        {
                            int id = ID;
                            String converted = Convert.ToString(id);
                            return converted;
                        } ;
                    case 1:
                        {
                            return FirstName;
                        }

                    default:  case 2:
                        {
                            return LastName;
                        }
                }
            }
        }
    }

}