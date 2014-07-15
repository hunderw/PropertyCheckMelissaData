<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblInsertedRecords = New System.Windows.Forms.Label()
        Me.lblProcessing = New System.Windows.Forms.Label()
        Me.btnNewRequestArray = New System.Windows.Forms.Button()
        Me.btnSendRequest = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCountyFIPS = New System.Windows.Forms.TextBox()
        Me.lblCountyFIPS = New System.Windows.Forms.Label()
        Me.txtAPN = New System.Windows.Forms.TextBox()
        Me.lblAPN = New System.Windows.Forms.Label()
        Me.txtAddressKey = New System.Windows.Forms.TextBox()
        Me.lblAddressKey = New System.Windows.Forms.Label()
        Me.txtRecordCount = New System.Windows.Forms.TextBox()
        Me.txtMaxRecords = New System.Windows.Forms.TextBox()
        Me.lblMaxrecords = New System.Windows.Forms.Label()
        Me.chkDetailedResponse = New System.Windows.Forms.CheckBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.webBrowserResponse = New System.Windows.Forms.WebBrowser()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(688, 232)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTitle)
        Me.TabPage1.Controls.Add(Me.lblInsertedRecords)
        Me.TabPage1.Controls.Add(Me.lblProcessing)
        Me.TabPage1.Controls.Add(Me.btnNewRequestArray)
        Me.TabPage1.Controls.Add(Me.btnSendRequest)
        Me.TabPage1.Controls.Add(Me.btnInsert)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.txtCountyFIPS)
        Me.TabPage1.Controls.Add(Me.lblCountyFIPS)
        Me.TabPage1.Controls.Add(Me.txtAPN)
        Me.TabPage1.Controls.Add(Me.lblAPN)
        Me.TabPage1.Controls.Add(Me.txtAddressKey)
        Me.TabPage1.Controls.Add(Me.lblAddressKey)
        Me.TabPage1.Controls.Add(Me.txtRecordCount)
        Me.TabPage1.Controls.Add(Me.txtMaxRecords)
        Me.TabPage1.Controls.Add(Me.lblMaxrecords)
        Me.TabPage1.Controls.Add(Me.chkDetailedResponse)
        Me.TabPage1.Controls.Add(Me.txtCustomerID)
        Me.TabPage1.Controls.Add(Me.lblCustomerID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(680, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Property Service "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblInsertedRecords
        '
        Me.lblInsertedRecords.AutoSize = True
        Me.lblInsertedRecords.Location = New System.Drawing.Point(442, 158)
        Me.lblInsertedRecords.Name = "lblInsertedRecords"
        Me.lblInsertedRecords.Size = New System.Drawing.Size(91, 13)
        Me.lblInsertedRecords.TabIndex = 17
        Me.lblInsertedRecords.Text = "Inserted Records:"
        '
        'lblProcessing
        '
        Me.lblProcessing.AutoSize = True
        Me.lblProcessing.Location = New System.Drawing.Point(551, 281)
        Me.lblProcessing.Name = "lblProcessing"
        Me.lblProcessing.Size = New System.Drawing.Size(0, 13)
        Me.lblProcessing.TabIndex = 16
        '
        'btnNewRequestArray
        '
        Me.btnNewRequestArray.Location = New System.Drawing.Point(556, 119)
        Me.btnNewRequestArray.Name = "btnNewRequestArray"
        Me.btnNewRequestArray.Size = New System.Drawing.Size(110, 23)
        Me.btnNewRequestArray.TabIndex = 15
        Me.btnNewRequestArray.Text = "New Request"
        Me.btnNewRequestArray.UseVisualStyleBackColor = True
        '
        'btnSendRequest
        '
        Me.btnSendRequest.Location = New System.Drawing.Point(556, 82)
        Me.btnSendRequest.Name = "btnSendRequest"
        Me.btnSendRequest.Size = New System.Drawing.Size(110, 23)
        Me.btnSendRequest.TabIndex = 14
        Me.btnSendRequest.Text = "Send Request"
        Me.btnSendRequest.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(445, 118)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 13
        Me.btnInsert.Text = "Insert Record"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(445, 83)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtCountyFIPS
        '
        Me.txtCountyFIPS.Location = New System.Drawing.Point(302, 154)
        Me.txtCountyFIPS.Name = "txtCountyFIPS"
        Me.txtCountyFIPS.Size = New System.Drawing.Size(100, 20)
        Me.txtCountyFIPS.TabIndex = 11
        '
        'lblCountyFIPS
        '
        Me.lblCountyFIPS.AutoSize = True
        Me.lblCountyFIPS.Location = New System.Drawing.Point(230, 158)
        Me.lblCountyFIPS.Name = "lblCountyFIPS"
        Me.lblCountyFIPS.Size = New System.Drawing.Size(69, 13)
        Me.lblCountyFIPS.TabIndex = 10
        Me.lblCountyFIPS.Text = "County FIPS:"
        '
        'txtAPN
        '
        Me.txtAPN.Location = New System.Drawing.Point(302, 116)
        Me.txtAPN.Name = "txtAPN"
        Me.txtAPN.Size = New System.Drawing.Size(100, 20)
        Me.txtAPN.TabIndex = 9
        '
        'lblAPN
        '
        Me.lblAPN.AutoSize = True
        Me.lblAPN.Location = New System.Drawing.Point(264, 118)
        Me.lblAPN.Name = "lblAPN"
        Me.lblAPN.Size = New System.Drawing.Size(32, 13)
        Me.lblAPN.TabIndex = 8
        Me.lblAPN.Text = "APN:"
        '
        'txtAddressKey
        '
        Me.txtAddressKey.Location = New System.Drawing.Point(302, 82)
        Me.txtAddressKey.Name = "txtAddressKey"
        Me.txtAddressKey.Size = New System.Drawing.Size(100, 20)
        Me.txtAddressKey.TabIndex = 7
        Me.txtAddressKey.Text = "44202927355"
        '
        'lblAddressKey
        '
        Me.lblAddressKey.AutoSize = True
        Me.lblAddressKey.Location = New System.Drawing.Point(230, 83)
        Me.lblAddressKey.Name = "lblAddressKey"
        Me.lblAddressKey.Size = New System.Drawing.Size(69, 13)
        Me.lblAddressKey.TabIndex = 6
        Me.lblAddressKey.Text = "Address Key:"
        '
        'txtRecordCount
        '
        Me.txtRecordCount.Location = New System.Drawing.Point(537, 155)
        Me.txtRecordCount.Name = "txtRecordCount"
        Me.txtRecordCount.Size = New System.Drawing.Size(21, 20)
        Me.txtRecordCount.TabIndex = 5
        '
        'txtMaxRecords
        '
        Me.txtMaxRecords.Location = New System.Drawing.Point(148, 115)
        Me.txtMaxRecords.Name = "txtMaxRecords"
        Me.txtMaxRecords.Size = New System.Drawing.Size(25, 20)
        Me.txtMaxRecords.TabIndex = 4
        Me.txtMaxRecords.Text = "5"
        '
        'lblMaxrecords
        '
        Me.lblMaxrecords.AutoSize = True
        Me.lblMaxrecords.Location = New System.Drawing.Point(17, 118)
        Me.lblMaxrecords.Name = "lblMaxrecords"
        Me.lblMaxrecords.Size = New System.Drawing.Size(125, 13)
        Me.lblMaxrecords.TabIndex = 3
        Me.lblMaxrecords.Text = "Max Number of Records:"
        '
        'chkDetailedResponse
        '
        Me.chkDetailedResponse.AutoSize = True
        Me.chkDetailedResponse.Location = New System.Drawing.Point(20, 154)
        Me.chkDetailedResponse.Name = "chkDetailedResponse"
        Me.chkDetailedResponse.Size = New System.Drawing.Size(156, 17)
        Me.chkDetailedResponse.TabIndex = 2
        Me.chkDetailedResponse.Text = "Return a detailed response."
        Me.chkDetailedResponse.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(91, 80)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 1
        Me.txtCustomerID.Text = " 106223395"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(17, 83)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(68, 13)
        Me.lblCustomerID.TabIndex = 0
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.webBrowserResponse)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(680, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "XML View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'webBrowserResponse
        '
        Me.webBrowserResponse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowserResponse.Location = New System.Drawing.Point(3, 3)
        Me.webBrowserResponse.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowserResponse.Name = "webBrowserResponse"
        Me.webBrowserResponse.Size = New System.Drawing.Size(674, 343)
        Me.webBrowserResponse.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitle.Location = New System.Drawing.Point(68, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(534, 31)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "Melissa Data Web Service Property Search"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 257)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents chkDetailedResponse As System.Windows.Forms.CheckBox
    Friend WithEvents txtMaxRecords As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxrecords As System.Windows.Forms.Label
    Friend WithEvents txtRecordCount As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressKey As System.Windows.Forms.TextBox
    Friend WithEvents lblAddressKey As System.Windows.Forms.Label
    Friend WithEvents txtAPN As System.Windows.Forms.TextBox
    Friend WithEvents lblAPN As System.Windows.Forms.Label
    Friend WithEvents lblCountyFIPS As System.Windows.Forms.Label
    Friend WithEvents txtCountyFIPS As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnSendRequest As System.Windows.Forms.Button
    Friend WithEvents btnNewRequestArray As System.Windows.Forms.Button
    Friend WithEvents lblProcessing As System.Windows.Forms.Label
    Friend WithEvents webBrowserResponse As System.Windows.Forms.WebBrowser
    Friend WithEvents lblInsertedRecords As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
