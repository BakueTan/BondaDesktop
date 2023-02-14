
Imports RevoModelC
Imports Miscelleneous
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmCoA
    Public frmmain As Form


    Private Sub BanksBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)




    End Sub

    Private Sub frmBanks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsAccountsSettings.AccountCartegories' table. You can move, or remove it, as needed.
        Me.AccountCartegoriesTableAdapter.Fill(Me.DsAccountsSettings.AccountCartegories)
        'TODO: This line of code loads data into the 'DsCoA.GLStatement' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsCoA.ChartOfAccounts' table. You can move, or remove it, as needed.

        LoadAccountingCompanies()
        LoadCurrencies()
        loadAccountingPeriods()
        LoadCoa()
        Me.ChartOfAccountsTableAdapter.Fill(Me.DsCoA.ChartOfAccounts)

        'TODO: This line of code loads data into the 'DsBanks.BankTransactions' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsBanks.Banks' table. You can move, or remove it, as needed.





        Prepareform(Me, frmmain, False)
        Show()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub LoadCurrencies()


        With CurrencyComboBox
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadCoa()

        With cboTransAccFrom
            .DataSource = ChartOfAccounts(" where acctype = 'Bank'")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With ParentAccountComboBox
            .DataSource = ChartOfAccounts("   where blocked = 0  and issubaccount = 0")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With dgJournalAcounts.Rows(0)
            Dim cboExpenseCart As DataGridViewComboBoxCell = CType(.Cells("colJournalAccount"), DataGridViewComboBoxCell)


            cboExpenseCart.DataSource = ChartOfAccounts(" where accountnumber not in (select isnull(parentaccount,'') from chartofaccounts)")
            cboExpenseCart.DisplayMember = "Text"
            cboExpenseCart.ValueMember = "Value"

        End With


    End Sub




    Private Sub LoadAccountingCompanies()

        Dim Companies As List(Of ComboItem) = AccountingCompanies()

        With cboAccCompany
            .DataSource = Companies
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboTransCompany
            .DataSource = Companies
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboJournalCompany
            .DataSource = Companies
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub


    Private Sub loadAccountingPeriods()
        With cboTransPeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

        With cboJournalPeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With
    End Sub

    Private Sub btnTransSave_Click(sender As Object, e As EventArgs) Handles btnTransSave.Click

        cnn = New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction

        sql = "spCreateGLTransaction"

        Try
            cnn.Open()


            cmd = New SqlCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@account", cboTransAccFrom.SelectedValue)
            cmd.Parameters.AddWithValue("@date", Date.Parse(mskTransDate.Text))
            cmd.Parameters.AddWithValue("@amount", Val(txtTansAmount.Text))
            cmd.Parameters.AddWithValue("@transdoc", txtTransRef.Text)
            cmd.Parameters.AddWithValue("@user", goUser.userName)
            cmd.Parameters.AddWithValue("@comment", txtTransComments.Text)
            cmd.Parameters.AddWithValue("@transPeriod", cboTransPeriod.SelectedValue)
            cmd.Parameters.AddWithValue("@Transtype", "TR")
            cmd.Parameters.AddWithValue("@accountto", cboTransAccTo.SelectedValue)
            cmd.Parameters.AddWithValue("@company", Guid.Parse(cboTransCompany.SelectedValue.ToString))
            cmd.Parameters.AddWithValue("@dc", "C")
            cmd.ExecuteNonQuery()
            MsgBox("Bank Transfer effected")
            ChartOfAccountsTableAdapter.Fill(DsCoA.ChartOfAccounts)


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()

        End Try


    End Sub

    Private Sub txtTransRef_TextChanged(sender As Object, e As EventArgs) Handles txtTransRef.TextChanged, txtTansAmount.TextChanged, mskTransDate.TextChanged, cboTransPeriod.SelectedIndexChanged, cboTransAccFrom.SelectedIndexChanged, cboTransAccTo.SelectedIndexChanged
        Dim transdate As Date

        Dim snder As Control
        Dim SelItem As ComboItem

        Try
            snder = sender
            If snder.Name = cboTransAccFrom.Name Then
                cboTransAccTo.DataSource = ChartOfAccounts(" where acctype = 'Bank' and Accountnumber <>  '" & cboTransAccFrom.SelectedValue & "'")
                cboTransAccTo.DisplayMember = "Text"
                cboTransAccTo.ValueMember = "Value"

                SelItem = cboTransAccFrom.SelectedItem
                lbAccFromBalance.Text = CType(SelItem.Ref, c_CoA).Balance
            ElseIf snder.Name = cboTransAccTo.Name Then
                SelItem = cboTransAccTo.SelectedItem
                lbAccToBalance.Text = CType(SelItem.Ref, c_CoA).Balance

            End If
        Catch ex As Exception

        End Try

        If txtTransRef.Text <> "" And Val(txtTansAmount.Text) <> 0 And Date.TryParse(mskTransDate.Text, transdate) And cboTransPeriod.Text <> "" And cboTransAccFrom.Text <> "" Then
            btnTransSave.Enabled = True
        Else
            btnTransSave.Enabled = False
        End If


    End Sub



    Private Sub AccountNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccountNumberTextBox.TextChanged, chkGLShowCredits.CheckedChanged, chkGLShowDebits.CheckedChanged
        If BankRefTextBox.Text <> "" Then
            BalanceTextBox.Enabled = False
            BalanceTextBox.ReadOnly = True
        Else
            BalanceTextBox.Enabled = False
            BalanceTextBox.ReadOnly = True
        End If
        Try
            Me.GLStatementTableAdapter.FillByStatement(Me.DsCoA.GLStatement, AccountNumberTextBox.Text, chkGLShowDebits.Checked, chkGLShowCredits.Checked, -1, -1, 1, True, "", 1)
            ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub lbAccFromBalance_Click(sender As Object, e As EventArgs) Handles lbAccFromBalance.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cnn = New SqlConnection(ConnectionString)
        Dim trans As SqlTransaction
        Dim debitssum As Double
        Dim creditssum As Double





        Dim transum As Double = 0
        Try
            cnn.Open()
            trans = cnn.BeginTransaction
            For Each rw In dgJournalAcounts.Rows

                If rw.cells("colJournalAccount").value = "" Then
                    Exit For
                End If


                sql = "spCreateGLTransaction"


                '     cnn.Open()


                cmd = New SqlCommand(sql, cnn, trans)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@account", rw.cells("colJournalAccount").value)
                cmd.Parameters.AddWithValue("@date", Date.Parse(mskJournalDate.Text))
                cmd.Parameters.AddWithValue("@amount", Val(rw.cells("colJournalAmnt").value))
                cmd.Parameters.AddWithValue("@transdoc", txtJournalDoc.Text)
                cmd.Parameters.AddWithValue("@user", goUser.userName)
                cmd.Parameters.AddWithValue("@comment", rw.cells("colJournamMemo").value)
                cmd.Parameters.AddWithValue("@transPeriod", cboJournalPeriod.SelectedValue)
                cmd.Parameters.AddWithValue("@Transtype", "AB")
                cmd.Parameters.AddWithValue("@company", cboJournalCompany.SelectedValue)
                cmd.Parameters.AddWithValue("@dc", rw.cells("colJournalAdj").value)
                cmd.ExecuteNonQuery()

                If rw.cells("colJournalAdj").value = "C" Then
                    creditssum += Val(rw.cells("colJournalAmnt").value)
                ElseIf rw.cells("colJournalAdj").value = "D" Then
                    debitssum += Val(rw.cells("colJournalAmnt").value)
                End If

            Next

            If creditssum <> debitssum Then
                Throw New Exception("Debits Totals should match Credit Totals")
            End If

            trans.Commit()
            MsgBox("Journal Posted")
            ChartOfAccountsTableAdapter.Fill(DsCoA.ChartOfAccounts)

        Catch ex As Exception
            MsgBox(ex.Message)
            If Not IsNothing(trans) Then trans.Rollback()
        Finally
            cnn.Close()

        End Try
    End Sub



    Private Sub IsSubAccountCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsSubAccountCheckBox.CheckedChanged
        pnlParentAccount.Enabled = IsSubAccountCheckBox.Checked



        If IsSubAccountCheckBox.Checked Then
            With ParentAccountComboBox
                .DataSource = ChartOfAccounts("   where blocked = 0 and accountnumber <> " & Val(AccountNumberTextBox.Text) & " and issubaccount = 0")
                .DisplayMember = "Text"
                .ValueMember = "Value"
            End With
        Else
            With ParentAccountComboBox
                .DataSource = Nothing

            End With
        End If
    End Sub

    Private Sub dgJournalAcounts_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgJournalAcounts.RowsAdded

        Try



            Dim cboExpenseCart As DataGridViewComboBoxCell = CType(dgJournalAcounts.Rows(e.RowIndex).Cells("colJournalAccount"), DataGridViewComboBoxCell)


            cboExpenseCart.DataSource = ChartOfAccounts(" where accountnumber not in (select isnull(parentaccount,'') from chartofaccounts)")
            cboExpenseCart.DisplayMember = "Text"
            cboExpenseCart.ValueMember = "Value"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkGLShowDebits_CheckedChanged(sender As Object, e As EventArgs) Handles chkGLShowDebits.CheckedChanged

    End Sub

    Private Sub ToolStripButton34_Click(sender As Object, e As EventArgs) Handles ToolStripButton34.Click

        Dim comp As ComboItem = cboAccCompany.SelectedItem

        Dim coaRef As Guid
        Try
            coaRef = Guid.Parse(BankRefTextBox.Text)
        Catch ex As Exception
            coaRef = Guid.NewGuid
        End Try
        Try
            ChartOfAccountsTableAdapter.CreateAccount(DsCoA.ChartOfAccounts, DescriptionTextBox.Text, Val(BalanceTextBox.Text), CurrencyComboBox.Text, AccTypeComboBox.Text, coaRef, ActiveCheckBox.Checked, IsSubAccountCheckBox.Checked, Val(ParentAccountComboBox.SelectedValue), Guid.Parse(cboAccCompany.SelectedValue.ToString))
            MsgBox("Account Details updated")
            ChartOfAccountsTableAdapter.Fill(DsCoA.ChartOfAccounts)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ttxVendorSearchtext_TextChanged(sender As Object, e As EventArgs) Handles ttxVendorSearchtext.TextChanged

    End Sub

    Private Sub ToolStripButton29_Click(sender As Object, e As EventArgs) Handles ToolStripButton29.Click

    End Sub
End Class