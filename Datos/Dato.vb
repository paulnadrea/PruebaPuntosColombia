Public Class Dato
    Dim Arr_listaA() As String
    Dim Arr_listaB() As String

    Public Property ListaA() As Array
        Get
            Return Arr_listaA
        End Get
        Set(ByVal value As Array)
            Arr_listaA = value
        End Set
    End Property

    Public Property ListaB() As Array
        Get
            Return Arr_listaB
        End Get
        Set(ByVal value As Array)
            Arr_listaB = value
        End Set
    End Property

End Class
