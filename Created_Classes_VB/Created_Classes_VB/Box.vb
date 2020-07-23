Public Class Box
    Private _length, _width, _height As Double

    Public Sub New()
        _length = 0
        _width = 0
        _height = 0
    End Sub

    Public Sub New(ByVal len As Double, ByVal wid As Double, ByVal ht As Double)
        _length = len
        _width = wid
        _height = ht
    End Sub

    Public Sub setLength(ByVal len As Double)
        _length = len
    End Sub

    Public Sub setWidth(ByVal wid As Double)
        _width = wid
    End Sub

    Public Sub setHeight(ByVal ht As Double)
        _height = ht
    End Sub

    Public Function getLength() As Double
        Return _length
    End Function

    Public Function getWidth() As Double
        Return _width
    End Function

    Public Function getHeight() As Double
        Return _height
    End Function

    Public Function getVolume() As Double
        Return _length * _width * _height
    End Function
End Class
