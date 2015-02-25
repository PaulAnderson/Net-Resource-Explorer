Imports System.Runtime.InteropServices




Module Module1
    Public Const ATTACH_PARENT_PROCESS As Integer = -1

 
    Declare Function AttachConsole Lib "kernel32.dll" (ByVal dwProcessId As Int32) As Boolean
    Declare Function AllocConsole Lib "kernel32.dll" () As Boolean
    Declare Function FreeConsole Lib "kernel32.dll" () As Boolean
End Module
