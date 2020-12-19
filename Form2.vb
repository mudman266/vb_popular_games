Public Class frmSortedList
    Private Sub frmSortedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sort only supports 1D arrays thus a tuple can be used
        Dim tplList As New List(Of Tuple(Of Object, Object))
        For i = 0 To frmMain.arrGames.GetUpperBound(1)
            tplList.Add(Tuple.Create(frmMain.arrGames(0, i), frmMain.arrGames(1, i)))
        Next
        tplList = tplList.OrderBy(Function(i) i.Item1).ToList
        For Each tpl As Tuple(Of Object, Object) In tplList
            lstSortedGames.Items.Add(tpl.Item1 & " - " & tpl.Item2)
        Next
    End Sub
End Class