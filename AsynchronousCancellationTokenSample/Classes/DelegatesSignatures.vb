Namespace Classes
    Public Class DelegatesSignatures
        ''' <summary>
        ''' Provides a callback when working is being performed in <see cref="Operations.Run"/>
        ''' </summary>
        ''' <param name="arguments"><see cref="MonitorArguments"/></param>
        Public Delegate Sub MonitorHandler(arguments As MonitorArguments)
    End Class
End NameSpace