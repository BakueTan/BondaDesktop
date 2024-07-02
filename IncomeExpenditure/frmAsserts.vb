Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports Miscelleneous

Public Class frmAsserts

    Private cnn As SqlConnection
    Private cmd As SqlCommand
    Public frmmain As Form
    Private CustDets As c_Customer

    Private customerTransError As String

    Private Sub frmAsserts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsCoA.GLStatement' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsAccountsReceivable.CustomerTransactions' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsAccountsReceivable.Customers' table. You can move, or remove it, as needed.


        Prepareform(Me, frmmain, False)



        cboPayTransType.Text = "Invoiced"

    End Sub


    Public Sub Init()
        LoadVat()
        LoadCompanies()
        LoadPaymentTerms()
        LoadCurrencies()
        loadAccountingPeriods()
        LoadAccountCartegories()
        loadCustomers()

        LoadDataSets()

    End Sub

    Private Sub LoadDataSets()
        Me.CustomersTableAdapter.Fill(Me.DsAccountsReceivable.Customers)
        Me.GLStatementTableAdapter.Fill(Me.dsCoA.GLStatement)
    End Sub

    Private Sub LoadVat()

        With TaxCodeComboBox
            .DataSource = VATS()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

        With cboCustVatcode
            .DataSource = VATS()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

        With cboPaymentsVat
            .DataSource = VATS()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With



    End Sub

    Private Sub LoadCompanies()

        With CustomerCompanyComboBox
            .DataSource = AccountingCompanies()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

        With cboInvoiceCompany
            .DataSource = AccountingCompanies()
            .DisplayMember = "Text"
            .ValueMember = "Value"


        End With

        With cboPayorCompany
            .DataSource = AccountingCompanies()
            .DisplayMember = "Text"
            .ValueMember = "Value"



        End With
    End Sub

    Private Sub LoadPaymentTerms()

        With PaymentTermsComboBox
            .DataSource = PaymentTerms()
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

        With cboInvCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With cboPayCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub loadAccountingPeriods()

        With cboInvPeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With cboInvPayPeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With



    End Sub

    Private Sub LoadAccountCartegories()



        With cboInvCartegory
            .DataSource = ChartOfAccounts(" where acctype = 'Revenue'")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboCustVatAccount
            .DataSource = ChartOfAccounts(" where acctype = 'OtherRevenue'")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


        With cboUnivoicedPayCartegory
            .DataSource = ChartOfAccounts(" where acctype = 'Revenue'")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With




    End Sub

    Private Sub loadCustomers()



        With cboInvoiceCustomer
            .DataSource = Customers()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

        With cboPaymentsCustomer
            .DataSource = Customers()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

    End Sub

    Private Sub ToolStripButton34_Click(sender As Object, e As EventArgs) Handles ToolStripButton34.Click

        cnn = New SqlConnection(ConnectionString)

        sql = "spInsertCustomer"

        Try
            cnn.Open()


            cmd = New SqlCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@accname", NameTextBox.Text)
            cmd.Parameters.AddWithValue("@AccContact", ContactNameTextBox.Text)
            cmd.Parameters.AddWithValue("@ContNumber", ContactNumberTextBox.Text)
            cmd.Parameters.AddWithValue("@email", EmailTextBox.Text)
            cmd.Parameters.AddWithValue("@address", AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@city", CityTextBox.Text)
            cmd.Parameters.AddWithValue("@country", CountryTextBox.Text)
            cmd.Parameters.AddWithValue("@BankDetails", BankDetailsTextBox.Text)
            cmd.Parameters.AddWithValue("@currency", CurrencyComboBox.Text)
            cmd.Parameters.AddWithValue("@notes", NotesTextBox.Text)
            cmd.Parameters.AddWithValue("@blocked", BlockedCheckBox.Checked)


            Try

                cmd.Parameters.AddWithValue("@accref", Guid.Parse(CustomerRefTextBox.Text))
            Catch ex As Exception
                cmd.Parameters.AddWithValue("@accref", Guid.NewGuid)
            End Try

            cmd.Parameters.AddWithValue("@company", CustomerCompanyComboBox.SelectedValue)

            cmd.Parameters.AddWithValue("@taxcode", TaxCodeComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@payterms", PaymentTermsComboBox.SelectedValue)
            cmd.Parameters.AddWithValue("@taxreg", TaxRegTextBox.Text)
            cmd.Parameters.AddWithValue("@taxaccount", cboCustVatAccount.SelectedValue)

            cmd.ExecuteNonQuery()
            MsgBox("Customer Saved")
            CustomersTableAdapter.Fill(DsAccountsReceivable.Customers)
            loadCustomers()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub AccNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccNumberTextBox.TextChanged, chkVenStatShowInvoices.CheckedChanged, chkVenStatShowPayments.CheckedChanged, chkVenStatShowReversals.CheckedChanged
        If Trim(AccNumberTextBox.Text) = "" Then
            CustomerBalanceTextBox.Enabled = False
            CustomerBalanceTextBox.ReadOnly = True
        Else
            CustomerBalanceTextBox.Enabled = False
            CustomerBalanceTextBox.ReadOnly = True
        End If

        Try
            GLStatementTableAdapter.FillByStatement(dsCoA.GLStatement, AccNumberTextBox.Text, chkVenStatShowInvoices.Checked, chkVenStatShowPayments.Checked, -1, -1, 1, False, "", 1)
            ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cboInvoiceCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInvoiceCustomer.SelectedIndexChanged

        Dim cust As ComboItem

        cust = cboInvoiceCustomer.SelectedItem

        CustDets = New c_Customer()

        With CustDets
            .PaymentTerms = CType(cust.Ref, c_Customer).PaymentTerms
            .TaxCode = CType(cust.Ref, c_Customer).TaxCode
            .Currency = CType(cust.Ref, c_Customer).Currency
            cboCustVatcode.Text = .TaxCode
            cboInvCurrency.Text = .Currency
        End With












    End Sub

    Private Sub FormatInvoiceGrig()
        For Each rw As DataGridViewRow In dgVendorInvoices.Rows
            If CBool(rw.Cells("ColInvActive").Value) = False Then
                rw.DefaultCellStyle.BackColor = Drawing.Color.Red
                rw.ReadOnly = True
                'Dim btncell As DataGridViewButtonCell
                'btncell = CType(rw.Cells("btnDelete"), DataGridViewButtonCell)



            End If
        Next
    End Sub

    Private Sub FormatPaymentGrid()
        For Each rw As DataGridViewRow In dgPayInvoice.Rows



            If rw.Cells("colInvPayTransType").Value = "R" Then
                rw.ReadOnly = True
                rw.DefaultCellStyle.BackColor = Color.Gray
            ElseIf rw.Cells("colInvPayTransType").Value = "I" Then
                rw.ReadOnly = False
            End If









        Next
    End Sub
    Private Sub mskInvDate_Validated(sender As Object, e As EventArgs) Handles mskInvDate.Validated
        Dim duedate As Date
        Dim strdueDate As String

        Try
            duedate = DateAdd(DateInterval.Day, CustDets.PaymentTerms, Date.Parse(mskInvDate.Text))

            strdueDate = duedate.ToShortDateString()
            mskInvDueDate.Text = strdueDate

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboCustVatcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustVatcode.SelectedIndexChanged, txtInvAmnt.Validated
        Dim TaxItem As ComboItem
        TaxItem = cboCustVatcode.SelectedItem

        Dim TaxRate As Double
        Dim TaxIncl As Boolean
        Dim taxamount As Double
        Dim invamount As Double = Val(txtInvAmnt.Text)



        With TaxItem
            TaxRate = CType(.Ref, c_Taxes).TaxRate
            TaxIncl = CType(.Ref, c_Taxes).RaxIncl
        End With

        If TaxIncl Then
            taxamount = (TaxRate / (TaxRate + 1)) * invamount
            txtVatAmount.Text = Math.Round(taxamount, 2)
            txtNetAmount.Text = Math.Round(invamount - taxamount, 2)
            lbNetAmount.Text = "Amount Before Tax: "

        Else

            taxamount = TaxRate * invamount
            txtVatAmount.Text = Math.Round(taxamount, 2)
            txtNetAmount.Text = Math.Round(invamount + taxamount, 2)
            lbNetAmount.Text = "Amount After Tax: "

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cnn = New SqlConnection(ConnectionString)

        sql = "spCustomerTransaction"

        Try
            cnn.Open()


            cmd = New SqlCommand(sql, cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@company", cboInvoiceCompany.SelectedValue)
            cmd.Parameters.AddWithValue("@ccnumber", cboInvoiceCustomer.SelectedValue)
            cmd.Parameters.AddWithValue("@doc", txtInvNumber.Text)
            cmd.Parameters.AddWithValue("@invamount", Val(txtInvAmnt.Text))
            cmd.Parameters.AddWithValue("@period", cboInvPeriod.SelectedValue)
            cmd.Parameters.AddWithValue("@InvDate", Date.Parse(mskInvDate.Text))
            cmd.Parameters.AddWithValue("@InvDueDate", Date.Parse(mskInvDueDate.Text))
            cmd.Parameters.AddWithValue("@InvNotes", txtInvNotes.Text)
            cmd.Parameters.AddWithValue("@InvRef", Guid.NewGuid)
            cmd.Parameters.AddWithValue("@User", goUser.userName)
            cmd.Parameters.AddWithValue("@InvCartegory", cboInvCartegory.SelectedValue)
            cmd.Parameters.AddWithValue("@TransType", "I")

            cmd.Parameters.AddWithValue("@InvCurrency", cboInvCurrency.Text)
            cmd.Parameters.AddWithValue("@Active", True)
            cmd.Parameters.AddWithValue("@bankAccount", 0)
            cmd.Parameters.AddWithValue("@PayType", "")
            cmd.Parameters.AddWithValue("@dc", "C")
            cmd.Parameters.AddWithValue("@vatcode", cboCustVatcode.SelectedValue)


            cmd.ExecuteNonQuery()
            MsgBox("Customer Invoice Saved")
            Try
                CustomersTableAdapter.Fill(DsAccountsReceivable.Customers)
                GLStatementTableAdapter.Fill(dsCoA.GLStatement)
                chkDisplayCncelledInvoices_CheckedChanged(Me, Nothing)
            Catch ex As Exception

            End Try






        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub dgVendorInvoices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVendorInvoices.CellContentClick

        Try
            If dgVendorInvoices.CurrentCell.Value = "Edit" Then
                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .VendorNumber = dgVendorInvoices.CurrentRow.Cells("colCustInvVendor").Value
                    .blnEditInvoice = True
                    .scInvoiceAdjust.Visible = True
                    .scInvoicedCancel.Visible = False
                    .scInvoiceAdjust.Dock = DockStyle.Fill
                    .scInvoiceAdjust.Panel1Collapsed = True
                    .Text = "Edit Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value
                    .isVendorTrans = False
                    .ShowDialog()

                    If .DialogResult = DialogResult.OK Then

                        Dim Inv As New GenericTrans

                        Try
                            With Inv
                                .InvVendorAccNumber = dgVendorInvoices.CurrentRow.Cells("colCustInvVendor").Value
                                .InvAmount = dgAdjustinvoice.txtInvAmnt.Text
                                .InvCartegory = cboInvCartegory.Text
                                .InvDate = Date.Parse(dgAdjustinvoice.mskInvDate.Text)
                                .InvNotes = dgAdjustinvoice.txtInvNotes.Text
                                .Period = dgAdjustinvoice.cboInvPeriod.SelectedValue
                                .InvPostedBy = goUser.userName
                                .InvDueDate = Date.Parse(dgAdjustinvoice.mskInvDueDate.Text)
                                .InvRef = Guid.Parse(dgAdjustinvoice.txtInvref.Text)
                                .InvCurrency = dgAdjustinvoice.cboInvCurrency.Text
                                .InvActive = True
                                .InvTransType = "I"
                                .InvDocNumber = dgAdjustinvoice.txtInvNumber.Text


                                'If .PostInvoice() Then
                                '    MsgBox("Invoice Posted")
                                '    cboInvoiceVendor_SelectedIndexChanged(Me, Nothing)

                                'Else
                                '    MsgBox(Inv.TransError)
                                'End If

                            End With



                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try



                    End If

                End With
            ElseIf dgVendorInvoices.CurrentCell.Value = "Reverse" Then

                Dim venInvoice As New GenericTrans()


                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .VendorNumber = dgVendorInvoices.CurrentRow.Cells("colCustInvVendor").Value
                    .blnCancelInvoice = True

                    .scInvoiceAdjust.Visible = False
                    .scInvoicedCancel.Visible = True
                    .scInvoicedCancel.Dock = DockStyle.Fill
                    .scInvoicedCancel.Panel2Collapsed = True
                    .Text = "Cancel Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value
                    .isVendorTrans = False
                    .ShowDialog()

                    If .DialogResult = DialogResult.OK Then

                        If MsgBox("Cancel Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value & " ?", vbYesNo) = MsgBoxResult.Yes Then
                            With venInvoice

                                .InvAmount = 0
                                .InvCartegory = 0
                                .InvVendorAccNumber = dgVendorInvoices.CurrentRow.Cells("colCustInvVendor").Value

                                .InvDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvNotes = dgAdjustinvoice.txtCancelInvoiceNotes.Text
                                .Period = dgAdjustinvoice.cboCreditMemoPeriod.SelectedValue
                                .InvPostedBy = goUser.userName
                                .InvDueDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvRef = Guid.Parse(dgAdjustinvoice.txtCancelInvoiceInvRef.Text)
                                .InvCurrency = dgVendorInvoices.CurrentRow.Cells("colInvCurrency").Value
                                .InvActive = True
                                .InvTransType = "IR"
                                .InvDocNumber = dgAdjustinvoice.txtCancelInvoiceDoc.Text
                                .DC = "C"
                                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue.ToString)
                                .InvPaymentType = ""
                                .VatCode = dgVendorInvoices.CurrentRow.Cells("colVatCode").Value







                            End With

                            If PostCustomerTrans(venInvoice) Then

                                MsgBox("Invoice Cancelled")
                                chkDisplayCncelledInvoices_CheckedChanged(Me, Nothing)

                            Else
                                MsgBox("Transaction failed : " & customerTransError)


                            End If
                        End If

                    End If

                End With




            ElseIf dgVendorInvoices.CurrentCell.Value = "DebitMemo" Then

                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .VendorNumber = dgVendorInvoices.CurrentRow.Cells("colCustInvVendor").Value
                    .blnAdjustInvoice = True
                    .scInvoiceAdjust.Visible = True
                    .scInvoicedCancel.Visible = False
                    .scInvoiceAdjust.Dock = DockStyle.Fill
                    .scInvoiceAdjust.Panel2Collapsed = True
                    '    .txtCreditMemoInvRef.Text = .InvoiceRef
                    .mskCreditMemoDate.Text = Now.Date.ToShortDateString()
                    .cboCreditMemoAdjust.Text = "C"
                    .Text = "Debit Memo for Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value
                    .isVendorTrans = False
                    .ShowDialog()


                    If .DialogResult = DialogResult.OK Then

                        Dim Inv As New GenericTrans

                        Try
                            With Inv
                                .InvVendorAccNumber = dgVendorInvoices.CurrentRow.Cells("colCustInvVendor").Value
                                If dgAdjustinvoice.cboCreditMemoAdjust.Text = "" Then
                                    MsgBox("Select Adjustment Type")
                                    Exit Sub
                                End If
                                .InvAmount = Val(dgAdjustinvoice.txtCreditMemoAmount.Text)
                                .InvCartegory = 0
                                .InvDate = Date.Parse(dgAdjustinvoice.mskCreditMemoDate.Text)
                                .InvNotes = dgAdjustinvoice.txtCreditMemoNotes.Text
                                .Period = dgAdjustinvoice.cboCreditMemoPeriod.SelectedValue
                                .InvPostedBy = goUser.userName
                                .InvDueDate = Date.Parse(dgAdjustinvoice.mskCreditMemoDate.Text)
                                .InvRef = Guid.Parse(dgAdjustinvoice.txtCreditMemoInvRef.Text)
                                .InvCurrency = dgAdjustinvoice.cboCreditMemoCurrency.Text
                                .InvActive = True
                                .InvTransType = "DM"
                                .InvDocNumber = dgAdjustinvoice.txtCreditMemoDoc.Text
                                .DC = dgAdjustinvoice.cboCreditMemoAdjust.Text
                                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue.ToString)
                                .InvPaymentType = ""
                                .VatCode = dgVendorInvoices.CurrentRow.Cells("colVatCode").Value







                                'If .PostInvoice() Then
                                '    MsgBox("Invoice Posted")
                                '    cboInvoiceVendor_SelectedIndexChanged(Me, Nothing)

                                'Else
                                '    MsgBox(Inv.TransError)
                                'End If

                            End With

                            If PostCustomerTrans(Inv) Then
                                MsgBox("Transaction Saved")
                            Else
                                MsgBox("Transaction failed : " & customerTransError)

                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try



                    End If

                End With

            ElseIf dgVendorInvoices.CurrentCell.Value = "View" Then
                Dim dgviewInvoice As New dgViewVendorInvoice
                With dgviewInvoice
                    .invoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .isCustomerInvoice = True
                    .Invoicenumber = dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value
                    .AccountNumer = dgVendorInvoices.CurrentRow.Cells("colCustInvVendor").Value
                    .ShowDialog()
                End With


            End If
        Catch ex As Exception

        End Try


    End Sub


    Private Function PostCustomerTrans(Custtrans As GenericTrans) As Boolean

        cnn = New SqlConnection(ConnectionString)

        sql = "spCustomerTransaction"

        Try
            cnn.Open()


            With Custtrans

                cmd = New SqlCommand(sql, cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@company", .InvCompany)
                cmd.Parameters.AddWithValue("@ccnumber", .InvVendorAccNumber)
                cmd.Parameters.AddWithValue("@doc", .InvDocNumber)
                cmd.Parameters.AddWithValue("@invamount", .InvAmount)
                cmd.Parameters.AddWithValue("@period", .Period)
                cmd.Parameters.AddWithValue("@InvDate", .InvDate)
                cmd.Parameters.AddWithValue("@InvDueDate", .InvDueDate)
                cmd.Parameters.AddWithValue("@InvNotes", .InvNotes)
                cmd.Parameters.AddWithValue("@InvRef", .InvRef)
                cmd.Parameters.AddWithValue("@User", goUser.userName)
                cmd.Parameters.AddWithValue("@InvCartegory", .InvCartegory)
                cmd.Parameters.AddWithValue("@TransType", .InvTransType)

                cmd.Parameters.AddWithValue("@InvCurrency", .InvCurrency)
                cmd.Parameters.AddWithValue("@Active", .InvActive)
                cmd.Parameters.AddWithValue("@bankAccount", .InvBankAccount)
                cmd.Parameters.AddWithValue("@PayType", .InvPaymentType)
                cmd.Parameters.AddWithValue("@dc", .DC)
                cmd.Parameters.AddWithValue("@vatcode", .VatCode)
            End With

            cmd.ExecuteNonQuery()

            '      CustomersTableAdapter.Fill(DsAccountsReceivable.Customers)
            Return True


        Catch ex As Exception
            customerTransError = ex.Message
        Finally
            cnn.Close()
        End Try

        Return False

    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim payinvoice As dsAccountsReceivable.CustomerTransactionsRow
        Dim Invoices As New List(Of dsAccountsReceivable.CustomerTransactionsRow)
        For Each rw As DataGridViewRow In dgPayInvoice.Rows
            If rw.Cells("chkPayInvoice").Value = True Then
                '    payinvoice = New dsAccountsPayable.VendorInvoicesRow
                payinvoice = DsAccountsReceivable.CustomerTransactions.Where(Function(x) x.InvRef = rw.Cells("ColCustInvRef").Value).SingleOrDefault()
                payinvoice.InvDocNumber = rw.Cells("colPayDocNumber").Value
                payinvoice.InvNotes = rw.Cells("ColPayNotes").Value
                payinvoice.InvAmount = rw.Cells("colInvPayAmnt").Value
                payinvoice.CustAccNumber = rw.Cells("ColPayCustomerAcc").Value
                Invoices.Add(payinvoice)

            End If

        Next

        '   Invoices = Invoices.OrderBy(Function(x) x.InvBalance).ToList()

        Dim TotalToBePaid As Double = Invoices.Sum(Function(x) x.InvAmount)


        Dim amnt As Double = Val(txtPaymentAmnt.Text)

        If TotalToBePaid > amnt Then
            MsgBox("Total to be paid for all invoices is greater than the available Amount")
        End If

        Dim invcount As Integer = 0
        Dim paidamount As Double
        For Each inv In Invoices

            If amnt <= 0 Then
                Exit For
            End If

            paidamount = inv.InvAmount

            'post amount 


            Dim Inv2 As New GenericTrans

            Try
                With Inv2
                    .InvVendorAccNumber = inv.CustAccNumber
                    .InvAmount = paidamount
                    .InvCartegory = inv.InvCartegory
                    .InvDate = Date.Parse(mskInvPayDate.Text)
                    .InvNotes = inv.InvNotes
                    .Period = cboInvPayPeriod.SelectedValue
                    .InvPostedBy = goUser.userName
                    .InvDueDate = Date.Parse(mskInvPayDate.Text)
                    .InvRef = inv.InvRef
                    .InvCurrency = cboPayCurrency.Text
                    .InvActive = True
                    .InvTransType = "R"
                    .InvDocNumber = inv.InvDocNumber
                    .InvBankAccount = Long.Parse(cboCustomerPaymentsPayto.SelectedValue)
                    .InvPaymentType = "I"
                    .InvCompany = Guid.Parse(cboPayorCompany.SelectedValue)
                    .DC = "C"




                End With


                If PostCustomerTrans(Inv2) Then
                    MsgBox("Payment Posted for Invoice " & inv.InvoiceNumber)
                    invcount += 1
                    amnt -= inv.InvAmount
                Else
                    MsgBox("Payment Failed for Invoice " & inv.InvoiceNumber & " " & customerTransError)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ' post balance








        Next

        MsgBox(invcount & " invoices successfully payed ")
        If invcount > 0 Then
            btnCustomerPaySearch_Click(Me, Nothing)
        End If



    End Sub


    Private Sub btnPayNonInv_Click(sender As Object, e As EventArgs) Handles btnPayNonInv.Click
        Dim amnt As Decimal = Val(txtPaymentAmnt.Text)


        'post amount 


        Dim Inv2 As New GenericTrans

        Try
            With Inv2
                .InvVendorAccNumber = cboPaymentsCustomer.SelectedValue
                .InvAmount = amnt
                .InvCartegory = Long.Parse(cboUnivoicedPayCartegory.SelectedValue)
                .InvDate = Date.Parse(mskInvPayDate.Text)
                .InvNotes = txtPayComment.Text
                .Period = cboInvPayPeriod.SelectedValue
                .InvPostedBy = goUser.userName
                .InvDueDate = Date.Parse(mskInvPayDate.Text)
                .InvCurrency = cboPayCurrency.Text
                .InvActive = True
                .InvTransType = "R"
                .InvDocNumber = txtPayReceipt.Text
                .InvBankAccount = Long.Parse(cboCustomerPaymentsPayto.SelectedValue)
                .InvPaymentType = "U"
                .DC = "C"
                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue.ToString)
                .VatCode = Guid.Parse(cboPaymentsVat.SelectedValue)



            End With


            If PostCustomerTrans(Inv2) Then
                MsgBox("Payment Posted for Customer " & cboPaymentsCustomer.SelectedValue)

                Me.CustomerTransactionsTableAdapter.Fill(DsAccountsReceivable.CustomerTransactions)

                btnCustomerPaySearch_Click(Me, Nothing)


            Else
                MsgBox("Payment Failed for Vendor " & cboPaymentsCustomer.SelectedValue & " " & customerTransError)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub cboPayCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayCurrency.SelectedIndexChanged
        Try
            cboCustomerPaymentsPayto.DataSource = Nothing
            With cboCustomerPaymentsPayto
                .DataSource = ChartOfAccounts(" where c.acctype in ('Bank') and c.currency = '" & cboPayCurrency.Text & "' and c.blocked = 0")
                .DisplayMember = "Text"
                .ValueMember = "Value"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            txtCustomerSearch.Clear()
            CustomersTableAdapter.Fill(DsAccountsReceivable.Customers)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub cboInvoiceCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInvoiceCompany.SelectedIndexChanged

    End Sub

    Private Sub chkDisplayCncelledInvoices_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayCncelledInvoices.CheckedChanged, btnCustInvoiceSearch.Click
        Dim strInvOptions As String = ""
        Dim strwhere As String = ""
        Try

            If Not chkDisplayCncelledInvoices.Checked Then

                strInvOptions = " and i.invActive = 1"

            End If

            strwhere = "where  concat(i.CustAccNumber,'',C.Description,'',i.invoicenumber,'',i.invpostedby,'',i.invDocnumber,'',ContactName,'',ContactNumber,'',Address,'',Email) like '%" & txtCustInvoiceSearchh.Text & "%'" & strInvOptions & " and i.InvTransType = 'I'      order by i.invpostdate desc"

            CustomerTransactionsTableAdapter.FillCustomerTransactions(DsAccountsReceivable.CustomerTransactions, strwhere)

            gbCustomerInvoice.Text = Val(DsAccountsReceivable.CustomerTransactions.Count) & " Invoices Displayed."

            '  Dim cart As String = DsAccountsPayable.Vendors.Where(Function(x) x.AccNumber = cboInvoiceVendor.SelectedValue).Select(Function(y) y.AccountGroup).SingleOrDefault()

        Catch ex As Exception

        End Try

        FormatInvoiceGrig()
    End Sub

    Private Sub btnCustInvoiceRefeesh_Click(sender As Object, e As EventArgs) Handles btnCustInvoiceRefeesh.Click
        txtCustInvoiceSearchh.Clear()
        chkDisplayCncelledInvoices_CheckedChanged(Me, Nothing)
    End Sub

    Private Sub txtCustInvoiceSearchh_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustInvoiceSearchh.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkDisplayCncelledInvoices_CheckedChanged(Me, Nothing)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        Select Case TabControl1.SelectedTab.Name
            Case TabControl1.TabPages().Item("tbCustomerInvoice").Name
                chkDisplayCncelledInvoices_CheckedChanged(Me, Nothing)
            Case TabControl1.TabPages().Item("tbCustomers").Name
                Button3_Click(Me, Nothing)
            Case TabControl1.TabPages().Item("tbCustomerPayment").Name
                btnCustomerPaySearch_Click(Me, Nothing)
        End Select

    End Sub

    Private Sub btnSearchVendor_Click(sender As Object, e As EventArgs) Handles btnSearchVendor.Click

    End Sub

    Private Sub dgVendorInvoices_Sorted(sender As Object, e As EventArgs) Handles dgVendorInvoices.Sorted
        FormatInvoiceGrig()
    End Sub

    Private Sub cboPaymentsCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentsCustomer.SelectedIndexChanged

        Dim cust As ComboItem

        cust = cboPaymentsCustomer.SelectedItem

        CustDets = New c_Customer()

        With CustDets

            .TaxCode = CType(cust.Ref, c_Customer).TaxCode

            cboPaymentsVat.Text = .TaxCode

        End With

    End Sub

    Private Sub btnCustomerPaySearch_Click(sender As Object, e As EventArgs) Handles btnCustomerPaySearch.Click, chkShowPayments.CheckedChanged, cboPayTransType.SelectedIndexChanged
        Dim strOptions As String = ""
        Dim strWhere As String = ""

        If cboPayTransType.Text = "Invoiced" Then

            If Not chkShowPayments.Checked Then
                strOptions = " and i.invtranstype='I' And i.invcleared = 0  "
            Else
                strOptions = " and  ((i.invtranstype = 'R' and i.invpaymenttype = 'I') or (i.invTransType = 'I' And i.invcleared = 0 ))  "
            End If

            strWhere = " where    concat(i.CustAccNumber,'',C.Description,'',i.invoicenumber,'',i.invpostedby,'',i.invDocnumber,'',contactname,'',contactnumber,'',email,'',address) like '%" & txtCustomerPaySearch.Text & "%' and i.invactive = 1  " & strOptions

            CustomerTransactionsTableAdapter.FillCustomerTransactions(DsAccountsReceivable.CustomerTransactions, strWhere)
            pnlPay.Visible = True
            pnlInvoicedPayment.Visible = True
            pnlUnimvoicedPayment.Visible = False

        ElseIf cboPayTransType.Text = "UnInvoiced" Then

            If Not chkShowPayments.Checked Then
                strOptions = " and i.invtranstype='I' And i.invcleared = 0  "

                pnlInvoicedPayment.Visible = False
            Else
                '   strOptions = " and  i.invtranstype = 'R'   "
                pnlInvoicedPayment.Visible = True
                strOptions = " and i.invtranstype='R' "

            End If

            strWhere = "where  concat(i.CustAccNumber,'',C.Description,'',i.invoicenumber,'',i.invpostedby,'',i.invDocnumber,'',contactname,'',contactnumber,'',email,'',address) like '%" & txtCustomerPaySearch.Text & "%'" & strOptions & " and  i.invpaymenttype = 'U' and  i.invactive = 1  order by i.invpostdate desc"

            CustomerTransactionsTableAdapter.FillCustomerTransactions(DsAccountsReceivable.CustomerTransactions, strWhere)

            pnlUnimvoicedPayment.Visible = True

        End If
        FormatPaymentGrid()
    End Sub

    Private Sub btnCustomerPaySearchRefresh_Click(sender As Object, e As EventArgs) Handles btnCustomerPaySearchRefresh.Click
        txtCustomerPaySearch.Clear()
        btnCustomerPaySearch_Click(Me, Nothing)
    End Sub

    Private Sub dgPayInvoice_Sorted(sender As Object, e As EventArgs) Handles dgPayInvoice.Sorted
        FormatPaymentGrid()
    End Sub

    Private Sub txtCustomerPaySearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerPaySearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCustomerPaySearch_Click(Me, Nothing)
        End If

    End Sub

    Private Sub dgPayInvoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPayInvoice.CellContentClick
        Try
            If dgPayInvoice.CurrentCell.Value = "View" Then
                Dim dgviewInvoice As New dgViewVendorInvoice
                With dgviewInvoice
                    .invoiceRef = dgPayInvoice.CurrentRow.Cells("ColCustInvRef").Value
                    .AccountNumer = dgPayInvoice.CurrentRow.Cells("ColPayCustomerAcc").Value

                    If dgPayInvoice.CurrentRow.Cells("colInvPayTransType").Value = "R" Then
                        .isCustomerReceipt = True
                    ElseIf dgPayInvoice.CurrentRow.Cells("colInvPayTransType").Value = "I" Then
                        .isCustomerInvoice = True

                    End If



                    .Invoicenumber = dgPayInvoice.CurrentRow.Cells("ColCustInvNumber").Value


                    .ShowDialog()
                End With

            ElseIf dgPayInvoice.CurrentCell.Value = "Reverse" Then


                Dim venInvoice As New GenericTrans


                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgPayInvoice.CurrentRow.Cells("ColCustInvRef").Value
                    .VendorNumber = dgPayInvoice.CurrentRow.Cells("ColPayCustomerAcc").Value
                    .blnCancelInvoice = True

                    .scInvoiceAdjust.Visible = False
                    .scInvoicedCancel.Visible = True
                    .scInvoicedCancel.Dock = DockStyle.Fill
                    .scInvoicedCancel.Panel2Collapsed = True
                    If dgPayInvoice.CurrentRow.Cells("colInvPayTransType").Value = "R" Then
                        .Text = "Cancel Customer Receipt " & dgPayInvoice.CurrentRow.Cells("ColCustInvNumber").Value
                    ElseIf dgPayInvoice.CurrentRow.Cells("colInvPayTransType").Value = "I" Then
                        .Text = "Cancel Customer " & dgPayInvoice.CurrentRow.Cells("colPayInvNumber").Value
                    End If

                    .isVendorTrans = False
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then

                        If MsgBox("Reverse  " & dgPayInvoice.CurrentRow.Cells("ColCustInvNumber").Value & " ?", vbYesNo) = MsgBoxResult.Yes Then
                            With venInvoice
                                .InvRef = Guid.Parse(dgAdjustinvoice.txtCancelInvoiceInvRef.Text)
                                .InvNotes = dgAdjustinvoice.txtCancelInvoiceNotes.Text
                                .InvDocNumber = dgAdjustinvoice.txtCancelInvoiceDoc.Text
                                .InvDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvPostedBy = goUser.userName
                                .InvVendorAccNumber = dgPayInvoice.CurrentRow.Cells("ColPayCustomerAcc").Value
                                .InvAmount = 0
                                .InvCartegory = 0
                                .Period = dgAdjustinvoice.cboCancelInvoicePeriod.SelectedValue

                                .InvDueDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvCurrency = dgPayInvoice.CurrentRow.Cells("colInvPayCurrency").Value

                                .InvActive = True
                                .DC = "D"
                                .InvCompany = Guid.Parse(cboPayorCompany.SelectedValue)
                                .VatCode = Guid.NewGuid
                                .InvPaymentType = "I"
                                If dgPayInvoice.CurrentRow.Cells("colInvPayTransType").Value = "R" Then
                                    .InvTransType = "RR"
                                ElseIf dgPayInvoice.CurrentRow.Cells("colInvPayTransType").Value = "I" Then
                                    .InvTransType = "IR"
                                End If



                                If PostCustomerTrans(venInvoice) Then
                                    MsgBox("Customer Document successfully Cancelled")
                                    btnCustomerPaySearch_Click(Me, Nothing)

                                Else
                                    MsgBox(customerTransError)
                                End If

                            End With
                        End If

                    End If

                End With





            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtInvAmnt_TextChanged(sender As Object, e As EventArgs) Handles txtInvAmnt.TextChanged

    End Sub

    Private Sub txtPaymentAmnt_Validated(sender As Object, e As EventArgs) Handles txtPaymentAmnt.Validated, cboPaymentsVat.SelectedIndexChanged

        If cboPayTransType.Text = "UnInvoiced" Then
            Dim TaxItem As ComboItem
            TaxItem = cboPaymentsVat.SelectedItem

            Dim TaxRate As Double
            Dim TaxIncl As Boolean
            Dim taxamount As Double
            Dim invamount As Double = Val(txtPaymentAmnt.Text)



            With TaxItem
                TaxRate = CType(.Ref, c_Taxes).TaxRate
                TaxIncl = CType(.Ref, c_Taxes).RaxIncl
            End With

            If TaxIncl Then
                taxamount = (TaxRate / (TaxRate + 1)) * invamount
                txtPaymentsVat.Text = Math.Round(taxamount, 2)
                txtPaymentsNetAmount.Text = Math.Round(invamount - taxamount, 2)
                lbPaymentsNet.Text = "Amount Before Tax: "

            Else

                taxamount = TaxRate * invamount
                txtPaymentsVat.Text = Math.Round(taxamount, 2)
                txtPaymentsNetAmount.Text = Math.Round(invamount + taxamount, 2)
                lbPaymentsNet.Text = "Amount After Tax: "

            End If

        End If

    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgVendorInvoices_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgVendorInvoices.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPayInvoice_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgPayInvoice.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TbCustContact_Click(sender As Object, e As EventArgs) Handles TbCustContact.Click

    End Sub
End Class