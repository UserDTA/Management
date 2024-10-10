Imports System.Data.SqlClient
Public Class EmpAdd
    Private Sub EmpAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '登録フォーム(EmpAdd)が読み込まれた時の処理
        'コンボボックスにデータを連結
        cboDep.DataSource = ds
        cboDep.DisplayMember = "部署.部署名"
        cboDep.ValueMember = "部署.部署番号"
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If MessageBox.Show("確定してもよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'OKボタンがクリックされた時の処理
            '新しい社員を登録する
            Try
                Dim dr As DataRow
                dr = ds.Tables("社員").NewRow
                '編集モード開始
                dr.BeginEdit()
                'テキストボックスに入力された値を取得
                dr.Item("社員番号") = txtEno.Text
                dr.Item("氏名") = txtName.Text
                dr.Item("ふりがな") = txtKana.Text
                dr.Item("部署番号") = cboDep.SelectedValue
                dr.Item("役職") = txtPost.Text
                dr.Item("入社年月日") = txtDate.Text
                '初期パスワードに「pass」を設定
                dr.Item("パスワード") = "pass"
                '編集モード終了
                dr.EndEdit()
                '社員をテーブルに追加
                ds.Tables("社員").Rows.Add(dr)
                Me.Close()
            Catch ex As Exception
                'エラーの場合はエラーメッセージを表示
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '閉じるボタンがクリックされた時フォームを閉じる()
        Me.Close()
    End Sub
End Class
