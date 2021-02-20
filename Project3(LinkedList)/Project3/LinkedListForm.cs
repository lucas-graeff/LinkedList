using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    /// <summary>
    /// Lucas Graeff N01384687   
    /// Project 3
    /// 11/27/2018
    /// 
    /// Create a doubly linked list of 100 randomly generated doubles. 
    /// Print these nodes out forwards, backwards, and backwards with 10 extra nodes. 
    /// </summary>

    public partial class LinkedListForm : Form
    {
        public LinkedListForm()
        {
            InitializeComponent();
        }//end constructor

        Node markedNode;

        private void btnStart_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            #region Linked List Created
            Random rand = new Random();
            int size = 100;
            DoublyLinkedList list = new DoublyLinkedList();
            List<double> nodeData = new List<double>(111);
            double randomNum;
            int nodeNum = rand.Next(0, 101);

            for (int i = 0; i < size; i++)
            {
                randomNum = Math.Round(RandomDouble(rand, 0, 100.00), 2);
                nodeData.Add(randomNum);
                list.InsertLast(list, randomNum);
                if (i == nodeNum)
                {
                    markedNode = list.GetLastNode(list);
                    Console.WriteLine("Marked node: " + markedNode);
                }//end if
            }//end loop

            int numNodes = list.getNumNodes(list);
            Console.WriteLine("Num Nodes is " + numNodes + ",");
            #endregion

            #region Print Linked List

            listBox.Items.Add(string.Format("{0}", "Nodes Printed Forwards:"));
            listBox.Items.Add(string.Format("{0}", "-----------------------"));

            int index = 0;
            Node node = list.GetFirstNode(list);

            while (node != null)
            {
                listBox.Items.Add(string.Format("Node {0,2}:    {1:00.00}", index++, node.data));
                node = node.next;
            }//end loop

            listBox.Items.Add("");
            listBox.Items.Add(string.Format("{0}", "Nodes Printed Backwards:"));
            listBox.Items.Add(string.Format("{0}", "-----------------------"));


            while (index != 0)
            {
                listBox.Items.Add(string.Format("Node {0,2}:    {1:00.00}", --index, nodeData[index]));
            }//end loop

            listBox.Items.Add("");
            listBox.Items.Add(string.Format("{0}", "Nodes Printed Backwards + 10:"));
            listBox.Items.Add(string.Format("{0}", "-----------------------"));


            //Generate 10 new nodes
            
            for (int i = 0; i < 10; i++)
            {
                randomNum = Math.Round(RandomDouble(rand, 0, 100.00), 2);
                list.InsertFirst(list, randomNum);
                nodeData[i + nodeNum] = randomNum;
                nodeData.Insert(1 + nodeNum, randomNum);
                
            }//end loop
            index = 110;
            Console.WriteLine(list.getNumNodes(list));

            while (index != 0)
            {
                listBox.Items.Add(string.Format("Node {0,2}:    {1:00.00}", --index, nodeData[index]));
            }//end loop

        }//end method

        public double RandomDouble(Random random, double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }//end method

        private void btnRestart_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }//end method

        #endregion
    }//end class

}//end namespace
