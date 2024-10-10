Public Class chooseForm
    'メインフォーム
    '管理メニューか勤務表どちらを開くか選択するフォーム
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        '管理メニューボタンが押されたとき管理メニューを開く
        Admin.ShowDialog()
    End Sub

    Private Sub btnEmpList_Click(sender As Object, e As EventArgs) Handles btnEmpList.Click
        '勤務表メニューボタンが押されたとき勤務表メニューを開く
        EmpList.ShowDialog()
    End Sub
End Class
