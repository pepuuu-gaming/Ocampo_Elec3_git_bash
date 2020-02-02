Imports System.IO
Public Class Form1
    Dim name_input As String
    Dim age_input As Byte
    Dim address_input As String
    Dim output As String


    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress
        e.Handled = True
        If e.KeyChar Like "[A-z]" Or e.KeyChar = "." Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Then
            e.Handled = False
        End If
    End Sub

    Private Sub AgeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgeTextBox.KeyPress
        e.Handled = True
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TXT_Button_Click(sender As Object, e As EventArgs) Handles TXT_Button.Click
        If AgeTextBox.Text.Length >= 255 Then
            MessageBox.Show("You have exceed the maximum value 255")
        End If

        name_input = NameTextBox.Text
        age_input = AgeTextBox.Text
        address_input = AddressTextBox.Text

        output = name_input + ".txt"
        Try
            Using file_write As StreamWriter = New StreamWriter(output)
                file_write.WriteLine(name_input)
                file_write.WriteLine(age_input)
                file_write.WriteLine(address_input)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub

    Private Sub XML_Button_Click(sender As Object, e As EventArgs) Handles XML_Button.Click
        If AgeTextBox.Text.Length >= 255 Then
            MessageBox.Show("You have exceed the maximum value 255")
        End If


        name_input = NameTextBox.Text
        age_input = AgeTextBox.Text
        address_input = AddressTextBox.Text

        output = name_input + ".xml"
        Try
            Using file_write As StreamWriter = New StreamWriter(output)
                file_write.WriteLine(name_input)
                file_write.WriteLine(age_input)
                file_write.WriteLine(address_input)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub

    Private Sub JSON_Button_Click(sender As Object, e As EventArgs) Handles JSON_Button.Click
        If AgeTextBox.Text.Length >= 255 Then
            MessageBox.Show("You have exceed the maximum value 255")
        End If


        name_input = NameTextBox.Text
        age_input = AgeTextBox.Text
        address_input = AddressTextBox.Text

        output = name_input + ".json"
        Try
            Using file_write As StreamWriter = New StreamWriter(output)
                file_write.WriteLine(name_input)
                file_write.WriteLine(age_input)
                file_write.WriteLine(address_input)
            End Using
        Catch ex As Exception
            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)
        End Try
    End Sub
End Class
