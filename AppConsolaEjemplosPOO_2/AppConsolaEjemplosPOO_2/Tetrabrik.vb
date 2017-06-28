Imports AppConsolaEjemplosPOO_2

Public Class Tetrabrik
    Implements IConAreaCalculable

    Public an, al, pr As Single

    Public Sub New(an As Single, al As Single, pr As Single)
        Me.an = an
        Me.al = al
        Me.pr = pr
    End Sub

    Public ReadOnly Property Area As Single Implements IConAreaCalculable.Area
        Get
            Return CalcularArea()
        End Get
    End Property

    Public Function CalcularArea() As Single Implements IConAreaCalculable.CalcularArea
        Return Me.an * Me.al * 2 + Me.pr * Me.al * 2 + Me.pr * Me.an * 2
    End Function
End Class
