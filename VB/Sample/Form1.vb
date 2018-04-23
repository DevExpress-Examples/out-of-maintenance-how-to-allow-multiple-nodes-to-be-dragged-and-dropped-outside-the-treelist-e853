Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList

Namespace Sample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			InitData()
			label3.Text = "This example demonstrates how to use DragDrop capabilities of the XtraTreeList within the control and when working with another control."

			treeList1.OptionsBehavior.AutoChangeParent = False
			treeList1.OptionsBehavior.CloseEditorOnLostFocus = False
			treeList1.OptionsBehavior.DragNodes = True
			treeList1.OptionsBehavior.ShowToolTips = False
			treeList1.OptionsBehavior.SmartMouseHover = False
			treeList1.OptionsSelection.MultiSelect = True

			listBox1.AllowDrop = True
			listBox1.ItemHeight = 16
		End Sub

		Private Sub InitData()
			Dim xv As New DevExpress.XtraTreeList.Design.XViews(treeList1)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub listBox1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles listBox1.DragEnter
			If GetDragNodes(e.Data) IsNot Nothing Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub

		Private Sub listBox1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles listBox1.DragDrop
			Dim lb As DevExpress.XtraEditors.ListBoxControl = TryCast(sender, DevExpress.XtraEditors.ListBoxControl)
			Dim nodes As DevExpress.XtraTreeList.TreeListMultiSelection = GetDragNodes(e.Data)
			If nodes IsNot Nothing Then
				Dim ind As Integer = lb.IndexFromPoint(lb.PointToClient(New Point(e.X, e.Y)))
				For i As Integer = 0 To nodes.Count - 1
					Dim dragString As String = GetStringByNode(nodes(i))
					If ind = -1 Then
						lb.Items.Add(dragString)
					Else
						lb.Items.Insert(ind, dragString)
					End If
				Next i
			End If
		End Sub

		Private Function GetDragNodes(ByVal data As IDataObject) As DevExpress.XtraTreeList.TreeListMultiSelection
			 Return TryCast(data.GetData(GetType(DevExpress.XtraTreeList.TreeListMultiSelection)), DevExpress.XtraTreeList.TreeListMultiSelection)
		End Function

		Private Function GetStringByNode(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode) As String
			Dim ret As String = String.Empty
			For i As Integer = 0 To treeList1.Columns.Count - 1
				If i < treeList1.Columns.Count - 1 Then
					ret &= node.GetDisplayText(i) + ("; ")
				Else
					ret &= node.GetDisplayText(i) + (".")
				End If
			Next i
			Return ret
		End Function
		Private dragStartHitInfo As TreeListHitInfo
		Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList1.MouseDown
			If e.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.None Then
				Dim tl As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
				dragStartHitInfo = tl.CalcHitInfo(e.Location)
			End If
		End Sub

		Private Sub treeList1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList1.MouseMove
			If e.Button = MouseButtons.Left AndAlso dragStartHitInfo IsNot Nothing AndAlso dragStartHitInfo.Node IsNot Nothing Then
				Dim dragSize As Size = SystemInformation.DragSize
				Dim dragRect As New Rectangle(New Point(dragStartHitInfo.MousePoint.X - dragSize.Width \ 2, dragStartHitInfo.MousePoint.Y - dragSize.Height \ 2), dragSize)
				If (Not dragRect.Contains(e.Location)) Then
					CType(sender, TreeList).DoDragDrop(treeList1.Selection, DragDropEffects.Copy)
				End If
			End If

		End Sub

		Private Sub splitter1_SplitterMoved(ByVal sender As Object, ByVal e As SplitterEventArgs)

		End Sub
	End Class
End Namespace