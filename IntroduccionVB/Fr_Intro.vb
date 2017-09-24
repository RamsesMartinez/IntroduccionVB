Public Class Fr_Intro

    Dim valor_uno, valor_dos As Integer
    Dim resultado As Double
    Dim mensaje As String

    Private Sub DataGrid(ByVal Operacion As String, ByVal ResultadoDG As Double)
        Dim file As Integer = Dgv_Datos.RowCount

        Dgv_Datos.Rows.Add()
        Dgv_Datos.Rows(file).Cells(0).Value = Operacion
        Dgv_Datos.Rows(file).Cells(1).Value = ResultadoDG
    End Sub


    Private Function ValidarCampos() As Boolean
        If IsNumeric(Txt_Valor_uno.Text) Then
            valor_uno = Txt_Valor_uno.Text
        Else
            MsgBox("El valor 1 debe ser numérico.")
            Return False
        End If

        If IsNumeric(Txt_Valor_Dos.Text) Then
            valor_dos = Txt_Valor_Dos.Text
        Else
            MsgBox("El valor 2 debe ser numérico.")
            Return False
        End If
        Return True

    End Function

    Private Sub MostrarResultado(ByVal operacion As String)
        Txt_Resultado.Text = resultado
        DataGrid(operacion, resultado)
    End Sub

    Private Sub Btn_Suma_Click(sender As Object, e As EventArgs) Handles Btn_Suma.Click

        If ValidarCampos() = False Then Exit Sub
        resultado = valor_uno + valor_dos

        MostrarResultado("Suma")
    End Sub

    Private Sub Btn_Resta_Click(sender As Object, e As EventArgs) Handles Btn_Resta.Click
        If ValidarCampos() = False Then Exit Sub
        resultado = valor_uno - valor_dos
        MostrarResultado("Resta")
    End Sub

    Private Sub Btn_Multiplicacion_Click(sender As Object, e As EventArgs) Handles Btn_Multiplicacion.Click
        If ValidarCampos() = False Then Exit Sub
        resultado = valor_uno * valor_dos
        MostrarResultado("Multiplicación")
    End Sub

    Private Sub Btn_Division_Click(sender As Object, e As EventArgs) Handles Btn_Division.Click
        If ValidarCampos() = False Then Exit Sub
        resultado = valor_uno / valor_dos
        MostrarResultado("Dividición")
    End Sub
End Class
