Public Class frmMain
    Private _FILENAME = "c:\school\csc-139\chapter8\mobile.txt"
    Public Shared arrGames(1, 0)
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prepare the reader
        Dim objReader As IO.StreamReader
        objReader = IO.File.OpenText(_FILENAME)

        'Populate array
        Dim i = 0
        Do While objReader.Peek() <> -1
            ReDim Preserve arrGames(1, i)
            arrGames(0, i) = objReader.ReadLine
            arrGames(1, i) = objReader.ReadLine
            i += 1
        Loop

        'Populate Listbox
        For j = 0 To arrGames.GetUpperBound(1)
            lstGames.Items.Add(arrGames(0, j) & " - " & arrGames(1, j))
        Next
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        frmSortedList.Show()
    End Sub
End Class
