<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpList
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
        Me.txtEno = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.dgWork = New System.Windows.Forms.DataGridView()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPre = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDBup = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.dgWork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "社員番号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "氏名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(564, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "役職："
        '
        'txtEno
        '
        Me.txtEno.Location = New System.Drawing.Point(53, 50)
        Me.txtEno.Name = "txtEno"
        Me.txtEno.Size = New System.Drawing.Size(214, 25)
        Me.txtEno.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(315, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(214, 25)
        Me.txtName.TabIndex = 4
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(567, 50)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(214, 25)
        Me.txtPost.TabIndex = 5
        '
        'dgWork
        '
        Me.dgWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgWork.Location = New System.Drawing.Point(53, 101)
        Me.dgWork.Name = "dgWork"
        Me.dgWork.RowTemplate.Height = 27
        Me.dgWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgWork.Size = New System.Drawing.Size(933, 261)
        Me.dgWork.TabIndex = 6
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(61, 399)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(88, 37)
        Me.btnFirst.TabIndex = 7
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.Location = New System.Drawing.Point(155, 399)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(88, 37)
        Me.btnPre.TabIndex = 8
        Me.btnPre.Text = "<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(360, 399)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(88, 37)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(454, 399)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(88, 37)
        Me.btnLast.TabIndex = 10
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDBup
        '
        Me.btnDBup.Location = New System.Drawing.Point(567, 399)
        Me.btnDBup.Name = "btnDBup"
        Me.btnDBup.Size = New System.Drawing.Size(214, 37)
        Me.btnDBup.TabIndex = 11
        Me.btnDBup.Text = "データベース更新"
        Me.btnDBup.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(808, 399)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 37)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "終了"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(245, 408)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(109, 18)
        Me.lblCount.TabIndex = 13
        Me.lblCount.Text = "ShowPosition"
        '
        'EmpList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 449)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDBup)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPre)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.dgWork)
        Me.Controls.Add(Me.txtPost)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmpList"
        Me.Text = "勤務表"
        CType(Me.dgWork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEno As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPost As System.Windows.Forms.TextBox
    Friend WithEvents dgWork As System.Windows.Forms.DataGridView
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDBup As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
End Class
