Imports System.Data.SqlClient
Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '管理メニュー(Admin)フォームが読み込まれたときの処理
        '接続文字列
        cn.ConnectionString = "Data Source=AISATT-NOTE03\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"
        'Commandオブジェクトの生成
        Dim cmEmp As New SqlCommand
        Dim cmDep As New SqlCommand
        'Connectionオブジェクトとの関連付け
        cmEmp.Connection = cn
        cmDep.Connection = cn
        'CommandTextプロパティの設定
        '社員テーブル全てをcmEmpへ
        cmEmp.CommandText = "SELECT * FROM 社員"
        '部署テーブル全てをcmDepへ
        cmDep.CommandText = "SELECT * FROM 部署"
        'Commandオブジェクトとの関連付け
        daEmp.SelectCommand = cmEmp
        daDep.SelectCommand = cmDep
        'DataSetオブジェクトにデータを読み込む
        daEmp.Fill(ds, "社員")
        daDep.Fill(ds, "部署")
        'データソースの指定
        dv.Table = ds.Tables("社員")
        '社員番号昇順で並べ替え
        dv.Sort = "社員番号 ASC"
        'データグリッドにデータを連結
        dgList.DataSource = dv
        'コンボボックスにデータを連結
        cboFilter.DataSource = ds
        cboFilter.DisplayMember = "部署.部署名"
        cboFilter.ValueMember = "部署.部署番号"
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        '検索ボタンがクリックされた時の処理
        Dim intFind As Integer
        'テキストボックス(txtFind)に入力された社員番号で検索
        intFind = dv.Find(txtFind.Text)
        If intFind = -1 Then
            '該当する行が無かった場合はメッセージボックスを表示
            MessageBox.Show("該当する社員はいません")
        Else
            '該当する行があった場合は該当行を選択
            dgList.ClearSelection()
            dgList.Rows(intFind).Selected = True
            Me.dgList.CurrentCell = Me.dgList(0, intFind)
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        '抽出ボタンがクリックされた時の処理

        If btnFilter.Text = "抽出" Then
            'ボタンのテキストが抽出の時
            'コンボボックスで選んだ部署を抽出しデータグリッドに表示
            dv.RowFilter = "部署番号 = '" & cboFilter.SelectedValue & "'"
            'ボタンのテキストを解除に変更
            btnFilter.Text = "解除"
            'コンボボックスを使用不可に変更
            cboFilter.Enabled = False
        Else
            'ボタンのテキストが解除の時
            'フィルターを解除しデータグリッドに全てを表示
            dv.RowFilter = ""
            'ボタンのテキストを抽出に変更
            btnFilter.Text = "抽出"
            'コンボボックスを使用可能に変更
            cboFilter.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '登録ボタンがクリックされた時の処理
        '登録フォーム(EmpAdd)を開く
        Dim frmEA As New EmpAdd
        frmEA.ShowDialog()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        '削除ボタンがクリックされた時の処理
        '削除確認のメッセージを表示
        If MessageBox.Show("削除してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            'OKの場合
            Try
                '現在選択されている行のデータを削除
                Dim dr As DataRow
                dr = dv.Item(dgList.CurrentCell.RowIndex).Row
                dr.Delete()
            Catch ex As Exception
                'エラーの場合はエラーメッセージを表示
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'キャンセルボタンがクリックされたときの処理
        '取消確認のメッセージを表示
        If MessageBox.Show("取消してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            '行った変更を全て取り消し完了メッセージを表示
            ds.RejectChanges()
            MessageBox.Show("変更はすべて取り消されました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDBup_Click(sender As Object, e As EventArgs) Handles btnDBup.Click
        '更新ボタンがクリックされたときの処理
        '更新確認のメッセージを表示
        If MessageBox.Show("更新してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            'OKの場合
            Try
                'データセットに行った変更をデーターベースに反映し完了メッセージを表示
                Dim cb As New SqlCommandBuilder(daEmp)
                daEmp.Update(ds, "社員")
                MessageBox.Show("データベースが変更されました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'エラーの場合はエラーメッセージを表示
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '終了ボタンが押されたときアプリケーションを終了する
        Application.Exit()
    End Sub
End Class
