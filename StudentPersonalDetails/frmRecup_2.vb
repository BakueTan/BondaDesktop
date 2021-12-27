
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Net
Imports Miscelleneous
Imports System.Data
Public Class frmRecup_2

    Public transtype As String

    Private Sub frmRecup_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        With cboRecUpClas
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cborecupCart
            .DataSource = PaymentTypes("schoolfees")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cbpRecUpPeriod
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub

    ' Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim file_name2 As String = ""
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
        OpenFileDialog1.FilterIndex = 2

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file_name2 = OpenFileDialog1.FileName
        Else
            Exit Sub
        End If

        Dim theLine As String = ""
        Dim arrSplt() As String
        Dim StudentID, paytype, amount, clas, cartegory, period, currency, ref, StudentName, StudentSurname As String
        Dim rec_date As Date
        Dim oReader As New System.IO.StreamReader(file_name2)
        Dim count As Integer = 0

        Dim sendcount As Integer
        Dim num As New List(Of String)


        While oReader.Peek <> -1
            Try
                sqltext = "spUploadReceipts"
                cnn = New SqlConnection(ConnectionString)
                cnn.Open()


                theLine = oReader.ReadLine()
                arrSplt = theLine.Split("|")
                StudentID = Trim(arrSplt(0)).ToUpper
                StudentName = Trim(arrSplt(1)).ToUpper
                StudentSurname = Trim(arrSplt(2)).ToUpper
                ref = Trim(arrSplt(3)).ToUpper
                Date.TryParse(arrSplt(4), rec_date)
                paytype = Trim(arrSplt(5))
                amount = Trim(arrSplt(6))
                currency = Trim(arrSplt(7))
                period = cbpRecUpPeriod.SelectedValue
                clas = cboRecUpClas.Text
                cartegory = cborecupCart.SelectedValue


                cmd = New SqlCommand(sqltext, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@stud", StudentID)
                    .Parameters.AddWithValue("@studentname", StudentName)
                    .Parameters.AddWithValue("@studentsurname", StudentSurname)
                    .Parameters.AddWithValue("@recdate", rec_date)
                    .Parameters.AddWithValue("@user", goUser.userName)
                    .Parameters.AddWithValue("@transtype", transtype)
                    .Parameters.AddWithValue("@cashtype", paytype)
                    .Parameters.AddWithValue("@amount", amount)
                    .Parameters.AddWithValue("@currency", currency)
                    .Parameters.AddWithValue("@cartegory", cartegory)
                    .Parameters.AddWithValue("@period", period)
                    .Parameters.AddWithValue("@ref", ref)
                    .Parameters.AddWithValue("@line", 1)
                    .Parameters.AddWithValue("@comment", "Upload")
                    .Parameters.AddWithValue("@lineref", Guid.NewGuid)
                    .Parameters.AddWithValue("@class", clas)
                    .ExecuteNonQuery()
                    count += 1
                End With

            Catch ex As Exception
                '  MsgBox(ex.Message)
                sendcount = sendcount + 1
                num.Add(theLine & "|" & ex.Message)
            Finally
                cnn.Close()
            End Try





        End While

        If count > 0 Then
            MsgBox(count & " receipts successfuly imported")
        End If

        If sendcount > 0 Then

            MsgBox(sendcount & " Receipts could not be uploaded in the system choose location below to save Failed Receipts")


            OpenFileDialog1.Filter = "txt files (*.txt)|*.txt*"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True
            '   SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                file_name2 = SaveFileDialog1.FileName
                Using objwriter As New StreamWriter(file_name2)
                    For Each stud In num
                        objwriter.WriteLine(stud)

                    Next
                    MsgBox("Save Successful")
                End Using
            End If


        End If

    End Sub


End Class
'End Sub
