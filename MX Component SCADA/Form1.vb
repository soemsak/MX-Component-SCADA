Option Explicit On
Option Strict On

Public Class Form1
#Region "Basic Control"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblOpen.Text = ""
        lblClose.Text = ""
        lblOn.Text = ""
        lblOff.Text = ""
    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Dim iRet As Long = 0
        Dim iLogicalStationNumber As Integer = 0
        AxActUtlType1.ActLogicalStationNumber = iLogicalStationNumber
        iRet = AxActUtlType1.Open()
        lblOpen.Text = iRet.ToString
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Dim iRet As Long = 0
        iRet = AxActUtlType1.Close()
        lblClose.Text = iRet.ToString
    End Sub

    Private Sub cmdOn_Click(sender As Object, e As EventArgs) Handles cmdOn.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M0", 1)
        lblOn.Text = iRet.ToString
    End Sub

    Private Sub cmdOff_Click(sender As Object, e As EventArgs) Handles cmdOff.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M0", 0)
        lblOff.Text = iRet.ToString
    End Sub

#End Region
End Class
