<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGames
        '
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.Location = New System.Drawing.Point(12, 36)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(376, 381)
        Me.lstGames.TabIndex = 0
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(508, 128)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(207, 156)
        Me.btnSort.TabIndex = 1
        Me.btnSort.Text = "Sort List"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lstGames)
        Me.Name = "frmMain"
        Me.Text = "Popular Games"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstGames As ListBox
    Friend WithEvents btnSort As Button
End Class
