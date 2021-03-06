Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Imports Miscelleneous
Imports System.Windows.Forms

Public Class frmSchoolParameters
    Public frmMain As Form
    Private mblnaddingperiod, mblnedtngperiod As Boolean
    Private ExamGrades As New List(Of cExamGrading)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadYears()
        With ClasComboBox
            .DataSource = Years()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadExchangeRates()
        Dim sql As String
        Dim drr As SqlDataReader
        Dim items As New ListViewItem
        Dim subitem As ListViewItem.ListViewSubItem

        cnn = New SqlConnection(ConnectionString)

        Try

            cnn.Open()
            sqltext = "spLoadExchangeRates"
            cmd = New SqlCommand(sqltext, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            drr = cmd.ExecuteReader



            If drr.HasRows Then
                lvExchangeRate.Items.Clear()
                While drr.Read



                    items = lvExchangeRate.Items.Add("")
                    items.Text = drr("CurrencyFrom").ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr("CurrencyTo").ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr("Rate").ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr("DateFrom").ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr("DateTo").ToString
                End While
            Else
                lvExchangeRate.Items.Clear()
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub loadcurrencies()
        With cboBaseCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboCurrFromCurr
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboCurrToCurr
            .DataSource = Currencies(True)
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadClasses()
        With ExamClassRefComboBox
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With ClassComboBox
            .DataSource = Classes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadIntakes()
        With IntakeComboBox1
            .DataSource = Intakes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadSchoolSections()
        With SectionComboBox
            .DataSource = SchoolSections()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub

    Private Sub LoadProgramTypes()
        With TypeComboBox
            .DataSource = ProgramTypes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

    End Sub

    Private Sub LoadPrograms()
        With ProgramComboBox
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With ComboBox1
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cbGradingProg
            .DataSource = Programs()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadSubjectCartegories()
        With ComboBox3
            .DataSource = SubjectCartegories()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadSessions()
        With cboGradeSession
            .DataSource = SchoolSessions()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub frmSchoolParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSchoolParameters.Currencies' table. You can move, or remove it, as needed.


        Prepareform(Me, frmMain, False)
        Show()
        '     MdiParent = frmMain
        loadCombos()
        loadSets()

  '      AutoStudIDCheckBox.CheckState = CheckState.Unchecked
        'AutoReceitCheckBox.CheckState = CheckState.Unchecked


    End Sub
    Private Sub loadCombos()
        LoadSubjects()
        LoadYears()
        LoadIntakes()
        LoadSchoolSections()
        LoadProgramTypes()
        LoadSubjectCartegories()
        LoadPrograms()
        LoadClasses()
        loadSessions()
        loadcurrencies()
    End Sub

    Private Sub loadSets()
        Try
            Me.CurrenciesTableAdapter.Fill(Me.DsSchoolParameters.Currencies)
            Me.QualificationsTableAdapter.Fill(Me.DsSchoolParameters.Qualifications)
            Me.CashtypeTableAdapter.Fill(Me.DsSchoolParameters.Cashtype)
            'TODO: This line of code loads data into the 'DsSchoolParameters.PaymentType' table. You can move, or remove it, as needed.
            Me.PaymentTypeTableAdapter.Fill(Me.DsSchoolParameters.PaymentType)
            'TODO: This line of code loads data into the 'DsSchoolParameters.PaymentPeriods' table. You can move, or remove it, as needed.
            Me.PaymentPeriodsTableAdapter.Fill(Me.DsSchoolParameters.PaymentPeriods)
            'TODO: This line of code loads data into the 'DsSchoolParameters.MarkWeighting' table. You can move, or remove it, as needed.
            Me.MarkWeightingTableAdapter.Fill(Me.DsSchoolParameters.MarkWeighting)
            'TODO: This line of code loads data into the 'DsSchoolParameters.ExamSessions' table. You can move, or remove it, as needed.
            Me.ExamSessionsTableAdapter.Fill(Me.DsSchoolParameters.ExamSessions)
            'TODO: This line of code loads data into the 'DsSchoolParameters.SemesterDurations' table. You can move, or remove it, as needed.
            Me.SemesterDurationsTableAdapter.Fill(Me.DsSchoolParameters.SemesterDurations)
            'TODO: This line of code loads data into the 'DsSchoolParameters.smtp' table. You can move, or remove it, as needed.
            Me.SmtpTableAdapter.Fill(Me.DsSchoolParameters.smtp)
            'TODO: This line of code loads data into the 'DsSchoolParameters.SchoolSections' table. You can move, or remove it, as needed.
            Me.SchoolSectionsTableAdapter.Fill(Me.DsSchoolParameters.SchoolSections)
            'TODO: This line of code loads data into the 'DsSchoolParameters.Deps' table. You can move, or remove it, as needed.
            Me.DepsTableAdapter.Fill(Me.DsSchoolParameters.Deps)
            'TODO: This line of code loads data into the 'DsSchoolParameters.schoolsessions' table. You can move, or remove it, as needed.
            Me.SchoolsessionsTableAdapter.Fill(Me.DsSchoolParameters.schoolsessions)
            'TODO: This line of code loads data into the 'DsSchoolParameters.SMSAcc' table. You can move, or remove it, as needed.
            Me.SMSAccTableAdapter.Fill(Me.DsSchoolParameters.SMSAcc)
            'TODO: This line of code loads data into the 'DsSchoolParameters.Subjects' table. You can move, or remove it, as needed.
            Me.SubjectsTableAdapter.Fill(Me.DsSchoolParameters.Subjects)
            'TODO: This line of code loads data into the 'DsSchoolParameters.Classes' table. You can move, or remove it, as needed.
            Me.ClassesTableAdapter.Fill(Me.DsSchoolParameters.Classes)
            'TODO: This line of code loads data into the 'DsSchoolParameters.forms' table. You can move, or remove it, as needed.
            Me.FormsTableAdapter.Fill(Me.DsSchoolParameters.forms)
            'TODO: This line of code loads data into the 'DsSchoolParameters.schoolinfo' table. You can move, or remove it, as needed.
            Me.SchoolinfoTableAdapter.Fill(Me.DsSchoolParameters.schoolinfo)
            LoadExchangeRates()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click
        'OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LogoPictureBox.ImageLocation = OpenFileDialog1.FileName
        End If

    End Sub







    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            Me.Validate()
            Me.SMSAccBindingSource.EndEdit()
            Me.SMSAccTableAdapter.Update(Me.DsSchoolParameters.SMSAcc)
            MsgBox("Save Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ProgramCodeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadSubjects()


        With chkPrograms
            .DataSource = Subjects()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With


    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        loadCombos()
        loadSets()

        BindingNavigator6.Items("AddNew6").Visible = True
        BindingNavigator3.Items("AddNew3").Visible = True
        BindingNavigator1.Items("Add").Visible = True
        BindingNavigator2.Items("AddNew").Visible = True
        '       BindingNavigator7.Items("AddNew7").Visible = True
        BindingNavigator8.Items("AddNew8").Visible = True
        BindingNavigator9.Items("AddNew9").Visible = True
        BindingNavigator10.Items("AddNew10").Visible = True
    End Sub

    Private Sub cbosubSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim a As Integer = SubjectsBindingSource.Find("SubjectID", cbosubSearch.SelectedValue.ToString)
        '    SubjectsBindingSource.Position = a
        'Catch ex As Exception

        'End Try

    End Sub



    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        cnn = New SqlConnection(ConnectionString)
        Try


            cnn.Open()
            sqltext = "spInsertProgram"

            cmd = New SqlCommand(sqltext, cnn)

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@program", FormsTextBox.Text)
                .Parameters.AddWithValue("@description", DescriptionTextBox.Text)
                .Parameters.AddWithValue("@year", YearTextBox.Text)
                .Parameters.AddWithValue("@sems", SemestersTextBox.Text)
                .Parameters.AddWithValue("@sufix", ProgSufixTextBox.Text)
                .Parameters.AddWithValue("@type", TypeComboBox.Text)
                .Parameters.AddWithValue("@section", SectionComboBox.Text)
                .Parameters.AddWithValue("@progref", IIf(txtProgRef.Text = "", Guid.NewGuid, txtProgRef.Text))
                .ExecuteNonQuery()
                MsgBox("Program Saved")

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub









    Private Sub AutoStudIDCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoStudIDCheckBox.CheckedChanged
        StudIdLengthTextBox.Enabled = AutoStudIDCheckBox.Checked
        StudIdPrefixTextBox.Enabled = AutoStudIDCheckBox.Checked
        cboIdYearFormat.Enabled = AutoStudIDCheckBox.Checked
    End Sub



    Private Sub ToolStripButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton32.Click
        Try
            Me.Validate()
            Me.SchoolsessionsBindingSource.EndEdit()
            Me.SchoolsessionsTableAdapter.Update(Me.DsSchoolParameters.schoolsessions)
            MsgBox("Save Successful")
            BindingNavigator8.Items("AddNew8").Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SectionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionComboBox.SelectedIndexChanged

    End Sub



    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        studprnt = False
        receiptprnt = False
        gstrstud2 = FormsTextBox.Text
        enrolform = True

        '    frmReportPreview.Show()
    End Sub






    Private Sub AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingNavigator2.Items("AddNew").Visible = False
    End Sub

    Private Sub AddNew3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew3.Click
        BindingNavigator3.Items("AddNew3").Visible = False
    End Sub

    Private Sub AddNew6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddNew7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingNavigator7.Items("AddNew7").Visible = False
    End Sub

    Private Sub AddNew8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew8.Click
        BindingNavigator8.Items("AddNew8").Visible = False
    End Sub


    Private Sub AddNew9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingNavigator9.Items("AddNew9").Visible = False
    End Sub


    Private Sub AddNew10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingNavigator10.Items("AddNew10").Visible = False
    End Sub











    Private Sub ToolStripButton67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton67.Click
        Try
            Me.Validate()
            '   Me.SchoolSectionsTableAdapter.en
            Me.SchoolSectionsTableAdapter.Update(Me.DsSchoolParameters.SchoolSections)
            MsgBox("Save Successful")
            ' BindingNavigator8.Items("AddNew8").Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Function searchGrade(ByVal grade As String) As Boolean

        For i = 0 To lvExmGrd.Items.Count - 1
            If Trim(lvExmGrd.Items(i).Text.ToUpper) = grade Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function



    Private Sub txtGradingUpperLimit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)


        'If FormatNumber((txtGradingLowerLimit.Text)) >= FormatNumber((txtGradingUpperLimit.Text)) Then
        '    'MsgBox("Limit not valid")
        '    btnAddGrade.Enabled = False
        '    '  txtGradingUpperLimit.Focus()
        'Else
        '    btnAddGrade.Enabled = True

        'End If
    End Sub







    Private Sub lvExmGrd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvExmGrd.DoubleClick
        Dim grade, lower, upper, comment, credits, graderef As String
        Dim item As ListViewItem

        Dim indx As Integer = lvExmGrd.SelectedItems(0).Index
        item = lvExmGrd.SelectedItems(0)
        grade = lvExmGrd.SelectedItems(0).Text
        lower = lvExmGrd.SelectedItems(0).SubItems(1).Text
        upper = lvExmGrd.SelectedItems(0).SubItems(2).Text
        graderef = lvExmGrd.SelectedItems(0).SubItems(4).Text
        credits = lvExmGrd.SelectedItems(0).SubItems(3).Text
        txtGradingLowerLimit.Text = lower
        txtGradingUpperLimit.Text = upper
        TxtGradingGrade.Text = grade
        txtgradeRef.Text = graderef
        txtGradingCredits.Text = credits
        lvExmGrd.Items.Remove(item)

        If ExamGrades.Any Then
            Dim grditem As New cExamGrading
            grditem = ExamGrades.Where(Function(x) x.Grade = grade).Single
            ExamGrades.Remove(grditem)
        End If



    End Sub




    Private Sub ToolStripButton60_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton60.Click
        Try
            Me.Validate()
            Me.DepsBindingSource.EndEdit()
            Me.DepsTableAdapter.Update(Me.DsSchoolParameters.Deps)
            MsgBox("Save Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        cnn = New SqlConnection(ConnectionString)
        sqltext = "spInsertSubjects"
        Try
            cnn.Open()
            cmd = New SqlCommand(sqltext, cnn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@subjectid", SubjectIDTextBox.Text)
                .Parameters.AddWithValue("@subject", SubjectTextBox.Text)
                .Parameters.AddWithValue("@program", "")
                .Parameters.AddWithValue("@credits", CreditsTextBox.Text)
                .Parameters.AddWithValue("@type", TypeComboBox1.Text)
                .Parameters.AddWithValue("@fees", FeesTextBox1.Text)
                .Parameters.AddWithValue("@dept", ComboBox3.Text)
                .Parameters.AddWithValue("@subref", IIf(txtSubref.Text = "", Guid.NewGuid, txtSubref.Text))
                .ExecuteNonQuery()
                MsgBox("Subject Saved")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try




    End Sub







    Private Sub DataGridView3_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub



    Private Sub SchoolsessionsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SchoolsessionsDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub







    Private Sub ToolStripButton89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton89.Click
        Try
            Me.Validate()
            Me.SmtpBindingSource.EndEdit()
            Me.SmtpTableAdapter.Update(Me.DsSchoolParameters.smtp)
            MsgBox("Save Successful")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton83.Click
        If ToolStripTextBox13.Text > 1 Then
            MsgBox("Only single smtp config details are required")


        Else
            '  GroupBox.Enabled = True

        End If
    End Sub



    Private Sub MarkWeightingDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lnkProgType_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'Dim progtype As New frmProgType()
        'progtype.ShowDialog()

        ' frmProgType.Show()
    End Sub





    Private Sub txtGradingUpperLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton96_Click(sender As Object, e As EventArgs) Handles ToolStripButton96.Click
        Dim cnn As New SqlConnection(ConnectionString)
        Dim sql As String = "spInsertClasses"
        Dim cmd As New SqlCommand(sql, cnn)

        Try


            cnn.Open()

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@description", DescriptionTextBox1.Text)
                .Parameters.AddWithValue("@class", ClasComboBox.Text)
                .Parameters.AddWithValue("@sem", SemComboBox.Text)
                .Parameters.AddWithValue("@intake", IntakeComboBox1.Text)
                .Parameters.AddWithValue("@ref", IIf(RefTextBox.Text = "", Guid.NewGuid, RefTextBox.Text))
                .ExecuteNonQuery()
                MsgBox("Class updated")
                ClassesTableAdapter.Fill(DsSchoolParameters.Classes)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub SchoolInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SchoolInfoBindingNavigatorSaveItem.Click
        Dim cnn As New SqlConnection(ConnectionString)
        Dim sql As String = "spInsertSchoolInfo"
        Dim imagebytes As Byte()

        Try
            cnn.Open()

            Dim cmd As New SqlCommand(sql, cnn)

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@name", NameTextBox.Text)
                .Parameters.AddWithValue("@web", WebTextBox.Text)
                .Parameters.AddWithValue("@address", AddressTextBox.Text)

                param = New SqlParameter("@logo", SqlDbType.Image)
                Try

                    imagebytes = getimage(LogoPictureBox)
                    If Not IsNothing(imagebytes) Then
                        param.Value = imagebytes
                        .Parameters.Add(param)
                    Else
                        Dim par As New SqlParameter("@logo", SqlDbType.Image)
                        With par
                            .Value = DBNull.Value

                        End With
                        .Parameters.Add(par)
                    End If

                Catch ex As Exception
                    param.Value = DBNull.Value
                End Try



                .Parameters.AddWithValue("@phone", PhoneTextBox.Text)
                .Parameters.AddWithValue("@autoid", AutoStudIDCheckBox.Checked)
                .Parameters.AddWithValue("@idprefix", StudIdPrefixTextBox.Text)
                .Parameters.AddWithValue("@yearformat", cboIdYearFormat.Text)
                .Parameters.AddWithValue("@idlength", StudIdLengthTextBox.Text)
                .Parameters.AddWithValue("@ref", IIf(txtschoolref.Text = "", Guid.NewGuid, txtschoolref.Text))
                .Parameters.AddWithValue("@curr", cboBaseCurrency.Text)
                .ExecuteNonQuery()
                MsgBox("School Info Saved")
                Me.SchoolinfoTableAdapter.Fill(DsSchoolParameters.schoolinfo)


            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try




    End Sub

    Private Sub ToolStripButton1_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If txtschoolref.Text <> "" Then

            If MsgBox("Delete School Info?", vbYesNo) = vbYes Then
                sqltext = "Delete Schoolinfo"
                cnn = New SqlConnection(ConnectionString)
                Try
                    cnn.Open()

                    cmd = New SqlCommand(sqltext, cnn)
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                    MsgBox("Record Deleted")
                    Me.SchoolinfoTableAdapter.Fill(DsSchoolParameters.schoolinfo)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try


            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click


        Dim cnn As New SqlConnection(ConnectionString)
        Dim sql As String = "spDeleteProgram"
        If txtProgRef.Text <> "" Then
            If MsgBox("Delete Program?", vbYesNo) = vbYes Then

                Try
                    cnn.Open()
                    Dim cmd As New SqlCommand(sql, cnn)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@ref", txtProgRef.Text)
                        .ExecuteNonQuery()
                        MsgBox("Program Deleted")
                        FormsTableAdapter.Fill(DsSchoolParameters.forms)
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try

            End If
        End If
    End Sub

    Private Sub ToolStripButton75_Click(sender As Object, e As EventArgs) Handles ToolStripButton75.Click
        If txtSubref.Text <> "" Then

            Dim cnn As New SqlConnection(ConnectionString)
            Dim sql As String = "spDeleteSubject"
            If MsgBox("Delete Subject?", vbYesNo) = vbYes Then

                Try
                    cnn.Open()
                    Dim cmd As New SqlCommand(sql, cnn)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@ref", txtSubref.Text)
                        .ExecuteNonQuery()
                        MsgBox("Subject Deleted")
                        SubjectsTableAdapter.Fill(DsSchoolParameters.Subjects)
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try

            End If
        End If
    End Sub

    Private Sub SemSave_Click(sender As Object, e As EventArgs) Handles SemSave.Click
        sqltext = "spInsertTermDurations"
        cnn = New SqlConnection(ConnectionString)

        Dim startdate As Date
        Dim enddate As Date

        Date.TryParse(mskSemStartDate.Text, startdate)
        Date.TryParse(msksemEndDate.Text, enddate)

        Try
            cnn.Open()
            cmd = New SqlCommand(sqltext, cnn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@program", ProgramComboBox.Text)
                .Parameters.AddWithValue("@class", ClassComboBox.Text)
                .Parameters.AddWithValue("@startdate", startdate)
                .Parameters.AddWithValue("@enddate", enddate)
                .Parameters.AddWithValue("@ref", IIf(txtSemDurRef.Text = "", Guid.NewGuid, txtSemDurRef.Text))
                .ExecuteNonQuery()
                MsgBox("Term Duration Saved")

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        If txtSemDurRef.Text <> "" Then
            cnn = New SqlConnection(ConnectionString)
            Try

                cnn.Open()

                If MsgBox("Delete Current Record ?", vbYesNo) = vbYes Then
                    sqltext = "spDeleteSemDurations"
                    cmd = New SqlCommand(sqltext, cnn)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@ref", txtSemDurRef.Text)
                        .ExecuteNonQuery()
                        MsgBox("Record Deleted")
                        SemesterDurationsTableAdapter.Fill(DsSchoolParameters.SemesterDurations)
                    End With
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cnn.Close()

            End Try
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        cnn = New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction

        Try
            cnn.Open()
            trans = cnn.BeginTransaction
            sqltext = "Delete SubjectPrograms  where program = '" & ComboBox1.Text & "'"

            cmd = New SqlCommand(sqltext, cnn, trans)
            With cmd
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With

            For i = 0 To chkPrograms.Items.Count - 1
                If chkPrograms.GetItemChecked(i) = True Then
                    sqltext = "spUpdateSubjectPrograms"
                    cmd = New SqlCommand(sqltext, cnn, trans)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@prog", ComboBox1.Text)
                        .Parameters.AddWithValue("@sub", CleanComboVal(chkPrograms.Items(i).ToString))
                        .ExecuteNonQuery()
                    End With
                End If
            Next

            trans.Commit()
            MsgBox("Program Subjects successfully updated", MsgBoxStyle.Information, "TAMS")

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        Finally
            cnn.Close()

        End Try



    End Sub

    Private Sub ToolStripButton25_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton25.Click
        cnn = New SqlConnection(ConnectionString)
        Dim imagebytes As Byte()

        Try
            cnn.Open()
            sqltext = "spInsertExamSession"
            cmd = New SqlCommand(sqltext, cnn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@sess", SessionTextBox.Text)
                .Parameters.AddWithValue("@sitting", SittingTextBox.Text)
                .Parameters.AddWithValue("@ref", IIf(RefTextBox1.Text = "", Guid.NewGuid, RefTextBox1.Text))
                .Parameters.AddWithValue("@classdesc", ExamClassRefComboBox.Text)
                .Parameters.AddWithValue("@publish", PublishCheckBox.Checked)
                .Parameters.AddWithValue("@autocomment", AutoCommentCheckBox.Checked)
                .Parameters.AddWithValue("@markformat", cboMarkFormat.Text)

                param = New SqlParameter("@examstamp", SqlDbType.Image)
                Try

                    imagebytes = getimage(pbSchoolStamp)
                    If Not IsNothing(imagebytes) Then
                        param.Value = imagebytes
                        .Parameters.Add(param)
                    Else
                        Dim par As New SqlParameter("@examstamp", SqlDbType.Image)
                        With par
                            .Value = DBNull.Value

                        End With
                        .Parameters.Add(par)
                    End If

                Catch ex As Exception
                    param.Value = DBNull.Value
                End Try

                param = New SqlParameter("@examstamp2", SqlDbType.Image)
                Try

                    imagebytes = getimage(pbSchoolStamp2)
                    If Not IsNothing(imagebytes) Then
                        param.Value = imagebytes
                        .Parameters.Add(param)
                    Else
                        Dim par As New SqlParameter("@examstamp2", SqlDbType.Image)
                        With par
                            .Value = DBNull.Value

                        End With
                        .Parameters.Add(par)
                    End If

                Catch ex As Exception
                    param.Value = DBNull.Value
                End Try

                .ExecuteNonQuery()
                MsgBox("Exam Session Saved")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            Dim drr As SqlDataReader
            For b = 0 To chkPrograms.Items.Count - 1
                chkPrograms.SetItemChecked(b, False)
            Next




            For b = 0 To chkPrograms.Items.Count - 1

                cnn = New SqlConnection(ConnectionString)
                sqltext = "spGetProgramSubjects"
                cnn.Open()
                Dim cmd = New SqlCommand(sqltext, cnn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@prog", ComboBox1.Text)
                    drr = .ExecuteReader()
                End With
                Try


                    While drr.Read

                        Dim txt As String = chkPrograms.GetItemText(chkPrograms.Items(b))

                        If drr(1).ToString = CleanComboVal(txt) Then
                            chkPrograms.SetItemChecked(b, True)
                        End If
                    End While
                Catch ex As Exception
                Finally
                    cnn.Close()
                    'MsgBox(ex.Message)
                End Try


            Next
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub ToolStripButton97_Click(sender As Object, e As EventArgs) Handles ToolStripButton97.Click
        If RefTextBox1.Text <> "" Then

            If MsgBox("Delete Exam Session?", vbYesNo) = vbYes Then
                Try
                    cnn.Open()
                    sqltext = "spDeleteExamSession"
                    Dim cmd As New SqlCommand(sqltext, cnn)
                    With cmd
                        .Parameters.AddWithValue("@ref", RefTextBox1.Text)
                        .ExecuteNonQuery()
                        MsgBox("Exam Session Deleted")
                        ExamSessionsTableAdapter.Fill(DsSchoolParameters.ExamSessions)
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try

            End If
        End If
    End Sub




    Private Sub cboGradeSession_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboGradeSession.SelectedIndexChanged, cbGradingProg.SelectedIndexChanged
        Dim sql As String
        Dim drr As SqlDataReader
        Dim items As New ListViewItem
        Dim subitem As ListViewItem.ListViewSubItem
        If chkAllSessions.Checked Then
            sql = " select grade,upper,lower,credits,refid from examgrading where program = '" & cbGradingProg.SelectedValue & "' and session = 'All'"
        Else
            sql = " select grade,upper,lower,credits,refid from examgrading where program = '" & cbGradingProg.SelectedValue & "' and session = '" & cboGradeSession.Text & "'"
        End If


        drr = ExecuteReader(sql, , True)

        If drr.HasRows Then
            lvExmGrd.Items.Clear()
            ExamGrades = New List(Of cExamGrading)
            While drr.Read
                Dim exmgrade As New cExamGrading
                With exmgrade


                    .Program = cbGradingProg.Text
                    items = lvExmGrd.Items.Add("")
                    items.Text = drr(0).ToString
                    .Grade = drr(0).ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr(2).ToString
                    .LowerLimit = drr(2).ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr(1).ToString
                    .UpperLimit = drr(1).ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr(3).ToString
                    .Credits = drr(3).ToString

                    subitem = items.SubItems.Add("")
                    subitem.Text = drr(4).ToString
                    .RefId = drr(4).ToString
                    .AutoComents = getGradeComments(.RefId)
                End With
                ExamGrades.Add(exmgrade)
            End While
        Else
            lvExmGrd.Items.Clear()
        End If
    End Sub
    Private Function getGradeComments(refid As String) As List(Of cAutoComment)
        cnn = New SqlConnection(ConnectionString)
        Dim comments As SqlDataReader
        Dim GradeComments As New List(Of cAutoComment)
        Try
            cnn.Open()


            sqltext = "spGetGradeComments"
            cmd = New SqlCommand(sqltext, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ref", refid)
            comments = cmd.ExecuteReader

            While comments.Read
                Dim gradecoment As New cAutoComment
                With gradecoment
                    .Comment = comments(0)
                    .GradeRef = refid
                    .Refid = Guid.NewGuid.ToString
                End With
                GradeComments.Add(gradecoment)
            End While

        Catch ex As Exception
        Finally
            cnn.Close()
        End Try


        Return GradeComments

    End Function

    Private Sub chkAllSessions_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkAllSessions.CheckedChanged
        cboGradeSession.Enabled = Not chkAllSessions.Checked
    End Sub

    Private Sub txtGradingLowerLimit_Validated(sender As Object, e As EventArgs) Handles txtGradingLowerLimit.Validated, txtGradingUpperLimit.Validated
        Dim lower, upper As Integer


        Try
            lower = txtGradingLowerLimit.Text
            upper = txtGradingUpperLimit.Text
        Catch ex As Exception
            lower = 1
            upper = 0
        End Try



        If lower >= upper Then
            ' MsgBox("Limit not valid")
            btnAddGrade.Enabled = False
            ' txtGradingUpperLimit.Focus()
        Else
            btnAddGrade.Enabled = True

        End If




    End Sub

    Private Sub btnAddGrade_Click(sender As Object, e As EventArgs) Handles btnAddGrade.Click
        Dim items As ListViewItem
        Dim subitems As ListViewItem.ListViewSubItem
        Dim gradecomments As New List(Of cAutoComment)

        Dim Exmgrading As New cExamGrading


        If IsNothing(ExamGrades) Then
            ExamGrades = New List(Of cExamGrading)
        End If

        If chkMultipleAutoComments.Checked Then
            Dim dggradecomm As New dgautoComments()
            With dggradecomm
                .GradeRef = txtgradeRef.Text
                .GradeString = cbGradingProg.Text & " - " & TxtGradingGrade.Text & " Grade"
                .Grade = TxtGradingGrade.Text
                .exmgrades = ExamGrades
                .GetComments()
                .ShowDialog()


            End With
            If dggradecomm.DialogResult = DialogResult.OK Then
                For i = 0 To dggradecomm.dgGeadeComments.Rows.Count - 2
                    Dim autocomment As New cAutoComment
                    autocomment.Comment = dggradecomm.dgGeadeComments.Rows(i).Cells(0).Value
                    autocomment.Refid = ""
                    autocomment.GradeRef = ""
                    gradecomments.Add(autocomment)

                Next
            End If
        End If




        If searchGrade(Trim(TxtGradingGrade.Text.ToUpper)) Then
            With Exmgrading
                .Program = cbGradingProg.Text
                .Session = cboGradeSession.Text
                .Grade = TxtGradingGrade.Text
                .Credits = Val(txtGradingCredits.Text)
                .LowerLimit = Val(txtGradingLowerLimit.Text)
                .UpperLimit = Val(txtGradingUpperLimit.Text)
                .MultipleAutoComments = chkMultipleAutoComments.Checked
                .AutoComents = gradecomments
                .RefId = txtgradeRef.Text





                items = lvExmGrd.Items.Add("")
                items.Text = .Grade
                TxtGradingGrade.Text = ""

                subitems = items.SubItems.Add("")
                subitems.Text = .LowerLimit
                txtGradingLowerLimit.Text = ""

                subitems = items.SubItems.Add("")
                subitems.Text = .UpperLimit
                txtGradingUpperLimit.Text = ""


                '     subitems = items.SubItems.Add("")
                'subitems.Text = txtGradeComment.Text
                'txtGradeComment.Text = ""


                subitems = items.SubItems.Add("")
                subitems.Text = .Credits
                txtGradingCredits.Text = ""


                subitems = items.SubItems.Add("")
                subitems.Text = .RefId
                txtgradeRef.Text = ""
            End With

            ExamGrades.Add(Exmgrading)

        Else
            MsgBox("Grade Already Present")
        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql, lower, upper, grade, program, comment, credits, session, Ref As String
        Dim trans As SqlTransaction
        cnn = New SqlConnection(ConnectionString)


        Try
            cnn.Open()
            trans = cnn.BeginTransaction

            sqltext = "spDeleteExamGrading"


            cmd = New SqlCommand(sqltext, cnn, trans)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@session", IIf(chkAllSessions.Checked, "All", cboGradeSession.Text))
            cmd.Parameters.AddWithValue("@prog", cbGradingProg.Text)
            With cmd
                .ExecuteNonQuery()
            End With

            Dim a As Integer = lvExmGrd.Items.Count


            For Each grd As cExamGrading In ExamGrades

                program = grd.Program
                grade = grd.Grade
                lower = grd.LowerLimit
                upper = grd.UpperLimit
                comment = ""
                credits = grd.Credits

                Ref = Guid.NewGuid.ToString


                sqltext = "spInsertExamGrading"
                cmd = New SqlCommand(sqltext, cnn, trans)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@prog", program)
                    .Parameters.AddWithValue("@lower", lower)
                    .Parameters.AddWithValue("@upper", upper)
                    .Parameters.AddWithValue("@comment", comment)
                    .Parameters.AddWithValue("@credits", credits)
                    .Parameters.AddWithValue("@grade", grade)
                    .Parameters.AddWithValue("@session", IIf(chkAllSessions.Checked, "All", cboGradeSession.Text))
                    .Parameters.AddWithValue("@ref", Ref)
                    .ExecuteNonQuery()

                End With
                For Each cmnt As cAutoComment In grd.AutoComents
                    sqltext = "spInsertGradeComments"
                    cmd = New SqlCommand(sqltext, cnn, trans)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@graderef", Ref)
                        .Parameters.AddWithValue("@comment", cmnt.Comment)
                        .ExecuteNonQuery()

                    End With

                Next







            Next

            trans.Commit()
            MsgBox("Exam Grading Saved")

        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        Finally
            cnn.Close()

        End Try


    End Sub

    Private Sub ToolStripButton82_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton82.Click
        Try
            Me.Validate()
            Me.MarkWeightingBindingSource.EndEdit()
            Me.MarkWeightingTableAdapter.Update(Me.DsSchoolParameters.MarkWeighting)
            MsgBox("Save Successful")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton18_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton18.Click
        Dim sql, period, descr As String
        Dim curr As Boolean
        Dim truecnt As Integer = 0
        sql = " "

        Dim rows As Integer

        rows = PaymentPeriodsDataGridView.Rows.Count

        For a1 = 0 To rows - 2
            period = PaymentPeriodsDataGridView.Rows(a1).Cells(0).Value
            descr = PaymentPeriodsDataGridView.Rows(a1).Cells(1).Value
            Try
                curr = PaymentPeriodsDataGridView.Rows(a1).Cells(2).Value
            Catch ex As Exception
                curr = False
            End Try


            If curr = True Then
                truecnt = truecnt + 1
            End If

            If truecnt > 1 Then
                MsgBox("Only one current period is allowed ")
                truecnt = 0
                Exit Sub
            End If



        Next

        If truecnt = 0 Then
            MsgBox("Please select current period")
            Exit Sub
        End If


        If mblnaddingperiod = True Then




            For a1 = 0 To rows - 2
                period = PaymentPeriodsDataGridView.Rows(a1).Cells(0).Value
                descr = PaymentPeriodsDataGridView.Rows(a1).Cells(1).Value
                Try
                    curr = PaymentPeriodsDataGridView.Rows(a1).Cells(2).Value
                Catch ex As Exception

                End Try


                sql = "insert into paymentperiods (period,description,[current]) values ('" & period & "','" & descr & "','" & curr & "')"
                ExecuteNonQuery(sql)
                If era = False And a1 = rows - 2 Then
                    MsgBox("Save successful")
                    mblnaddingperiod = False
                    BindingNavigator6.Items("AddNew6").Visible = True
                End If




            Next
        Else

            Try
                Me.Validate()
                Me.PaymentPeriodsBindingSource.EndEdit()
                Me.PaymentPeriodsTableAdapter.Update(Me.DsSchoolParameters.PaymentPeriods)
                MsgBox("Save Successful")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AddNew6_Click_1(sender As Object, e As EventArgs) Handles AddNew6.Click
        mblnaddingperiod = True

        '  mblnedtngperiod = False
        BindingNavigator6.Items("AddNew6").Visible = False
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click

    End Sub

    Private Sub ToolStripButton39_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton39.Click
        Try
            Me.Validate()
            Me.PaymentTypeBindingSource.EndEdit()
            Me.PaymentTypeTableAdapter.Update(Me.DsSchoolParameters.PaymentType)
            MsgBox("Save Successful")
            BindingNavigator9.Items("AddNew9").Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton46_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton46.Click
        Try
            Me.Validate()
            Me.CashtypeBindingSource.EndEdit()
            Me.CashtypeTableAdapter.Update(Me.DsSchoolParameters.Cashtype)
            MsgBox("Save Successful")
            BindingNavigator10.Items("AddNew10").Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton53_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton53.Click
        Try
            Me.Validate()
            Me.QualificationsBindingSource.EndEdit()
            Me.QualificationsTableAdapter.Update(Me.DsSchoolParameters.Qualifications)
            MsgBox("Save Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        FormsBindingSource.AddNew()
    End Sub

    Private Sub btnProgSearch_Click(sender As Object, e As EventArgs) Handles btnProgSearch.Click
        Dim serchtext As String = Trim(txtProgSearch.Text)
        lbprograms.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(forms, ' ' , description) like '%" & serchtext & "%'"

            cmd.CommandText = "spProgramSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbprograms.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbprograms.DataSource = dsApps.Tables(0)
            lbprograms.DisplayMember = "Description"
            lbprograms.ValueMember = "forms"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub lbprograms_DoubleClick(sender As Object, e As EventArgs) Handles lbprograms.DoubleClick
        Try
            FormsTableAdapter.FillByProgram(DsSchoolParameters.forms, lbprograms.SelectedValue)
            txtProgSearch.Text = lbprograms.GetItemText(lbprograms.SelectedItem)
        Catch ex As Exception
        Finally
            lbprograms.Visible = False

        End Try
    End Sub

    Private Sub ToolStripButton90_Click(sender As Object, e As EventArgs) Handles ToolStripButton90.Click

    End Sub

    Private Sub btnClassSearch_Click(sender As Object, e As EventArgs) Handles btnClassSearch.Click
        Dim serchtext As String = Trim(txtClassSearch.Text)
        lbClasses.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(description, clas,sem,intake) like '%" & serchtext & "%'"

            cmd.CommandText = "spClassSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbClasses.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbClasses.DataSource = dsApps.Tables(0)
            lbClasses.DisplayMember = "Description"
            lbClasses.ValueMember = "Description"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub lbClasses_DoubleClick(sender As Object, e As EventArgs) Handles lbClasses.DoubleClick
        Try
            ClassesTableAdapter.FillByClass(DsSchoolParameters.Classes, lbClasses.SelectedValue)
            txtClassSearch.Text = lbClasses.GetItemText(lbClasses.SelectedItem)
        Catch ex As Exception
        Finally
            lbClasses.Visible = False

        End Try
    End Sub

    Private Sub btnSubjectSearch_Click(sender As Object, e As EventArgs) Handles btnSubjectSearch.Click
        Dim serchtext As String = Trim(txtSubjectSearch.Text)
        lbSubjects.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(subject, subjectid) like '%" & serchtext & "%'"

            cmd.CommandText = "spSubjectSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbSubjects.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbSubjects.DataSource = dsApps.Tables(0)
            lbSubjects.DisplayMember = "Subject"
            lbSubjects.ValueMember = "SubjectID"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub lbSubjects_DoubleClick(sender As Object, e As EventArgs) Handles lbSubjects.DoubleClick
        Try
            SubjectsTableAdapter.FillBySubject(DsSchoolParameters.Subjects, lbSubjects.SelectedValue)
            txtSubjectSearch.Text = lbSubjects.GetItemText(lbSubjects.SelectedItem)
        Catch ex As Exception
        Finally
            lbSubjects.Visible = False
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnTermDurationSearch.Click
        Dim serchtext As String = Trim(txtTermDurationsSearch.Text)
        lbTermDurations.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(classdesc, ' ' , program) like '%" & serchtext & "%'"

            cmd.CommandText = "spTermDurationSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbTermDurations.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbTermDurations.DataSource = dsApps.Tables(0)
            lbTermDurations.DisplayMember = "ClassDesc"
            lbTermDurations.ValueMember = "semDurRef"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub lbTermDurations_DoubleClick(sender As Object, e As EventArgs) Handles lbTermDurations.DoubleClick
        Try
            SemesterDurationsTableAdapter.FillByTerm(DsSchoolParameters.SemesterDurations, lbTermDurations.SelectedValue)
            txtTermDurationsSearch.Text = lbprograms.GetItemText(lbprograms.SelectedItem)
        Catch ex As Exception
        Finally
            lbTermDurations.Visible = False

        End Try
    End Sub

    Private Sub btnExamSearch_Click(sender As Object, e As EventArgs) Handles btnExamSearch.Click
        Dim serchtext As String = Trim(txtExamSearch.Text)
        lbExamSearch.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(description, ' ' , session) like '%" & serchtext & "%'"

            cmd.CommandText = "spExamSearch"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lbExamSearch.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lbExamSearch.DataSource = dsApps.Tables(0)
            lbExamSearch.DisplayMember = "session"
            lbExamSearch.ValueMember = "ref"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub lbExamSearch_DoubleClick(sender As Object, e As EventArgs) Handles lbExamSearch.DoubleClick
        Try
            ExamSessionsTableAdapter.FillBySession(DsSchoolParameters.ExamSessions, lbExamSearch.SelectedValue)
            txtExamSearch.Text = lbExamSearch.GetItemText(lbExamSearch.SelectedItem)
        Catch ex As Exception
        Finally
            lbExamSearch.Visible = False

        End Try
    End Sub

    Private Sub MarkWeightingDataGridView_DataError_1(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MarkWeightingDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton70_Click(sender As Object, e As EventArgs) Handles ToolStripButton70.Click
        Try
            Me.Validate()
            Me.CurrenciesBindingSource.EndEdit()
            Me.CurrenciesTableAdapter.Update(Me.DsSchoolParameters.Currencies)
            MsgBox("Save Successful")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cnn As New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction

        Try
            cnn.Open()
            trans = cnn.BeginTransaction
            sqltext = "delete exchangerates"
            cmd = New SqlCommand(sqltext, cnn, trans)
            cmd.ExecuteNonQuery()

            For i = 0 To lvExchangeRate.Items.Count - 1
                Dim rate As Double
                Dim datefrom, dateto As Date
                Dim currfrom, currto As String


                currfrom = lvExchangeRate.Items(i).Text
                currto = lvExchangeRate.Items(i).SubItems(1).Text
                rate = lvExchangeRate.Items(i).SubItems(2).Text
                Date.TryParse(lvExchangeRate.Items(i).SubItems(3).Text, datefrom)
                Date.TryParse(lvExchangeRate.Items(i).SubItems(4).Text, dateto)
                sqltext = "spInsertExchangeRate"
                cmd = New SqlCommand(sqltext, cnn, trans)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@currfrom", currfrom)
                    .Parameters.AddWithValue("@currto", currto)
                    .Parameters.AddWithValue("@datefrom", datefrom)
                    .Parameters.AddWithValue("@dateto", dateto)
                    .Parameters.AddWithValue("@rate", rate)
                    .Parameters.AddWithValue("@rateref", Guid.NewGuid)
                    .ExecuteNonQuery()
                End With

            Next
            trans.Commit()
            MsgBox("Exchange Rates maintained")


        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub btnAddExchangeRate_Click(sender As Object, e As EventArgs) Handles btnAddExchangeRate.Click
        Dim items As ListViewItem
        Dim subitems As ListViewItem.ListViewSubItem




        items = lvExchangeRate.Items.Add("")
        items.Text = cboCurrFromCurr.Text


        subitems = items.SubItems.Add("")
        subitems.Text = cboCurrToCurr.Text


        subitems = items.SubItems.Add("")
        subitems.Text = Val(txtCurrToVal.Text) / Val(txtCurrFromValue.Text)



        subitems = items.SubItems.Add("")
        subitems.Text = mskExDateFrom.Text


        subitems = items.SubItems.Add("")
        subitems.Text = mskExDateTo.Text



    End Sub

    Private Sub mskExDateFrom_Validated(sender As Object, e As EventArgs) Handles mskExDateFrom.Validated, mskExDateTo.Validated, txtCurrToVal.Validated, txtCurrFromValue.Validated

        Dim datefrom, dateto As Date
        Dim currfrom, currto As Double
        If Date.TryParse(mskExDateFrom.Text, datefrom) And Date.TryParse(mskExDateTo.Text, dateto) And IsNumeric(txtCurrToVal.Text) And IsNumeric(txtCurrFromValue.Text) And cboCurrFromCurr.Text <> "" And cboCurrToCurr.Text <> "" Then
            btnAddExchangeRate.Enabled = True
        Else
            btnAddExchangeRate.Enabled = False
        End If

    End Sub

    Private Sub lvExchangeRate_DoubleClick(sender As Object, e As EventArgs) Handles lvExchangeRate.DoubleClick
        lvExchangeRate.Items.Remove(lvExchangeRate.SelectedItems(0))
    End Sub

    Private Sub PaymentTypeDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles PaymentTypeDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTermDurationsSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTermDurationsSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button7_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbTermDurations.Visible = False


        End If
    End Sub

    Private Sub txtExamSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtExamSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnExamSearch_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbExamSearch.Visible = False
        End If
    End Sub

    Private Sub txtProgSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProgSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnProgSearch_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbprograms.Visible = False

        End If
    End Sub

    Private Sub txtClassSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClassSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnClassSearch_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbClasses.Visible = False

        End If
    End Sub

    Private Sub txtSubjectSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSubjectSearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            btnSubjectSearch_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            lbSubjects.Visible = False
        End If
    End Sub

    Private Sub QualificationsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles QualificationsDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub



    Private Sub chkMultipleAutoComments_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultipleAutoComments.CheckedChanged

    End Sub

    Private Sub lvExmGrd_KeyDown(sender As Object, e As KeyEventArgs) Handles lvExmGrd.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim itm As ListViewItem
            Dim ref As String = ""
            Dim grade As String = ""
            Dim prog As String = ""

            Dim gradeline As New cExamGrading

            Dim gradecomments As New List(Of cAutoComment)

            itm = lvExmGrd.SelectedItems(0)
            grade = itm.Text
            gradeline = ExamGrades.Where(Function(x) x.Grade = grade).Single
            ref = gradeline.RefId
            prog = gradeline.Program
            Dim dgGradeComment As New dgautoComments()
            With dgGradeComment
                .GradeRef = ref
                .GradeString = prog & " - " & grade & " Grade"
                .Grade = grade
                .exmgrades = ExamGrades
                .GetComments()
                .ShowDialog()


            End With


            If dgGradeComment.DialogResult = DialogResult.OK Then
                For i = 0 To dgGradeComment.dgGeadeComments.Rows.Count - 2
                    Dim autocomment As New cAutoComment
                    autocomment.Comment = dgGradeComment.dgGeadeComments.Rows(i).Cells(0).Value
                    autocomment.Refid = ""
                    autocomment.GradeRef = ""
                    gradecomments.Add(autocomment)

                Next
            End If

            gradeline.AutoComents = gradecomments


        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbSchoolStamp_Click(sender As Object, e As EventArgs) Handles pbSchoolStamp.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbSchoolStamp.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub pbSchoolStamp2_Click(sender As Object, e As EventArgs) Handles pbSchoolStamp2.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbSchoolStamp2.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ToolStripButton91_Click(sender As Object, e As EventArgs) Handles ToolStripButton91.Click
        If RefTextBox.Text <> "" Then

            Dim cnn As New SqlConnection(ConnectionString)
            Dim sql As String = "spDeleteClasses"
            If MsgBox("Delete Class?", vbYesNo) = vbYes Then

                Try
                    cnn.Open()
                    Dim cmd As New SqlCommand(sql, cnn)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@ref", RefTextBox.Text)
                        .ExecuteNonQuery()
                        MsgBox("Class Deleted")
                        ClassesTableAdapter.Fill(DsSchoolParameters.Classes)
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cnn.Close()
                End Try

            End If
        End If

    End Sub


End Class