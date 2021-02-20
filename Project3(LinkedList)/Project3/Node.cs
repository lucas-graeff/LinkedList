using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Node
    {

        public double data;
        public Node next;
        public Node prev;

        public Node(double d)
        {
            data = d;
            next = null;
            prev = null;
        }//end constructor


    }//end class

}//end namespace
