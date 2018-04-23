Imports Microsoft.VisualBasic
Imports System
Namespace Q146124
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
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet = New Q146124.CarsDBDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCarId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAllDay = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.carSchedulingTableAdapter = New Q146124.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(747, 499)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "CarScheduling"
			Me.bindingSource1.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colCarId, Me.colUserId, Me.colAllDay})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsSelection.MultiSelect = True
'			Me.gridView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseDown);
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colCarId
			' 
			Me.colCarId.Caption = "CarId"
			Me.colCarId.FieldName = "CarId"
			Me.colCarId.Name = "colCarId"
			Me.colCarId.Visible = True
			Me.colCarId.VisibleIndex = 1
			' 
			' colUserId
			' 
			Me.colUserId.Caption = "UserId"
			Me.colUserId.FieldName = "UserId"
			Me.colUserId.Name = "colUserId"
			Me.colUserId.Visible = True
			Me.colUserId.VisibleIndex = 2
			' 
			' colAllDay
			' 
			Me.colAllDay.Caption = "AllDay"
			Me.colAllDay.FieldName = "AllDay"
			Me.colAllDay.Name = "colAllDay"
			Me.colAllDay.Visible = True
			Me.colAllDay.VisibleIndex = 3
			' 
			' carSchedulingTableAdapter
			' 
			Me.carSchedulingTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(747, 499)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private carsDBDataSet As CarsDBDataSet
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private carSchedulingTableAdapter As Q146124.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCarId As DevExpress.XtraGrid.Columns.GridColumn
		Private colUserId As DevExpress.XtraGrid.Columns.GridColumn
		Private colAllDay As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

