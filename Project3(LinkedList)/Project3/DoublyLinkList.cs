using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class DoublyLinkedList
    {
        /// <summary>
        /// The first node in the linked list
        /// </summary>
        private Node head = null;



        public void InsertFirst(DoublyLinkedList list, double newData)
        {

            Node newNode = new Node(newData);
            newNode.next = list.head;
            list.head = newNode;

        }//end method

        public void InsertLast(DoublyLinkedList list, double newData)
        {

            Node newNode = new Node(newData);

            if (list.head == null)
            {
                list.head = newNode;
                return;
            }//end if

            Node lastNode = GetLastNode(list);
            lastNode.next = newNode;

        }//end method


        public Node GetLastNode(DoublyLinkedList list)
        {
            Node tempNode = list.head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }//end loop

            return tempNode;

        }//end method

        public Node GetFirstNode(DoublyLinkedList list)
        {

            Node tempNode = list.head;
            if(list.head == null)
            {
                return null;
            }//end if
            return tempNode;
        }//end method


        public void InsertAfter(Node prevNode, double newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("No previous node found.");
                return;

            }//end if

            Node newNode = new Node(newData);
            newNode.next = prevNode.next;
            prevNode.next = newNode;

        }//end method

        public int getNumNodes(DoublyLinkedList list)
        {

            Node node = list.head;
            int result = 0;

            if(node != null)
            {
                result++;

                while (node.next != null)
                {
                    node = node.next;
                    result++;
                }//end loop

            }//end if

            return result;
        }

    }//end class

}//end namespace
