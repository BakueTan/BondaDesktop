
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net

Imports System.Data
Imports Miscelleneous



Public Class frmReceiptUpload_1
    Private clas, program, session As String
    Private level As Integer

    Private Sub frmClassUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cboClsUpProg
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboClsUpSess
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboClsUpCls
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadStydents.Click
        Dim file_name2 As String = ""
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file_name2 = OpenFileDialog1.FileName
        Else
            Exit Sub
        End If

        Dim theLine As String = ""
        Dim arrSplt() As String
        Dim Mobile, adress, gender, name, surname, email, strdob, StudentID As String
        Dim dob As Date
        Dim oReader As New System.IO.StreamReader(file_name2)
        Dim count As Integer = 0
        Dim num As List(Of String)
        Dim notsendcount As Integer = 0

        clas = cboClsUpCls.Text
        program = cboClsUpProg.Text
        level = cboclsUpFrm.Text
        session = cboClsUpSess.Text


        num = New List(Of String)

        Dim cnn As New SqlConnection(ConnectionString)




        While oReader.Peek <> -1
            Try
                theLine = oReader.ReadLine()
                arrSplt = theLine.Split("|")
                StudentID = Trim(arrSplt(0)).ToUpper
                name = Trim(arrSplt(2)).ToUpper
                surname = Trim(arrSplt(1)).ToUpper
                gender = Trim(arrSplt(3))
                If gender.ToLower = "male" Then
                    gender = "M"
                ElseIf gender.ToLower = "female" Then
                    gender = "F"

                ElseIf gender.Length > 1 Then
                    Throw New Exception("Invalid Gender for " & name & " " & surname)
                End If

                adress = Trim(arrSplt(4)).ToUpper
                Mobile = Trim(arrSplt(5))
                email = Trim(arrSplt(6))
                strdob = Trim(arrSplt(7))

                If Mid(Trim(Mobile), 1, 1) = "0" Then

                    Mobile = "263" + Mid(Trim(Mobile), 2)
                Else

                    If Mid(Mobile, 1, 4).Contains("263") Then
                    Else
                        Mobile = "263" + Mobile
                    End If

                End If


                '     If strdob <> "" Then
                If Not Date.TryParse(strdob, dob) Then
                    '  Throw New Exception("Invalid DOB format for " & name & " " & surname)
                    dob = Now.Date

                End If
                '     End If



                Mobile = Mobile.Replace(" ", "").Replace("/0", "/263")
                If Trim(Mobile) = "" Then
                    'GoTo StartPosition
                Else
5:

                End If


                cnn.Open()
                Dim cmd As New SqlCommand("spUploadStudents", cnn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@program", program)
                cmd.Parameters.AddWithValue("@lvl", level)
                cmd.Parameters.AddWithValue("@sess", session)
                cmd.Parameters.AddWithValue("@class", clas)
                cmd.Parameters.AddWithValue("@studname", name)
                cmd.Parameters.AddWithValue("@studsurname", surname)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@contact", Mobile)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@address", adress)
                cmd.Parameters.AddWithValue("@dob", dob)
                cmd.Parameters.AddWithValue("@studentid", StudentID)
                cmd.ExecuteNonQuery()
                count = count + 1
            Catch ex As Exception
                MsgBox(ex.Message)
                num.Add(theLine)
                notsendcount = notsendcount + 1
                Continue While
            Finally
                cnn.close
            End Try





        End While


        MsgBox(count & " students  successfully uploaded")


        If notsendcount > 0 Then

            MsgBox(notsendcount & " students could not be uploaded,Choose location to save failed records")


            OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                file_name2 = SaveFileDialog1.FileName
                Using objwriter As New StreamWriter(file_name2)
                    For Each record In num
                        objwriter.WriteLine(record)
                    Next
                    MsgBox("Save Successful")
                End Using
            End If


        End If






    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class