Imports Datos
Public Class Form1

    Dim obj As Dato
    Dim Arr_listaA(), Arr_listaB() As String
    Dim List_Missing As New List(Of String)
    Dim valor, List_A, List_B As String
    Dim cont_A, cont_B As Integer
    Dim n As Integer = 0
    Dim cambio, cond1, cond2, cond3, cond4 As Boolean
    Dim Xmax, Xmin, lim As Integer

    Private Sub Limpiar()
        txtGrupoA.Clear()
        txtGrupoB.Clear()
        txtNumPerdidos.Clear()
        txtMaximo.Clear()
        txtMinimo.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        Close()
    End Sub


    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If (String.IsNullOrEmpty(txtGrupoA.Text.Trim) Or String.IsNullOrEmpty(txtGrupoB.Text.Trim())) Then
            MsgBox("Debe ingresar una lista de numeros para la busqueda", MsgBoxStyle.Information, AcceptButton)
        Else
            Condiciones()
            If (cond1 = True And cond2 = True And cond3 = True And cond4 = True) Then
                RecorrerLista()
                cambio = True
                Do While cambio = True
                    cambio = False
                    For x As Integer = 0 To List_Missing.Count - 1
                        For y As Integer = x + 1 To List_Missing.Count - 1
                            If List_Missing.Item(x) = List_Missing.Item(y) Then
                                txtNumPerdidos.Text = txtNumPerdidos.Text + List_Missing.Item(x) + " "
                            End If
                        Next
                    Next
                Loop
            Else
                MsgBox("Una o mas condiciones no cumplen los parametros de busqueda", MsgBoxStyle.Critical, AcceptButton)
            End If
        End If
    End Sub

    Public Sub Separa()
        Arr_listaA = Split(txtGrupoA.Text, " ")
        Arr_listaB = Split(txtGrupoB.Text, " ")
    End Sub

    Public Sub RecorrerLista()
        For i As Integer = 0 To Arr_listaA.Length - 1
            cont_A = 0
            cont_B = 0
            valor = Arr_listaA.GetValue(i)
            For j As Integer = 0 To Arr_listaA.Length - 1
                If valor = Arr_listaA.GetValue(j) Then
                    cont_A = cont_A + 1
                End If
            Next

            For l As Integer = 0 To Arr_listaB.Length - 1
                If valor = Arr_listaB.GetValue(l) Then
                    cont_B = cont_B + 1
                End If
            Next

            If cont_A <> cont_B Then
                List_Missing.Add(valor)
            End If
        Next
    End Sub

    'n = txtGrupoA
    'm = txtGrupoB
    'cond1 = n<=m
    'cond2 = 1<=n , m<= 200000
    'cond3 = Xmax -Xmin <= 101
    'cod4 = 1<= x <=10000

    Public Sub Max_Min()
        Separa()
        Xmax = Arr_listaB.Max().ToString()
        Xmin = Arr_listaB.Min().ToString()
        txtMaximo.Text = Xmax
        txtMinimo.Text = Xmin
    End Sub

    Public Sub Rango()
        For a As Integer = 0 To Arr_listaB.Length - 1
            If 1 <= CInt(Arr_listaB(a)) And CInt(Arr_listaB(a)) <= 10000 Then
                lim = lim + 1
            Else
                lim = 0
                Exit Sub
            End If
        Next
    End Sub
    Public Sub Condiciones()
        lim = 0
        Max_Min()
        Rango()

        If txtGrupoA.TextLength <= txtGrupoB.TextLength Then
            cond1 = True
        Else
            cond1 = False
        End If

        If ((1 <= txtGrupoA.TextLength) And (txtGrupoB.TextLength <= 200000)) Then
            cond2 = True
        Else
            cond2 = False
        End If

        If Xmax - Xmin < 101 Then
            cond3 = True
        Else
            cond3 = False
        End If

        If lim = Arr_listaB.Length Then
            cond4 = True
        Else
            cond4 = False
        End If

    End Sub
End Class