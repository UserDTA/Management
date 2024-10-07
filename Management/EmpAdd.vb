Imports System.Data.SqlClient
Public Class EmpAdd
    Private Sub EmpAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDep.DataSource = ds
        cboDep.DisplayMember = "部署.部署名"
        cboDep.ValueMember = "部署.部署番号"
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If MessageBox.Show("確定してもよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Try
                Dim dr As DataRow
                dr = ds.Tables("社員").NewRow
                '5-2
                dr.BeginEdit()
                '5-3
                dr.Item("社員番号") = txtEno.Text
                dr.Item("氏名") = txtName.Text
                dr.Item("ふりがな") = txtKana.Text
                dr.Item("部署番号") = cboDep.SelectedValue
                dr.Item("役職") = txtPost.Text
                dr.Item("入社年月日") = txtDate.Text
                dr.Item("パスワード") = "pass"
                '5-4
                dr.EndEdit()
                '5-5
                ds.Tables("社員").Rows.Add(dr)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class