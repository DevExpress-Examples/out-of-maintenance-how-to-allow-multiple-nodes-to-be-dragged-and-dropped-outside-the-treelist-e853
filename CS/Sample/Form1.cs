using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitData();
            label3.Text = "This example demonstrates how to use DragDrop capabilities of the XtraTreeList within the control and when working with another control.";

            treeList1.OptionsBehavior.AutoChangeParent = false;
            treeList1.OptionsBehavior.CloseEditorOnLostFocus = false;
            treeList1.OptionsBehavior.DragNodes = true;
            treeList1.OptionsBehavior.ShowToolTips = false;
            treeList1.OptionsBehavior.SmartMouseHover = false;
            treeList1.OptionsSelection.MultiSelect = true;

            listBox1.AllowDrop = true;
            listBox1.ItemHeight = 16;
        }

        private void InitData()
        {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if ( GetDragNodes(e.Data) != null)
                e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            DevExpress.XtraEditors.ListBoxControl lb = sender as DevExpress.XtraEditors.ListBoxControl;
            DevExpress.XtraTreeList.TreeListMultiSelection nodes = GetDragNodes(e.Data);
            if (nodes != null)
            {
                int ind = lb.IndexFromPoint(lb.PointToClient(new Point(e.X, e.Y)));                
                for (int i = 0 ; i < nodes.Count ; i++)
                {
                    string dragString  = GetStringByNode(nodes[i]);
                    if (ind == -1)
                        lb.Items.Add(dragString);
                    else
                        lb.Items.Insert(ind, dragString);                    
                }
            }
        }

        private DevExpress.XtraTreeList.TreeListMultiSelection GetDragNodes(IDataObject data)
        {
             return data.GetData(typeof (DevExpress.XtraTreeList.TreeListMultiSelection)) as  DevExpress.XtraTreeList.TreeListMultiSelection;
        }

        private string GetStringByNode(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            string ret  = string.Empty;
            for (int i = 0 ; i < treeList1.Columns.Count; i++)
                ret += node.GetDisplayText(i) + (i < treeList1.Columns.Count - 1 ? "; ": ".");
            return ret;
        }
        private TreeListHitInfo dragStartHitInfo; 
        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.None)
            {
                DevExpress.XtraTreeList.TreeList tl = sender as DevExpress.XtraTreeList.TreeList;
                dragStartHitInfo = tl.CalcHitInfo(e.Location);
            }
        }

        private void treeList1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragStartHitInfo != null && dragStartHitInfo.Node != null){
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(dragStartHitInfo.MousePoint.X - dragSize.Width / 2,
                    dragStartHitInfo.MousePoint.Y - dragSize.Height / 2), dragSize);
                if ( !dragRect.Contains(e.Location) )
                    ((TreeList)sender).DoDragDrop(treeList1.Selection, DragDropEffects.Copy);
            }

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}