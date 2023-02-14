Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports Miscelleneous
Imports RevoModelC

Public Class frmLiabilities
    '  Public ovendor As Vendor
    Public frmmain As Form

    Public VendorTransError As String
    Private VenDets As c_Vendor
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ovendor As Vendor = New Vendor()
        Try
            With ovendor
                .Description = txtVendorName.Text
                .ContactName = txtVendorContName.Text
                .ContactNumber = txtVendorContNummber.Text
                .Address = txtVendorAddress.Text
                .Country = txtVendorCountry.Text
                .BankDetails = txtVendorBankDetails.Text
                .City = txtVendorCity.Text
                .Currency = cboVendorCurrency.Text
                .Email = txtVendorEmail.Text
                .Notes = txtVendorNotes.Text
                .Blocked = chkVendorIsBLocked.Checked
                Try
                    .VendorCompany = Guid.Parse(cboVendorCompany.SelectedValue)
                Catch ex As Exception
                    Throw New Exception("Invalid Vendor Company")
                End Try
                Try
                    .PaymentTerms = Guid.Parse(PaymentTermsComboBox.SelectedValue)
                Catch ex As Exception
                    Throw New Exception("Invalid Payment Terms")
                End Try

                Try
                    .VatAccount = Long.Parse(cboVendorVatAccount.SelectedValue)
                Catch ex As Exception
                    Throw New Exception("Invalid VAT Account")
                End Try

                .TaxReg = TaxRegTextBox.Text
                Try
                    .TaxCode = Guid.Parse(TaxCodeComboBox.SelectedValue)
                Catch ex As Exception
                    Throw New Exception("Invalid VAT Code")
                End Try

                '       .AccRef = IIf(txtVendorAccRef.Text = "", Guid.NewGuid, txtVendorAccRef)

                Try
                    .AccRef = Guid.Parse(txtVendorAccRef.Text)
                Catch ex As Exception
                    .AccRef = Guid.NewGuid
                End Try
                .AccountNumber = "0"
                .AccountGroup = 0
                If SaveAccount(ovendor) Then
                    MsgBox("Vendor Saved")
                    VendorsTableAdapter.Fill(DsAccountsPayable.Vendors)
                    loadVendors()
                Else
                    MsgBox(VendorTransError)
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub


    Private Function SaveAccount(ven As Vendor) As Boolean
        cnn = New SqlConnection(ConnectionString)

        sql = "spInsertVendor"

        Try
            cnn.Open()


            cmd = New SqlCommand(sql, cnn)
            With ven
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@accname", .Description)
                cmd.Parameters.AddWithValue("@AccContact", .ContactName)
                cmd.Parameters.AddWithValue("@ContNumber", .ContactNumber)
                cmd.Parameters.AddWithValue("@email", .Email)
                cmd.Parameters.AddWithValue("@address", .Address)
                cmd.Parameters.AddWithValue("@city", .City)
                cmd.Parameters.AddWithValue("@country", .Country)
                cmd.Parameters.AddWithValue("@BankDetails", .BankDetails)
                cmd.Parameters.AddWithValue("@currency", .Currency)
                cmd.Parameters.AddWithValue("@notes", .Notes)
                cmd.Parameters.AddWithValue("@blocked", .Blocked)




                cmd.Parameters.AddWithValue("@accref", .AccRef)


                cmd.Parameters.AddWithValue("@company", .VendorCompany)

                cmd.Parameters.AddWithValue("@taxcode", .TaxCode)
                cmd.Parameters.AddWithValue("@payterms", .PaymentTerms)
                cmd.Parameters.AddWithValue("@taxreg", .TaxReg)
                cmd.Parameters.AddWithValue("@taxaccount", .VatAccount)
                cmd.Parameters.AddWithValue("@AccGroup", .AccountGroup)
            End With

            cmd.ExecuteNonQuery()

            Return True



        Catch ex As Exception
            VendorTransError = ex.Message
        Finally
            cnn.Close()
        End Try

        Return False
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearchVendor.Click
        Dim serchtext As String = Trim(ttxVendorSearchtext.Text)
        lstResult.DataSource = Nothing
        Dim dsApps As New DataSet()
        Dim taApps As SqlDataAdapter = Nothing
        Dim cmd As New SqlCommand
        Dim cnn As New SqlConnection(ConnectionString)

        Try


            cnn.Open()

            Dim filter As String = " where concat(Accnumber, ' ' , [name] , ' ' , contactname) like '%" & serchtext & "%'"

            cmd.CommandText = "spSearchVendor"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@filter", filter)



            lstResult.Visible = True

            taApps = New SqlDataAdapter(cmd)
            taApps.Fill(dsApps)

            lstResult.DataSource = dsApps.Tables(0)
            lstResult.DisplayMember = "Name"
            lstResult.ValueMember = "AccNumber"

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cnn.Close()

        End Try

    End Sub

    Private Sub lstResult_DoubleClick(sender As Object, e As EventArgs) Handles lstResult.DoubleClick
        ttxVendorSearchtext.Text = lstResult.SelectedValue
        lstResult.DataSource = Nothing

        lstResult.Visible = False

        VendorsTableAdapter.FillByVendorFilter(DsAccountsPayable.Vendors, " where accnumber = '" & ttxVendorSearchtext.Text & "'")
    End Sub

    Private Sub ttxSearchtext_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles ttxVendorSearchtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Me, Nothing)
        ElseIf e.KeyCode = Keys.Down Then
            If lstResult.Items.Count > 0 Then
                lstResult.SetSelected(0, True)
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            lstResult.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Inv As New GenericTrans

        Try
            With Inv
                .InvVendorAccNumber = cboInvoiceVendor.SelectedValue
                .InvAmount = txtInvAmnt.Text
                .InvCartegory = cboInvCartegory.SelectedValue
                .InvDate = Date.Parse(mskInvDate.Text)
                .InvNotes = txtInvNotes.Text
                .Period = cboInvPeriod.SelectedValue
                .InvPostedBy = goUser.userName
                .InvDueDate = Date.Parse(mskInvDueDate.Text)
                .InvRef = Guid.NewGuid
                .InvCurrency = cboInvCurrency.Text
                .InvActive = True
                .InvTransType = "I"
                .InvDocNumber = txtInvNumber.Text
                .DC = "C"
                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue)
                .VatCode = Guid.Parse(cboVenVatcode.SelectedValue)
                .InvPaymentType = "I"



                If PostVendorTrans(Inv) Then
                    MsgBox("Invoice Posted")
                    Button5_Click(Me, Nothing)

                Else
                    MsgBox(VendorTransError)
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub LoadCurrencies()
        With cboInvCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboVendorCurrency
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

    Private Sub loadVendors()

        '  Dim Vens As List(Of ComboItem) = Vendors()

        With cboInvoiceVendor
            .DataSource = Vendors()
            .DisplayMember = "Text"
            .ValueMember = "Value"
            chkDisplayCncelledInvoices_CheckedChanged(cboInvoiceVendor, Nothing)
        End With



        With cboPaymentsVendor
            .DataSource = Vendors()
            .DisplayMember = "Text"
            .ValueMember = "Value"

            ComboBox1_SelectedIndexChanged(chkShowPayments, Nothing)
            '        cboPaymentsVendor(Me, Nothing)
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

        With cboVenStatCurrentPeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


    End Sub

    Private Sub LoadAccountCartegories()

        With cboInvCartegory
            .DataSource = ChartOfAccounts(" where acctype = 'Expense' and accountnumber not in (select isnull(parentaccount,'') from chartofaccounts)  ")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboUnivoicedPayCartegory
            .DataSource = ChartOfAccounts(" where acctype = 'Expense' and accountnumber not in (select isnull(parentaccount,'') from chartofaccounts)")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboVendorVatAccount
            .DataSource = ChartOfAccounts(" where acctype = 'OtherExpense'")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With



    End Sub
    Private Sub LoadPaymentTerms()
        Dim terms As List(Of ComboItem) = PaymentTerms()
        With PaymentTermsComboBox
            .DataSource = terms
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With
    End Sub

    Private Sub LoadAccountingCompanies()


        With cboVendorCompany
            .DataSource = AccountingCompanies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboExpenseCompany
            .DataSource = AccountingCompanies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboInvoiceCompany
            .DataSource = AccountingCompanies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


    End Sub
    Private Sub LoadDatserts()
        VendorsTableAdapter.Fill(DsAccountsPayable.Vendors)


    End Sub

    Private Sub LoadVat()

        With TaxCodeComboBox
            .DataSource = VATS()
            .DisplayMember = "Text"
            .ValueMember = "Value"

        End With

        With cboVenVatcode
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


    Private Sub frmAccountsPayables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsCoA.GLStatement' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsAccountsPayable.VendorStatement' table. You can move, or remove it, as needed.
        '    Me.VendorStatementTableAdapter.Fill(Me.DsAccountsPayable.VendorStatement)
        'TODO: This line of code loads data into the 'DsBanks.Banks' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsAccountsSettings.AccountCartegories' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'DsAccountsPayable.VendorInvoices' table. You can move, or remove it, as needed.
        '   Me.VendorInvoicesTableAdapter.Fill(Me.DsAccountsPayable.VendorInvoices)

        Prepareform(Me, frmmain, False)




        cboPayTransType.Text = "Invoiced"
        '     MdiParent = frmMain


    End Sub

    Public Sub Init()
        LoadCurrencies()
        loadAccountingPeriods()
        LoadAccountCartegories()
        LoadAccountingCompanies()
        LoadVat()
        LoadPaymentTerms()

        loadVendors()

        LoadDatserts()
        Me.ReportViewer1.RefreshReport()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VendorsTableAdapter.Fill(DsAccountsPayable.Vendors)
        ttxVendorSearchtext.Clear()
    End Sub


    Private Sub clearInvoice()
        txtInvNumber.Clear()
        txtInvAmnt.Clear()
    End Sub

    Private Sub dgFessDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVendorInvoices.CellContentClick

        Try


            If dgVendorInvoices.CurrentCell.Value = "Edit" Then
                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .VendorNumber = dgVendorInvoices.CurrentRow.Cells("colInvVendorNumber").Value
                    .blnEditInvoice = True
                    .scInvoiceAdjust.Visible = True
                    .scInvoicedCancel.Visible = False
                    .scInvoiceAdjust.Dock = DockStyle.Fill
                    .scInvoiceAdjust.Panel1Collapsed = True
                    .Text = "Edit Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value
                    .isVendorTrans = True
                    .ShowDialog()

                    If .DialogResult = DialogResult.OK Then

                        Dim Inv As New GenericTrans

                        Try
                            With Inv
                                .InvVendorAccNumber = dgAdjustinvoice.cboVendorCCOUNT.SelectedValue
                                .InvAmount = dgAdjustinvoice.txtInvAmnt.Text
                                .InvCartegory = dgVendorInvoices.CurrentRow.Cells("colInvCartegory").Value
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
                                .DC = "C"
                                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue)
                                .VatCode = Guid.Parse(cboVenVatcode.SelectedValue)
                                .InvPaymentType = "I"




                                If PostVendorTrans(Inv) Then
                                    MsgBox("Invoice Posted")
                                    Button5_Click(Me, Nothing)

                                Else
                                    MsgBox(VendorTransError)
                                End If

                            End With
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try



                    End If

                End With
            ElseIf dgVendorInvoices.CurrentCell.Value = "Reverse" Then

                Dim venInvoice As New GenericTrans


                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .VendorNumber = dgVendorInvoices.CurrentRow.Cells("colInvVendorNumber").Value
                    .blnCancelInvoice = True

                    .scInvoiceAdjust.Visible = False
                    .scInvoicedCancel.Visible = True
                    .scInvoicedCancel.Dock = DockStyle.Fill
                    .scInvoicedCancel.Panel2Collapsed = True
                    .Text = "Cancel Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value
                    .isVendorTrans = True
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then

                        If MsgBox("Cancel Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value & " ?", vbYesNo) = MsgBoxResult.Yes Then
                            With venInvoice
                                .InvRef = Guid.Parse(dgAdjustinvoice.txtCancelInvoiceInvRef.Text)
                                .InvNotes = dgAdjustinvoice.txtCancelInvoiceNotes.Text
                                .InvDocNumber = dgAdjustinvoice.txtCancelInvoiceDoc.Text
                                .InvDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvTransType = "IR"
                                .InvPostedBy = goUser.userName
                                .InvVendorAccNumber = dgVendorInvoices.CurrentRow.Cells("colInvVendorNumber").Value
                                .InvAmount = 0
                                .InvCartegory = dgVendorInvoices.CurrentRow.Cells("colInvCartegory").Value
                                .Period = 1
                                .InvDueDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvCurrency = cboInvCurrency.Text
                                .InvActive = True
                                .DC = "D"
                                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue)
                                .VatCode = Guid.Parse(cboVenVatcode.SelectedValue)
                                .InvPaymentType = "I"

                                If PostVendorTrans(venInvoice) Then
                                    MsgBox("Invoice successfully Cancelled")
                                    Button5_Click(Me, Nothing)

                                Else
                                    MsgBox(VendorTransError)
                                End If

                            End With
                        End If

                    End If

                End With




            ElseIf dgVendorInvoices.CurrentCell.Value = "CreditMemo" Then

                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .VendorNumber = dgVendorInvoices.CurrentRow.Cells("colInvVendorNumber").Value
                    .blnAdjustInvoice = True
                    .scInvoiceAdjust.Visible = True
                    .scInvoicedCancel.Visible = False
                    .scInvoiceAdjust.Dock = DockStyle.Fill
                    .scInvoiceAdjust.Panel2Collapsed = True

                    .mskCreditMemoDate.Text = Now.Date.ToShortDateString()
                    .cboCreditMemoAdjust.Text = "D"
                    .Text = "Credit Memo for Invoice " & dgVendorInvoices.CurrentRow.Cells("colInvNumber").Value
                    .isVendorTrans = True
                    .ShowDialog()


                    If .DialogResult = DialogResult.OK Then

                        Dim Inv As New GenericTrans

                        Try
                            With Inv
                                .InvVendorAccNumber = dgAdjustinvoice.cboCreditMemoVendor.SelectedValue
                                If dgAdjustinvoice.cboCreditMemoAdjust.Text = "" Then
                                    MsgBox("Select Adjustment Type")
                                    Exit Sub
                                End If
                                .InvAmount = Val(dgAdjustinvoice.txtCreditMemoAmount.Text)
                                .InvDate = Date.Parse(dgAdjustinvoice.mskCreditMemoDate.Text)
                                .InvNotes = dgAdjustinvoice.txtCreditMemoNotes.Text
                                .Period = dgAdjustinvoice.cboCreditMemoPeriod.SelectedValue
                                .InvPostedBy = goUser.userName
                                .InvDueDate = Date.Parse(dgAdjustinvoice.mskCreditMemoDate.Text)
                                .InvRef = Guid.Parse(dgAdjustinvoice.txtCreditMemoInvRef.Text)
                                .InvCurrency = dgAdjustinvoice.cboCreditMemoCurrency.Text
                                .InvActive = True
                                .InvTransType = "CM"
                                .InvDocNumber = dgAdjustinvoice.txtCreditMemoDoc.Text
                                .DC = dgAdjustinvoice.cboCreditMemoAdjust.Text
                                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue.ToString)
                                .InvCartegory = Long.Parse(dgVendorInvoices.CurrentRow.Cells("colInvCartegory").Value)
                                .InvPostedBy = goUser.userName
                                .InvActive = True
                                .VatCode = Guid.Parse(cboVenVatcode.SelectedValue)
                                .InvPaymentType = "I"


                                If PostVendorTrans(Inv) Then
                                    MsgBox("Invoice Posted")
                                    Button5_Click(Me, Nothing)

                                Else
                                    MsgBox(VendorTransError)
                                End If

                            End With
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try



                    End If

                End With

            ElseIf dgVendorInvoices.CurrentCell.Value = "View" Then
                Dim dgviewInvoice As New dgViewVendorInvoice
                With dgviewInvoice
                    .invoiceRef = dgVendorInvoices.CurrentRow.Cells("colInvRef").Value
                    .AccountNumer = dgVendorInvoices.CurrentRow.Cells("colInvVendorNumber").Value
                    .isVendorInvoice = True
                    .Invoicenumber = dgVendorInvoices.CurrentRow.Cells("colInvnumber").Value


                    .ShowDialog()
                End With


            End If

        Catch ex As Exception

        End Try



    End Sub



    Private Function PostVendorTrans(Custtrans As GenericTrans) As Boolean

        cnn = New SqlConnection(ConnectionString)

        sql = "spInsertVendorInvoice"

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
            VendorTransError = ex.Message
        Finally
            cnn.Close()
        End Try

        Return False

    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayTransType.SelectedIndexChanged, chkShowPayments.CheckedChanged, btnPayInvoiceSearch.Click

        Dim strwhere As String = ""
        Dim strOptions As String = ""



        If cboPayTransType.Text = "Invoiced" Then
            If Not chkShowPayments.Checked Then
                strOptions = " and i.invtranstype='I' And i.invcleared = 0  "
            Else
                strOptions = " and  ((i.invtranstype = 'R' and i.invpaymenttype = 'I') or (i.invTransType = 'I' And i.invcleared = 0 ))  "
            End If

            strwhere = "where  concat(i.invVendorAccNumber,'',v.Description,'',i.invoicenumber,'',i.invpostedby,'',i.invDocnumber,'',contactname,'',contactnumber,'',email,'',address) like '%" & txtPayInvoiceSearchh.Text & "%'" & strOptions & " and i.invactive = 1   order by i.invpostdate desc"

            VendorInvoicesTableAdapter.FillByInvoice(DsAccountsPayable.VendorInvoices, strwhere)
            pnlPay.Visible = True
            pnlInvoicedExpenditure.Visible = True
            pnlUnimvoicedExpense.Visible = False

        ElseIf cboPayTransType.Text = "UnInvoiced" Then
            If Not chkShowPayments.Checked Then
                strOptions = " and i.invtranstype='I' And i.invcleared = 0  "

                pnlInvoicedExpenditure.Visible = False
            Else
                strOptions = " and  i.invtranstype = 'R'   "
                pnlInvoicedExpenditure.Visible = True
            End If

            strwhere = "where  concat(i.invVendorAccNumber,'',v.Description,'',i.invoicenumber,'',i.invpostedby,'',i.invDocnumber,'',contactname,'',contactnumber,'',email,'',address) like '%" & txtPayInvoiceSearchh.Text & "%'" & strOptions & " and  i.invpaymenttype = 'U' and  i.invactive = 1  order by i.invpostdate desc"
            VendorInvoicesTableAdapter.FillByInvoice(DsAccountsPayable.VendorInvoices, strwhere)
            pnlUnimvoicedExpense.Visible = True



        End If







        FormatPaymentGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPayInvoice.CellContentClick
        Try
            If dgPayInvoice.CurrentCell.Value = "View" Then
                Dim dgviewInvoice As New dgViewVendorInvoice
                With dgviewInvoice
                    .invoiceRef = dgPayInvoice.CurrentRow.Cells("ColPayInvRef").Value
                    .AccountNumer = dgPayInvoice.CurrentRow.Cells("colInvPayAccountNumber").Value

                    If dgPayInvoice.CurrentRow.Cells("ColPayInvTransType").Value = "R" Then
                        .isVendorReceipt = True
                    ElseIf dgPayInvoice.CurrentRow.Cells("ColPayInvTransType").Value = "I" Then
                        .isVendorInvoice = True

                    End If



                    .Invoicenumber = dgPayInvoice.CurrentRow.Cells("colPayInvNumber").Value


                    .ShowDialog()
                End With

            ElseIf dgPayInvoice.CurrentCell.Value = "Reverse" Then


                Dim venInvoice As New GenericTrans


                Dim dgAdjustinvoice As New dgAdjustInvoice
                With dgAdjustinvoice
                    .InvoiceRef = dgPayInvoice.CurrentRow.Cells("ColPayInvRef").Value
                    .VendorNumber = dgPayInvoice.CurrentRow.Cells("colInvPayAccountNumber").Value
                    .blnCancelInvoice = True

                    .scInvoiceAdjust.Visible = False
                    .scInvoicedCancel.Visible = True
                    .scInvoicedCancel.Dock = DockStyle.Fill
                    .scInvoicedCancel.Panel2Collapsed = True
                    If dgPayInvoice.CurrentRow.Cells("ColPayInvTransType").Value = "R" Then
                        .Text = "Cancel Vendor Receipt " & dgPayInvoice.CurrentRow.Cells("colPayInvNumber").Value
                    ElseIf dgPayInvoice.CurrentRow.Cells("ColPayInvTransType").Value = "I" Then
                        .Text = "Cancel Invoice " & dgPayInvoice.CurrentRow.Cells("colPayInvNumber").Value
                    End If

                    .isVendorTrans = True
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then

                        If MsgBox("Cancel  " & dgPayInvoice.CurrentRow.Cells("colPayInvNumber").Value & " ?", vbYesNo) = MsgBoxResult.Yes Then
                            With venInvoice
                                .InvRef = Guid.Parse(dgAdjustinvoice.txtCancelInvoiceInvRef.Text)
                                .InvNotes = dgAdjustinvoice.txtCancelInvoiceNotes.Text
                                .InvDocNumber = dgAdjustinvoice.txtCancelInvoiceDoc.Text
                                .InvDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvPostedBy = goUser.userName
                                .InvVendorAccNumber = dgPayInvoice.CurrentRow.Cells("colInvPayAccountNumber").Value
                                .InvAmount = 0
                                .InvCartegory = Long.Parse(dgPayInvoice.CurrentRow.Cells("colExpCartegory").Value)
                                .Period = 1

                                .InvDueDate = Date.Parse(dgAdjustinvoice.mskCancelInvoiceDate.Text)
                                .InvCurrency = cboInvCurrency.Text
                                .InvActive = True
                                .DC = "D"
                                .InvCompany = Guid.Parse(cboExpenseCompany.SelectedValue)
                                .VatCode = Guid.NewGuid
                                .InvPaymentType = "I"
                                If dgPayInvoice.CurrentRow.Cells("ColPayInvTransType").Value = "R" Then
                                    .InvTransType = "RR"
                                ElseIf dgPayInvoice.CurrentRow.Cells("ColPayInvTransType").Value = "I" Then
                                    .InvTransType = "IR"
                                End If



                                If PostVendorTrans(venInvoice) Then
                                    MsgBox("Vendor Payment successfully Cancelled")
                                    ComboBox1_SelectedIndexChanged(Me, Nothing)

                                Else
                                    MsgBox(VendorTransError)
                                End If

                            End With
                        End If

                    End If

                End With





            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboPayCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayCurrency.SelectedIndexChanged
        Try
            cboVendorPaymentsPayFrom.DataSource = Nothing
            With cboVendorPaymentsPayFrom
                .DataSource = ChartOfAccounts(" where c.acctype in ('Bank','CreditCard') and c.currency = '" & cboPayCurrency.Text & "' and c.blocked = 0")
                .DisplayMember = "Text"
                .ValueMember = "Value"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboVendorPaymentsPayFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendorPaymentsPayFrom.SelectedIndexChanged
        Dim balance As Double = 0

        Dim bank As c_CoA = CType(cboVendorPaymentsPayFrom.SelectedItem, ComboItem).Ref

        balance = bank.Balance

        'BanksTableAdapter.Fill(DsBanks.Banks)
        ' Try
        '     balance = DsBanks.Banks.Where(Function(x) x.AccountNumber = cboVendorPaymentsPayFrom.SelectedValue).Select(Function(y) y.Balance).SingleOrDefault()

        ' Catch ex As Exception

        ' End Try
        txtBankBalance.Text = balance

    End Sub

    Private Sub FormatInvoiceGrig()
        For Each rw As DataGridViewRow In dgVendorInvoices.Rows
            If CBool(rw.Cells("colInvActive").Value) = False Then
                rw.DefaultCellStyle.BackColor = Color.Red
                rw.ReadOnly = True
                'Dim btncell As DataGridViewButtonCell
                'btncell = CType(rw.Cells("btnDelete"), DataGridViewButtonCell)



            End If
        Next
    End Sub

    Private Sub FormatPaymentGrid()
        For Each rw As DataGridViewRow In dgPayInvoice.Rows

            Dim btncell As DataGridViewButtonCell
            btncell = CType(rw.Cells("btnPayView"), DataGridViewButtonCell)


            If rw.Cells("ColPayInvTransType").Value = "R" Then
                rw.ReadOnly = True
                rw.DefaultCellStyle.BackColor = Color.Gray
            ElseIf rw.Cells("ColPayInvTransType").Value = "I" Then
                rw.ReadOnly = False
            End If









        Next
    End Sub

    Private Sub dgVendorInvoices_Sorted(sender As Object, e As EventArgs) Handles dgVendorInvoices.Sorted
        FormatInvoiceGrig()
    End Sub


    Private Function ValidInvPayTypes() As Boolean
        For Each rw As DataGridViewRow In dgPayInvoice.Rows
            If rw.Cells("chkPayInvoice").Value = True Then

                If rw.Cells("ColPayInvTransType").Value = "R" Then
                    Return False
                End If

            End If

        Next
        Return True
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        If Not ValidInvPayTypes() Then
            MsgBox("Payment failed , An Invalid Transaction Type is selected for Payment")
            Exit Sub
        End If

        Dim payinvoice As dsAccountsPayable.VendorInvoicesRow
        Dim Invoices As New List(Of dsAccountsPayable.VendorInvoicesRow)
        For Each rw As DataGridViewRow In dgPayInvoice.Rows
            If rw.Cells("chkPayInvoice").Value = True Then
                '    payinvoice = New dsAccountsPayable.VendorInvoicesRow
                payinvoice = DsAccountsPayable.VendorInvoices.Where(Function(x) x.InvRef = rw.Cells("ColPayInvRef").Value).SingleOrDefault()
                payinvoice.InvDocNumber = rw.Cells("colPayDocNumber").Value
                payinvoice.InvNotes = rw.Cells("ColPayNotes").Value
                payinvoice.InvAmount = rw.Cells("colInvPayAmnt").Value
                payinvoice.InvVendorAccNumber = rw.Cells("colInvPayAccountNumber").Value
                Invoices.Add(payinvoice)

            End If

        Next

        '   Invoices = Invoices.OrderBy(Function(x) x.InvBalance).ToList()

        Dim TotalToBePaid As Double = Invoices.Sum(Function(x) x.InvAmount)


        Dim amnt As Double = Val(txtExpenseAmnt.Text)

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
                    .InvVendorAccNumber = inv.InvVendorAccNumber
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
                    .InvBankAccount = Long.Parse(cboVendorPaymentsPayFrom.SelectedValue)
                    .InvPaymentType = "I"
                    .InvCompany = Guid.Parse(cboExpenseCompany.SelectedValue)
                    .DC = "D"



                    If PostVendorTrans(Inv2) Then
                        MsgBox("Payment Posted for Invoice " & inv.InvoiceNumber)
                        invcount += 1
                        amnt -= inv.InvAmount


                    Else
                        MsgBox("Payment Failed for Invoice " & inv.InvoiceNumber & " " & VendorTransError)
                    End If

                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ' post balance








        Next

        MsgBox(invcount & " invoices successfully payed ")

        If invcount > 0 Then
            Me.VendorInvoicesTableAdapter.Fill(DsAccountsPayable.VendorInvoices)
            ComboBox1_SelectedIndexChanged(Me, Nothing)


        End If


    End Sub



    Private Sub txtBankBalance_Validated(sender As Object, e As EventArgs) Handles txtExpenseAmnt.Validated, cboPaymentsVat.SelectedIndexChanged

        '    pnlInvoicedExpenditure.Enabled = Val(txtBankBalance.Text) >= Val(txtExpenseAmnt.Text) And Val(txtBankBalance.Text) <> 0
        '   pnlUnimvoicedExpense.Enabled = Val(txtBankBalance.Text) >= Val(txtExpenseAmnt.Text) And Val(txtBankBalance.Text) <> 0

        If cboPayTransType.Text = "UnInvoiced" Then
            Dim TaxItem As ComboItem
            TaxItem = cboPaymentsVat.SelectedItem

            Dim TaxRate As Double
            Dim TaxIncl As Boolean
            Dim taxamount As Double
            Dim invamount As Double = Val(txtExpenseAmnt.Text)



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

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            VendorsBindingSource.AddNew()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("Functionality not yet available")
    End Sub

    Private Sub btnPayNonInv_Click(sender As Object, e As EventArgs) Handles btnPayNonInv.Click
        Dim amnt As Decimal = Val(txtExpenseAmnt.Text)


        'post amount 


        Dim Inv2 As New GenericTrans

        Try
            With Inv2
                .InvVendorAccNumber = cboPaymentsVendor.SelectedValue
                .InvAmount = amnt
                .InvCartegory = cboUnivoicedPayCartegory.SelectedValue
                .InvDate = Date.Parse(mskInvPayDate.Text)
                .InvNotes = txtPayComment.Text
                .Period = cboInvPayPeriod.SelectedValue
                .InvPostedBy = goUser.userName
                .InvDueDate = Date.Parse(mskInvPayDate.Text)
                .InvCurrency = cboPayCurrency.Text
                .InvActive = True
                .InvTransType = "R"
                .InvDocNumber = txtPayReceipt.Text
                .InvBankAccount = Long.Parse(cboVendorPaymentsPayFrom.SelectedValue)
                .InvPaymentType = "U"
                .DC = "D"
                .InvCompany = Guid.Parse(cboInvoiceCompany.SelectedValue.ToString)
                .vatcode = Guid.Parse(cboPaymentsVat.SelectedValue)



                If PostVendorTrans(Inv2) Then
                    MsgBox("Payment Posted for vendor " & cboPaymentsVendor.SelectedValue)

                    Me.VendorInvoicesTableAdapter.Fill(DsAccountsPayable.VendorInvoices)

                    ComboBox1_SelectedIndexChanged(Me, Nothing)


                Else
                    MsgBox("Payment Failed for Vendor " & cboPaymentsVendor.SelectedValue & " " & VendorTransError)
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        ' post balance








    End Sub

    Private Sub txtVendorAccNumber_TextChanged(sender As Object, e As EventArgs) Handles txtVendorAccNumber.TextChanged, chkVenStatShowInvoices.CheckedChanged, chkVenStatShowPayments.CheckedChanged, chkVenStatShowReversals.CheckedChanged, cboVenStatCurrentPeriod.SelectedIndexChanged
        Try
            GLStatementTableAdapter.FillByStatement(dsCoA.GLStatement, txtVendorAccNumber.Text, chkVenStatShowPayments.Checked, chkVenStatShowInvoices.Checked, -1, -1, 1, False, "", 1)
            ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgPayInvoice_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgPayInvoice.RowsAdded

        Try



            Dim cboExpenseCart As DataGridViewComboBoxCell = CType(dgPayInvoice.Rows(e.RowIndex).Cells("colExpCartegory"), DataGridViewComboBoxCell)


            cboExpenseCart.DataSource = ChartOfAccounts(" where c.acctype = 'Expense'")
            cboExpenseCart.DisplayMember = "Text"
            cboExpenseCart.ValueMember = "Value"



            Dim btncell As DataGridViewTextBoxCell
            btncell = CType(dgPayInvoice.Rows(e.RowIndex).Cells("colInvPayAmnt"), DataGridViewTextBoxCell)




            If dgPayInvoice.Rows(e.RowIndex).Cells("ColPayInvTransType").Value = "R" Then
                btncell.Value = 0
                btncell.ReadOnly = True
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboUnivoicedPayCartegory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnivoicedPayCartegory.SelectedIndexChanged

    End Sub

    Private Sub cboInvoiceCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInvoiceCompany.SelectedIndexChanged

    End Sub

    Private Sub cboExpenseCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExpenseCompany.SelectedIndexChanged

    End Sub

    Private Sub cboCustVatcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVenVatcode.SelectedIndexChanged, txtInvAmnt.Validated
        Dim TaxItem As ComboItem
        TaxItem = cboVenVatcode.SelectedItem

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

    Private Sub mskInvDate_Validated(sender As Object, e As EventArgs) Handles mskInvDate.Validated
        Dim duedate As Date
        Dim strdueDate As String

        Try
            duedate = DateAdd(DateInterval.Day, VenDets.PaymentTerms, Date.Parse(mskInvDate.Text))

            strdueDate = duedate.ToShortDateString()
            mskInvDueDate.Text = strdueDate

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkDisplayCncelledInvoices_CheckedChanged(sender As Object, e As EventArgs) Handles cboInvoiceVendor.SelectedIndexChanged


        Try
            '  Dim cart As String = DsAccountsPayable.Vendors.Where(Function(x) x.AccNumber = cboInvoiceVendor.SelectedValue).Select(Function(y) y.AccountGroup).SingleOrDefault()
            '      Dim currency As String = DsAccountsPayable.Vendors.Where(Function(x) x.AccNumber = cboInvoiceVendor.SelectedValue).Select(Function(y) y.Currency).SingleOrDefault()


            '  cboInvCartegory.Text = cart
            '   cboInvCurrency.Text = currency



            Dim Ven As ComboItem

            Ven = cboInvoiceVendor.SelectedItem

            VenDets = New c_Vendor()

            With VenDets
                .PaymentTerms = CType(Ven.Ref, c_Vendor).PaymentTerms
                .TaxCode = CType(Ven.Ref, c_Vendor).TaxCode
                cboVenVatcode.Text = .TaxCode
                .Currency = CType(Ven.Ref, c_Vendor).Currency
                cboInvCurrency.Text = .Currency
            End With

        Catch ex As Exception









        End Try

        FormatInvoiceGrig()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnVenInvoiceSearch.Click, chkDisplayCncelledInvoices.CheckedChanged
        Dim strwhere As String

        Dim strInvOptions As String = ""

        If Not chkDisplayCncelledInvoices.Checked Then

            strInvOptions = " and i.invActive = 1"

        End If

        strwhere = "where  concat(i.invVendorAccNumber,'',v.Description,'',i.invoicenumber,'',i.invpostedby,'',i.invDocnumber) like '%" & txtVenInvoiceSearch.Text & "%'" & strInvOptions & " and i.InvTransType = 'I'      order by i.invpostdate desc"

        Me.VendorInvoicesTableAdapter.FillByInvoice(DsAccountsPayable.VendorInvoices, strwhere)

        FormatInvoiceGrig()
    End Sub

    Private Sub txtVenInvoiceSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVenInvoiceSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5_Click(Me, Nothing)
        End If
    End Sub

    Private Sub btnVenInvSearchRefresh_Click(sender As Object, e As EventArgs) Handles btnVenInvSearchRefresh.Click
        txtVenInvoiceSearch.Clear()
        Button5_Click(Me, Nothing)
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged


        Try


            Select Case TabControl2.SelectedTab.Name
                Case TabControl2.TabPages().Item("tbInvoices").Name
                    Button5_Click(Me, Nothing)
                Case TabControl2.TabPages().Item("tbVendorPayments").Name
                    ComboBox1_SelectedIndexChanged(Me, Nothing)
                Case TabControl2.TabPages().Item("tbVendors").Name
                    Button3_Click(Me, Nothing)


            End Select

        Catch ex As Exception

        End Try


    End Sub

    Private Sub dgPayInvoice_Sorted(sender As Object, e As EventArgs) Handles dgPayInvoice.Sorted
        FormatPaymentGrid()
    End Sub

    Private Sub txtPayInvoiceSearchh_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPayInvoiceSearchh.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1_SelectedIndexChanged(Me, Nothing)
        End If
    End Sub

    Private Sub btnPayInvoiceRefeesh_Click(sender As Object, e As EventArgs) Handles btnPayInvoiceRefeesh.Click
        txtPayInvoiceSearchh.Clear()
        ComboBox1_SelectedIndexChanged(Me, Nothing)
    End Sub

    Private Sub cboPaymentsVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentsVendor.SelectedIndexChanged
        Dim ven As ComboItem

        ven = cboPaymentsVendor.SelectedItem

        VenDets = New c_Vendor

        With VenDets

            .TaxCode = CType(ven.Ref, c_Vendor).TaxCode

            cboPaymentsVat.Text = .TaxCode

        End With
    End Sub

    Private Sub txtExpenseAmnt_TextChanged(sender As Object, e As EventArgs) Handles txtExpenseAmnt.TextChanged

    End Sub

    Private Sub dgPayInvoice_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgPayInvoice.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgVendorInvoices_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgVendorInvoices.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class