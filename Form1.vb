Imports System.IO

Public Class Form1
    Dim CountInteger As Integer
    Dim PrefixString As String = "\images\die"
    Dim SuffixString As String = ".png"
    Dim ObjRandomInteger As Random = New Random

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CountInteger < 15 Then
            Roll(Dice1PictureBox)
        End If
        If CountInteger < 30 Then
            Roll(Dice2PictureBox)
        End If
        CountInteger += 1
    End Sub

    Private Sub Roll(ByVal die As PictureBox)
        Dim FaceInteger As Integer = ObjRandomInteger.Next(1, 7)
        die.Image = Image.FromFile(Directory.GetCurrentDirectory & PrefixString & FaceInteger & SuffixString)
    End Sub

    Private Sub RollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollButton.Click
        CountInteger = 0
        Timer1.Enabled = True
    End Sub
End Class
