
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Module ini

    Public Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public nome_arquivo_ini As String = My.Application.Info.DirectoryPath.ToString & "\config.ini"

    Public Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)
        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)
        Return string_builder.ToString()
    End Function

End Module

