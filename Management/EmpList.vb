Imports System.Data.SqlClient
Public Class EmpList

    Private Sub EmpList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=AISATT-NOTE03\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"
        Dim cmEmp As New SqlCommand
        cmEmp.CommandText = "SELECT * FROM 社員"
        cmEmp.Connection = cn
        Dim cmWork As New SqlCommand
        cmWork.CommandText = "SELECT * FROM 勤務"
        cmWork.Connection = cn
        daEmp.SelectCommand = cmEmp
        daWork.SelectCommand = cmWork
        daEmp.Fill(ds, "社員")
        daWork.Fill(ds, "勤務")

        Dim pCol As DataColumn
        Dim cCol As DataColumn
        pCol = ds.Tables("社員").Columns("社員番号")
        cCol = ds.Tables("勤務").Columns("社員番号")
        Dim rel As New DataRelation("relEmpID", pCol, cCol)
        ds.Relations.Add(rel)
        dgWork.DataSource = ds
        dgWork.DataMember = "社員.relEmpID"
        txtEno.DataBindings.Add("Text", ds, "社員.社員番号")
        txtName.DataBindings.Add("Text", ds, "社員.氏名")
        txtPost.DataBindings.Add("Text", ds, "社員.役職")
        ShowPosition()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        dgWork.ClearSelection()
        dgWork.Rows(0).Selected = True
        'dgWork.CurrentCell = dgWork.Rows(0).Cells("社員番号")
        'セル選択の場合
    End Sub

    Private Sub btnPre_Click(sender As Object, e As EventArgs) Handles btnPre.Click
        '選択行を１つ前に移動
        Dim intTemp As Integer
        intTemp = Me.dgWork.CurrentCell.RowIndex
        If intTemp <> 0 Then
            dgWork.ClearSelection()
            dgWork.Rows(intTemp - 1).Selected = True
            'クリックして▶も１つ前に移動
            Dim iRow As Int32 = intTemp - 1
            Dim iCol As Int32 = 0
            Me.dgWork.CurrentCell = Me.dgWork(iCol, iRow)
        End If
        
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim intTemp As Integer
        intTemp = Me.dgWork.CurrentCell.RowIndex
        dgWork.ClearSelection()
        dgWork.Rows(intTemp + 1).Selected = True
        Dim iRow As Int32 = intTemp + 1
        Dim iCol As Int32 = 0
        Me.dgWork.CurrentCell = Me.dgWork(iCol, iRow)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim allRows As Integer
        allRows = dgWork.Rows.Count
        dgWork.ClearSelection()
        dgWork.Rows(allRows - 2).Selected = True
    End Sub
    Public Sub ShowPosition()
        Dim allRows As Integer
        allRows = dgWork.Rows.Count
        Dim cs As Integer = 0
        cs = dgWork.Rows.GetRowCount(DataGridViewElementStates.Selected)

        lblCount.Text = cs & "/" & allRows
    End Sub

    Private Sub btnDBup_Click(sender As Object, e As EventArgs) Handles btnDBup.Click

        Dim tr As SqlTransaction
        Try
            cn.Open()
            tr = cn.BeginTransaction
            daWork.SelectCommand.Transaction = tr
            Dim cb As New SqlCommandBuilder(daWork)
            daWork.Update(ds, "勤務")
            tr.Commit()
            MessageBox.Show("データベースが変更されました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
End Class