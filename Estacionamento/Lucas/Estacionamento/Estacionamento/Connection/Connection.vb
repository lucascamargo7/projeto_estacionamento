
Imports FirebirdSql.Data.FirebirdClient
Public Class Connection
    'Todos os métodos e variáveis estão publicas, para que eu possa chamar o mesmo
    'sem a necessidade de instanciar uma nova classe, já que a conexão com o banco de dados 
    'deve ser global, sendo assim, para todos os módulos.

    Public Shared cnn As New FbConnection 'Responsável por fazer a comunicação com o banco de dados.
    Public Shared dblocal As String
    Public Shared dbsource As String
    Public Shared DbUser As String
    Public Shared DbPassword As String
    Public Shared DbPort As String

    Public Shared Sub carregarConfiguracoes()
        'Ao chamar este método o sistema irá armazenar nas variáveis o caminho do banco,
        'assim ele não fica chamando o mesmo de forma redundante.
        'Vou chamar ele no frmPrincipal, no método load, assim ele fará a leitura do arquivo ini.

        dblocal = ini.LeArquivoINI(nome_arquivo_ini, "CAMINHO", "Bd", "")
        dbsource = ini.LeArquivoINI(nome_arquivo_ini, "CAMINHO", "Local", "")
        DbUser = ini.LeArquivoINI(nome_arquivo_ini, "CAMINHO", "Usuario", "")
        DbPassword = ini.LeArquivoINI(nome_arquivo_ini, "CAMINHO", "Senha", "")
        DbPort = ini.LeArquivoINI(nome_arquivo_ini, "CAMINHO", "Porta", "")
    End Sub

    Public Shared Sub conOpen()

        Dim stringConexao As String = ""

        If DbUser = "" Then
            stringConexao = "User=SYSDBA;Password=masterkey;Database=" + dblocal + ";DataSource=" + dbsource + ";Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0"
        Else
            stringConexao = "User=" & DbUser & ";Password=" & DbPassword & ";Database=" + dblocal + ";DataSource=" + dbsource + ";Port=" & DbPort & ";Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0"
        End If

        cnn = New FbConnection()
        cnn.ConnectionString = stringConexao

        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Erro de conexão com o banco de dados: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Public Shared Sub conClose()
        cnn.Close()
        cnn.Dispose()
    End Sub

End Class
