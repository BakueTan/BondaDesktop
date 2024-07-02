Imports System.Windows.Forms
Imports RevoModelC
Imports Miscelleneous
Imports System.Data.SqlClient

Public Class frmAccountingSettings
    Public frmmain As Form


    Private Sub frmAccountingSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsAccountsSettings.AccountSubType' table. You can move, or remove it, as needed.
        Me.AccountSubTypeTableAdapter.Fill(Me.DsAccountsSettings.AccountSubType)
        'TODO: This line of code loads data into the 'DsAccountsSettings.PaymentTerms' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsAccountsSettings.AccountingCompanies' table. You can move, or remove it, as needed.

        LoadYears()
        LoadCurrencies()
        LoadAccountTypes()
        LoadAccountSubTypes()

        LoadDatasets()

        Prepareform(Me, frmmain, False)
        Show()

    End Sub

    Private Sub LoadDatasets()
        Try
            Me.AccountingCompaniesTableAdapter.Fill(Me.DsAccountsSettings.AccountingCompanies)
            'TODO: This line of code loads data into the 'DsAccountsSettings.AccountingCompanies' table. You can move, or remove it, as needed.
            'TODO: This line of code loads data into the 'DsAccountsSettings.AccountingPeriods' table. You can move, or remove it, as needed.
            Me.AccountingPeriodsTableAdapter.Fill(Me.DsAccountsSettings.AccountingPeriods)
            'TODO: This line of code loads data into the 'DsAccountsSettings.AccountingPeriods' table. You can move, or remove it, as needed.
            'TODO: This line of code loads data into the 'DsAccountsSettings.schoolinfo' table. You can move, or remove it, as needed.
            '   Me.SchoolinfoTableAdapter.Fill(Me.DsAccountsSettings.schoolinfo)
            'TODO: This line of code loads data into the 'DsAccountsSettings.AccountingDocuments' table. You can move, or remove it, as needed.
            Me.AccountingDocumentsTableAdapter.Fill(Me.DsAccountsSettings.AccountingDocuments)
            'TODO: This line of code loads data into the 'DsAccountsSettings.AccountCartegories' table. You can move, or remove it, as needed.
            Me.AccountCartegoriesTableAdapter.Fill(Me.DsAccountsSettings.AccountCartegories)
            'TODO: This line of code loads data into the 'DsAccountsSettings.AccountNumberValue' table. You can move, or remove it, as needed.
            Me.AccountNumberValueTableAdapter.Fill(Me.DsAccountsSettings.AccountNumberValue)
            Me.PaymentTermsTableAdapter.Fill(Me.DsAccountsSettings.PaymentTerms)
            'TODO: This line of code loads data into the 'DsAccountsSettings.VAT' table. You can move, or remove it, as needed.
            Me.VATTableAdapter.Fill(Me.DsAccountsSettings.VAT)
            'TODO: This line of code loads data into the 'DsCoA.ChartOfAccounts' table. You can move, or remove it, as needed.
            Me.ChartOfAccountsTableAdapter.Fill(Me.DsCoA.ChartOfAccounts)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub LoadYears()
        With FiscalYearComboBox
            .DataSource = Years()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadAccountTypes()
        With cboAccTypeSubType_AccType
            .DataSource = AccountTypes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadAccountSubTypes()
        With chkAccSubTypes
            .DataSource = AccountSubTypes()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadCurrencies()


        With CurrencyComboBox
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub



    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click

        Dim cartref As Guid
        Try
            cartref = Guid.Parse(CartRefTextBox.Text)

        Catch ex As Exception

        End Try


        Try
            AccountCartegoriesTableAdapter.InsertCartegory(DsAccountsSettings.AccountCartegories, CartegoryTextBox.Text, cartref)
            Me.AccountCartegoriesTableAdapter.Fill(Me.DsAccountsSettings.AccountCartegories)
            LoadAccountTypes()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub tbAccNumbers_Click(sender As Object, e As EventArgs) Handles tbAccNumbers.Click

    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click


        Try
            Me.Validate()
            Me.AccountingDocumentsBindingSource.EndEdit()
            Me.AccountingDocumentsTableAdapter.Update(Me.DsAccountsSettings.AccountingDocuments)
            MsgBox("Save Successful")

            AccountingDocumentsTableAdapter.Fill(DsAccountsSettings.AccountingDocuments)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ToolStripButton20_Click(sender As Object, e As EventArgs) Handles ToolStripButton20.Click
        Try
            Dim ref As Guid
            Try
                ref = Guid.Parse(RefIdTextBox.Text)
            Catch ex As Exception
                ref = Guid.NewGuid
            End Try

            Me.AccountNumberValueTableAdapter.InsertNumber(Me.DsAccountsSettings.AccountNumberValue, DocNameComboBox.Text, Val(DocFromTextBox.Text), Val(DocToTextBox.Text), SchoolComboBox.SelectedValue, ref, Val(CurrentDocTextBox.Text))
            MsgBox("Save Successful")
            AccountNumberValueTableAdapter.Fill(DsAccountsSettings.AccountNumberValue)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton21_Click(sender As Object, e As EventArgs) Handles ToolStripButton21.Click
        Try
            If AccountNumberValueDataGridView.SelectedRows.Count = 1 Then

                If MsgBox("Delete Selected Number Range ?", vbYesNo) = vbYes Then

                    AccountNumberValueTableAdapter.DeleteDocNumber(DsAccountsSettings.AccountNumberValue, Guid.Parse(RefIdTextBox.Text))

                    AccountNumberValueTableAdapter.Fill(DsAccountsSettings.AccountNumberValue)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Try
            If AccountingDocumentsDataGridView.SelectedRows.Count = 1 Then

                If MsgBox("Delete Selected Number Range ?", vbYesNo) = vbYes Then

                    AccountingDocumentsTableAdapter.DeleteDoc(DsAccountsSettings.AccountingDocuments, AccountingDocumentsDataGridView.SelectedRows(0).Cells("doc").Value)

                    AccountingDocumentsTableAdapter.Fill(DsAccountsSettings.AccountingDocuments)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click

    End Sub

    Private Sub AccountNumberValueDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles AccountNumberValueDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AccountingDocumentsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles AccountingDocumentsDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AccountCartegoriesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles AccountCartegoriesDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton27_Click(sender As Object, e As EventArgs) Handles ToolStripButton27.Click

        Dim periodref As Guid
        Try
            periodref = Guid.Parse(RefIdTextBox.Text)
        Catch ex As Exception
            periodref = Guid.NewGuid
        End Try

        Try
            AccountingPeriodsTableAdapter.InsertPeriod(DsAccountsSettings.AccountingPeriods, DescriptionTextBox.Text, AccountingPeriodTextBox.Text, OpenCheckBox.Checked, periodref, FiscalYearComboBox.Text)
            MsgBox("Accounting Period updated")
            Me.AccountingPeriodsTableAdapter.Fill(DsAccountsSettings.AccountingPeriods)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigator3_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator3.RefreshItems

    End Sub

    Private Sub ToolStripButton34_Click(sender As Object, e As EventArgs) Handles ToolStripButton34.Click
        Dim cnn As New SqlConnection(ConnectionString)
        Dim sql As String = "spInsertAccountingCompany"
        Dim imagebytes As Byte()

        Try
            cnn.Open()

            Dim cmd As New SqlCommand(sql, cnn)

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@name", CompanyNameTextBox.Text)
                .Parameters.AddWithValue("@web", WebsiteTextBox.Text)
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

                .Parameters.AddWithValue("@ref", IIf(CompanyRefLabel1.Text = "", Guid.NewGuid, CompanyRefLabel1.Text))
                .Parameters.AddWithValue("@curr", CurrencyComboBox.Text)
                .Parameters.AddWithValue("@defaultPayableAcc ", 0)
                .Parameters.AddWithValue("@defaultReceivableAcc", 0)
                .Parameters.AddWithValue("@email", EmailTextBox.Text)
                .ExecuteNonQuery()
                MsgBox("Company Info Saved")
                Me.AccountingCompaniesTableAdapter.Fill(DsAccountsSettings.AccountingCompanies)


            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try



    End Sub

    Private Sub DefaultPayableAccountComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub ToolStripButton41_Click(sender As Object, e As EventArgs) Handles ToolStripButton41.Click
        Try
            Dim ref As Guid
            Try
                ref = Guid.Parse(TaxRefTextBox.Text)
            Catch ex As Exception
                ref = Guid.NewGuid
            End Try

            Me.VATTableAdapter.InsertVat(Me.DsAccountsSettings.VAT, TaxDescriptionTextBox.Text, Val(TaxRateTextBox.Text), TaxInclusiveCheckBox.Checked, ref)
            MsgBox("Save Successful")
            VATTableAdapter.Fill(DsAccountsSettings.VAT)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton42_Click(sender As Object, e As EventArgs) Handles ToolStripButton42.Click
        If TaxRefTextBox.Text <> "" Then
            If MsgBox("Delete VAT?", vbYesNo) = vbYes Then
                VATTableAdapter.DeleteVat(DsAccountsSettings.VAT, Guid.Parse(TaxRefTextBox.Text))
                VATTableAdapter.Fill(DsAccountsSettings.VAT)
            End If
        End If
    End Sub

    Private Sub ToolStripButton48_Click(sender As Object, e As EventArgs) Handles ToolStripButton48.Click
        Try
            Dim ref As Guid
            Try
                ref = Guid.Parse(txtPaymentRef.Text)
            Catch ex As Exception
                ref = Guid.NewGuid
            End Try

            Me.PaymentTermsTableAdapter.InsertPaymentTerms(Me.DsAccountsSettings.PaymentTerms, txtPaymentTerm.Text, Val(txtPaymentDays.Text), ref)
            MsgBox("Save Successful")
            PaymentTermsTableAdapter.Fill(DsAccountsSettings.PaymentTerms)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton49_Click(sender As Object, e As EventArgs) Handles ToolStripButton49.Click
        If txtPaymentRef.Text <> "" Then
            If MsgBox("Delete Payment Term?", vbYesNo) = vbYes Then
                PaymentTermsTableAdapter.DeletePaymentTerm(DsAccountsSettings.PaymentTerms, Guid.Parse(txtPaymentRef.Text))
                PaymentTermsTableAdapter.Fill(DsAccountsSettings.PaymentTerms)
            End If
        End If
    End Sub

    Private Sub btnSettingsRefresh_Click(sender As Object, e As EventArgs) Handles btnSettingsRefresh.Click
        LoadDatasets()
    End Sub

    Private Sub ToolStripButton55_Click(sender As Object, e As EventArgs) Handles ToolStripButton55.Click
        Try
            Me.Validate()
            Me.AccountSubTypeBindingSource.EndEdit()
            Me.AccountSubTypeTableAdapter.Update(Me.DsAccountsSettings.AccountSubType)
            MsgBox("Save Successful")

            Me.AccountSubTypeTableAdapter.Fill(DsAccountsSettings.AccountSubType)
            LoadAccountSubTypes()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = ""
        Dim cnn As SqlConnection = New SqlConnection(ConnectionString)

        Dim cmd As SqlCommand

        Dim trans As SqlTransaction

        Try

            cnn.Open()
            trans = cnn.BeginTransaction

            sql = "Delete AccountTypeSubtypes where accounttype = '" & cboAccTypeSubType_AccType.Text & "'"

            cmd = New SqlCommand(sql, cnn, trans)
            cmd.ExecuteNonQuery()

            For i = 0 To chkAccSubTypes.Items.Count - 1
                If chkAccSubTypes.GetItemChecked(i) = True Then
                    sql = "spInsertAccountTypeSubTypes"
                    cmd = New SqlCommand(sql, cnn, trans)

                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@acctype", cboAccTypeSubType_AccType.Text)
                    cmd.Parameters.AddWithValue("@subtype", chkAccSubTypes.Items(i).value)
                    cmd.ExecuteNonQuery()
                End If
            Next

            trans.Commit()
            MsgBox("Account SubTypes Updated")
        Catch ex As Exception

            If Not IsNothing(trans) Then trans.Rollback()

            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try

    End Sub

    Private Sub cboAccTypeSubType_AccType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccTypeSubType_AccType.SelectedIndexChanged
        Dim SubTYpes As New List(Of ComboItem)
        SubTYpes = AccountTypeSubTypes(" where accounttype = '" & cboAccTypeSubType_AccType.Text & "'")

        For i = 0 To chkAccSubTypes.Items.Count - 1
            chkAccSubTypes.SetItemChecked(i, False)
        Next

        For Each itm In SubTYpes
            For i = 0 To chkAccSubTypes.Items.Count - 1
                If itm.Text = chkAccSubTypes.Items(i).value Then
                    chkAccSubTypes.SetItemChecked(i, True)
                    Exit For
                End If
            Next

        Next
    End Sub
End Class