using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TreeViewXMLTest
{
    public partial class Form1 : Form
    {

        TreeView treeView = new TreeView();
        private int count = 0;

        public Form1()
        {
            InitializeComponent();

            //取得XElement
            XElement X = XElement.Load("XML.xml");

            var Xitems =  X.XmlSerachElementXI("item");

            if (Xitems != null)
            {

                TreeNode rootNode = new TreeNode("Root");

                //為每個item建立一個property的依序層級node，並加至rootNode
                foreach (XElement item in Xitems)
                {
                    TreeNode ItemNode = new TreeNode(item.Elements().ElementAt(0).Value);
                    AddChildNode(ItemNode, item, 1);

                    rootNode.Nodes.Add(ItemNode);
                }

                treeView.Nodes.Add(rootNode);
            }

            treeView.Width = 300;
            treeView.Height = 300;

            this.Controls.Add(treeView);

        }



        /// <summary>
        /// 遞迴加子節點
        /// </summary>
        /// <param name="tNode"></param>
        /// <param name="item"></param>
        /// <param name="pos"></param>
        private void AddChildNode(TreeNode tNode, XElement item, int pos)
        {

            var property = item.Elements().ElementAtOrDefault(pos);

            if (property!=null)
            {
                tNode.Nodes.Add(property.Value);
                AddChildNode(tNode.FirstNode, item, ++pos);
            }
            
        }

    }
}
