Public Class frmInstructions
    Private Sub btnCloseInstructions_Click(sender As System.Object, e As System.EventArgs) Handles btnCloseInstructions.Click
        Me.Close()
    End Sub

    Private Sub CloseInstructionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseInstructionsToolStripMenuItem.Click

        btnCloseInstructions_Click(Nothing, e)

    End Sub

    Private Sub frmInstructions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        panOblique.Visible = True
    End Sub
End Class