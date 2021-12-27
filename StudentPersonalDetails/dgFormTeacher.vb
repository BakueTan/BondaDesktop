Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System
Imports Miscelleneous

Public Class dgFormTeacher
    Public isloaded As Boolean = False
    Public studid, studname, studsurname, Exam As String
    Public FormTeachers As List(Of ComboItem)

    Public classstuds As DataSet

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Trim(studid) = "" Then
            MsgBox("Select Student")
            Exit Sub
        End If

        If cboFormTeacher.Text = "" Then
            MsgBox("Select FormTeacher")
            Exit Sub
        End If



        Dim sql As String = "spInsertFormTeacherExamComment"

        Try

            Dim cmd As New SqlCommand
            cmd.CommandText = sql
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@comment", Trim(txtComment.Text))
            cmd.Parameters.AddWithValue("@stud", studid)
            cmd.Parameters.AddWithValue("@ft", cboFormTeacher.SelectedValue)
            cmd.Parameters.AddWithValue("@exam", Exam)
            cmd.Parameters.AddWithValue("@user", goUser.userName)
            cmd.Connection = cnn
            cnn.Open()

            cmd.ExecuteNonQuery()

            MsgBox("Form Teacher's Comment Successfully added")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        '   Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgFormTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadMarkStudents()
        With cboFormTeacher
            .DataSource = FormTeachers
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        isloaded = True

    End Sub


    Private Sub LoadMarkStudents()
        dgStudents.DataSource = Nothing

        dgStudents.DataSource = classstuds.Tables(0)

        For Each row As DataGridViewRow In dgStudents.Rows
            If row.Cells(0).Value = studid Then
                row.Selected = True
                Exit Sub
            End If

        Next






    End Sub

    Private Sub dgStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgStudents.SelectionChanged
        Try
            studid = dgStudents.SelectedRows(0).Cells(0).Value
            studname = dgStudents.SelectedRows(0).Cells(1).Value
            populateComments()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub populateComments()

        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)
        Try

            cmd.CommandText = "spLoadFormTeacherComment"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@stud", studid)
            cmd.Parameters.AddWithValue("@exam", Exam)
            cmd.Connection = cnn
            cnn.Open()

            Dim program As SqlDataReader = cmd.ExecuteReader
            If program.HasRows Then
                While program.Read
                    ' studname = student.gdStudents.SelectedRows(0).Cells(1).Value
                    '  studsurname = student.gdStudents.SelectedRows(0).Cells(2).Value
                    '  exam = student.cboExam.Text
                    ' txtTeacher.Text = program(2)
                    Try
                        txtComment.Text = program("Comment")
                    Catch ex As Exception
                        txtComment.Text = ""
                    End Try

                    cboFormTeacher.SelectedValue = program("formteacher")

                    lbStud.Text = studname & "'s Comment"
                    Me.StudentAcademicReportTableAdapter.FillByStudent(Me.dsSchool.StudentAcademicReport, Exam, studid)
                    Me.ReportViewer1.RefreshReport()
                End While

                ' gdHeadStudents = Student.gdStudents

                '   LoadMarkStudents()
            Else
                txtComment.Text = ""
                lbStud.Text = ""
                Me.StudentAcademicReportTableAdapter.FillByStudent(Me.dsSchool.StudentAcademicReport, Exam, studid)
                Me.ReportViewer1.RefreshReport()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub

    Private Sub txtTeacher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim drr As SqlDataReader
        'lbTeacher.Visible = True
        'Dim sql As String = " select staffID,name,surname,stafftype from staffpersonaldetails where  name + ' ' + surname like '%" & txtTeacher.Text & "%'"
        'drr = ExecuteReader(sql)
        'While drr.Read
        '    lbTeacher.Items.Add(drr(0).ToString & " " & drr(1).ToString & " " & drr(2).ToString)
        'End While
    End Sub

    Private Sub lbTeacher_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    txtTeacher.Text = lbTeacher.SelectedItem.ToString
        '    lbTeacher.Items.Clear()
        '    Try
        '        Dim a, b As Integer
        '        Dim searchstring As String
        '        b = InStr(Trim(txtTeacher.Text), " ")
        '        searchstring = Mid(Trim(txtTeacher.Text), 1, b - 1)
        '        txtTeacher.Text = searchstring

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        '    lbTeacher.Visible = False
        'Catch ex As Exception

        'End Try
    End Sub


    Private Sub lbTeacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
