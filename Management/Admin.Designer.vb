<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDBup = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "社員番号"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(125, 32)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(173, 25)
        Me.txtFind.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(316, 26)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(106, 36)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "検索"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'cboFilter
        '
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Location = New System.Drawing.Point(468, 31)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(172, 26)
        Me.cboFilter.TabIndex = 3
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(680, 22)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(106, 35)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "抽出"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'dgList
        '
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Location = New System.Drawing.Point(29, 93)
        Me.dgList.Name = "dgList"
        Me.dgList.RowTemplate.Height = 27
        Me.dgList.Size = New System.Drawing.Size(1128, 241)
        Me.dgList.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(29, 362)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 36)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "登録"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(125, 362)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 36)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "変更"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(230, 362)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(83, 36)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "削除"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(339, 362)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 36)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDBup
        '
        Me.btnDBup.Location = New System.Drawing.Point(468, 362)
        Me.btnDBup.Name = "btnDBup"
        Me.btnDBup.Size = New System.Drawing.Size(213, 36)
        Me.btnDBup.TabIndex = 10
        Me.btnDBup.Text = "データベース更新"
        Me.btnDBup.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(702, 362)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 36)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "終了"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 410)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDBup)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgList)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cboFilter)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin"
        Me.Text = "管理メニュー"
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents dgList As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDBup As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
