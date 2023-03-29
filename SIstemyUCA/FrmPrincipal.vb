Public Class FrmPrincipal

    Sub mostrarHora()
        LblHora.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub TmrAuxiliar_Tick(sender As Object, e As EventArgs) Handles TmrAuxiliar.Tick
        mostrarHora()

    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrAuxiliar.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        MsgBox("Registro guardado exitosamente", MsgBoxStyle.Information, "Sistema UCA")



    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombres.Clear()
        TxtApellidos.Clear()
        TxtMotivo.Clear()
        TxtNombres.Focus()

    End Sub
End Class
