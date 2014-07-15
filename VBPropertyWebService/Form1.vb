Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Xml.XmlWriter
Imports System.Xml.Serialization
Imports System.Windows.Forms

Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim request As New VBPropertyWebService.PropertyService.RequestArray
    Dim response As New VBPropertyWebService.PropertyService.ResponseArray
    Dim action As New VBPropertyWebService.PropertyService.ServiceClient
    Dim XmlSer As XmlSerializer
    Dim fs As FileStream
    Dim xmlDoc As New XmlDocument
    Dim MaxArraySize As Integer = 20
    Dim recordcount As Integer = 0

    Private Sub Initialize()
        ' Initialize new instance of Request Array
        ' Change the MaxArraySize value to the maximum number of records you with to insert

        'Set Customer ID and Transmission Reference (Optional)
        ReDim request.Record(MaxArraySize)

        request.CustomerId = txtCustomerID.Text
        request.TransmissionReference = "Testing: DQWS SOAP Sample Code implementation using multiple record inputs."
        If (chkDetailedResponse.Checked) Then
            request.OptPropertyDetail = True

        Else
            request.OptPropertyDetail = False
        End If

        'Initialize the records array

        Dim maxRecs As Integer
        Dim isValidint As Boolean

        isValidint = Int32.TryParse(txtMaxRecords.Text, maxRecs)

        If isValidint Then

            If maxRecs <= 100 And maxRecs > 0 Then
                MaxArraySize = maxRecs
                ReDim request.Record(MaxArraySize)
                chkDetailedResponse.Enabled = False
                txtRecordCount.Enabled = False
                lblMaxrecords.Enabled = False
                txtMaxRecords.Enabled = False
            Else
                MessageBox.Show("Invalid Range: Please select a number between 1-100", "Range Error")
            End If
        Else
            MessageBox.Show("Invalid Input. Please select a number between 1-100", "Set Max Error")

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAddressKey.Text = ""
        txtAPN.Text = ""
        txtCountyFIPS.Text = ""
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If recordcount = 0 Then
            Initialize()
        End If

        'Clicking insert multiple times will cause the following function to be called
        'Records will be inserted until the 'Send Request' button is clicked or until the maximum
        'number of records are reached.

        If recordcount <> MaxArraySize And MaxArraySize <> 0 Then
            'Set the input fields for current record
            request.Record(recordcount) = New PropertyService.RequestRecord
            request.Record(recordcount).RecordID = (recordcount + 1)
            request.Record(recordcount).AddressKey = txtAddressKey.Text
            request.Record(recordcount).APN = txtAPN.Text
            request.Record(recordcount).FIPS = txtCountyFIPS.Text

            ' Increment Record Count
            recordcount = recordcount + 1

            ' Output current record number
            txtRecordCount.Text = recordcount.ToString

        End If
    End Sub

    Private Sub btnNewRequestArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRequestArray.Click
        recordCount = 0
        txtRecordCount.Text = "0"
        chkDetailedResponse.Enabled = True
        txtRecordCount.Enabled = True
        lblMaxrecords.Enabled = True
        lblProcessing.Text = ""
        txtMaxRecords.Enabled = True
    End Sub

    Private Sub btnSendRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendRequest.Click
        request.TotalRecords = recordcount

        ' Clear the XML Each Time
        webBrowserResponse.Navigate("about:blank")

        Try
            response = action.DoLookup(request)

            XmlSer = New XmlSerializer(response.GetType)

            'Read in XML filestream and then output it to the AxtiveX Web Browser
            fs = New FileStream((System.Environment.CurrentDirectory + "\Response.xml"), FileMode.Create)
            XmlSer.Serialize(fs, response)
            fs.Close()
            webBrowserResponse.Navigate(System.Environment.CurrentDirectory + "\Response.xml")
            btnNewRequestArray.Enabled = True
            lblProcessing.Text = "Lookup Complete. Please see result tabs."
        Catch ex As Exception
            MessageBox.Show("Exception: " + ex.Message + "\r\n")
            Return
        End Try
    End Sub
End Class

