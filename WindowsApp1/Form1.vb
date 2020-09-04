﻿Public Class Form1
    Dim action As String
    Dim firstNum As Long
    Dim secondNum As Long

    Private Sub AddNumber(num As Integer)
        If action <> Nothing Then
            secondNum = Val(Str(secondNum) + Str(num))
            TextBox1.Text = Str(secondNum)
        Else
            firstNum = Val(Str(firstNum) + Str(num))
            TextBox1.Text = Str(firstNum)
        End If
    End Sub

    Private Sub Clear()
        firstNum = Nothing
        secondNum = Nothing
        action = Nothing
        AddNumber(0)
    End Sub

    Private Sub Backspace()
        If TextBox1.Text.Length > 2 Then
            TextBox1.Text = Mid(
                TextBox1.Text, 1, TextBox1.Text.Length - 1
            )
        Else
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub SetAction(act As String)
        If secondNum <> Nothing Then
            Evaluate()
        End If

        Label1.Text = act
        action = act
    End Sub

    Private Sub Evaluate()
        Dim result As Long

        If action = "add" Then
            result = firstNum + secondNum
        ElseIf action = "subtract" Then
            result = firstNum - secondNum
        ElseIf action = "multiply" Then
            result = firstNum * secondNum
        ElseIf action = "divide" Then
            result = firstNum / secondNum
        End If

        firstNum = result
        secondNum = Nothing
        TextBox1.Text = Str(result)
        action = Nothing
        Label1.Text = ""
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        AddNumber(7)
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        AddNumber(8)
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        AddNumber(9)
    End Sub
    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        AddNumber(4)
    End Sub
    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        AddNumber(5)
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        AddNumber(6)
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        AddNumber(1)
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        AddNumber(2)
    End Sub
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        AddNumber(3)
    End Sub
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        AddNumber(0)
    End Sub

    Private Sub BtnClr_Click(sender As Object, e As EventArgs) Handles BtnClr.Click
        Clear()
    End Sub

    Private Sub BtnBsp_Click(sender As Object, e As EventArgs)
        Backspace()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        SetAction("add")
    End Sub

    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        SetAction("subtract")
    End Sub

    Private Sub BtnMlt_Click(sender As Object, e As EventArgs) Handles BtnMlt.Click
        SetAction("multiply")
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        SetAction("divide")
    End Sub

    Private Sub BtnEql_Click(sender As Object, e As EventArgs) Handles BtnEql.Click
        Evaluate()
    End Sub

    Private Sub BtnSqrt_Click(sender As Object, e As EventArgs) Handles BtnSqrt.Click
        Dim num As String = TextBox1.Text
        Clear()
        TextBox1.Text = Str(Math.Sqrt(Val(num)))
    End Sub
End Class