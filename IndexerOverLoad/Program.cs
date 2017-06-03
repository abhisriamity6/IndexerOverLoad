using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverLoad
{
    class IndererDemo
        {
        int[] a;
        public int length;
        public bool errflag;

       private bool ISValid(int index)
        {
                if(index >= 0 & index <length)
            {
                return true;
            }
                else
            {
                return false;
            }
        }
        
        public IndererDemo (int size)
        {
            a = new int[size];
            length = size;
        }

        public int this[int index]
            {

            get
            {
                if(ISValid(index))
                {
                    errflag = false;
                    return a[index];

                }
                else
                {
                    errflag = true;
                    return 0;
                }
            }

            set
            {
                if (ISValid(index))
                {
                    errflag = false;
                    a[index] = value;

                }
                else
                {
                    errflag = true;
                    
                }
            }
            }


    }
    class Program
    {
        static void Main(string[] args)
        {

            
        }
    }
}
