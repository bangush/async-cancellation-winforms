Namespace Classes
    Public Class MonitorArguments
        Inherits EventArgs
        ''' <summary>
        ''' Create an new instance of this class
        ''' </summary>
        ''' <param name="msg">Message to display when finished operation</param>
        ''' <param name="percent">Percentage done</param>
        Public Sub New(msg As String, percent As Integer)

            Message = msg
            PercentDone = percent

        End Sub
        ''' <summary>
        ''' Text for operation completed
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Message() As String

        ''' <summary>
        ''' Current progress of operation
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property PercentDone() As Integer

    End Class
End Namespace