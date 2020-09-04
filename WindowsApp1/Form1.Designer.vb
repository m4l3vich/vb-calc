<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim BtnBsp As System.Windows.Forms.Button
        Me.BtnClr = New System.Windows.Forms.Button()
        Me.BtnSqrt = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSub = New System.Windows.Forms.Button()
        Me.BtnMlt = New System.Windows.Forms.Button()
        Me.BtnDiv = New System.Windows.Forms.Button()
        Me.BtnEql = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        BtnBsp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnBsp
        '
        BtnBsp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        BtnBsp.Location = New System.Drawing.Point(12, 69)
        BtnBsp.Name = "BtnBsp"
        BtnBsp.Size = New System.Drawing.Size(53, 28)
        BtnBsp.TabIndex = 0
        BtnBsp.Text = "←"
        BtnBsp.UseVisualStyleBackColor = True
        AddHandler BtnBsp.Click, AddressOf Me.BtnBsp_Click
        '
        'BtnClr
        '
        Me.BtnClr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnClr.Location = New System.Drawing.Point(71, 69)
        Me.BtnClr.Name = "BtnClr"
        Me.BtnClr.Size = New System.Drawing.Size(53, 28)
        Me.BtnClr.TabIndex = 1
        Me.BtnClr.Text = "С"
        Me.BtnClr.UseVisualStyleBackColor = True
        '
        'BtnSqrt
        '
        Me.BtnSqrt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnSqrt.Location = New System.Drawing.Point(130, 69)
        Me.BtnSqrt.Name = "BtnSqrt"
        Me.BtnSqrt.Size = New System.Drawing.Size(53, 28)
        Me.BtnSqrt.TabIndex = 3
        Me.BtnSqrt.Text = "√"
        Me.BtnSqrt.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn7.Location = New System.Drawing.Point(12, 103)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(53, 28)
        Me.Btn7.TabIndex = 4
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn8.Location = New System.Drawing.Point(71, 103)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(53, 28)
        Me.Btn8.TabIndex = 5
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn9.Location = New System.Drawing.Point(130, 103)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(53, 28)
        Me.Btn9.TabIndex = 6
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn4.Location = New System.Drawing.Point(12, 137)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(53, 28)
        Me.Btn4.TabIndex = 7
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn5.Location = New System.Drawing.Point(71, 137)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(53, 28)
        Me.Btn5.TabIndex = 8
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn6.Location = New System.Drawing.Point(130, 137)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(53, 28)
        Me.Btn6.TabIndex = 9
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn3.Location = New System.Drawing.Point(130, 171)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(53, 28)
        Me.Btn3.TabIndex = 12
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn2.Location = New System.Drawing.Point(71, 171)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(53, 28)
        Me.Btn2.TabIndex = 11
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn1.Location = New System.Drawing.Point(12, 171)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(53, 28)
        Me.Btn1.TabIndex = 10
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Btn0.Location = New System.Drawing.Point(12, 205)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(112, 28)
        Me.Btn0.TabIndex = 13
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(187, 69)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(53, 28)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSub
        '
        Me.BtnSub.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnSub.Location = New System.Drawing.Point(187, 103)
        Me.BtnSub.Name = "BtnSub"
        Me.BtnSub.Size = New System.Drawing.Size(53, 28)
        Me.BtnSub.TabIndex = 16
        Me.BtnSub.Text = "-"
        Me.BtnSub.UseVisualStyleBackColor = True
        '
        'BtnMlt
        '
        Me.BtnMlt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnMlt.Location = New System.Drawing.Point(187, 137)
        Me.BtnMlt.Name = "BtnMlt"
        Me.BtnMlt.Size = New System.Drawing.Size(53, 28)
        Me.BtnMlt.TabIndex = 17
        Me.BtnMlt.Text = "*"
        Me.BtnMlt.UseVisualStyleBackColor = True
        '
        'BtnDiv
        '
        Me.BtnDiv.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnDiv.Location = New System.Drawing.Point(189, 171)
        Me.BtnDiv.Name = "BtnDiv"
        Me.BtnDiv.Size = New System.Drawing.Size(53, 28)
        Me.BtnDiv.TabIndex = 18
        Me.BtnDiv.Text = "/"
        Me.BtnDiv.UseVisualStyleBackColor = True
        '
        'BtnEql
        '
        Me.BtnEql.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnEql.Location = New System.Drawing.Point(130, 205)
        Me.BtnEql.Name = "BtnEql"
        Me.BtnEql.Size = New System.Drawing.Size(112, 28)
        Me.BtnEql.TabIndex = 19
        Me.BtnEql.Text = "="
        Me.BtnEql.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 33)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 244)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnEql)
        Me.Controls.Add(Me.BtnDiv)
        Me.Controls.Add(Me.BtnMlt)
        Me.Controls.Add(Me.BtnSub)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.BtnSqrt)
        Me.Controls.Add(Me.BtnClr)
        Me.Controls.Add(BtnBsp)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(268, 282)
        Me.MinimumSize = New System.Drawing.Size(268, 282)
        Me.Name = "Form1"
        Me.Text = "Калькулятор"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClr As Button
    Friend WithEvents BtnSqrt As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSub As Button
    Friend WithEvents BtnMlt As Button
    Friend WithEvents BtnDiv As Button
    Friend WithEvents BtnEql As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
