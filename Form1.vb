Imports System.Runtime.InteropServices

Public Class Form1
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Public Structure QueueEntry
        Public queueNumber As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=100)>
        Public name As String
        Public numPeople As Integer
    End Structure

    ' DLL Imports
    <DllImport("QueueLogic.dll", CharSet:=CharSet.Ansi)>
    Public Shared Sub AddToQueue(name As String, numPeople As Integer, ByRef queueNumber As Integer)
    End Sub

    <DllImport("QueueLogic.dll")>
    Public Shared Function GetQueueSize() As Integer
    End Function

    <DllImport("QueueLogic.dll")>
    Public Shared Function GetQueueEntry(index As Integer, ByRef entry As QueueEntry) As Boolean
    End Function

    <DllImport("QueueLogic.dll")>
    Public Shared Function ServeNext(ByRef entry As QueueEntry) As Boolean
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or Not Integer.TryParse(txtPeople.Text, Nothing) Then
            MessageBox.Show("Enter valid name and number of people.")
            Return
        End If

        Dim qNum As Integer = 0
        AddToQueue(txtName.Text, Integer.Parse(txtPeople.Text), qNum)
        MessageBox.Show("Your queue number is: " & qNum)

        RefreshQueue()
    End Sub

    Private Sub RefreshQueue()
        lstWaiting.Items.Clear()
        Dim size As Integer = GetQueueSize()
        For i = 0 To size - 1
            Dim entry As QueueEntry
            If GetQueueEntry(i, entry) Then
                lstWaiting.Items.Add("Queue" & entry.queueNumber & ": " & entry.name & " (" & entry.numPeople & ")")
            End If
        Next
    End Sub

    Private Sub btnServe_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entry As QueueEntry
        If ServeNext(entry) Then
            lstServing.Items.Add("Serving Queue" & entry.queueNumber & ": " & entry.name)
            RefreshQueue()
        Else
            MessageBox.Show("No one in queue.")
        End If
    End Sub
End Class
