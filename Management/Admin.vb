Imports System.Data.SqlClient
Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '1
        cn.ConnectionString = "Data Source=AISATT-NOTE03\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"
        Dim cmEmp As New SqlCommand
        Dim cmDep As New SqlCommand
        cmEmp.Connection = cn
        cmDep.Connection = cn
        cmEmp.CommandText = "SELECT * FROM 社員"
        cmDep.CommandText = "SELECT * FROM 部署"
        '2
        daEmp.SelectCommand = cmEmp
        daDep.SelectCommand = cmDep
        '3
        daEmp.Fill(ds, "社員")
        daDep.Fill(ds, "部署")
        '4
        dv.Table = ds.Tables("社員")
        dv.Sort = "社員番号 ASC"
        '5
        dgList.DataSource = dv
        cboFilter.DataSource = ds
        cboFilter.DisplayMember = "部署.部署名"
        cboFilter.ValueMember = "部署.部署番号"
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim intFind As Integer
        intFind = dv.Find(txtFind.Text)

        If intFind = -1 Then
            MessageBox.Show("該当する社員はいません")
        Else
            dgList.Rows(intFind).Selected = True
            'dgList.CurrentRowIndex = intFind
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If btnFilter.Text = "抽出" Then
            dv.RowFilter = "部署番号 = '" & cboFilter.SelectedValue & "'"
            btnFilter.Text = "解除"
            cboFilter.Enabled = False
        Else
            dv.RowFilter = ""
            btnFilter.Text = "抽出"
            cboFilter.Enabled = True
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmEA As New EmpAdd
        frmEA.ShowDialog()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If MessageBox.Show("削除してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Try
                Dim dr As DataRow
                dr = dv.Item(dgList.SelectedRows.Count).Row
                dr.Delete()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("取消してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            ds.RejectChanges()
            MessageBox.Show("変更はすべて取り消されました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDBup_Click(sender As Object, e As EventArgs) Handles btnDBup.Click
        If MessageBox.Show("更新してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Try
                Dim cb As New SqlCommandBuilder(daEmp)
                daEmp.Update(ds, "社員")
                MessageBox.Show("データベースが変更されました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class
