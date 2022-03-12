Public Class frm_PrescriptionEditor

#Region " Top Panel "
#Region " Move Form "

  Public MoveForm As Boolean
  Public MoveForm_MousePosition As Point

  Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_TopBar.MouseDown
    If e.Button = MouseButtons.Left Then
      MoveForm = True
      MoveForm_MousePosition = e.Location
    End If

  End Sub

  Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles pnl_TopBar.MouseMove

    If MoveForm Then
      Me.Location += (e.Location - MoveForm_MousePosition)
    End If

  End Sub

  Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles pnl_TopBar.MouseUp
    If e.Button = MouseButtons.Left Then
      MoveForm = False
    End If

  End Sub
#End Region

  Private Sub CloseApp(sender As Object, e As EventArgs) _
    Handles btn_Close.Click, ctxItem_Exit.Click, img_TopBar_Logo.DoubleClick
    Me.Close()
  End Sub

  Private Sub InvokeCtx(sender As Object, e As EventArgs) _
    Handles img_TopBar_Logo.Click
    ctx_Main.Show(MousePosition.X + 2, MousePosition.Y + 2)
  End Sub

#End Region

  Private Sub ClearAdvice(sender As Object, e As EventArgs) Handles btn_ClearAdvice.Click
    rtb_Advice.Clear()
  End Sub

  Private Sub AddMedicine(sender As Object, e As EventArgs) Handles btn_AddMed.Click
    Dim form As New frm_MedicineSearch
    form.Show()
  End Sub

  Private Sub btn_AddProc_Click(sender As Object, e As EventArgs) Handles btn_AddProc.Click
    Dim form As New frm_ProcedureSearch
    form.Show()
  End Sub
End Class