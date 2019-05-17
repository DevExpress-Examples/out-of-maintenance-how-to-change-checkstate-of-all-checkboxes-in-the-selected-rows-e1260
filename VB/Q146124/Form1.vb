Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace Q146124
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function CanCheck(ByVal view As GridView, ByVal location As Point) As Boolean
			Dim hitInfo As GridHitInfo = view.CalcHitInfo(location)
			Return view.SelectedRowsCount > 1 AndAlso hitInfo.InRowCell AndAlso hitInfo.Column Is colAllDay AndAlso view.IsRowSelected(hitInfo.RowHandle)
		End Function

		Private Sub DoCheck(ByVal view As GridView)
			Dim selectedRows As New List(Of Integer)()
			Dim value As Boolean = False
			For i As Integer = 0 To view.RowCount - 1
				If view.IsRowSelected(i) Then
					selectedRows.Add(i)
					If Not value Then
						value = Not CBool(view.GetRowCellValue(i, colAllDay))
					End If
				End If
			Next i
			For Each row As Integer In selectedRows
				view.SetRowCellValue(row, colAllDay, value)
			Next row
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			bindingSource1.DataSource = GetCarSchedulingDataTable()
		End Sub
		Private Function GetCarSchedulingDataTable() As DataTable
			Dim table As New DataTable()
			table.TableName = "CarScheduling"
			table.Columns.Add(New DataColumn("ID", GetType(Integer)))
			table.Columns.Add(New DataColumn("CarId", GetType(String)))
			table.Columns.Add(New DataColumn("UserId", GetType(String)))
			table.Columns.Add(New DataColumn("AllDay", GetType(Boolean)))
			Dim random As New Random()
			For i As Integer = 0 To 19
				Dim index As Integer = i + 1
				table.Rows.Add(index, "Car " & random.Next(0, 100), "User " & random.Next(0, 1000), random.Next(2) = 0)
			Next i
			Return table
		End Function
		Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseDown
			If e.Button <> MouseButtons.Left Then
				Return
			End If
			Dim view As GridView = DirectCast(sender, GridView)
			If Not CanCheck(view, e.Location) Then
				Return
			End If
			DoCheck(view)
			CType(e, DXMouseEventArgs).Handled = True
		End Sub
	End Class
End Namespace