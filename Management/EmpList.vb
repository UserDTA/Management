Imports System.Data.SqlClient

Public Class EmpList
    Private Sub EmpList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '勤務(Admin)フォームが読み込まれたときの処理
        '接続文字列
        cn2.ConnectionString = "Data Source=AISATT-NOTE03\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"
        'Commandオブジェクトの生成
        Dim cmEmp As New SqlCommand
        Dim cmWork As New SqlCommand
        'Connectionオブジェクトとの関連付け
        cmEmp.Connection = cn2
        cmWork.Connection = cn2
        'CommandTextプロパティの設定
        cmEmp.CommandText = "SELECT * FROM 社員"
        cmWork.CommandText = "SELECT * FROM 勤務"
        'Commandオブジェクトとの関連付け
        daEmp2.SelectCommand = cmEmp
        daWork2.SelectCommand = cmWork
        'DataSetオブジェクトにデータを読み込む
        daEmp2.Fill(ds2, "社員")
        daWork2.Fill(ds2, "勤務")
        '主キーと外部キーの代入
        Dim pCol As DataColumn
        Dim cCol As DataColumn
        pCol = ds2.Tables("社員").Columns("社員番号")
        cCol = ds2.Tables("勤務").Columns("社員番号")
        'リレーションシップの設定
        Dim rel As New DataRelation("relEmpID", pCol, cCol)
        ds2.Relations.Add(rel)
        'データの連結
        dgWork.DataSource = ds2
        dgWork.DataMember = "社員.relEmpID"
        txtEno.DataBindings.Add("Text", ds2, "社員.社員番号")
        txtName.DataBindings.Add("Text", ds2, "社員.氏名")
        txtPost.DataBindings.Add("Text", ds2, "社員.役職")
        ShowPosition()

    End Sub

    Private Function allRows() As Integer
        '総行数を定義
        Return dgWork.Rows.Count - 1
    End Function

    Private Function curRow() As Integer
        '選択行数を定義
        Return dgWork.CurrentCell.RowIndex
    End Function

    Public Sub ShowPosition()
        'テキストボックスに「選択行数/総行数」を表示
        lblCount.Text = curRow() + 1 & "/" & allRows()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        '「<<」ボタンがクリックされた時の処理
        '選択を解除
        dgWork.ClearSelection()
        '1行目を選択
        dgWork.Rows(0).Selected = True
        dgWork.CurrentCell = dgWork(0, 0)
        ShowPosition()
    End Sub

    Private Sub btnPre_Click(sender As Object, e As EventArgs) Handles btnPre.Click
        '「<」ボタンがクリックされた時の処理

        '１行目より大きいの場合のみ実行
        If curRow() > 0 Then
            '選択行を１つ前に移動
            dgWork.ClearSelection()
            dgWork.Rows(curRow() - 1).Selected = True
            Me.dgWork.CurrentCell = Me.dgWork(0, curRow() - 1)
        End If
        ShowPosition()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        '「>」ボタンがクリックされた時の処理

        '最終行未満場合のみ実行
        If curRow() < allRows() - 1 Then
            '選択行を１つ後に移動
            dgWork.ClearSelection()
            dgWork.Rows(curRow() + 1).Selected = True
            dgWork.CurrentCell = dgWork(0, curRow() + 1)
        End If
        ShowPosition()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        '「>>」ボタンがクリックされた時の処理
        '最終行を選択
        dgWork.ClearSelection()
        dgWork.Rows(allRows() - 1).Selected = True
        Me.dgWork.CurrentCell = Me.dgWork(0, allRows() - 1)
        ShowPosition()
    End Sub

    Private Sub btnDBup_Click(sender As Object, e As EventArgs) Handles btnDBup.Click
        '更新ボタンがクリックされたときの処理
        'データセットに行った変更をデーターベースに反映し完了メッセージを表示
        Dim tr As SqlTransaction
        Try
            cn2.Open()
            tr = cn2.BeginTransaction
            daWork2.SelectCommand.Transaction = tr
            Dim cb As New SqlCommandBuilder(daWork2)
            daWork2.Update(ds2, "勤務")
            tr.Commit()
            MessageBox.Show("データベースが変更されました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            'エラーが発生した場合はロールバック
            tr.Rollback()
            MessageBox.Show(ex.Message)
        Finally
            cn2.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '終了ボタンが押されたときアプリケーションを終了する
        Application.Exit()
    End Sub
End Class