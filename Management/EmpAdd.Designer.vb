<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpAdd
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEno = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtKana = New System.Windows.Forms.TextBox()
        Me.cboDep = New System.Windows.Forms.ComboBox()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "社員番号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "氏名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ふりがな"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "部署名"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "役職"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "入社年月日"
        '
        'txtEno
        '
        Me.txtEno.Location = New System.Drawing.Point(195, 35)
        Me.txtEno.Name = "txtEno"
        Me.txtEno.Size = New System.Drawing.Size(233, 25)
        Me.txtEno.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(195, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(233, 25)
        Me.txtName.TabIndex = 7
        '
        'txtKana
        '
        Me.txtKana.Location = New System.Drawing.Point(195, 142)
        Me.txtKana.Name = "txtKana"
        Me.txtKana.Size = New System.Drawing.Size(233, 25)
        Me.txtKana.TabIndex = 8
        '
        'cboDep
        '
        Me.cboDep.FormattingEnabled = True
        Me.cboDep.Location = New System.Drawing.Point(195, 198)
        Me.cboDep.Name = "cboDep"
        Me.cboDep.Size = New System.Drawing.Size(232, 26)
        Me.cboDep.TabIndex = 9
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(194, 260)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(233, 25)
        Me.txtPost.TabIndex = 10
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(194, 319)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(233, 25)
        Me.txtDate.TabIndex = 11
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(119, 375)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(119, 42)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "確定"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(308, 375)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 42)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'EmpAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 437)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtPost)
        Me.Controls.Add(Me.cboDep)
        Me.Controls.Add(Me.txtKana)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmpAdd"
        Me.Text = "登録"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEno As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtKana As System.Windows.Forms.TextBox
    Friend WithEvents cboDep As System.Windows.Forms.ComboBox
    Friend WithEvents txtPost As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
