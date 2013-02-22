Public Class Main

    Private Sub toNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toNew.Click
        txtText.Clear()
    End Sub

    Private Sub toOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toOpen.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Rich Text Files|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtText.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub toSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toSave.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtText.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub toSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toSaveAs.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save as"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtText.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub toExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toExit.Click
        End
    End Sub

    Private Sub toUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toUndo.Click
        txtText.Undo()
    End Sub

    Private Sub toRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toRedo.Click
        txtText.Redo()
    End Sub

    Private Sub toCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toCopy.Click
        txtText.Copy()
    End Sub

    Private Sub toPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toPaste.Click
        txtText.Paste()
    End Sub

    Private Sub otCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toCut.Click
        txtText.Cut()
    End Sub

    Private Sub toClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toClear.Click
        txtText.Clear()
    End Sub

    Private Sub otSellectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles otSellectAll.Click
        txtText.SelectAll()
    End Sub

    Private Sub toColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toColor.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = txtText.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                txtText.ForeColor = dlg.Color
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub toStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toStyle.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = txtText.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                txtText.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub toAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toAbout.Click
        About.Show()
    End Sub
End Class
