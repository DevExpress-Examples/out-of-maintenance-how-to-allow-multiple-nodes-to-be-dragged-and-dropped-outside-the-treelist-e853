Imports Microsoft.VisualBasic
Imports System
Namespace Sample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.label3 = New System.Windows.Forms.Label()
			Me.listBox1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Top
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(255, 20)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Drag && Drop Here"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label2
			' 
			Me.label2.Dock = System.Windows.Forms.DockStyle.Left
			Me.label2.Image = (CType(resources.GetObject("label2.Image"), System.Drawing.Image))
			Me.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
			Me.label2.Location = New System.Drawing.Point(0, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(27, 33)
			Me.label2.TabIndex = 2
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 33)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(349, 370)
			Me.treeList1.TabIndex = 3
'			Me.treeList1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.treeList1_MouseDown);
'			Me.treeList1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.treeList1_MouseMove);
			' 
			' label3
			' 
			Me.label3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label3.Location = New System.Drawing.Point(27, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(580, 33)
			Me.label3.TabIndex = 5
			Me.label3.Text = "label3"
			' 
			' listBox1
			' 
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBox1.Location = New System.Drawing.Point(0, 20)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(255, 350)
			Me.listBox1.TabIndex = 6
'			Me.listBox1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.listBox1_DragDrop);
'			Me.listBox1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.listBox1_DragEnter);
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(607, 33)
			Me.panel1.TabIndex = 7
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.listBox1)
			Me.panel2.Controls.Add(Me.label1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(352, 33)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(255, 370)
			Me.panel2.TabIndex = 8
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitter1.Location = New System.Drawing.Point(349, 33)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(3, 370)
			Me.splitter1.TabIndex = 9
			Me.splitter1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(607, 403)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "TreeList DragDrop"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Friend label2 As System.Windows.Forms.Label
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private label3 As System.Windows.Forms.Label
		Private WithEvents listBox1 As DevExpress.XtraEditors.ListBoxControl
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private splitter1 As System.Windows.Forms.Splitter
	End Class
End Namespace

